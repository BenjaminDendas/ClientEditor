using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientEditor
{
    public class Dialogue : AkEditor
    {
        public string Unknown1 { get; set; }
        public string Unknown2 { get; set; }

        public Dialogue(string u1, string u2)
        {
            this.Unknown1 = u1;
            this.Unknown2 = u2;
        }
    }
}
