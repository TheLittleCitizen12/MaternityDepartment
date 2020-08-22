using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class AssistantDepartmentManager : Employee
    {
        public AssistantDepartmentManager()
        {
            isManager = true;
            isMakeDecission = true;
        }
    }
}
