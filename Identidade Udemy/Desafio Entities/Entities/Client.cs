using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Desafio_Entities.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
        }
    }
}
