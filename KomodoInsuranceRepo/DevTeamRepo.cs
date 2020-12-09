using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceRepo
{
    class DevTeamRepo
    {
        private List<Developer> _DevelopersOnTeam = new List<Developer>();

        private List<DevTeam> _DeveloperTeams = new List<DevTeam>();
        //create
        public void AddDevelopersToList(Developer content)
        {
            _DevelopersOnTeam.Add(content);
        }

        //Read
        public List<Developer> GetDevelopersOnTeam()
        {
            return _DevelopersOnTeam;
        }

        public DevTeam GetDevTeam(string DevTeamName)
        {
            foreach (DevTeam x in _DeveloperTeams)
            {
                if (x.DevTeamName == DevTeamName)
                {
                    return x;
                }
            }
            return null;
        }

        //update
        public bool UpdateExistingTeam(string DevTeamName, DevTeam newTeam)
        {
            //Find the content
            DevTeam OriginalTeam = GetDevTeam(DevTeamName);
            if(OriginalTeam != null)
            {
                OriginalTeam.DevTeamName = newTeam.DevTeamName;
                OriginalTeam.DevTeamID = newTeam.DevTeamID;
                OriginalTeam.DevelopersOnTeam = newTeam.DevelopersOnTeam;

                return true;
            }

            else
            {
                return false;
            }
        }
        //Delete
    }
}
