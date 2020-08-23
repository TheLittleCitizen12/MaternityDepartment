using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    public class SaleryInfo
    {


        public void UpdateEmployee(string id, double salery, Dictionary<string,double> employeeSaleryDict)
        {
            
            if (!employeeSaleryDict.ContainsKey(id))
            {
                employeeSaleryDict.Add(id, salery);
            }
            employeeSaleryDict[id] = salery;
        }

        public void ShowSalery(string id, Dictionary<string, double> employeeSaleryDict)
        {
            Console.WriteLine(employeeSaleryDict[id]);
        }


    }
}
