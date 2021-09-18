using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace App.Task1
{
    public class Parser : BaseStringParser
    {
        private const string Pattern = @"\{\s?(\d)\s?\,\s?(\[\s?(\s?\d\s?\,?){1,}\s?\])\s?\}";

        public override List<Officer> Parse(string input)
        {
            const RegexOptions options = RegexOptions.None;
            foreach (Match m in Regex.Matches(input, Pattern, options))
            {
                var officerId = int.Parse(m.Groups[1].Value);
                var child = m.Groups[2].Value.Trim('[', ']').Split(',').Select(int.Parse).ToList();
                OfficerBuilder.AddOfficer(officerId, 0);
                foreach (var childId in child)
                {
                    OfficerBuilder.AddOfficer(childId, officerId);
                }
            }

            return OfficerBuilder.Build();
        }

        public Parser(IOfficerBuilder officerBuilder) : base(officerBuilder)
        {
        }
    }
}