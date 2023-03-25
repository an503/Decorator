using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lamp_decorator;

namespace lamp_decorator
{
    public partial class Form1 : Form
    {
        private IncandescentLamp lamp1;

        public Form1() => InitializeComponent();

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lamp1 = new IncandescentLamp();
            lamp1 = new IncandescentLamp(lamp1); // лампа розжарювання
            MessageBox.Show("Назва: " + lamp1.Name);
            MessageBox.Show("Вартість: "+ lamp1.GetCost());

            Lamp lamp2 = new HalogenLamp();
            lamp2 = new HalogenLamp(lamp2);// галогенна лампа
            MessageBox.Show("Назва: " + lamp2.Name);
            MessageBox.Show("Вартість: " + lamp2.GetCost());

            Lamp lamp3 = new LedLamp();
            lamp3 = new EfectLamp(lamp3);
            lamp3 = new IndexLamp(lamp3);// світлодіодна лампа
            MessageBox.Show("Назва: " + lamp3.Name);
            MessageBox.Show("Вартість: " + lamp3.GetCost());

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
