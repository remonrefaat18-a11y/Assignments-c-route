using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal struct DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[10];
        public Shipment this[int index]
        {
            get
            {
                if (index >= shipments.Length || index < 0)
                {
                    return default;
                }
                else { return shipments[index]; }
            }
            set
            {
                if (index >= shipments.Length || index < 0)
                {
                    return;
                }
                else { shipments[index] = value; }
            }

        }

        public Shipment this[string trachingCode]
        {
            get
            {
                Shipment shipment = new Shipment();
                for (int i=0;i< shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode==trachingCode)
                    {
                        shipment = shipments[i];
                        break;
                    }
                }
                if(shipment.TrackingCode is null)
                {
                    return default;
                }
                else
                {
                    return shipment;
                }
            }
        }

        public DeliveryCenter()
        {
        }

        int i = 0;
        public bool AddShipment(Shipment shipment)
        {
            if (i == 10)
            {
                return false;
            }
            else
            {
                shipments[i] = shipment;
                i++;
                return true;
            }
            
            

        }

    }
}
