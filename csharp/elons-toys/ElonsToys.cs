using System;

class RemoteControlCar
{
    private int _metersDriven = 0;
    private int _batteryPercentage = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryPercentage > 0 ? $"Battery at {_batteryPercentage}%" : "Battery empty";
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _metersDriven += 20;
            _batteryPercentage -= 1;
        }
    }
}
