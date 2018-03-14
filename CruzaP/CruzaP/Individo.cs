using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruzaP
{
    class Individo
    {
        Individo [] Cross1P(int [] f1,int [] m1,int crosspoint)
        {
            Individo[] hijo = new Individo[2];

            for (int i = 0; i < m1.Length ; i ++)
            {
                if (i <= crosspoint)
                {
                    hijo[0] = f1[i];

                }
                else
                {
                    hijo[0] = m1[i+1];
                }

            }
            


        }
    }
}
