using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagExplorer.Core.Common
{
    public class EnvironmentVariable
    {
        public string? Prod { get; set; }
        public string? Staging { get; set; }
        public string? Dev { get; set; }
    }
}
