using System;
namespace Exercises
{
    public class Exercise003
    {
        string[] icecreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };
        public string[] IceCreamFlavours => icecreamFlavours;

        public int IceCreamCode(string iceCreamFlavour) => Array.IndexOf(icecreamFlavours, iceCreamFlavour);
    }
}
