class RemoteControlCar
{
    private int _drive;
    private int _distance_driven;
    private int _battery;

    public RemoteControlCar(){
        _drive = 0;
        _distance_driven = 0;
        _battery = 100;
    }

    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay() => $"Driven {_drive} meters";

    public string BatteryDisplay(){
        if(_battery <= 0){
            return "Battery empty";
        } else {
            return $"Battery at {_battery}%";
        }
    }

    public void Drive()
    {
        _distance_driven++;
        _drive = _distance_driven * 20;
        _battery = 100 - _distance_driven;

        if(_battery <= 0){
            _drive -= 20;
        }
    }
}
