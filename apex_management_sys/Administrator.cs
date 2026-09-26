using System;
using System.Collections.Generic;
using System.Text;

namespace apex_management_sys
{
    public class Administrator : User
    {
        public override UserRole Role => UserRole.Admin;
    }
}
