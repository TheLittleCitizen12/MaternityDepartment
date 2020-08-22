using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class TraineeDoctorAndObsteticain : TraineeDoctor
    {
        public TraineeDoctorAndObsteticain()
        {
            isMinor = true;
            isExpert = true;
        }
        public void HelpWithChildbirth()
        {

        }
    }
}
