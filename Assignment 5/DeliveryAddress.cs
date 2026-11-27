using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Address;
        public int BuildingNumber;
        
        public DeliveryAddress()
        {
        }
        public string GetFullAddress()
        {
            return $"The City is {City} , The Address is {Address} and The building number is {BuildingNumber}";
        }

    }
}
