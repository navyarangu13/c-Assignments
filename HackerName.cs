// HackerName.cs
using System;

namespace myproject
{
    public class HackerName
    {
        public string Color { get; set; }
        public string Sign { get; set; }
        public string AddressNumber { get; set; }

        public HackerName(string color, string sign, string addressNumber)
        {
            Color = color;
            Sign = sign;
            AddressNumber = addressNumber;
        }

        public string GenerateHackerName()
        {
            return $"{Color}{Sign}{AddressNumber}";
        }
    }
}
