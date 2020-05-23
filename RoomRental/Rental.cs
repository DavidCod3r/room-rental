using System;
using System.Collections.Generic;
using System.Text;

namespace RoomRental
{
    class Rental
    {
        public string Name { get; private set; }
        public string  Email { get; private set; }

        public Rental(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
