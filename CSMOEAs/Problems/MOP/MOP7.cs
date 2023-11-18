﻿using MOEAPlat.Encoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOEAPlat.Problems
{
    public class MOP7 : AbstractMOP
    {
        private static MOP7 instance;

        private MOP7()
        {
            this.parDimension = 10;
            Init();
        }

        public override void Evaluate(MoChromosome chromosome)
        {
            double[] sp = chromosome.realGenes;
            double[] obj = chromosome.objectivesValue;

            for (int i = 0; i < this.parDimension; i++)
                sp[i] = domain[i, 0] + sp[i] * (domain[i, 1] - domain[i, 0]);

            // objection function

            double g = 0, ti = 0;
            for (int j = 3; j <= parDimension; j++)
            {
                ti = sp[j - 1] - sp[0] * sp[1];
                g += -0.9 * ti * ti + Math.Pow(Math.Abs(ti), 0.6);
            }
            g = 2 * Math.Sin(Math.PI * sp[0]) * g;

            obj[0] = (1 + g) * Math.Cos(sp[0] * Math.PI / 2) * Math.Cos(sp[1] * Math.PI / 2);
            obj[1] = (1 + g) * Math.Cos(sp[0] * Math.PI / 2) * Math.Sin(sp[1] * Math.PI / 2);
            obj[2] = (1 + g) * Math.Sin(sp[0] * Math.PI / 2);

            //

            for (int i = 0; i < this.parDimension; i++)
                sp[i] = (sp[i] - domain[i, 0]) / (domain[i, 1] - domain[i, 0]);
        }

        public override void Init()
        {
            this.domain = new double[this.parDimension, 2];
            for (int i = 0; i < parDimension; i++)
            {
                domain[i, 0] = 0;
                domain[i, 1] = 1;
            }
            this.objDimension = 3;
            this.range = new double[objDimension, 2];
        }

        public static MOP7 GetInstance()
        {
            if (instance == null)
            {
                instance = new MOP7();
                instance.name = "MOP7";
            }
            return instance;
        }
    }
}
