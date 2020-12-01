using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireSystem.Classes
{
    class VanClass: Vehicle
    {
        protected double cargoSpace;
        protected char wheelBase;
        protected bool sideDors;
        protected bool tailLift;

        //setters
        public void setCargoSpace(double CargoSpace)
        {
            this.cargoSpace = CargoSpace;
        }
        public void setWheelBase(char WheelBase)
        {
            this.wheelBase = WheelBase;
        }
        public void setSideDors(bool SideDors)
        {
            this.sideDors = SideDors;
        }
        public void setTailLift(bool TailLift)
        {
            this.tailLift = TailLift;
        }
        //getters
        public double getCargoSpace()
        {
            return cargoSpace;
        }
        public char getWheelBase()
        {
            return wheelBase;
        }
        public bool getSideDors()
        {
            return sideDors;
        }
        public bool getTailLift()
        {
            return tailLift;
        }
        //constructor
        public VanClass(String make, String model, int daysHired, double price, String fuelType, 
            int engineSize, bool manual, double cargoSpace, char wheelBase, bool sideDors, bool tailLift)
        {
            this.make = make;
            this.model = model;
            this.daysHired = daysHired;
            this.price = price;
            this.fuelType = fuelType;
            this.engineSize = engineSize;
            this.manual = manual;
            this.cargoSpace = cargoSpace;
            this.wheelBase = wheelBase;
            this.sideDors = sideDors;
            this.tailLift = tailLift;
        }
        public VanClass() { }
        public string PringVanDetails()
        {
            return "";
        }
    }
}
