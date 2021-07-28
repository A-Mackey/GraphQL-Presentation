using System;
using System.Collections.Generic;

namespace GraphQL_Presentation_REST_API.Classes
{
    /// <summary>
    /// Wrapper class for a collection of interns
    /// </summary>
    public class InternsHolderClass
    {
        public List<Intern> interns;

        public InternsHolderClass()
        {
            interns = new List<Intern>();
        }
    }
}
