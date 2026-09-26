using System;
using System.Collections.Generic;
using System.Text;

namespace apex_management_sys
{
    public enum UserRole { Receptionist, Doctor, Admin }

    public enum Permission
    {
        ManageQueue,
        BookAppointment,
        ViewPatientRecords,
        AddConsultationNote,
        ViewPatientHistory,
        ManageStaff,
        ViewReports
    }
}
