using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace thithu
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }
        List<Car> LCar = new List<Car>();





        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_xoa_Click(object sender, EventArgs e)
        {
            foreach (Car i in LCar)
            {
                if (i.Hangxe == txt_hangxe.Text)
                {
                    LCar.Remove(i);
                }
                break;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LCar;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Car car = new Car(txt_hangxe.Text, txt_bienso.Text, txt_nsx.Text, Int32.Parse(txt_gia.Text));
            LCar.Add(car);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LCar;
        }
        List<ElectricCar> L_ECar = new List<ElectricCar>();
        private void btn_them2_Click(object sender, EventArgs e)
        {
            ElectricCar ECar = new ElectricCar(txt_hangxedien.Text, txt_biensoxedien.Text, txt_nsxxedien.Text, Int32.Parse(txt_giaxedien.Text), Int32.Parse(txt_pin.Text));
            L_ECar.Add(ECar);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ECar;
        }

        private void btn_sua2_Click(object sender, EventArgs e)
        {
            foreach (ElectricCar i in L_ECar)
            {
                if (txt_hangxedien.Text == i.Hangxe)
                {
                    i.Nsx = txt_nsxxedien.Text;
                    i.Gia = Int32.Parse(txt_giaxedien.Text);
                    i.Bienso = txt_biensoxedien.Text;
                    i.Dungluongpin = Int32.Parse(txt_pin.Text);
                }
            }
        }

        private void btn_xoa2_Click(object sender, EventArgs e)
        {
            foreach (ElectricCar i in L_ECar)
            {
                if (i.Hangxe == txt_hangxedien.Text)
                {
                    L_ECar.Remove(i);
                }
                break;
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = L_ECar;
        }
    }
}
