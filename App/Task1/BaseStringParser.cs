using System.Collections.Generic;

namespace App.Task1
{
    public abstract class BaseStringParser : IStringParser
    {
        protected BaseStringParser(IOfficerBuilder officerBuilder)
        {
            OfficerBuilder = officerBuilder;
        }

        protected IOfficerBuilder OfficerBuilder { get; set; }
        public abstract List<Officer> Parse(string args);
    }
}