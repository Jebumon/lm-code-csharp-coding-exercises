using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (word == null || word == "")
            {
                return word;
            }
            else
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (vatRate < 0)
            {
                 return 0;

            }
            else if (originalPrice < 0)
            {
                return 0;
            }
            else if (vatRate == 20 || vatRate == 0)
            {
                return originalPrice + vatRate;
            }
            else
            {
                var vatPrice = originalPrice + originalPrice * vatRate / 100;
                vatPrice = (double)Math.Round((Decimal)vatPrice, 2, MidpointRounding.AwayFromZero);
                return vatPrice;
            }
        }

        public string Reverse(string sentence)
        {
            if (sentence == null || sentence == "")
            {
                return sentence;
            }
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int CountLinuxUsers(List<User> users)
        {
            int count = 0;
            int userCount;
            if (users == null || users.Count == 0)
            {
                userCount = 0;
                return userCount;
            }
            foreach (var user in users)
            {
                if (user.Type.Contains("Linux"))
                {
                    count++;
                }
            }
            return count;

        }
    }
}
