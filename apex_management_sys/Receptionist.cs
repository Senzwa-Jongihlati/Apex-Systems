using apex_management_sys;
using System;
using System.Collections.Generic;
using System.Text;
namespace ApexSystems
{
    public class Receptionist : User
    {
        public override UserRole Role => UserRole.Receptionist;
    }
}