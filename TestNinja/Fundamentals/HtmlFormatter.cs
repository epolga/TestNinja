using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}
