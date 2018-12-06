using System;

namespace CIDM3312Project.Models
{
    public class Member
    {
        public int MemberID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Major { get; set; }
        
        public override string ToString(){
            return "Student " + this.MemberID + ": " + this.FirstName + " " + this.LastName + " - " + this.Major;
}
    }
}