using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class CleanToxicSubstances : Cleaner
    {
        public CleanToxicSubstances()
        {
            isMinor = true;
            isMakeDecission = true;
            isExpert = true;
            isAtRisk = true;
            riskPrecent = 1.2;
            
        }
    }
}
