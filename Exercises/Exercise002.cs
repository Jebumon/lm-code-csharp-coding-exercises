using Exercises.Models;
using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person ) => person != null && person.PersonLocation == "Manchester";


        public bool CanWatchFilm(Person person, int ageLimit) => person.PersonAge > ageLimit;
        
    }
}
