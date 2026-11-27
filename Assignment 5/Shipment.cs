using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal struct Shipment
    {
        private string _trackingCode;
        private string _description;
        private int _weight;
        private decimal _deliveryFee;
        public DeliveryAddress Destination { get; set; }
        public string TrackingCode
        { 
            get { return _trackingCode; }
            private set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value>0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }
        public Shipment(string trackingCode,string description,int weight,decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"The TrackingCode is {TrackingCode}\n" +
                $"The Description is {Description} \n" +
                $"The Weight is {Weight} \n" +
                $"The DeliveryFee is {DeliveryFee} \n" +
                $"The EstimatedCost is {EstimatedCost} \n" +
                $"The Destination is : \n" +
                $"The city is {Destination.City}\n" +
                $"The addreess is {Destination.Address}\n" +
                $"The building number is {Destination.BuildingNumber}");
        }

        



    }
}
