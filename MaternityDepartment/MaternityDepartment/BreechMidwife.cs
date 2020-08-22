using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class BreechMidwife: Midwife
    {
        public BreechMidwife()
        {
            isMinor = true;
            isExpert = true;
        }
    }
}
