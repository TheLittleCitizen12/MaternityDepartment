using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MaternityDepartment
{
    abstract class Employee
    {
        public string name;
        public string id;
        protected double _hourlyWage;
        private double sumOfWorkHours { get; set; }
        private double salery { get; set; }
        protected double riskPrecent { get; set; }

        private string _startShift;
        private string _endShift;
        private double _hoursForDay;
        protected bool isMinor;
        protected bool isSenior;
        protected bool isExpert;
        protected bool isMakeDecission;
        protected bool isManager;
        protected bool isAtRisk;
        SaleryInfo saleryInfo = new SaleryInfo();




        public string startShift
        {
            set
            {
                _startShift = value;
            }
            get
            {
                return _startShift;
            }
                
        }

        public string endShift
        {
            set
            {
                _endShift = value;
            }
            get
            {
                return _endShift;
            }

        }
        public double sumOfHours
        {
            set
            {
                _hoursForDay = value;
            }
            get
            {
                return _hoursForDay;
            }

        }


        protected Employee()
        {
            
            _hourlyWage = 25;
            riskPrecent = 0;
            isMinor = false;
            isSenior = false;
            isExpert = false;
            isMakeDecission = false;
            isManager = false;
            isAtRisk = false;
            
        }
        
        

        public double shiftTime(string start, string end)
        {
            DateTime resultStartShift;
            DateTime.TryParse(start, out resultStartShift);

            DateTime resultEndShift;
            DateTime.TryParse(end, out resultEndShift);

            TimeSpan difference = resultEndShift - resultStartShift;

            double sum = (double)difference.TotalHours;
            return sum;
        }

        public void calculateSalery(Employee employee, Dictionary<string, double> employeeSaleryDict)
        {
            if (isManager)
                salery =  _hourlyWage;
            else if (isMakeDecission)
            {
                if (sumOfWorkHours >= 50)
                    salery = 200 * _hourlyWage * 1.5;
                else
                    salery = (sumOfWorkHours += _hoursForDay) * _hourlyWage * 1.5;
            }
            else if (isExpert)
                salery = (sumOfWorkHours += _hoursForDay) * _hourlyWage * 1.3;

            else if(isSenior)
                salery = (sumOfWorkHours += _hoursForDay) * _hourlyWage * 1.05;
            else
                salery = (sumOfWorkHours += _hoursForDay) * _hourlyWage;

            if (isAtRisk)
                salery = salery * riskPrecent;

            string id1 = this.id;
            double salery1 = this.salery;
            
            saleryInfo.UpdateEmployee(id1, salery1, employeeSaleryDict);

        }

        public void ShowSalery(string id, Dictionary<string, double> employeeSaleryDict)
        {

            saleryInfo.ShowSalery(id, employeeSaleryDict);



        }

    }
}
