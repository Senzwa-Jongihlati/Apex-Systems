using ApexSystems;
using System;
using System.Collections.Generic;
using System.Text;
public static class Session
{
    public static Receptionist CurrentReceptionist { get; private set; }

    public static void Login(Receptionist receptionist)
    {
        CurrentReceptionist = receptionist;
    }

    public static void Logout()
    {
        CurrentReceptionist = null;
    }
}