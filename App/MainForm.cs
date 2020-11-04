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
            ReloadAllValues();
        }

        private void ReloadAllValues()
        {
            ReloadUSD();
        }

        private void ReloadUSD()
        {
            DB database = new DB();
            DataTable select = DB.

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

        private void textBox_USD_SALE_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_USD_SALE.Text, out double result))
            {
                textBox_USD_RUB.Text = GetRubAmount(textbox_USD_SELL_RATE.Text, textbox_USD_BUY_RATE.Text, textBox_USD_SELL_SUM, textBox_USD_BUY_SUM,
                    textBox_USD_SALE);
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_EUR_BUY_SUM.Text, out double result))
            {
                textBox_EUR_RUB.Text = GetRubAmount(textbox_EUR_SELL_RATE.Text, textbox_EUR_BUY_RATE.Text, textBox_EUR_SELL_SUM, textBox_EUR_BUY_SUM,
                    textBox_EUR_SALE);
            }
        }

        private void textBox_EUR_SELL_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_EUR_SELL_SUM.Text, out double result))
            {
                textBox_EUR_RUB.Text = GetRubAmount(textbox_EUR_SELL_RATE.Text, textbox_EUR_BUY_RATE.Text, textBox_EUR_SELL_SUM, textBox_EUR_BUY_SUM,
                    textBox_EUR_SALE);
            }
        }

        private void textBox_EUR_SALE_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_EUR_SALE.Text, out double result))
            {
                textBox_EUR_RUB.Text = GetRubAmount(textbox_EUR_SELL_RATE.Text, textbox_EUR_BUY_RATE.Text, textBox_EUR_SELL_SUM, textBox_EUR_BUY_SUM,
                    textBox_EUR_SALE);
            }
        }

        private void textBox_GBP_BUY_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_GBP_BUY_SUM.Text, out double result))
            {
                textBox_GBP_RUB.Text = GetRubAmount(textbox_GBP_SELL_RATE.Text, textbox_GBP_BUY_RATE.Text, textBox_GBP_SELL_SUM, textBox_GBP_BUY_SUM,
                    textBox_GBP_SALE);
            }
        }

        private void textBox_GBP_SELL_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_GBP_SELL_SUM.Text, out double result))
            {
                textBox_GBP_RUB.Text = GetRubAmount(textbox_GBP_SELL_RATE.Text, textbox_GBP_BUY_RATE.Text, textBox_GBP_SELL_SUM, textBox_GBP_BUY_SUM,
                    textBox_GBP_SALE);
            }
        }

        private void textBox_GBP_SALE_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_GBP_SALE.Text, out double result))
            {
                textBox_GBP_RUB.Text = GetRubAmount(textbox_GBP_SELL_RATE.Text, textbox_GBP_BUY_RATE.Text, textBox_GBP_SELL_SUM, textBox_GBP_BUY_SUM,
                    textBox_GBP_SALE);
            }
        }

        private void textBox_CHF_BUY_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_CHF_BUY_SUM.Text, out double result))
            {
                textBox_CHF_RUB.Text = GetRubAmount(textbox_CHF_SELL_RATE.Text, textbox_CHF_BUY_RATE.Text, textBox_CHF_SELL_SUM, textBox_CHF_BUY_SUM,
                    textBox_CHF_SALE);
            }
        }

        private void textBox_CHF_SELL_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_CHF_SELL_SUM.Text, out double result))
            {
                textBox_CHF_RUB.Text = GetRubAmount(textbox_CHF_SELL_RATE.Text, textbox_CHF_BUY_RATE.Text, textBox_CHF_SELL_SUM, textBox_CHF_BUY_SUM,
                    textBox_CHF_SALE);
            }
        }

        private void textBox_CHF_SALE_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_CHF_SALE.Text, out double result))
            {
                textBox_CHF_RUB.Text = GetRubAmount(textbox_CHF_SELL_RATE.Text, textbox_CHF_BUY_RATE.Text, textBox_CHF_SELL_SUM, textBox_CHF_BUY_SUM,
                    textBox_CHF_SALE);
            }
        }

        private void textBox_JPY_BUY_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_JPY_BUY_SUM.Text, out double result))
            {
                textBox_JPY_RUB.Text = GetRubAmount(textbox_JPY_SELL_RATE.Text, textbox_JPY_BUY_RATE.Text, textBox_JPY_SELL_SUM, textBox_JPY_BUY_SUM,
                    textBox_JPY_SALE);
            }
        }

        private void textBox_JPY_SELL_SUM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_JPY_SELL_SUM.Text, out double result))
            {
                textBox_JPY_RUB.Text = GetRubAmount(textbox_JPY_SELL_RATE.Text, textbox_JPY_BUY_RATE.Text, textBox_JPY_SELL_SUM, textBox_JPY_BUY_SUM,
                    textBox_JPY_SALE);
            }
        }

        private void textBox_JPY_SALE_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_JPY_SALE.Text, out double result))
            {
                textBox_JPY_RUB.Text = GetRubAmount(textbox_JPY_SELL_RATE.Text, textbox_JPY_BUY_RATE.Text, textBox_JPY_SELL_SUM, textBox_JPY_BUY_SUM,
                    textBox_JPY_SALE);
            }
        }

        private void textBox_EUR_RUB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
