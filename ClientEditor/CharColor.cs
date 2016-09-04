using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientEditor
{
    public class CharColor
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public int Unknown02 { get; set; }
        public int Unknown03 { get; set; }
        public int Unknown04 { get; set; }



        public CharColor(int ID, string color, int unknown02, int unknown03, int unknown04)
        {
            this.ID = ID;
            this.Color = color;
            this.Unknown02 = unknown02;
            this.Unknown03 = unknown03;
            this.Unknown04 = unknown04;
        }
    }
}
