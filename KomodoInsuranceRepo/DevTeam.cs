using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceRepo
{
    public class DevTeam
    {
        public int DevTeamID { get; set; }
        public string DevTeamName { get; set; }
        public List<Developer> DevelopersOnTeam { get; set; }

    }
}
