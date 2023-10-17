namespace ForzaMotorsportTelemetry.Core.Models;

public readonly struct TelemetryData
{
    // = 1 when race is on. = 0 when in menus/race stopped
    public int IsRaceOn { get; }

    // Can overflow to 0 eventually
    public uint TimestampMS { get; }

    public float EngineMaxRpm { get; }
    public float EngineIdleRpm { get; }
    public float CurrentEngineRpm { get; }

    // In the car's local space; X = right, Y = up, Z = forward
    public float AccelerationX { get; }
    public float AccelerationY { get; }
    public float AccelerationZ { get; }

    // In the car's local space; X = right, Y = up, Z = forward
    public float VelocityX { get; }
    public float VelocityY { get; }
    public float VelocityZ { get; }

    // In the car's local space; X = pitch, Y = yaw, Z = roll
    public float AngularVelocityX { get; }
    public float AngularVelocityY { get; }
    public float AngularVelocityZ { get; }

    public float Yaw { get; }
    public float Pitch { get; }
    public float Roll { get; }

    // Suspension travel normalized: 0.0f = max stretch; 1.0 = max compression
    public float NormalizedSuspensionTravelFrontLeft { get; }
    public float NormalizedSuspensionTravelFrontRight { get; }
    public float NormalizedSuspensionTravelRearLeft { get; }
    public float NormalizedSuspensionTravelRearRight { get; }

    // Tire normalized slip ratio, = 0 means 100% grip and |ratio| > 1.0 means loss of grip.
    public float TireSlipRatioFrontLeft { get; }
    public float TireSlipRatioFrontRight { get; }
    public float TireSlipRatioRearLeft { get; }
    public float TireSlipRatioRearRight { get; }

    // Wheels rotation speed radians/sec.
    public float WheelRotationSpeedFrontLeft { get; }
    public float WheelRotationSpeedFrontRight { get; }
    public float WheelRotationSpeedRearLeft { get; }
    public float WheelRotationSpeedRearRight { get; }

    // = 1 when wheel is on rumble strip, = 0 when off.
    public int WheelOnRumbleStripFrontLeft { get; }
    public int WheelOnRumbleStripFrontRight { get; }
    public int WheelOnRumbleStripRearLeft { get; }
    public int WheelOnRumbleStripRearRight { get; }

    // = from 0 to 1, where 1 is the deepest puddle
    public float WheelInPuddleDepthFrontLeft { get; }
    public float WheelInPuddleDepthFrontRight { get; }
    public float WheelInPuddleDepthRearLeft { get; }
    public float WheelInPuddleDepthRearRight { get; }

    // Non-dimensional surface rumble values passed to controller force feedback
    public float SurfaceRumbleFrontLeft { get; }
    public float SurfaceRumbleFrontRight { get; }
    public float SurfaceRumbleRearLeft { get; }
    public float SurfaceRumbleRearRight { get; }

    // Tire normalized slip angle, = 0 means 100% grip and |angle| > 1.0 means loss of grip.
    public float TireSlipAngleFrontLeft { get; }
    public float TireSlipAngleFrontRight { get; }
    public float TireSlipAngleRearLeft { get; }
    public float TireSlipAngleRearRight { get; }

    // Tire normalized combined slip, = 0 means 100% grip and |slip| > 1.0 means loss of grip.
    public float TireCombinedSlipFrontLeft { get; }
    public float TireCombinedSlipFrontRight { get; }
    public float TireCombinedSlipRearLeft { get; }
    public float TireCombinedSlipRearRight { get; }

    // Actual suspension travel in meters
    public float SuspensionTravelMetersFrontLeft { get; }
    public float SuspensionTravelMetersFrontRight { get; }
    public float SuspensionTravelMetersRearLeft { get; }
    public float SuspensionTravelMetersRearRight { get; }

    // Unique ID of the car make/model
    public int CarOrdinal { get; }

    // Between 0 (D -- worst cars) and 7 (X class -- best cars) inclusive 
    public int CarClass { get; }

    // Between 100 (worst car) and 999 (best car) inclusive
    public int CarPerformanceIndex { get; }

    // 0 = FWD, 1 = RWD, 2 = AWD
    public int DrivetrainType { get; }

    // Number of cylinders in the engine
    public int NumCylinders { get; }

    public float PositionX { get; }
    public float PositionY { get; }
    public float PositionZ { get; }

    public float Speed { get; }
    public float Power { get; }
    public float Torque { get; }

    public float TireTempFrontLeft { get; }
    public float TireTempFrontRight { get; }
    public float TireTempRearLeft { get; }
    public float TireTempRearRight { get; }

    public float Boost { get; }
    public float Fuel { get; }
    public float DistanceTraveled { get; }

    public float BestLap { get; }
    public float LastLap { get; }
    public float CurrentLap { get; }
    public float CurrentRaceTime { get; }
    public ushort LapNumber { get; }
    public byte RacePosition { get; }

    public byte Accel { get; }
    public byte Brake { get; }
    public byte Clutch { get; }
    public byte HandBrake { get; }
    public byte Gear { get; }
    public sbyte Steer { get; }

    public sbyte NormalizedDrivingLine { get; }
    public sbyte NormalizedAIBrakeDifference { get; }

    public float TireWearFrontLeft { get; }
    public float TireWearFrontRight { get; }
    public float TireWearRearLeft { get; }
    public float TireWearRearRight { get; }

    // ID for track
    public int TrackOrdinal { get; }

    // Constructors
    public TelemetryData(
        int isRaceOn,
        uint timestampMS,
        float engineMaxRpm,
        float engineIdleRpm,
        float currentEngineRpm,
        float accelerationX,
        float accelerationY,
        float accelerationZ,
        float velocityX,
        float velocityY,
        float velocityZ,
        float angularVelocityX,
        float angularVelocityY,
        float angularVelocityZ,
        float yaw,
        float pitch,
        float roll,
        float normalizedSuspensionTravelFrontLeft,
        float normalizedSuspensionTravelFrontRight,
        float normalizedSuspensionTravelRearLeft,
        float normalizedSuspensionTravelRearRight,
        float tireSlipRatioFrontLeft,
        float tireSlipRatioFrontRight,
        float tireSlipRatioRearLeft,
        float tireSlipRatioRearRight,
        float wheelRotationSpeedFrontLeft,
        float wheelRotationSpeedFrontRight,
        float wheelRotationSpeedRearLeft,
        float wheelRotationSpeedRearRight,
        int wheelOnRumbleStripFrontLeft,
        int wheelOnRumbleStripFrontRight,
        int wheelOnRumbleStripRearLeft,
        int wheelOnRumbleStripRearRight,
        float wheelInPuddleDepthFrontLeft,
        float wheelInPuddleDepthFrontRight,
        float wheelInPuddleDepthRearLeft,
        float wheelInPuddleDepthRearRight,
        float surfaceRumbleFrontLeft,
        float surfaceRumbleFrontRight,
        float surfaceRumbleRearLeft,
        float surfaceRumbleRearRight,
        float tireSlipAngleFrontLeft,
        float tireSlipAngleFrontRight,
        float tireSlipAngleRearLeft,
        float tireSlipAngleRearRight,
        float tireCombinedSlipFrontLeft,
        float tireCombinedSlipFrontRight,
        float tireCombinedSlipRearLeft,
        float tireCombinedSlipRearRight,
        float suspensionTravelMetersFrontLeft,
        float suspensionTravelMetersFrontRight,
        float suspensionTravelMetersRearLeft,
        float suspensionTravelMetersRearRight,
        int carOrdinal,
        int carClass,
        int carPerformanceIndex,
        int drivetrainType,
        int numCylinders,
        float positionX,
        float positionY,
        float positionZ,
        float speed,
        float power,
        float torque,
        float tireTempFrontLeft,
        float tireTempFrontRight,
        float tireTempRearLeft,
        float tireTempRearRight,
        float boost,
        float fuel,
        float distanceTraveled,
        float bestLap,
        float lastLap,
        float currentLap,
        float currentRaceTime,
        ushort lapNumber,
        byte racePosition,
        byte accel,
        byte brake,
        byte clutch,
        byte handBrake,
        byte gear,
        sbyte steer,
        sbyte normalizedDrivingLine,
        sbyte normalizedAIBrakeDifference,
        float tireWearFrontLeft,
        float tireWearFrontRight,
        float tireWearRearLeft,
        float tireWearRearRight,
        int trackOrdinal)
    {
        IsRaceOn = isRaceOn;
        TimestampMS = timestampMS;
        EngineMaxRpm = engineMaxRpm;
        EngineIdleRpm = engineIdleRpm;
        CurrentEngineRpm = currentEngineRpm;
        AccelerationX = accelerationX;
        AccelerationY = accelerationY;
        AccelerationZ = accelerationZ;
        VelocityX = velocityX;
        VelocityY = velocityY;
        VelocityZ = velocityZ;
        AngularVelocityX = angularVelocityX;
        AngularVelocityY = angularVelocityY;
        AngularVelocityZ = angularVelocityZ;
        Yaw = yaw;
        Pitch = pitch;
        Roll = roll;
        NormalizedSuspensionTravelFrontLeft = normalizedSuspensionTravelFrontLeft;
        NormalizedSuspensionTravelFrontRight = normalizedSuspensionTravelFrontRight;
        NormalizedSuspensionTravelRearLeft = normalizedSuspensionTravelRearLeft;
        NormalizedSuspensionTravelRearRight = normalizedSuspensionTravelRearRight;
        TireSlipRatioFrontLeft = tireSlipRatioFrontLeft;
        TireSlipRatioFrontRight = tireSlipRatioFrontRight;
        TireSlipRatioRearLeft = tireSlipRatioRearLeft;
        TireSlipRatioRearRight = tireSlipRatioRearRight;
        WheelRotationSpeedFrontLeft = wheelRotationSpeedFrontLeft;
        WheelRotationSpeedFrontRight = wheelRotationSpeedFrontRight;
        WheelRotationSpeedRearLeft = wheelRotationSpeedRearLeft;
        WheelRotationSpeedRearRight = wheelRotationSpeedRearRight;
        WheelOnRumbleStripFrontLeft = wheelOnRumbleStripFrontLeft;
        WheelOnRumbleStripFrontRight = wheelOnRumbleStripFrontRight;
        WheelOnRumbleStripRearLeft = wheelOnRumbleStripRearLeft;
        WheelOnRumbleStripRearRight = wheelOnRumbleStripRearRight;
        WheelInPuddleDepthFrontLeft = wheelInPuddleDepthFrontLeft;
        WheelInPuddleDepthFrontRight = wheelInPuddleDepthFrontRight;
        WheelInPuddleDepthRearLeft = wheelInPuddleDepthRearLeft;
        WheelInPuddleDepthRearRight = wheelInPuddleDepthRearRight;
        SurfaceRumbleFrontLeft = surfaceRumbleFrontLeft;
        SurfaceRumbleFrontRight = surfaceRumbleFrontRight;
        SurfaceRumbleRearLeft = surfaceRumbleRearLeft;
        SurfaceRumbleRearRight = surfaceRumbleRearRight;
        TireSlipAngleFrontLeft = tireSlipAngleFrontLeft;
        TireSlipAngleFrontRight = tireSlipAngleFrontRight;
        TireSlipAngleRearLeft = tireSlipAngleRearLeft;
        TireSlipAngleRearRight = tireSlipAngleRearRight;
        TireCombinedSlipFrontLeft = tireCombinedSlipFrontLeft;
        TireCombinedSlipFrontRight = tireCombinedSlipFrontRight;
        TireCombinedSlipRearLeft = tireCombinedSlipRearLeft;
        TireCombinedSlipRearRight = tireCombinedSlipRearRight;
        SuspensionTravelMetersFrontLeft = suspensionTravelMetersFrontLeft;
        SuspensionTravelMetersFrontRight = suspensionTravelMetersFrontRight;
        SuspensionTravelMetersRearLeft = suspensionTravelMetersRearLeft;
        SuspensionTravelMetersRearRight = suspensionTravelMetersRearRight;
        CarOrdinal = carOrdinal;
        CarClass = carClass;
        CarPerformanceIndex = carPerformanceIndex;
        DrivetrainType = drivetrainType;
        NumCylinders = numCylinders;
        PositionX = positionX;
        PositionY = positionY;
        PositionZ = positionZ;
        Speed = speed;
        Power = power;
        Torque = torque;
        TireTempFrontLeft = tireTempFrontLeft;
        TireTempFrontRight = tireTempFrontRight;
        TireTempRearLeft = tireTempRearLeft;
        TireTempRearRight = tireTempRearRight;
        Boost = boost;
        Fuel = fuel;
        DistanceTraveled = distanceTraveled;
        BestLap = bestLap;
        LastLap = lastLap;
        CurrentLap = currentLap;
        CurrentRaceTime = currentRaceTime;
        LapNumber = lapNumber;
        RacePosition = racePosition;
        Accel = accel;
        Brake = brake;
        Clutch = clutch;
        HandBrake = handBrake;
        Gear = gear;
        Steer = steer;
        NormalizedDrivingLine = normalizedDrivingLine;
        NormalizedAIBrakeDifference = normalizedAIBrakeDifference;
        TireWearFrontLeft = tireWearFrontLeft;
        TireWearFrontRight = tireWearFrontRight;
        TireWearRearLeft = tireWearRearLeft;
        TireWearRearRight = tireWearRearRight;
        TrackOrdinal = trackOrdinal;
    }
}
