using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CIDM3312Project.Models
{
    public class SeedData
    {
        
        public static void CreateSeedData(IApplicationBuilder app) {

        var context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            
            
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
                if(!context.Project.Any()) 
                {
                    List<Project> project = new List<Project>()
                    {
                        new Project() 
                        {
                            ProjectName = "New Website",
                            EstimatedHours = 400,
                            Deadline = "12/12/2018"
                        },
                        new Project() 
                        {
                            ProjectName = "Fix Existing Website",
                            EstimatedHours = 300,
                            Deadline = "12/15/2018"
                        }
                    };
                    context.Project.AddRange(project);                    
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
                            OrganizationName = "Apple, Inc."
                        },
                        new Client() 
                        {
                            FirstName = "Jane", 
                            LastName = "Smith", 
                            PhoneNumber = "654-987-3210", 
                            Email = "jane@someemail.com",
                             OrganizationName = "Microsoft"
                        }
                    };
                    context.Client.AddRange(clients);                    
                    context.SaveChanges();
                }
                if(!context.ProjectDetails.Any()) 
                {
                    List<ProjectDetails> projectdetails = new List<ProjectDetails>()
                    {
                        new ProjectDetails() 
                        {
                            ProjectID = 1,
                            ClientID = 1,
                        },
                        new ProjectDetails() 
                        {
                            ProjectID = 2,
                            ClientID = 2,
                        }
                    };
                    context.ProjectDetails.AddRange(projectdetails);                    
                    context.SaveChanges();
                }
            }
        
    }
}