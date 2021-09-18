using System.Collections.Generic;
using System.Linq;

namespace App.Task1
{
    public class ReferenceManager : IReferenceManager
    {
        public ReferenceManager(IStringParser stringParser)
        {
            StringParser = stringParser;
        }

        public IStringParser StringParser { get; set; }

        public List<int> FindPath(string input)
        {
            var result = StringParser.Parse(input);
            return result.Select(z => z.Id).ToList();
        }
    }
}