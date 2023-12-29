using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return this.battery >= this.batteryDrain ? false : true;
    }

    public int DistanceDriven()
    {
        return this.distanceDriven;
    }

    public void Drive()
    {
        if (this.battery >= this.batteryDrain)
        {
            this.distanceDriven += this.speed;
            this.battery -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            if (!car.BatteryDrained())
            {
                car.Drive();
            }

            if (car.DistanceDriven() >= this.distance)
            {
                return true;
            }
        }
        return false;
    }
}
