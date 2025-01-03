using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsrRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Thank for you Renting:\n{tbCustomerName.Text}");//submit 增加語言
            //MessageBox.Show($"Thank for you Renting:\n{tbCustomerName.Text}");//submit 增加語言

            string customerName =tbCustomerName.Text;
            var dateOut=dtRented.Value;
            var dateIn=dtReturned.Value;
            double cost=Convert.ToDouble(tbCost.Text);
            var carType = cbTypeOfCar.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(customerName)||string.IsNullOrWhiteSpace(carType))
            {
                MessageBox.Show("Please enter missing data.");
            }
            if (dateOut > dateIn)
            {
                MessageBox.Show("時間錯誤");

            }
            MessageBox.Show($"Customer Name:{customerName}\n\r"+
                $"Date Rented:{dateOut}\n\r"+ $"Date Returned:{dateIn}\n\r"+
                $"Car Type:{carType}\n\r"
                +$"THANKS  FOR YOUR BUSINESS");

        }
       


private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
