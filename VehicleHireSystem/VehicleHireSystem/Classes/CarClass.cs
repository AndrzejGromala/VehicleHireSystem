using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireSystem.Classes
{
    class CarClass: Vehicle
    {
        protected int nbOfDors;
        protected int nbOfSeats;
        protected String bodyType;

        //setters
        public void setNbOfDors(int NbOfDors)
        {
            this.nbOfDors = NbOfDors;
        }
        public void setNbOfSeats(int NbOfSeats)
        {
            this.nbOfSeats = NbOfSeats;
        }
        public void setBodyType(String BodyType)
        {
            this.bodyType = BodyType;
        }
        //getters
        public int getNbOfDors()
        {
            return nbOfDors;
        }
        public int getNbOfSeats()
        {
            return nbOfSeats;
        }
        public String getBodyType()
        {
            return bodyType;
        }
        //constructor
        public CarClass(String make, String model, int daysHired, double price, String fuelType, 
            int engineSize, bool manual, int nbOfDors, int nbOfSeats, String bodyType)
        {
            this.make = make;
            this.model = model;
            this.daysHired = daysHired;
            this.price = price;
            this.fuelType = fuelType;
            this.engineSize = engineSize;
            this.manual = manual;
            this.nbOfDors = nbOfDors;
            this.nbOfSeats = nbOfSeats;
            this.bodyType = bodyType;
        }
        public CarClass() { }

        public string PringCarDetails()
        {
            return "";
        }

        //internal void Add(CarClass tempCar)
       // {
            //throw new NotImplementedException();
        //}
    }
}
