using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MaternityDepartment
{
    class Program 
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> employeeSaleryDict = new Dictionary<string, double>();
            bool runMenu = true;
            while(runMenu)
            {
                
                Console.WriteLine("[1] Enter all employee shift info");
                Console.WriteLine("[2] Show employee salery");
                Console.WriteLine("[3] Exit");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                    CreateEmployee(employeeSaleryDict);
                if (userInput == 2)
                    showSalery(employeeSaleryDict);
                if (userInput == 3)
                    return;
                else
                    Console.WriteLine("Please try again");
            }



        }
        public static void CreateEmployee(Dictionary<string,double> employeeSaleryDict)
        {
            var cleaner = new Cleaner();
            cleaner.id = "1";
            cleaner.name = "jhon";
            shiftInfo(cleaner, employeeSaleryDict);


            var cleanToxicSubstances = new CleanToxicSubstances();
            cleanToxicSubstances.id = "2";
            cleanToxicSubstances.name = "jhon";
            shiftInfo(cleanToxicSubstances, employeeSaleryDict);

            var doctor = new Doctor();
            doctor.id = "3";
            doctor.name = "john";
            shiftInfo(doctor, employeeSaleryDict);

            var chef = new Chef();
            chef.id = "4";
            chef.name = "john";
            shiftInfo(chef, employeeSaleryDict);

        }
        public static void  shiftInfo(Employee employee, Dictionary<string, double> employeeSaleryDict)
        {

            Console.Write("Enter start time of the shift: ");
            employee.startShift = Console.ReadLine();
            Console.Write("Enter end time of the shift: ");
            employee.endShift = Console.ReadLine();
            employee.sumOfHours = (employee.shiftTime(employee.startShift, employee.endShift));
            employee.calculateSalery(employee, employeeSaleryDict);
            Console.ReadLine();
        }

        public static void showSalery( Dictionary<string, double> employeeSaleryDict)
        {
            Cleaner employee = new Cleaner();
            Console.Write("Enter employ id to see salery: ");
            string id = Console.ReadLine();
            employee.ShowSalery(id, employeeSaleryDict);
            
        }

        
    }
}
