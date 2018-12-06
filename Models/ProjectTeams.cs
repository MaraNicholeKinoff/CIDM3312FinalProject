using System;

namespace CIDM3312Project.Models
{
    public class ProjectTeams
    {     
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public int ProjectID{ get; set; }
        public Project Project { get; set; }

        public override string ToString(){
            return "Project Teams: " + this.TeamID + " - " + this.ProjectID;
        }
    }
}