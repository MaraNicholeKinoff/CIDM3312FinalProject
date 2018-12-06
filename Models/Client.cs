using System;

namespace CIDM3312Project.Models
{
    public class Client
    {
        public int ClientID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString(){
            return "Client " + this.ClientID + ": " + this.FirstName + " " + this.LastName;
}
    }
}