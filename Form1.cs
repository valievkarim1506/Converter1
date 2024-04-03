using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace конвертер_валют
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (textBoxFrom.Text == "")
            {
                MessageBox.Show("Введите сумму денег");
            }
            else
            {

                double usd = 0.0, rub = 0.0, byn = 0.0, gbp = 0.0, from;
                from = Double.Parse(textBoxFrom.Text);

                string operatorFrom = comboBoxFrom.Text;
                string operatorTo = comboBoxTo.Text;

                switch (operatorFrom)
                {
                    case "USD":
                        rub = 92.52;
                        byn = 3.26;
                        gbp = 0.791;
                        usd = 1.0;
                        break;
                    case "RUB":
                        rub = 1.0;
                        byn = 0.035;
                        gbp = 0.0085;
                        usd = 0.0108;
                        break;
                    case "BYN":
                        rub = 28.41;
                        byn = 1.0;
                        gbp = 0.243;
                        usd = 0.307;
                        break;
                    case "GBP":
                        rub = 116.88;
                        byn = 4.11;
                        gbp = 1.0;
                        usd = 1.26;
                        break;
                }

                switch (operatorTo)
                {
                    case "USD":
                        textBoxTo.Text = Convert.ToString(from * usd);
                        break;
                    case "RUB":
                        textBoxTo.Text = Convert.ToString(from * rub);
                        break;
                    case "BYN":
                        textBoxTo.Text = Convert.ToString(from * byn);
                        break;
                    case "GBP":
                        textBoxTo.Text = Convert.ToString(from * gbp);
                        break;
                }
            }

        }
    }
}
