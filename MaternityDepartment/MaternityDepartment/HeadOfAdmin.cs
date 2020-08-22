using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class HeadOfAdmin : Employee
    {
        public HeadOfAdmin()
        {
            isManager = true;
            isMakeDecission = true;
            
            _hourlyWage = 15000;
        }
    }
}
