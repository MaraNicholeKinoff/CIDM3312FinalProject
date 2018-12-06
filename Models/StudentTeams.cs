using System;

namespace CIDM3312Project.Models
{
    public class StudentTeams
    {
        public int TeamID { get; set; }
        public int StudentID{ get; set; }
        public Team Team { get; set; }
        public Student Student { get; set; }
        public string Role { get; set; }

        public override string ToString(){
            return "Student Teams: " + this.TeamID + " - " + this.StudentID;
        }
    }
}