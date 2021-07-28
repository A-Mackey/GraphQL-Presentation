using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GraphQL_Presentation_REST_API.Classes
{
    public class Intern
    {
        public int id;
        public string name;
        public int age;
        public string about;
        public List<string> languages;
        public List<string> projects;
        public int numberOfPingPongGamesPlayed;

        public Intern()
        {
            languages = new List<string>();
        }
    }
}
