using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    class BirthdayParty : Party
    {
        private String cakeWriting;
        public String CakeWriting
        {
            get
            {
                return cakeWriting;
            }
            set
            {
                int maxLength;
                if(NumberOfPeople <= 4)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (maxLength < value.Length)
                {
                    MessageBox.Show("글자가 많습니다.");
                    cakeWriting = value.Substring(0, maxLength);
                }
                else
                    cakeWriting = value;
            }
        }
       
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, String cakeWriting) : base (numberOfPeople, fancyDecorations)
        {
            CakeWriting = cakeWriting;   
        }

        public override decimal CalculateCost()
        {
            decimal total = base.CalculateCost();
            if(NumberOfPeople <= 4)
                total += 40M + (cakeWriting.Length * 0.25M);
            else
                total += 75M + (cakeWriting.Length * 0.25M);
            return total;
        }
    }
}
