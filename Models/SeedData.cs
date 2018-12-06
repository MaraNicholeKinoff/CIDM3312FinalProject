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
                        },
                        new StudentTeams() 
                        {
                            StudentID = 3,
                            TeamID = 1,
                            Role = "Coder"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 4,
                            TeamID = 1,
                            Role = "Project Coordinator"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 5,
                            TeamID = 1,
                            Role = "Back End Developer"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 6,
                            TeamID = 2,
                            Role = "Front End Developer"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 7,
                            TeamID = 2,
                            Role = "Coder"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 8,
                            TeamID = 2,
                            Role = "Coder"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 9,
                            TeamID = 2,
                            Role = "Project Coordinator"
                        },
                        new StudentTeams() 
                        {
                            StudentID = 10,
                            TeamID = 1,
                            Role = "Back End Developer"
                        },
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
                            OrganizationID = 2,
                        }
                    };
                    context.ClientOrganization.AddRange(corgs);                    
                    context.SaveChanges();
                }
                if(!context.Member.Any())
                {
                    List<Member> members = new List<Member>()
                    {
                        new Member() 
                        {
                            FirstName = "Mara", 
                            LastName = "Kinoff", 
                            PhoneNumber = "012-345-6789", 
                            Email = "marak@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Sean", 
                            LastName = "Kinoff", 
                            PhoneNumber = "123-456-7890", 
                            Email = "seank@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Amy", 
                            LastName = "Saysouriyosack", 
                            PhoneNumber = "234-567-8901", 
                            Email = "amys@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "John", 
                            LastName = "Cunningham", 
                            PhoneNumber = "345-678-9012", 
                            Email = "johnc@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Vanessa", 
                            LastName = "Valenzuela", 
                            PhoneNumber = "456-789-0123", 
                            Email = "vanessav@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Michael", 
                            LastName = "Mathews", 
                            PhoneNumber = "567-890-1234", 
                            Email = "michaelm@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Claudia", 
                            LastName = "Silva", 
                            PhoneNumber = "678-901-2345", 
                            Email = "claudias@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Catherine", 
                            LastName = "McGovern", 
                            PhoneNumber = "789-012-3456", 
                            Email = "catherinem@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Kayla", 
                            LastName = "Washington", 
                            PhoneNumber = "890-123-4567", 
                            Email = "kaylaw@email.com", 
                            Major = "CIS" 
                        },
                        new Member() 
                        {
                            FirstName = "Cory", 
                            LastName = "Williams", 
                            PhoneNumber = "901-234-5678", 
                            Email = "coryw@email.com", 
                            Major = "CIS" 
                        },
                    };
                    context.Member.AddRange(members);                    
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
                            PhoneNumber = "987-654-3210", 
                            Email = "john@someemail.com", 
                            OrganizationID = 1
                        },
                        new Client() 
                        {
                            FirstName = "Jane", 
                            LastName = "Smith", 
                            PhoneNumber = "654-987-3210", 
                            Email = "jane@someemail.com", 
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
                if(!context.Project.Any()) 
                {
                    List<Project> project = new List<Project>()
                    {
                        new Project() 
                        {
                            ClientID = 1,
                            ProjectName = "New Website",
                            EstimatedHours = 40,
                            Deadline = "12/12/2018",
                            TeamID = 2,
                            SponsorID = 1
                        },
                        new Project() 
                        {
                            ClientID = 2,
                            ProjectName = "Fix Existing Website",
                            EstimatedHours = 30,
                            Deadline = "12/15/2018",
                            TeamID = 1,
                            SponsorID = 2
                        }
                    };
                    context.Project.AddRange(project);                    
                    context.SaveChanges();
                }
            }
        }
    }
}