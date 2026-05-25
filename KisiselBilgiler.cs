using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankacılık_Uygulaması__asıl_hali_
{
    internal class KisiselBilgiler
    {
        private string ad="Tester";
        private string soyad="ttt";
        private double tcno=132445435666664;

        private bool bilgiler=false;
        public string Ad { get { return ad; }  } 
        public string Soyad { get { return soyad; }  }

        public double TCno { get { return tcno; } }
        public bool Bilgiler { get { return bilgiler; } set { bilgiler = value; } }

    }
}
