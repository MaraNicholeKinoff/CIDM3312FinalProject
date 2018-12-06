using System;

namespace CIDM3312Project.Models
{
    public class ClientOrganization
    {
        public int ClientID { get; set; }
        public int OrganizationID{ get; set; }
        public Client Client { get; set; }
        public Organization Organization { get; set; }

        public override string ToString(){
            return "Client Organization: " + this.ClientID + " - " + this.OrganizationID;
        }
    }
}