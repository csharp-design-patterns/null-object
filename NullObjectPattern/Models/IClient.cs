using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern.Models
{
    public interface IClient
    {
        int Id { get; }

        string Name { get; }

        int Age { get; }
    }
}
