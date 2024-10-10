using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thithu
{
    internal class Car
    {
        private string hangxe;
        private string bienso;
        private string nsx;
        private int gia;

        
        
        public string Hangxe { get => hangxe; set => hangxe = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public string Nsx { get => nsx; set => nsx = value; }
        public int Gia { get => gia; set => gia = value; }

        public Car() { }
        public Car(string hangxe, string bienso, string nsx, int gia)
        {
            this.Hangxe = hangxe;
            this.Bienso = bienso;
              this.Nsx = nsx;
            this.Gia = gia;
        }
    }
}
