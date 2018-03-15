using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown
{
    class Scaryscary : Funnyfunny, IScaryClown
    {
        public string ScaryThingIHave { get => "나는 거미" + numberOfScaryThings +  "마리가 있다";}

        private int numberOfScaryThings;
        public int NumberOfScaryThings { get => numberOfScaryThings; set => numberOfScaryThings = value; }

        public Scaryscary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public void ScareLittleChilren()
        {
            MessageBox.Show("Boo! GotCha! You can't have my " + ScaryThingIHave);
        }
    }
}
