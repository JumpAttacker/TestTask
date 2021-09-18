using System.Collections.Generic;

namespace App.Task1
{
    public interface IStringParser
    {
        public List<Officer> Parse(string args);
    }
}