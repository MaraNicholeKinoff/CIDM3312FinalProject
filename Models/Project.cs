using System;

namespace CIDM3312Project.Models
{
    public class Project 
    {
        public int ProjectID { get; set; }
        public int ClientID{ get; set; }
        public Client Client { get; set; }
        public string ProjectName { get; set; }
        public int EstimatedHours { get; set; }
        public DateTime Deadline { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }

        public override string ToString(){
            return "Project " + this.ProjectID + ": " + this.ProjectName + " - " + this.TeamID;
        }
    }
}