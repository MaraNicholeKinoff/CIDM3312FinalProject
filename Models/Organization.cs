using System;

namespace CIDM3312Project.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; } 
        public string OrganizationName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }

        public override string ToString(){
            return "Organization " + this.OrganizationID + ": " + this.OrganizationName;
        }
    }
}