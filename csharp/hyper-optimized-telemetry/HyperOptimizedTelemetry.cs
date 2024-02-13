using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        return BitConverter.GetBytes(reading).Reverse();
    }

    public static long FromBuffer(byte[] buffer)
    {
        throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
    }
}
