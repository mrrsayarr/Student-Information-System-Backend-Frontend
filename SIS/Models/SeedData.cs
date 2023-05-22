using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SIS.Data;
using System;
using System.Linq;

namespace SIS.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SISContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SISContext>>()))
            {
                // Look for any movies.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }
                context.Students.AddRange(
                    new Students
                    {
                        FirstName = "Ahmet",
                        LastName = "Yılmaz",
                        Department = "Computer Engineering",
                        Email = "Ahmet@gmail.com",
                        Address = "İstanbul",
                        StudentNo = "4950",
                        PhoneNumber = "053212345",
                        BirthDate = DateTime.Parse("1995-01-01"),
                        RegistrationDate = DateTime.Parse("2000-3-13"),
                        Gender = "Male",
                        IdentificationNumber = "159753867"
                        
                    },
                    new Students
                    {
                        FirstName = "Ayşe",
                        LastName = "Balta",
                        Department = "Computer",
                        Email = "Ayse@gmail.com",
                        Address = "İstanbul",
                        StudentNo = "4951",
                        PhoneNumber = "053212345",
                        BirthDate = DateTime.Parse("1995-01-01"),
                        RegistrationDate = DateTime.Parse("2000-3-13"),
                        Gender = "Male",
                        IdentificationNumber = "123456789"
                    },
                    new Students
                    {
                        FirstName = "Mert",
                        LastName = "Karapınar",
                        Department = "Computer",
                        Email = "Mert4950@gmail.com",
                        Address = "İstanbul",
                        StudentNo = "4090",
                        PhoneNumber = "053212343",
                        BirthDate = DateTime.Parse("1995-01-01"),
                        RegistrationDate = DateTime.Parse("2000-3-13"),
                        Gender = "Male",
                        IdentificationNumber = "123456789"
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}

