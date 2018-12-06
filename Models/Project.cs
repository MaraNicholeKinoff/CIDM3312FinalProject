using System;
using System.Collections.Generic;

namespace CIDM3312Project.Models
{
    public class Project 
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public int EstimatedHours { get; set; }
        public string Deadline { get; set; }
        public List<Member> Members { get; set; }

        public override string ToString(){
            return "Project " + this.ProjectID + ": " + this.ProjectName;
        }
    }
}