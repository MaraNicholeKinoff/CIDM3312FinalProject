using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace CIDM3312Project.Models
{
    public class SeedData
    {
        
        public static void CreateSeedData() {
            using (var context = new AppDBContext()) {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            using (var context = new AppDBContext()) {
                if(!context.StudentTeams.Any())
                {
                    List<StudentTeams> steams = new List<StudentTeams>()
                    {
                        new StudentTeams() 
                        {
                            StudentID = 1,
                            TeamID = 1,
                            Role = "Front End Developer"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 2,
                            TeamID = 1,
                            Role = "Coder"
                        }
                    };
                    context.StudentTeams.AddRange(steams);                    
                    context.SaveChanges();
                }
                if(!context.ClientOrganization.Any())
                {
                    List<ClientOrganization> corgs = new List<ClientOrganization>()
                    {
                        new ClientOrganization() 
                        {
                            ClientID = 1,
                            OrganizationID = 1,
                        },
                        new ClientOrganization() 
                        {
                            ClientID = 2,
                            OrganizationID = 1,
                        }
                    };
                    context.ClientOrganization.AddRange(corgs);                    
                    context.SaveChanges();
                }
                if(!context.Student.Any())
                {
                    List<Student> students = new List<Student>()
                    {
                        new Student() 
                        {
                            FirstName = "Mara", 
                            LastName = "Kinoff", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "mara@domain.com", 
                            Major = "CIS" 
                        },
                        new Student() 
                        {
                            FirstName = "Sean", 
                            LastName = "Kinoff", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "sean@domain.com", 
                            Major = "CIS" 
                        }
                    };
                    context.Student.AddRange(students);                    
                    context.SaveChanges();
                }
                if(!context.Client.Any())
                {
                    List<Client> clients = new List<Client>()
                    {
                        new Client() 
                        {
                            FirstName = "John", 
                            LastName = "Smith", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "john@domain.com", 
                            OrganizationID = 1
                        },
                        new Client() 
                        {
                            FirstName = "Jane", 
                            LastName = "Smith", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "jane@domain.com", 
                            OrganizationID = 2
                        }
                    };
                    context.Client.AddRange(clients);                    
                    context.SaveChanges();
                }

                if(!context.FacultySponsor.Any())
                {
                    List<FacultySponsor> facultySponsors = new List<FacultySponsor>()
                    {
                        new FacultySponsor() 
                        {
                            FirstName = "Jeff", 
                            LastName = "Babb", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "jeff@domain.com",
                            DepartmentName = "Computer Information and Decision Management" 
                        },
                        new FacultySponsor() 
                        {
                            FirstName = "Katherine", 
                            LastName = "Payne", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "katherine@domain.com",
                            DepartmentName = "Computer Information and Decision Management" 
                        }
                    };
                    context.FacultySponsor.AddRange(facultySponsors);                    
                    context.SaveChanges();
                }

                if(!context.Team.Any())
                {
                    List<Team> teams = new List<Team>()
                    {
                        new Team() 
                        {
                            TeamName = "Team Alpha"
                        },
                        new Team() 
                        {
                            TeamName = "Team Beta"
                        }
                    };
                    context.Team.AddRange(teams);                    
                    context.SaveChanges();
                }
                
                if(!context.Organization.Any()) 
                {
                    List<Organization> org = new List<Organization>()
                    {
                        new Organization() 
                        {
                            OrganizationName = "A Company",
                            PhoneNumber = "012-345-6789",
                            Email = "acompanyn@email.com",
                            AddLine1 = "123 West Ave",
                            AddLine2 = "Suite 101",
                            City = "Amarillo",
                            Zipcode = "77777",
                            State = "TX"
                        },
                        new Organization() 
                        {
                            OrganizationName = "B Company",
                            PhoneNumber = "122-333-4444",
                            Email = "bcompanyn@email.com",
                            AddLine1 = "123 East Ave",
                            AddLine2 = "",
                            City = "Amarillo",
                            Zipcode = "77777",
                            State = "TX"
                        }
                    };
                    context.Organization.AddRange(org);                    
                    context.SaveChanges();
                }

            }
        }
    }
}