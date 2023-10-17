using ForzaMotorsportTelemetry.Core.Models;
using System.Runtime.InteropServices;

namespace ForzaMotorsportTelemetry.Core.Adapters;
public static class TelemetryDataAdapter
{
    // Fields
    private static readonly int _intSize = Marshal.SizeOf(typeof(int));
    private static readonly int _uintSize = Marshal.SizeOf(typeof(uint));
    private static readonly int _floatSize = Marshal.SizeOf(typeof(float));
    private static readonly int _ushortSize = Marshal.SizeOf(typeof(ushort));
    private static readonly int _byteSize = Marshal.SizeOf(typeof(byte));
    private static readonly int _sbyteSize = Marshal.SizeOf(typeof(sbyte));

    // Public Methods
    public static TelemetryData FromUdpData(byte[] dataRaw)
    {
        var data = dataRaw.AsSpan();
        var lastIndex = 0;

        return new TelemetryData(
            isRaceOn: ReadInt32(data, ref lastIndex),
            timestampMS: ReadUInt32(data, ref lastIndex),
            engineMaxRpm: ReadFloat(data, ref lastIndex),
            engineIdleRpm: ReadFloat(data, ref lastIndex),
            currentEngineRpm: ReadFloat(data, ref lastIndex),
            accelerationX: ReadFloat(data, ref lastIndex),
            accelerationY: ReadFloat(data, ref lastIndex),
            accelerationZ: ReadFloat(data, ref lastIndex),
            velocityX: ReadFloat(data, ref lastIndex),
            velocityY: ReadFloat(data, ref lastIndex),
            velocityZ: ReadFloat(data, ref lastIndex),
            angularVelocityX: ReadFloat(data, ref lastIndex),
            angularVelocityY: ReadFloat(data, ref lastIndex),
            angularVelocityZ: ReadFloat(data, ref lastIndex),
            yaw: ReadFloat(data, ref lastIndex),
            pitch: ReadFloat(data, ref lastIndex),
            roll: ReadFloat(data, ref lastIndex),
            normalizedSuspensionTravelFrontLeft: ReadFloat(data, ref lastIndex),
            normalizedSuspensionTravelFrontRight: ReadFloat(data, ref lastIndex),
            normalizedSuspensionTravelRearLeft: ReadFloat(data, ref lastIndex),
            normalizedSuspensionTravelRearRight: ReadFloat(data, ref lastIndex),
            tireSlipRatioFrontLeft: ReadFloat(data, ref lastIndex),
            tireSlipRatioFrontRight: ReadFloat(data, ref lastIndex),
            tireSlipRatioRearLeft: ReadFloat(data, ref lastIndex),
            tireSlipRatioRearRight:ReadFloat(data, ref lastIndex),
            wheelRotationSpeedFrontLeft: ReadFloat(data, ref lastIndex),
            wheelRotationSpeedFrontRight: ReadFloat(data, ref lastIndex),
            wheelRotationSpeedRearLeft: ReadFloat(data, ref lastIndex),
            wheelRotationSpeedRearRight: ReadFloat (data, ref lastIndex),
            wheelOnRumbleStripFrontLeft: ReadInt32(data, ref lastIndex),
            wheelOnRumbleStripFrontRight: ReadInt32(data, ref lastIndex),
            wheelOnRumbleStripRearLeft: ReadInt32(data, ref lastIndex),
            wheelOnRumbleStripRearRight: ReadInt32(data, ref lastIndex),
            wheelInPuddleDepthFrontLeft: ReadFloat(data, ref lastIndex),
            wheelInPuddleDepthFrontRight: ReadFloat(data, ref lastIndex),
            wheelInPuddleDepthRearLeft: ReadFloat(data, ref lastIndex),
            wheelInPuddleDepthRearRight: ReadFloat(data, ref lastIndex),
            surfaceRumbleFrontLeft: ReadFloat(data, ref lastIndex),
            surfaceRumbleFrontRight: ReadFloat(data, ref lastIndex),
            surfaceRumbleRearLeft: ReadFloat(data, ref lastIndex),
            surfaceRumbleRearRight: ReadFloat(data, ref lastIndex),
            tireSlipAngleFrontLeft: ReadFloat(data, ref lastIndex),
            tireSlipAngleFrontRight: ReadFloat(data, ref lastIndex),
            tireSlipAngleRearLeft: ReadFloat(data, ref lastIndex),
            tireSlipAngleRearRight: ReadFloat(data, ref lastIndex),
            tireCombinedSlipFrontLeft: ReadFloat(data, ref lastIndex),
            tireCombinedSlipFrontRight: ReadFloat(data, ref lastIndex),
            tireCombinedSlipRearLeft: ReadFloat(data, ref lastIndex),
            tireCombinedSlipRearRight: ReadFloat(data, ref lastIndex),
            suspensionTravelMetersFrontLeft: ReadFloat(data, ref lastIndex),
            suspensionTravelMetersFrontRight: ReadFloat(data, ref lastIndex),
            suspensionTravelMetersRearLeft: ReadFloat(data, ref lastIndex),
            suspensionTravelMetersRearRight: ReadFloat(data, ref lastIndex),
            carOrdinal: ReadInt32(data, ref lastIndex),
            carClass: ReadInt32(data, ref lastIndex),
            carPerformanceIndex: ReadInt32(data, ref lastIndex),
            drivetrainType: ReadInt32(data, ref lastIndex),
            numCylinders: ReadInt32(data, ref lastIndex),
            positionX: ReadFloat(data, ref lastIndex),
            positionY: ReadFloat(data, ref lastIndex),
            positionZ: ReadFloat(data, ref lastIndex),
            speed: ReadFloat(data, ref lastIndex),
            power: ReadFloat(data, ref lastIndex),
            torque: ReadFloat(data, ref lastIndex),
            tireTempFrontLeft: ReadFloat(data, ref lastIndex),
            tireTempFrontRight: ReadFloat(data, ref lastIndex),
            tireTempRearLeft: ReadFloat(data, ref lastIndex),
            tireTempRearRight: ReadFloat(data, ref lastIndex),
            boost: ReadFloat(data, ref lastIndex),
            fuel: ReadFloat(data, ref lastIndex),
            distanceTraveled: ReadFloat(data, ref lastIndex),
            bestLap: ReadFloat(data, ref lastIndex),
            lastLap: ReadFloat(data, ref lastIndex),
            currentLap: ReadFloat(data, ref lastIndex),
            currentRaceTime: ReadFloat(data, ref lastIndex),
            lapNumber: ReadUShort(data, ref lastIndex),
            racePosition: ReadByte(data, ref lastIndex),
            accel: ReadByte(data, ref lastIndex),
            brake: ReadByte(data, ref lastIndex),
            clutch: ReadByte(data, ref lastIndex),
            handBrake: ReadByte(data, ref lastIndex),
            gear: ReadByte(data, ref lastIndex),
            steer: ReadSByte(data, ref lastIndex),
            normalizedDrivingLine: ReadSByte(data, ref lastIndex),
            normalizedAIBrakeDifference: ReadSByte(data, ref lastIndex),
            tireWearFrontLeft: ReadFloat(data, ref lastIndex),
            tireWearFrontRight: ReadFloat(data, ref lastIndex),
            tireWearRearLeft: ReadFloat(data, ref lastIndex),
            tireWearRearRight: ReadFloat(data, ref lastIndex),
            trackOrdinal: ReadInt32(data, ref lastIndex)
        );
    }

