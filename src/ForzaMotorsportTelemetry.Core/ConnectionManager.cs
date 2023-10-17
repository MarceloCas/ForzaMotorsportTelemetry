using ForzaMotorsportTelemetry.Core.Adapters;
using ForzaMotorsportTelemetry.Core.Models;
using System.Net;
using System.Net.Sockets;

namespace ForzaMotorsportTelemetry.Core;
public class ConnectionManager
{
    // Fields
    private CancellationTokenSource? _cancellationTokenSource;

    private UdpClient? _udpClient;

    // Properties
    public ConnectionConfig ConnectionConfig { get; }
    public bool IsConnected => _udpClient?.Client?.Connected == true;

    // Constructors
    private ConnectionManager(ConnectionConfig connectionConfig)
    {
        ConnectionConfig = connectionConfig;
    }

    // Public Methods
    public void Connect(Func<TelemetryData, CancellationToken, Task> telemetryDataHandler)
    {
        if (IsConnected)
            return;

        _udpClient = new UdpClient(ConnectionConfig.Port);

        StartUdpReceiver(telemetryDataHandler);
    }
    public void Disconect()
    {
        if (!IsConnected)
            return;

        _cancellationTokenSource?.Cancel();
    }

    // Private Methods
    private void StartUdpReceiver(Func<TelemetryData, CancellationToken, Task> telemetryDataHandler)
    {
        _cancellationTokenSource = new CancellationTokenSource();

        _ = Task.Run(async () =>
            {
                var remoteEndPoint = new IPEndPoint(ConnectionConfig.IpAddress, ConnectionConfig.Port);

                while (!_cancellationTokenSource.IsCancellationRequested)
                {
                    var data = _udpClient!.Receive(ref remoteEndPoint);
                    var telemetryData = TelemetryDataAdapter.FromUdpData(data);

                    await telemetryDataHandler(telemetryData, _cancellationTokenSource.Token);
                }

                Disconect();
            },
            _cancellationTokenSource.Token
        );
    }

    // Builders
    public static ConnectionManager Init(ConnectionConfig connectionConfig)
    {
        return new ConnectionManager(connectionConfig);
    }
}
