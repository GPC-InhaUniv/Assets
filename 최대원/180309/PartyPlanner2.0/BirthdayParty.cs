using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2._0
{
    class BirthdayParty : Party
    {
        public int CakeSize;

        public int MaxLangth;
        private string cakeWriting = "";
        public string CakeWriting
        {
            get { return cakeWriting; }
            set
            {
                int maxLangth;

                if (CakeSize == 8) maxLangth = 16;
                else maxLangth = 40;

                if (value.Length > maxLangth)
                {
                    MessageBox.Show("입력 가능한 글자 수를 초과하였습니다.");
                    //if (maxLangth > cakeWriting.Length) { maxLangth = cakeWriting.Length; }
                    cakeWriting = value.Substring(0, maxLangth);
                }
                else cakeWriting = value;
                MaxLangth = maxLangth;
            }
        }

        public BirthdayParty(int numberOfPeople, bool decoUpgrade, string cakeWrite)
        {
            NumberOfPeople = numberOfPeople;
            CalculateCostDeco(decoUpgrade);
            CalculateCakeSize();
            CakeWriting = cakeWrite;
            CalculateCost();
        }

        public override decimal CalculateCost()
        {
            decimal TotalCost = CostofDeco + (CostOfFoodPerPeople * NumberOfPeople);
            decimal Cakecost;
            if (CakeSize == 8) { Cakecost = 40M + (CakeWriting.Length * .25M); }
            else { Cakecost = 70M + (CakeWriting.Length * .25M); }
            return TotalCost + Cakecost;
        }

        public void CalculateCakeSize()
        {
            if (NumberOfPeople < 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;
            }
        }

        public override decimal CalculateCost(bool NonAlcoholable)
        {
            return 0M;
        }
    }
}
