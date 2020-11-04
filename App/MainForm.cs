using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //текстовое поле покупки долларов
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_USD_BUY_SUM.Text, out double result))
            {
                textBox_USD_RUB.Text = GetRubAmount(textbox_USD_SELL_RATE.Text, textbox_USD_BUY_RATE.Text, textBox_USD_SELL_SUM, textBox_USD_BUY_SUM,
                textBox_USD_SALE);
            }
        }

        //текстовое поле продажи долларов
        private void textBox_USD_SELL_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_USD_SELL_SUM.Text, out double result))
            {
                textBox_USD_RUB.Text = GetRubAmount(textbox_USD_SELL_RATE.Text, textbox_USD_BUY_RATE.Text, textBox_USD_SELL_SUM, textBox_USD_BUY_SUM, 
                    textBox_USD_SALE);
            }
        }

        //расчет итогового изменения национальной валюты
        private string GetRubAmount(string sellRate, string buyRate, TextBox sell, TextBox buy, TextBox sale)
        {
            double sellSum = double.Parse(sell.Text) * double.Parse(sellRate) - double.Parse(sale.Text);
            double buySum = double.Parse(buy.Text) * double.Parse(buyRate);

            if (sellSum < 0)
            {
                sellSum = 0;
            }

            return $"{sellSum - buySum}";
        }

        private void textBox_USD_SALE_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_USD_SALE.Text, out double result))
            {
                textBox_USD_RUB.Text = GetRubAmount(textbox_USD_SELL_RATE.Text, textbox_USD_BUY_RATE.Text, textBox_USD_SELL_SUM, textBox_USD_BUY_SUM,
                    textBox_USD_SALE);
            }
        }
    }
}
