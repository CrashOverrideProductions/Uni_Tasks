using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_3C
{
    class TempClasses
    {
    }

    class Battery
    {
        private int charge; // Battery Charge Value 
        private int ID;

        public Battery(int ident)
        {
            this.charge = RandomNumber();
            this.ID = ident;
        }

        public string GetID()
        {
            return this.ID.ToString();
        }

        public void PrintChargeValue()
        {
            Console.WriteLine("Battery Charged to {0} Units", GetChargeValue());
        }

        public int GetChargeValue()
        {
            return this.charge;
        }

        public bool ChargeBattery(int units)
        {
            if ((this.charge + units) > 10)
            {
                this.charge = 10;
                Console.WriteLine("Battery Fully Charged");
                return true;
            }
            else
            {
                this.charge = (this.charge + units);
                Console.WriteLine("Battery Charged to {0} Units", GetChargeValue());
                return true;
            }

        }

        public bool DischargeBattery(int units)
        {
            if ((this.charge - units) < 0)
            {
                this.charge = (this.charge - units);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }

    }

    class SolarPanel
    {
        private string _name = "SunnyAbsorb 10000";
        private int _chargeValue = 1;
        Battery _battery;

        public SolarPanel() { }

        public void ConnectBattery(Battery battery)
        {
            this._battery = battery;
        }

        public void DisconnectBattery()
        {
            this._battery = null;
        }

        public bool ChargeBattery(Battery toCharge)
        {
            if (toCharge.ChargeBattery(_chargeValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class Motor
    {
        private string _name = "Tien Corp: M5";
        private int batteryUsage = 1;
        Battery _battery;


        public Motor()
        {

        }

        public void ConnectBattery(Battery battery)
        {
            this._battery = battery;
        }

        public void DisconnectBattery()
        {
            this._battery = null;
        }
        public bool MoveDirection()
        {
            if (this._battery.GetChargeValue() <= batteryUsage)
            {
                this._battery.DischargeBattery(batteryUsage);
                return true;
            }
            else
            {
                return false;
            }
        }


    }

    class Radar
    {
        private string _name = "Jai Force 27";
        private int batteryUsage = 4;
        Battery _battery;

        public Radar()
        {

        }

        public void ConnectBattery(Battery battery)
        {
            this._battery = battery;
        }

        public void DisconnectBattery()
        {
            this._battery = null;
        }

        public bool UseRadar()
        {
            if (this._battery.GetChargeValue() <= batteryUsage)
            {
                this._battery.DischargeBattery(batteryUsage);
                return true;
            }
            else
            {
                return false;
            }
        }

       

    }


    class Drill
    {
        private string _name = "Specimen Extractor 100";
        private int batteryUsage = 1; // Task sheet does not specifiy Drill Power consumption
        private int drillLife = 100;
        Battery _battery;

        public Drill() { }

        public bool TakeSpecimen()
        {
            if (this._battery.GetChargeValue() <= batteryUsage)
            {
               this._battery.DischargeBattery(batteryUsage);
                return true;
            }
            else
            {
                return false;
            }
        }

       public void ConnectBattery(Battery battery)
        {
            this._battery = battery;
        }

        public void DisconnectBattery()
        {
            this._battery = null;
        }
    }

    class Rover
    {
        private string _name = "Rover";
        private List<Battery> _batteries;
        private SolarPanel _solar;
        private Motor _motor;
        private Drill _drill;
        private Radar _radar;
        private int[] _position = {0,0};

        public Rover(int qtyBatteries)
        {
            // Add 3 Batteries to Rover
            _batteries = new List<Battery>();

            int x = 0;
            while (x < qtyBatteries)
            {
                _batteries.Add(new Battery(x));
                x++;
            }

            // Add Solar
            _solar = new SolarPanel();
            
            // Add Motor
            _motor = new Motor();

            // Add Drill
            _drill = new Drill();

            // Add Radar
            _radar = new Radar();

        }

        public bool MoveRover(string Direction, int size)
        {
            if (Direction == "Left")
            {
                if (_position[0] != 0)
                {
                    if (_motor.MoveDirection())
                    {
                        _position[0] = _position[0] - 1;
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else if (Direction == "Right")
            {
                if (_position[0] > size)
                {
                    if (_motor.MoveDirection())
                    {
                        _position[0] = _position[0] + 1;
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;

        }

        public int[] GetRoverPosition()
        {
            return this._position;
        }

    }

    class Environment
    {
        private int _gridWidth;
        private int _gridHeight;

        private List<Rover> _rover;

        public Environment(int gridWidth, int gridHeight)
        {
            this._gridWidth = gridWidth;
            this._gridHeight = gridHeight;

            this._rover = new List<Rover>();

        }

        public void AddRover(int QtyBatt)
        {
            _rover.Add(new Rover(QtyBatt));
        }

        public void MoveRover (int rover, string dir, int size)
        {
            _rover[rover].MoveRover(dir, size);
        }

        public int[] GetRoverPosition(int rover)
        {
            return _rover[rover].GetRoverPosition();
        }

    }
}
