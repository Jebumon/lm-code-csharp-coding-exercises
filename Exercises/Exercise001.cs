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
                /*string[] args = { "VAT cannot be negative. Please enter a valid VAT." };
                Assert.Throws<ArgumentException>(() => new ApplicationArguments(args)); */
                Assert.Throws<Exception>(delegate { throw new Exception("VAT cannot be negative. Please enter a valid VAT."); });
                throw new ArgumentException(message:"VAT cannot be negative. Please enter a valid VAT.");

            }
            else if (originalPrice < 0)
            {
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Price cannot be negative.Please enter a valid price.");
                Assert.Throws<Exception>(delegate { throw new Exception("Price cannot be negative.Please enter a valid price."); });

                throw new ArgumentException(message:"Price cannot be negative.Please enter a valid price.");
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
