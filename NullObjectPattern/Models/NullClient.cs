using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern.Models
{
    public class NullClient : IClient
    {
        public int Id => 0;

        public string Name => "Non-client";

        public int Age => 0;
    }
}
