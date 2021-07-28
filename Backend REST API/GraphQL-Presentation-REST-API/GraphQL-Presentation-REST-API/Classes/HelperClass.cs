using System;
using System.Collections.Generic;

namespace GraphQL_Presentation_REST_API.Classes
{
    public static class HelperClass
    {
        private static List<string> names = new List<string>
        {
            "Aidan",        // 1
            "Nick",         // 2
            "Casey",        // 3
            "Rania",        // 4
            "Aditya",       // 5
            "Vedya",        // 6
            "Kaveri",       // 7
            "Luca",         // 8
            "Zach LePenn",  // 9
            "Megan",        // 10
            "Stephen",      // 11
            "Kevin"         // 12
        };

        private static List<int> ages = new List<int>
        {
            19, 21, 21, 19, 21, 19, 19, 19, 104, 21, 45, 14
        };

        private static List<string> abouts = new List<string>
        {
            "Back-end Developer",
            "Back-end Developer",
            "Back-end Developer",
            "Back-End Developer",
            "UX Designer",
            "UX Designer",
            "Front-end Developer",
            "Front-end Developer",
            "Front-end Developer",
            "Front-end Developer",
            "Back-end Developer & Project Manager",
            "Full-stack Developer",
        };

        private static List<List<string>> languagess = new List<List<string>>
        {
            new List<string>{ "C#", "C++", "JavaScript", "Java"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
            new List<string>{ "C#", "C++"},
        };

        private static List<List<string>> projectss = new List<List<string>>
        {
            new List<string> { "Scorecard", "GraphQL Layer", "GraphQL Presentation" },
            new List<string> { "Scorecard", "Parking" },
            new List<string> { "Scorecard", "Parking", "AWS S3 Pulling" },
            new List<string> { "Scorecard", "Parking" },
            new List<string> { "Scorecard", "Parking", "User Experience" },
            new List<string> { "Scorecard", "Parking", "User Experience" },
            new List<string> { "Scorecard", "Parking" },
            new List<string> { "Scorecard", "Parking" },
            new List<string> { "Scorecard", "Parking", "Scorecard Front-end" },
            new List<string> { "Scorecard", "Parking", "Collisions Page" },
            new List<string> { "Scorecard", "Parking", "Project Mangagment" },
            new List<string> { "Scorecard", "Parking", "GraphQL Handling" },
        };

        private static List<int> pingPongGames = new List<int>
        {
            0, 99, 4, 8, 5, 3, 6, 14, -4, 35, 999, 2
        };

        public static List<Intern> GetInterns()
        {
            List<Intern> temp = new List<Intern>();

            for(int i = 0; i < names.Count; i++)
            {
                Intern t = new Intern
                {
                    id = i,
                    name = names[i],
                    age = ages[i],
                    about = abouts[i],
                    languages = languagess[i],
                    projects = projectss[i],
                    numberOfPingPongGamesPlayed = pingPongGames[i]
                };

                temp.Add(t);
            }

            return temp;
        }
    }
}
