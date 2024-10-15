namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Property[] properties = new Property[10];
            properties[0] = new Appartment(3000000, 80);
            properties[1] = new Appartment(5000000, 150);
            properties[2] = new Appartment(7000000, 320);
            properties[3] = new Car(2000000, 1500);
            properties[4] = new Car(3000000, 2000);
            properties[5] = new Car(4000000, 2500);
            properties[6] = new Boat(400000, 2666);
            properties[7] = new Boat(800000, 3000);
            properties[8] = new CountryHouse(5000000, 350);
            properties[9] = new CountryHouse(6000000, 400);

            foreach (var property in properties)
            {
                Console.WriteLine(property.ToString());
            }
        }
    }
}
