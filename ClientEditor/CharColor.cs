using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientEditor
{
    public class CharColor : AkEditor
    {
        public string ID { get; set; }
        public string Color { get; set; }
        public string Unknown02 { get; set; }
        public string Unknown03 { get; set; }
        public string Unknown04 { get; set; }



        public CharColor(string ID, string color, string unknown02, string unknown03, string unknown04)
        {
            this.ID = ID;
            this.Color = color;
            this.Unknown02 = unknown02;
            this.Unknown03 = unknown03;
            this.Unknown04 = unknown04;
        }
    }
}
