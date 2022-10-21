using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesCRDModelGen.Sync
{
    internal class Config
    {
        public string Group { get; set; }

        public List<string> Urls { get; set; }

        public string HelmRepo { get; set; }

        public string HelmChart { get; set; }

        public bool PreRelease { get; set; }
    }
}
