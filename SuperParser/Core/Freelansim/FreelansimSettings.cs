using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperParser.Core.Freelansim
{
    class FreelansimSettings : IParserSettings
    {
        public FreelansimSettings(int start,int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://freelansim.ru/tasks?";
        public string Prefix { get; set; } = "page={CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
