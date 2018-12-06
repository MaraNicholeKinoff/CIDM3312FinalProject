using System;

namespace CIDM3312Project.Models
{
    public class ProjectDetails 
    {
        public int ProjectID { get; set; }
        public Project Project  {get; set; }
        public int ClientID { get; set; }
        public Client Client  {get; set; }
    }
}