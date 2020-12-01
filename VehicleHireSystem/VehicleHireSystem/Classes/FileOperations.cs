using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VehicleHireSystem.Classes
{
    static class FileOperations
    {
        public static int car = 0;
        public static int van = 1;
        //method for reading Cars
        public static List<CarClass> ReadInCars(string filePath)
        {// Create method to read from text file.

            List<CarClass> listOfCars = new List<CarClass>();// Create  an Array list of object listOfAccounts so it could store data from text file.
            //List<VanClass> listOfVans = new List<VanClass>();
            String[] allCarsDatails = File.ReadAllLines(filePath);// String to read from file.
            //need to use something for the first position to load cars to cars list and vans to vanlist
            //this is the control for type of vehicle
            


            for (int i = 0; i < allCarsDatails.Length; i++)// Loops through the text file.
            {
               
                    CarClass tempCar = new CarClass();// This is temporary object that takes data from text file.
                    String[] CarDetails = allCarsDatails[i].Split('|');// Seperates data in text file using pipe.
                if (CarDetails.ElementAt(0).Equals(car.ToString()))
                {
                    tempCar.setType(int.Parse(CarDetails[0]));
                    tempCar.setMake(CarDetails[1]);// Assigns first item in text field to variable AccountNb.
                    tempCar.setModel(CarDetails[2]);// Assigns first item in text field to variable Balance.
                    tempCar.setDaysHired(int.Parse(CarDetails[3]));// Assigns first item in text field to variable Active.
                    tempCar.setFuelType(CarDetails[4]);// Assigns first item in text field to variable accountName.
                    tempCar.setPrice(double.Parse(CarDetails[5]));// // Assigns first item in text field to variable Pin.
                    tempCar.setEngineSize(int.Parse(CarDetails[6]));// Assigns first item in text field to variable numberOfattempts.
                    tempCar.setManual(bool.Parse(CarDetails[7]));
                    tempCar.setNbOfDors(int.Parse(CarDetails[8]));
                    tempCar.setNbOfSeats(int.Parse(CarDetails[9]));
                    tempCar.setBodyType(CarDetails[10]);
                    listOfCars.Add(tempCar);
                }
            }

            return listOfCars;
        }

        //method for reading vans
        public static List<VanClass> ReadInVans(string filePath)
        {// Create method to read from text file.

            List<VanClass> listOfVans = new List<VanClass>();

            String[] allVansDatails = File.ReadAllLines(filePath);


            for (int i = 0; i < allVansDatails.Length; i++)
            {

                VanClass tempVan = new VanClass();
                String[] VanDetails = allVansDatails[i].Split('|');
                if (VanDetails[0].Equals(van.ToString()))
                {
                    tempVan.setType(int.Parse(VanDetails[0]));
                    tempVan.setMake(VanDetails[1]);
                    tempVan.setModel(VanDetails[2]);
                    tempVan.setDaysHired(int.Parse(VanDetails[3]));
                    tempVan.setFuelType(VanDetails[4]);
                    tempVan.setPrice(double.Parse(VanDetails[5]));
                    tempVan.setEngineSize(int.Parse(VanDetails[6]));
                    tempVan.setManual(bool.Parse(VanDetails[7]));
                    tempVan.setCargoSpace(double.Parse(VanDetails[8]));
                    tempVan.setWheelBase(char.Parse(VanDetails[9]));
                    tempVan.setSideDors(bool.Parse(VanDetails[10]));
                    tempVan.setTailLift(bool.Parse(VanDetails[11]));
                    listOfVans.Add(tempVan);
                }
            }

            return listOfVans;
        }

        public static void WriteAllVehiclesToFile(string filePath, List<CarClass> listOfCars, List<VanClass> listOfVans)
        {
            try
            {
                // if (listOfCars.ElementAt(0).Equals(0))
                // {

                StreamWriter sw = new StreamWriter(filePath);
                string line;
                for (int i = 0; i < listOfCars.Count; i++)
                {
                    //if (i == Menu.selection)
                    //{
                    line = listOfCars[i].getType().ToString();
                    sw.Write(line + "|");

                    line = listOfCars[i].getMake();
                    sw.Write(line + "|");

                    line = listOfCars[i].getModel();
                    sw.Write(line + "|");

                    line = listOfCars[i].getDaysHired().ToString();
                    sw.Write(line + "|");

                    line = listOfCars[i].getFuelType();
                    sw.Write(line + "|");

                    line = listOfCars[i].getPrice().ToString();
                    sw.Write(line + "|");

                    line = listOfCars[i].getEngineSize().ToString();
                    sw.Write(line + "|");

                    line = listOfCars[i].getManual().ToString();
                    sw.Write(line + "|");

                    line = listOfCars[i].getNbOfDors().ToString();
                    sw.Write(line + "|");

                    line = listOfCars[i].getNbOfSeats().ToString();
                    sw.Write(line + "|");

                    line = listOfCars[i].getBodyType().ToString();
                    sw.WriteLine(line);


                }

                for (int i = 0; i < listOfVans.Count; i++)
                {

                    line = listOfVans[i].getType().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getMake();
                    sw.Write(line + "|");

                    line = listOfVans[i].getModel();
                    sw.Write(line + "|");

                    line = listOfVans[i].getDaysHired().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getFuelType();
                    sw.Write(line + "|");

                    line = listOfVans[i].getPrice().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getEngineSize().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getManual().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getCargoSpace().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getWheelBase().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getSideDors().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getTailLift().ToString();
                    sw.WriteLine(line);


                }

               sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }





        }

        
    }
}
