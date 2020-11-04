using MySql.Data.MySqlClient;
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
            ReloadSomething("USD");
            ReloadSomething("EUR");
            ReloadSomething("GBP");
            ReloadSomething("CHF");
            ReloadSomething("JPY");
            ReloadRub();
        }

        private void ReloadSomething(string name)
        {
            DB database = new DB();
            DataTable values = database.QueryToBase($"SELECT * FROM `money` WHERE name = '{name}'");

            var buySum = Controls[$"textbox_{name}_BUY_SUM"];
            buySum.Text = "0";

            var sellSum = Controls[$"textbox_{name}_SELL_SUM"];
            sellSum.Text = "0";

            var sale = Controls[$"textbox_{name}_SALE"];
            sale.Text = "0";

            var sellRate = Controls[$"textbox_{name}_SELL_RATE"];
            sellRate.Text = values.Rows[0].ItemArray[3].ToString();

            var buyRate = Controls[$"textbox_{name}_BUY_RATE"];
            buyRate.Text = values.Rows[0].ItemArray[2].ToString();

            var amount = Controls[$"textbox_{name}_AMOUNT"];
            amount.Text = values.Rows[0].ItemArray[4].ToString();
        }

        private void ReloadRub()
        {
            DB database = new DB();
            DataTable values = database.QueryToBase($"SELECT * FROM `money` WHERE name = 'RUB'");
            textBox_RUB_AMOUNT.Text = values.Rows[0].ItemArray[4].ToString();
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

        private void button_reload_Click(object sender, EventArgs e)
        {
            DB database = new DB();
            UpdateRub(database);

            ReloadSomething("USD");
            ReloadSomething("EUR");
            ReloadSomething("EUR");
            ReloadSomething("GBP");
            ReloadSomething("CHF");
            ReloadSomething("JPY");
            ReloadRub();
        }

        private void UpdateAmount(string name, DB database)
        {
            string amountStr = Controls[$"textBox_{name}_AMOUNT"].Text;
            double amount = double.Parse(amountStr);

            double changing = GetMoneyChange(name);
            SetQuery(amount, changing, name, database);
        }
       
        private bool CheckCanChange(string name)
        {
            string amountStr = Controls[$"textBox_{name}_AMOUNT"].Text;
            double amount = double.Parse(amountStr);

            double changing = GetMoneyChange(name);

            if (changing < 0)
            {
                if (amount >= -1 * changing)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"У вас недостаточно {name}!");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void SetQuery(double amount, double changing, string name, DB database)
        {
            string result = $"{amount + changing}";
            result = result.Replace(',', '.');

            database.QueryToBase($"UPDATE `money` SET `amount` = {result} WHERE name = '{name}'");
        }

        private void UpdateRub(DB database)
        {
            double amount = double.Parse(Controls[$"textBox_RUB_AMOUNT"].Text);

            //пытаемся перевести доллары
            if (CheckCanChange("USD") && -1 * double.Parse(textBox_USD_RUB.Text) < amount)
            {
                UpdateAmount("USD", database);
                amount += double.Parse(textBox_USD_RUB.Text);
            }

            //пытаемся перевести евро
            if (CheckCanChange("EUR") && -1 * double.Parse(textBox_EUR_RUB.Text) < amount)
            {
                UpdateAmount("EUR", database);
                amount += double.Parse(textBox_EUR_RUB.Text);
            }

            if (CheckCanChange("GBP") && -1 * double.Parse(textBox_GBP_RUB.Text) < amount)
            {
                UpdateAmount("GBP", database);
                amount += double.Parse(textBox_GBP_RUB.Text);
            }

            if (CheckCanChange("CHF") && -1 * double.Parse(textBox_CHF_RUB.Text) < amount)
            {
                UpdateAmount("CHF", database);
                amount += double.Parse(textBox_CHF_RUB.Text);
            }

            if (CheckCanChange("JPY") && -1 * double.Parse(textBox_JPY_RUB.Text) < amount)
            {
                UpdateAmount("JPY", database);
                amount += double.Parse(textBox_JPY_RUB.Text);
            }

            string result = $"{amount}";
            result = result.Replace(',', '.');

            database.QueryToBase($"UPDATE `money` SET `amount` = {result} WHERE name = 'RUB'");
        }

        private double GetMoneyChange(string name)
        {
            var buySum = Controls[$"textBox_{name}_BUY_SUM"];

            var sellSum = Controls[$"textBox_{name}_SELL_SUM"];

            double result = double.Parse(buySum.Text) - double.Parse(sellSum.Text);

            return result;
        }

        private void textBox_EUR_RUB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
