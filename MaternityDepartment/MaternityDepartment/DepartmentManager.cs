using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace MaternityDepartment
{
    class DepartmentManager : Employee
    {
        public DepartmentManager()
        {
            isManager = true;
            isMakeDecission = true;
            isAtRisk = true;
            riskPrecent = 2;
            _hourlyWage = 25000;
        }
    }
}
