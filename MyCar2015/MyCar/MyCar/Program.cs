using Freecol;
using MdfManufacturers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorContract;

namespace MyCar
{
    class Bootstrap
    {
        static void Main(string[] args)
        {
            var carType = ConfigurationManager.AppSettings["carType"];
            var mode = ConfigurationManager.AppSettings["mode"];

            Console.WriteLine(carType);
            Console.WriteLine(mode);



            var car = BuildCar(carType, mode);

            var remote = new Remote(car);
            remote.HandleUserInput();
        }

        private static Car BuildCar(string carType, string mode)
        {
            var simulator = new CarSpeedSimulator();
            var speedometer = new Speedometer(simulator);

            IAlarm alarm = AlarmFactory.CreateAlarm(carType);
            alarm = new VerifyingAlarmProxy(alarm, mode);

            var speedAlarm = new SpeedAlarm();

            var seatBelt = new SeatBelt();

            Car car = new Car(alarm, seatBelt, simulator, speedometer, speedAlarm);
            return car;
        }
    }

    public static class AlarmFactory
    {
        public static IAlarm CreateAlarm(string carType)
        {
            if (carType == "normal") return new Alarm();

            return new FeecolAlarmAdapter(new LowFrequencyAlarm());
        }
    }

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

    public class CarSpeedSimulator
    {
        private int _speed;
        public Action<int> SpeedChanged;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if (_speed != value)
                {
                    _speed = value;
                    SpeedChanged?.Invoke(_speed);
                }
            }
        }

        public void Increase()
        {
            if (Speed >= 220) return;
            Speed = Speed + 10;
        }

        public void Decrease()
        {
            if (Speed <= 0) return;
            Speed = Speed - 10;
        }
    }

    public class FeecolAlarmAdapter : IAlarm
    {
        private readonly LowFrequencyAlarm _lowFrequencyAlarm;

        public FeecolAlarmAdapter(LowFrequencyAlarm lowFrequencyAlarm)
        {
            _lowFrequencyAlarm = lowFrequencyAlarm;
        }

        public void RaiseAlarm()
        {
            _lowFrequencyAlarm.Beep();
        }
    }

    public interface ISpeedObserver
    {
        void OnSpeedChange(int speed);
    }


    public class Remote
    {
        private readonly Car _car;

        public Remote(Car car)
        {
            _car = car;
        }

        public void HandleUserInput()
        {
            Console.WriteLine("Please press the option");
            Console.WriteLine("i/I for increase car speed");
            Console.WriteLine("d/D for decrease car speed");
            Console.WriteLine("u/U for unlock car");
            Console.WriteLine("l/L for lock car");
            Console.WriteLine("e/E for exit the application");

            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                var keyChar = key.KeyChar;
                var optionString = keyChar.ToString().ToLower();

                if (optionString == "i") _car.IncreaseSpeed();
                else if (optionString == "d") _car.DecreaseSpeed();
                else if (optionString == "l") _car.Lock();
                else if (optionString == "u") _car.Unlock();
                else if (optionString == "e") break;
                else Console.WriteLine("unknown option");
            }
        }
    }

    public class SeatBelt : ISpeedObserver
    {

        private IAlarm _alarm;
        private int _oldSpeed = 0;
        private bool _isLocked = false;

        public void SetSpeedSource(ISpeedSource speedSource)
        {
            speedSource.AddSpeedObserver(this);
        }

        public void SetAlarm(IAlarm alarm)
        {
            _alarm = alarm;
        }

        public void Lock()
        {
            _isLocked = true;
        }

        public void UnLock()
        {
            _isLocked = false;
        }

        public void OnSpeedChange(int speed)
        {
            if ((_oldSpeed < 20) && (speed >= 20))
            {
                _alarm?.RaiseAlarm();
            }
            _oldSpeed = speed;
        }
    }

    public class SpeedAlarm : ISpeedObserver
    {
        private IAlarm _alarm;
        private int _oldSpeed = 0;

        public void SetAlarm(IAlarm alarm)
        {
            _alarm = alarm;
        }

        public void SetSpeedSource(ISpeedSource speedSource)
        {
            speedSource.AddSpeedObserver(this);
        }

        public void OnSpeedChange(int speed)
        {
            if ((_oldSpeed < 80) && (speed >= 80))
            {
                _alarm?.RaiseAlarm();
            }
            _oldSpeed = speed;
        }
    }

    public interface ISpeedSource
    {
        void AddSpeedObserver(ISpeedObserver speedObserver);
    }

    public class Speedometer : ISpeedSource
    {
        List<ISpeedObserver> _speedObservers = new List<ISpeedObserver>();

        public Speedometer(CarSpeedSimulator speedSimulator)
        {
            speedSimulator.SpeedChanged += OnSpeedChanged;
        }

        private void OnSpeedChanged(int speed)
        {
            Console.WriteLine("Current Speed :" + speed);
            foreach (var speedObserver in _speedObservers)
            {
                speedObserver.OnSpeedChange(speed);
            }

        }

        public void AddSpeedObserver(ISpeedObserver speedObserver)
        {
            _speedObservers.Add(speedObserver);
        }
    }

    public class VerifyingAlarmProxy : IAlarm
    {
        private readonly IAlarm _alarm;
        private readonly string _mode;

        public VerifyingAlarmProxy(IAlarm alarm, string mode)
        {
            _alarm = alarm;
            _mode = mode;
        }

        public void RaiseAlarm()
        {
            if (_mode == "testing" || _mode == "verification")
            {
                Log();
            }

            if (_mode != "testing")
            {
                _alarm.RaiseAlarm();
            }

        }

        private void Log()
        {
            Console.WriteLine("Alarm Raised");
        }
    }
}
