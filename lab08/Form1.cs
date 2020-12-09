using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab08
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            fCar ft = new fCar(car); 

            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbCarInfo.Text += string.Format("Марка: {0}. Модель: {1}. Тип кузову {2}. Об'єм двигуна {3:0.0}. Ціна: {4} грн. Країна виробник: {5}. {6}\r\n",

                    car.MarkaCar, car.ModelCar, car.BodyTipe, car.EngineСapacity, car.Price, car.ManufacturerCountry,car.Electro ? "Це електромобіль" : "Це не електромобіль") ;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            Application.Exit();
        }
    }
}
