using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{

    public class Person
    {
        public Person(string personName, string personJob, string personLocation, int personAge)
        {
            PersonName = personName;
            PersonJob = personJob;
            PersonLocation = personLocation;
            PersonAge = personAge;
        }

        public string PersonName { get; set; }
        public string PersonJob { get; set; }
        public string PersonLocation { get; set; }
        public int PersonAge { get; set; }
    }
}
