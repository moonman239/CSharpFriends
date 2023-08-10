using System;
using System.Collections.Generic;
namespace app
{
    class Friend
    {
        public string Name;
        public string Id;
        public string BirthDate;
        public string PhoneNumber;
        public Friend(string name, string BirthDate, string PhoneNumber)
        {
            this.Name = name;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.Id = Guid.NewGuid().ToString();
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
            foreach (var friend in friends)
            {
                Console.WriteLine(friend.Name);
                Console.WriteLine(friend.BirthDate);
                Console.WriteLine(friend.PhoneNumber);
            }
        }
    }
}
