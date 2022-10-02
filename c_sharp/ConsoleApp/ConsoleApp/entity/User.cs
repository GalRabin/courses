using System;
using System.Diagnostics;

namespace ConsoleApp.entity
{
    class User
    {
        private string firstName;
        private string lastName;
        private string email;

        public User(string firstName, string lastName, string email)
        {
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }

        ~User()
        {
            Console.WriteLine("hello");
            Debug.WriteLine("Deconstruct");
        }
    }
}
