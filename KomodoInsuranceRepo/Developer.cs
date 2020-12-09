using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceRepo
{
    public class Developer
    {
        //Developers have names and ID numbers
        public int DeveloperID { get; set; }
        public string DeveloperName { get; set; }
        public bool HasPluralSightAccess { get; set; }
    }
}
