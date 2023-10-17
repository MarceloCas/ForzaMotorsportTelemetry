using ForzaMotorsportTelemetry.Core;
using ForzaMotorsportTelemetry.Core.Models;

var connectionManager = ConnectionManager.Init(
    ConnectionConfig.Create(
        ipString: "127.0.0.1",
        port: 5300
    )
);

connectionManager.Connect(
    telemetryDataHandler: (telemetryData, cancellationToken) =>
    {
        Console.WriteLine($"{DateTime.Now} | Accel: {telemetryData.Accel} | Brake: {telemetryData.Brake}");

        return Task.CompletedTask;
    }
);

Console.ReadLine();