using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MOEAPlat.Encoding;

namespace MOEAPlat.Problems
{
    public class UF5 : AbstractMOP
    {
        private static UF5 instance;
        private UF5(int pd)
        {
            this.parDimension = pd;
            Init();
        }
        public override void Evaluate(MoChromosome chromosome)
        {
            double[] sp = chromosome.realGenes;
            double[] obj = chromosome.objectivesValue;

            for (int i = 0; i < this.parDimension; i++)
                sp[i] = domain[i, 0] + sp[i] * (domain[i, 1] - domain[i, 0]);

            int count1, count2;
            double sum1, sum2, yj, hj;
            sum1 = sum2 = 0.0;
            count1 = count2 = 0;

            int N_ = 10;
            double epsilon_ = 0.1;

            for (int j = 2; j <= this.parDimension; j++)
            {
                yj = sp[j - 1] - Math.Sin(6.0 * Math.PI * sp[0] + j * Math.PI / parDimension);
                hj = 2.0 * yj * yj - Math.Cos(4.0 * Math.PI * yj) + 1.0;
                if (j % 2 == 0)
                {
                    sum2 += hj;
                    count2++;
                }
                else
                {
                    sum1 += hj;
                    count1++;
                }
            }
            hj = (0.5 / N_ + epsilon_) * Math.Abs(Math.Sin(2.0 * N_ * Math.PI * sp[0]));

            obj[0] = sp[0] + hj + 2.0 * sum1 / (double)count1;
            obj[1] = 1.0 - sp[0] + hj + 2.0 * sum2 / (double)count2;

            for (int i = 0; i < this.parDimension; i++)
                sp[i] = (sp[i] - domain[i, 0]) / (domain[i, 1] - domain[i, 0]);
        }

        public override void Init()
        {
            this.domain = new double[this.parDimension, 2];
            domain[0, 0] = 0;
            domain[0, 1] = 1;
            for (int i = 1; i < parDimension; i++)
            {
                domain[i, 0] = -1;
                domain[i, 1] = 1;
            }
            this.objDimension = 2;
            this.range = new double[objDimension, 2];
        }

        public static UF5 GetInstance(int pd)
        {
            if (instance == null)
            {
                instance = new UF5(pd);
                instance.name = "UF5";
            }
            return instance;
        }
    }
}
