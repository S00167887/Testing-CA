using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fit.Fixtures;

namespace PremiumLibrary
{
    public class PremiumTest : ColumnFixture
    {
        public string gender;
        public int age;
        public float premium;
        public Premium p = new Premium();

        public float CalcPremium()
        {
            p.setProperties(gender, age);
            premium = p.CalcPremium();
            return premium;
        }
    }
    public class Premium
    {
        private string gender;
        private int age;
        private float premium;

        public void setProperties(string gen, int a)
        {
            gender = gen;
            age = a;
        }

        public float CalcPremium()
        {

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = 5.0f;
                else
                    if (age >= 31)
                    premium = 3.50f;
                else
                    premium = 0.0f;
            }
            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0f;
                else
                     if (age >= 36)
                    premium = 5.0f;
                else
                    premium = 0.0f;
            }
            else
                premium = 0.0f;

            if (age >= 50)
                premium = premium * 0.5f;
            return premium;
        }
    }
}
