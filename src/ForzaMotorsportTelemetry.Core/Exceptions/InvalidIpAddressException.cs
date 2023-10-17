namespace ForzaMotorsportTelemetry.Core.Exceptions;
public class InvalidIpAddressException
    : Exception
{
    // Properties
    public string IpString { get; }

    // Constructors
    public InvalidIpAddressException(string ipString)
    {
        IpString = ipString;
    }
}
