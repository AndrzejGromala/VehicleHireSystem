using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireSystem.Classes
{
    static class HireClass
    {
        //static List<CarClass> CarList = new List<CarClass>(); //the static keyword is needed here
        //static List<VanClass> VanList = new List<VanClass>();
        public static List<CarClass> displayCar = radioCar();
        public static List<VanClass> displayVan = radioVan();

        private static double vat;
        private static double vatRate = 0.21;
        private static double net;
        private static double gross;
        public static int nbOfDays;
        public static double price;

        //method for reading the file if the  radio button Car is selected
        public static List<CarClass> radioCar()
        {
            List<CarClass> display = FileOperations.ReadInCars("VehicleHire.txt");
            return display;
        }

        //method for radio button Van
        public static List<VanClass> radioVan()
        {
            List<VanClass> display = FileOperations.ReadInVans("VehicleHire.txt");
            return display;
        }

        //calculating the prices
        public static double  CalculatingVat()
        {
            vat = (price * nbOfDays) * vatRate;
            return vat;
        }
        //calculating nett
        public static double CalculatingNett()
        {
            net = price * nbOfDays;
            return net;
        }
        //calculating total
        public static double CalculatingTotal()
        {
            gross = net + vat;
            return gross;
        }
        //updating the rented car in the file

        public static void UpdateVehicles(List<CarClass> carListWriteToFile, List<VanClass> vanListWriteToFile)
        {
            //FileOperations.WriteCarsToFile("C:\\Users\\SwDev06\\Desktop\\VehicleHire.txt", carListWriteToFile, vanListWriteToFile);
            FileOperations.WriteAllVehiclesToFile("VehicleHire.txt", carListWriteToFile,vanListWriteToFile);

        }


        public static void UpdateRentedCar(List<CarClass> carListWriteToFile)
        {
           //FileOperations.WriteCarsToFile("C:\\Users\\SwDev06\\Desktop\\VehicleHire.txt", carListWriteToFile, vanListWriteToFile);
        }
        //updating the rented van in the file
        public static void UpdateRentedVan(List<VanClass> vanListWriteToFile)
        {
           //FileOperations.WriteVansToFile("C:\\Users\\SwDev06\\Desktop\\VehicleHire.txt", vanListWriteToFile, true);
        }
    }
    

}
