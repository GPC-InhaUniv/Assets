using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown
{
    class Funnyfunny : IClown
    {
        public Funnyfunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        protected string funnyThingIHave;
        public string FunnyThingIHave
        {
            get
            {
               return "Honk honk! I have a " + funnyThingIHave;
            }
        }

        public void Honk()
        {
            MessageBox.Show(FunnyThingIHave);
        }
    }
}
