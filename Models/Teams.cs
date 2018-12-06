using System;

namespace CIDM3312Project.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public override string ToString(){
            return "Team " + this.TeamID + ": " + this.TeamName;
        }    
    }
}