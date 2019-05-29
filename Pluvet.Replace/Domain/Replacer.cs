using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluvet.Replace.Domain
{
    class Replacer
    {
        public static string Do(string content, IEnumerable<string> rules, IEnumerable<string> replacement)
        {
            var i = 0;
            foreach (var rule in rules)
            {
                content = Regex.Replace(content, rule, replacement.ElementAt(i));
                    ++i;
            }
            return content;
        }

    }
}
