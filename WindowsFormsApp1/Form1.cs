using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCelsius_Click(object sender, EventArgs e)
        {
            float Celsius = float.Parse(txtCelsius.Text);
            float Farenheit = (Celsius * 9 / 5f) + 32;
            txtFarenheit.Text = Farenheit.ToString();
        }

        private void BtnFarenheit_Click(object sender, EventArgs e)
        {
            float Farenheit = float.Parse(txtFarenheit.Text);
            float Celsius = (Farenheit - 32) * 5f / 9;
            txtCelsius.Text = Celsius.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtFarenheit.Text = "0.0";
            txtCelsius.Text = "0.0";
            MessageBox.Show("Reset de valores");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }
    }
}
