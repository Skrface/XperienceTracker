using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core.Model
{
    internal class Experience
    {
        /// <summary>
        /// TODO : move to class ?
        /// The title we had during the mission
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// The main description of the mission
        /// </summary>
        public string MissionDescription { get; set; }

        /// <summary>
        /// The company we worked for during the mission
        /// </summary>
        public string Employer { get; set; }

        /// <summary>
        /// The client who paid for the product
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// The languages we has to use during the mission
        /// </summary>
        public IEnumerable<LanguageCode> Languages { get; set; }

        /// <summary>
        /// The period we worked on this mission
        /// </summary>
        public Period Period { get; set; }

        /// <summary>
        /// The real time we spent on this mission
        /// </summary>
        public RealTimeOfWork RealTimeOfWork { get; set; }

        /// <summary>
        /// The technologies related to the code
        /// </summary>
        public IEnumerable<Technologie> CodeTechnologies { get; set; }

        /// <summary>
        /// The technologies related to the environment
        /// </summary>
        public IEnumerable<Technologie> EnvironmentTechnologies { get; set; }

        /// <summary>
        /// What was the number of person in the project team
        /// </summary>
        public string TeamSize { get; set; }

        /// <summary>
        /// What was the roles we had to play during this mission
        /// TODO : move to class ?
        /// </summary>
        public IEnumerable<string> Roles { get; set; }

        /// <summary>
        /// Some information about the people management
        /// </summary>
        public string Management { get; set; }

        /// <summary>
        /// Some additionnal information about the experience
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// The tags are used to find specific experiences by keywords
        /// </summary>
        public IEnumerable<Tag> Tags { get; set; }

        /// <summary>
        /// The references represents the persons to contact to verify the experience
        /// </summary>
        public IEnumerable<Reference> References { get; set; }
    }
}
