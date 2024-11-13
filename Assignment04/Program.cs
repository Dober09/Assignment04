

namespace Assignment04
{
    public class Program
    {

        public static void Main(string[] args)
        {

            //first animal

            Animal  Whale =  new Animal("Echo","Humpback Whale","Megaptera novaeangliae","Mammalia","female");

            Whale.Age = 10; 

            Whale.UpdateAge(Whale.Age);

            Whale.UpdatePhysicalMeasurements(4.5, 34);


            Console.WriteLine(Whale.GetBasicInfo());
            
            
            

            

            Console.WriteLine(Whale.GetAgeGroup());
            Console.WriteLine($"BMI : {Whale.CalculateBodyMassIndex()}");
            

            Console.WriteLine("****************\n****************");

            //second animal

            Animal person = new Animal("Lebohang","Human", "Homo sapiens,", "Mammalia","Male");

            person.Age = 39;
            person.UpdateAge(person.Age);
            person.UpdatePhysicalMeasurements(67.5, 150);

            
            Console.WriteLine(person.GetBasicInfo());
            Console.WriteLine(person.GetAgeGroup());
            Console.WriteLine($"BMI : {person.CalculateBodyMassIndex()}");




        }
    }
}