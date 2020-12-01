using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireSystem.Classes
{
    abstract class Vehicle
    {
        protected int type;
        protected String make;
        protected String model;
        protected int daysHired;
        protected double price;
        protected String fuelType;
        protected int engineSize;
        protected bool manual;  //the method PrintVehicleDetails will be overriten in car and van

        //setters
        public void setType(int Type)
        {
            this.type = Type;
        }
        public void setMake(String Make)
        {
            this.make = Make;
        }
        public void setModel(String Model)
        {
            this.model = Model;
        }
        public void setDaysHired(int DaysHired)
        {
            this.daysHired = DaysHired;
        }
        public void setPrice(double Price)
        {
            this.price = Price;
        }
        public void setFuelType(String FuelType)
        {
            this.fuelType = FuelType;
        }
        public void setEngineSize(int EngineSize)
        {
            this.engineSize = EngineSize;
        }
        public void setManual(bool Manual)
        {
            this.manual = Manual;
        }
        //getters
        public int getType()
        {
            return type;
        }
        public String getMake()
        {
            return make;
        }
        public String getModel()
        {
            return model;
        }
        public int getDaysHired()
        {
            return daysHired;
        }
        public double getPrice()
        {
            return price;
        }
        public String getFuelType()
        {
            return fuelType;
        }
        public int getEngineSize()
        {
            return engineSize;
        }
        public bool getManual()
        {
            return manual;
        }
    }

}
