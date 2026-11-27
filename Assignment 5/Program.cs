namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            #region q1
            //a) it modifies only its copy but the first object isnot modified becuse it copies the value
            //b) it modifies both bqecuse it copies the address 
            #endregion
            #region q2
            //a) Public fields expose internal data, no validation, and poor maintainability
            //b)Use private fields with public properties to control access, validate values, and preserve encapsulation
            #endregion
            #endregion
            #region Practical Questions
            #region q1
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the shipment {i+1} data");

                Console.Write("Traching Code :");
                string trackingCode = Console.ReadLine();
                Console.Write("Discription :");
                string discription = Console.ReadLine();
                Console.Write("Weight :");
                int weight =int.Parse(Console.ReadLine());
                Console.Write("Delivery Fee :");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                DeliveryAddress deliveryAddress = new DeliveryAddress();
                Console.Write("City:");
                deliveryAddress.City = Console.ReadLine();
                Console.Write("Address: ");
                deliveryAddress.Address = Console.ReadLine();
                Console.Write("Building Number: ");
                deliveryAddress.BuildingNumber =int.Parse(Console.ReadLine());

                Shipment shipment = new Shipment(trackingCode, discription, weight, deliveryFee, deliveryAddress);
                Console.WriteLine("shipment added succseefully");
                Console.WriteLine("========================================");

                bool isAdded =deliveryCenter.AddShipment(shipment);
                if (isAdded==false)
                {
                    Console.WriteLine("The Delivery center is full");
                }
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"The shipment number {i+1}");
                deliveryCenter[i].PrintShipment();
                Console.WriteLine("========================================");
            }

            Console.Write("Enter a tracking code to search:");
            string inputTrackingCode = Console.ReadLine();
            Shipment searchedShipment = deliveryCenter[inputTrackingCode];

            if(searchedShipment.TrackingCode== null)
            {
                Console.WriteLine("shipment is not found");
            }
            else
            {
                Console.Write("shipment is found : " + searchedShipment.TrackingCode + " - " + searchedShipment.Description);
            }
            #endregion

            #region q2
            Console.WriteLine("Struct copy test");
            DeliveryAddress deliveryAddress1 = new DeliveryAddress();
            deliveryAddress1.Address = "15 tahrir street";
            deliveryAddress1.City = "Cairo";
            Console.WriteLine(deliveryAddress1.Address +", " + deliveryAddress1.City);
            DeliveryAddress deliveryAddress2 = deliveryAddress1;
            deliveryAddress2.Address = "20 Makram Ebied street";
            Console.WriteLine(deliveryAddress2.Address + ", " + deliveryAddress2.City);
            #endregion


            #endregion
        }
    }
}
