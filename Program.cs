using System;
using System.Collections.Generic;
using System.Linq;
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
        public DateTime BirthDate;
        public string PhoneNumber;
        public Friend(string name, string BirthDate, string PhoneNumber)
        {
            this.Name = name;
            this.BirthDate = DateTime.Parse(BirthDate);
            this.PhoneNumber = PhoneNumber;
            this.Id = Guid.NewGuid().ToString();
        }
        public Friend(string name, DateTime BirthDate, string PhoneNumber)
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
            var friends = new List<Friend>{
                new Friend("Linus", "01/01/1970", "707-419-4447"),
                new Friend("Scott", "10/10/1970", "801-224-7513"),
                new Friend("Charlie", DateTime.Parse("01/01/1999"), "801-225-8597")
            };
            var describables = new List<Describable>();
            describables.AddRange(friends);
            describables.Add(new Dog("Happy", "Border Collie"));
            describables.Add(new Flight("FL083", "Boeing 747"));
            foreach (var describable in describables)
            {
                Console.WriteLine(describable.Description());
            }
            // get all friends younger than 50.
            var now = DateTime.Now;
            var youngFriendsQuery =
            from friend in friends
            where (friend.BirthDate > now.AddYears(-50))
            select friend;
            foreach (var youngFriend in youngFriendsQuery)
            {
                Console.WriteLine(youngFriend.Description());
            }
        }
    }
}