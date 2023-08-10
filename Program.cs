using System;
using System.Collections.Generic;
namespace app
{
    abstract class RelatedAnimal
    {
        public string Name;
        public string Id;
    }
    class Dog : RelatedAnimal
    {
        public string Breed;
        public Dog(String name, String breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
        public override String ToString()
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
        public override String ToString()
        {
            return $"Name: {this.Name}, Phone Number: {this.PhoneNumber}, Birth Date: {this.BirthDate}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<Friend>();
            friends.Add(new Friend("Linus", "01/01/1970", "707-419-4447"));
            friends.Add(new Friend("Scott", "10/10/1970", "801-224-7513"));
            friends.Add(new Friend("Charlie", "01/01/1999", "801-225-8597"));
            var dog = new Dog("Happy", "Border Collie");
            Console.WriteLine(dog.ToString());
            foreach (var friend in friends)
            {
                Console.WriteLine(friend.ToString());
            }
        }
    }
}
