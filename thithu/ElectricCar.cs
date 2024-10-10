using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thithu
{
    internal class ElectricCar : Car
    {

 
     private int dungluongpin;
        public int Dungluongpin { get => dungluongpin; set => dungluongpin = value; }
       public ElectricCar() { }
        public ElectricCar (string hangxe,string biensoxe,string nsx,int gia,int dungluongpin): base (hangxe,biensoxe,nsx,gia)
        { 
            this.Dungluongpin= dungluongpin;
        }
    }

}
