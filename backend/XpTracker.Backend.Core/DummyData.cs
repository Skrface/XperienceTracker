using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Repo.Common;

namespace XpTracker.Backend.Core
{
    public static class DummyData
    {
        public static void Seed(this XpTrackerDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            if (!dbContext.Experiences.Any())
            {
                dbContext.Experiences.AddRange(new Experience
                {
                    Client = "EDF",
                    Employer = "CGI",
                    JobTitle = "Expert",
                    Management = "managing two beginers",
                    MissionDescription = "The mission was to integrate a GraphQL API on top on the legacy REST API in less than a week.",
                    Remarks = "This mission was pretty hard to deliver in time.",
                    TeamSize = "12 persons"
                },
                new Experience
                {
                    Client = "Orange",
                    Employer = "CGI",
                    JobTitle = "Beginer",
                    Management = "",
                    MissionDescription = "The mission was to take care of the remotely provided data, from an old API to a newer one.",
                    Remarks = "This mission was really nice to work on.",
                    TeamSize = "2 persons"
                },
                new Experience
                {
                    Client = "Atrya",
                    Employer = "CGI",
                    JobTitle = "Beginer",
                    Management = "Some apprentices",
                    MissionDescription = "The mission was to develop an e-commerce solution for the client and allow its final customers to manage order processes.",
                    Remarks = "This was my first mission at CGI.",
                    TeamSize = "5 persons"
                },
                new Experience
                {
                    Client = "Socomec",
                    Employer = "CGI",
                    JobTitle = "Expert",
                    Management = "",
                    MissionDescription = "The mission was develop the frontend application for an existing backend hosted in Microsoft Azure cloud.",
                    Remarks = "",
                    TeamSize = "2 persons"
                },
                new Experience
                {
                    Client = "Mars",
                    Employer = "CGI",
                    JobTitle = "Expert",
                    Management = "",
                    MissionDescription = "The mission was to develop a backend for a mobile application. This backend get the data from the mobile and store it in a Sharepoint list.",
                    Remarks = "This mission was really short, two days.",
                    TeamSize = "2 persons"
                }
                );

                dbContext.SaveChanges();
            }
        }
    }
}
