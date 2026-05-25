using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankacılık_Uygulaması__asıl_hali_
{
    internal class HesapBilgileri
    {
        private double hesapToplamı = 1500000;

        public double HesapToplamı
        {
            get { return hesapToplamı; }
            set
            {
                if (value <= hesapToplamı && value >= 0)
                    hesapToplamı = value;
            }
        }

    }
}
