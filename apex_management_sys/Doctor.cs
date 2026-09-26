using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace apex_management_sys
{
    public class Doctor : User
    {
        public override UserRole Role => UserRole.Doctor;
    }
}
