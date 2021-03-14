using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern.Models
{
    public class Client : IClient
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}
