using ForzaMotorsportTelemetry.Core.Exceptions;
using System.Net;

namespace ForzaMotorsportTelemetry.Core.Models;
public readonly struct ConnectionConfig
{
    // Properties
    public IPAddress IpAddress { get; }
    public int Port { get; }

    // Constructors
    private ConnectionConfig(
        IPAddress ipAddress,
        int port
    )
    {
        IpAddress = ipAddress;
        Port = port;
    }

    // Builders
    public static ConnectionConfig Create(
        string ipString,
        int port
    )
    {
        IPAddress? ipAddress;
        try
        {
            ipAddress = IPAddress.Parse(ipString);
        }
        catch (Exception)
        {
            throw new InvalidIpAddressException(ipString);
        }

        return new ConnectionConfig(ipAddress, port);
    }
}
