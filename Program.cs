using System;
using System.Collections.Generic;
namespace app
{
    interface Describable
    {
        public String Description();
    }
    abstract class RelatedAnimal : Describable
    {
        public string Name;
        public string Id;
        public abstract String Description();
    }
    class Dog : RelatedAnimal
    {
        public string Breed;
        public Dog(String name, String breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
        public override String Description()
        {
            return $"Name: {this.Name}, Breed: {this.Breed}";
        }
    }
    class Friend : RelatedAnimal
    {
        public string BirthDate;
        public string PhoneNumber;
        public Friend(string name, string BirthDate, string PhoneNumber)
        {
            this.Name = name;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.Id = Guid.NewGuid().ToString();
        }
        public override string Description()
        {
            return $"Name: {this.Name}, Phone Number: {this.PhoneNumber}, Birth Date: {this.BirthDate}";
        }
    }
    class Flight : Describable
    {
        public string FlightNumber;
        public string AircraftType;
        public Flight(string FlightNumber, string AircraftType)
        {
            this.FlightNumber = FlightNumber;
            this.AircraftType = AircraftType;
        }
        public String Description()
        {
            return $"Flight number: {this.FlightNumber}, Aircraft Type: {this.AircraftType}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var describables = new List<Describable>();
            describables.Add(new Friend("Linus", "01/01/1970", "707-419-4447"));
            describables.Add(new Friend("Scott", "10/10/1970", "801-224-7513"));
            describables.Add(new Friend("Charlie", "01/01/1999", "801-225-8597"));
            describables.Add(new Dog("Happy", "Border Collie"));
            describables.Add(new Flight("FL083", "Boeing 747"));
            foreach (var describable in describables)
            {
                Console.WriteLine(describable.Description());
            }
        }
    }
}