    // Private Methods
    private static int ReadInt32(Span<byte> data, ref int lastIndex)
    {
        var value = BitConverter.ToInt32(data.Slice(lastIndex, _intSize));
        lastIndex += _intSize;

        return value;
    }
    private static uint ReadUInt32(Span<byte> data, ref int lastIndex)
    {
        var value = BitConverter.ToUInt32(data.Slice(lastIndex, _uintSize));
        lastIndex += _uintSize;

        return value;
    }
    private static float ReadFloat(Span<byte> data, ref int lastIndex)
    {
        var value = BitConverter.ToSingle(data.Slice(lastIndex, _floatSize));
        lastIndex += _floatSize;

        return value;
    }
    private static ushort ReadUShort(Span<byte> data, ref int lastIndex)
    {
        var value = BitConverter.ToUInt16(data.Slice(lastIndex, _ushortSize));
        lastIndex += _ushortSize;

        return value;
    }
    private static byte ReadByte(Span<byte> data, ref int lastIndex)
    {
        var value = data.Slice(lastIndex, _byteSize).ToArray()[0];
        lastIndex += _byteSize;

        return value;
    }
    private static sbyte ReadSByte(Span<byte> data, ref int lastIndex)
    {
        var value = (sbyte)data.Slice(lastIndex, _byteSize).ToArray()[0];
        lastIndex += _sbyteSize;

        return value;
    }
}
