using WonderTools.VendorContract;

namespace WonderTools.MyCar
{
    public class Car
    {
        private readonly IAlarm _alarm;
        private readonly SeatBelt _seatBelt;
        private readonly CarSpeedSimulator _carSpeedSimulator;
        private readonly Speedometer _speedometer;
        private readonly SpeedAlarm _speedAlarm;

        public Car(IAlarm alarm, SeatBelt seatBelt, CarSpeedSimulator carSpeedSimulator, Speedometer speedometer, SpeedAlarm speedAlarm)
        {
            _alarm = alarm;
            _seatBelt = seatBelt;
            _carSpeedSimulator = carSpeedSimulator;
            _speedometer = speedometer;
            _speedAlarm = speedAlarm;

            speedAlarm.SetAlarm(alarm);
            speedAlarm.SetSpeedSource(speedometer);

            seatBelt.SetAlarm(alarm);
            seatBelt.SetSpeedSource(speedometer);

        }

        public void Lock()
        {
            _seatBelt.Lock();
        }

        public void Unlock()
        {
            _seatBelt.UnLock();
        }

        public void IncreaseSpeed()
        {
            _carSpeedSimulator.Increase();
        }

        public void DecreaseSpeed()
        {
            _carSpeedSimulator.Decrease();
        }
    }
}