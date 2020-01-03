using DAL;
using System;

namespace BLL
{
    public class PrivateInstallationManager
    {
        public void AddLage(string Strasse, string Nr, string PLZ, string Stadt)
        {
            PrivateInstallationDB r = new PrivateInstallationDB();
            r.AddLage(Strasse, Nr, PLZ, Stadt);
        }
    }
}