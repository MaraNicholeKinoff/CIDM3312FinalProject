using System;

namespace CIDM3312Project.Models
{
    public class FacultySponsor 
    {
        public int ID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }
        
        public override string ToString(){
            return "Advisor " + this.ID + ": " + this.FirstName + " " + this.LastName + " - " + this.DepartmentName;
        }
    }
}