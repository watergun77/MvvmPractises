using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControl.Practise2
{
    public class DateTab : Tab
    {
        public DateTab()
        {
            Name = DateTime.Now.ToString();
        }        
    }
}
