using System;
using System.Collections.Generic;
using Exercises.Models;
using NUnit.Framework;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (word != null && word != "")
            {
                return char.ToUpper(word[0]) + word.Substring(1);
                
            }
            return word;
        }

        public string GenerateInitials(string firstName, string lastName) => firstName[0] + "." + lastName[0];
        

        public double AddVat(double originalPrice, double vatRate)
        {
            
            if (vatRate < 0)
            {
               throw new ArgumentException(message: "VAT cannot be negative. Please enter a valid VAT.");
            }
            else if (originalPrice < 0)
            {
                throw new ArgumentException(message: "Price cannot be negative. Please enter a valid price.");
            }
            else if (vatRate < 20 && vatRate > 0)
            {
                var vatPrice = originalPrice + (originalPrice * vatRate / 100);
                return  (double)Math.Round((Decimal)vatPrice, 2, MidpointRounding.AwayFromZero); 
            }
            return (originalPrice + vatRate);
        }

        public string Reverse(string sentence)
        {
            if (sentence != null && sentence != "")
            {
                char[] charArray = sentence.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            return sentence;
        }
        public int CountLinuxUsers(List<User> users)
        {
            int linuxUserCount = 0;
            if (users != null && users.Count > 0)
            {

                foreach (var user in users)
                {
                    if (user.Type.Contains("Linux"))
                    {
                        linuxUserCount++;
                    }
                }
            }
            return linuxUserCount;

        }
    }
}
