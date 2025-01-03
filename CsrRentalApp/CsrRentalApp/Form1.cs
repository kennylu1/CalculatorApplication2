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
            string dateOut=dtRented.Value.ToString();
            string dateIn=dtReturned.Value.ToString();
            var carType = cbTypeOfCar.SelectedItem.ToString();

            MessageBox.Show($"Customer Name:{customerName}\n\r"+
                $"Date Rented:{dateOut}\n\r"+ $"Date Returned:{dateIn}\n\r"+
                $"Car Type:{carType}\n\r"
                +$"THANKS YOU FOR YOUR BUSINESS");

        }
       


private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
