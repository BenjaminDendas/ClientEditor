using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientEditor
{
    public class EditorNotFoundException : ApplicationException
    {
        public EditorNotFoundException(string message):base(message)
        {
            
        }
    }
}
