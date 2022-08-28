using Exercises.Models;
using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person )
        {
            if (person == null) return false;
            return person.PersonLocation == "Manchester";
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            bool ageLimitFlag = person.PersonAge > ageLimit;
            return ageLimitFlag;
        }
    }
}
