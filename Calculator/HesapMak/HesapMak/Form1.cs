using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMak
{
    public partial class Form1 : Form
    {
        double num1,sonuc;
        string op;
        List<string> hesapGecmisi = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numbers(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0")
            {
                txt_sonuc.Clear();
            }
            Button b = (Button)sender;
            txt_sonuc.Text+=b.Text;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_sonuc.Text = "0";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            txt_sonuc.Text = txt_sonuc.Text.Substring(0, txt_sonuc.Text.Length - 1);
            if (txt_sonuc.Text == "")
            {
                txt_sonuc.Text = "0";
            }
        }

        private void btn_nokta_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text.IndexOf(",") < 1)
            {
                txt_sonuc.Text += ",";
            }
        }

        private void islemler(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            num1 = double.Parse(txt_sonuc.Text);
            txt_sonuc.Clear();
        }

        private void btn_özet_Click(object sender, EventArgs e)
        {
            string gecmis = "";
            foreach (string islem in hesapGecmisi)
            {
                gecmis += islem + "\n";
            }
            MessageBox.Show(gecmis, "Geçmiş İşlemleriniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hesapGecmisi.Clear();
            MessageBox.Show("Geçmiş İşlemler Temizlendi","Bilgilendirme");
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(txt_sonuc.Text);
            switch (op)
            {
                case "+":
                    sonuc = num1 + num2;
                    hesapGecmisi.Add($"{num1} + {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "-":
                    sonuc = num1 - num2;
                    hesapGecmisi.Add($"{num1} - {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "X":
                    sonuc = num1 * num2;
                    hesapGecmisi.Add($"{num1} * {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "÷":
                    sonuc = num1 / num2;
                    hesapGecmisi.Add($"{num1} / {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "Sin":
                    sonuc = Math.Sin(double.Parse(txt_sonuc.Text) * (Math.PI / 180.0));
                    hesapGecmisi.Add($"Sin {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "Cos":
                    sonuc = Math.Cos(double.Parse(txt_sonuc.Text) * (Math.PI / 180.0));
                    hesapGecmisi.Add($"Cos {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "Tan":
                    sonuc = Math.Tan(double.Parse(txt_sonuc.Text) * (Math.PI / 180.0));
                    hesapGecmisi.Add($"Tan {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "Cot":
                    sonuc = 1/Math.Tan(double.Parse(txt_sonuc.Text) * (Math.PI / 180.0));
                    hesapGecmisi.Add($"Cot {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "Log":
                    sonuc =Math.Log10(double.Parse(txt_sonuc.Text));
                    hesapGecmisi.Add($"Log {num2} = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "%":
                    sonuc = num1*num2/100;
                    hesapGecmisi.Add($"{num1}'in % {num2}'i = {sonuc}");
                    txt_sonuc.Clear();
                    break;
                case "X²":
                    if (txt_sonuc.Text.Length > 0)
                    {
                        sonuc = double.Parse(txt_sonuc.Text) * double.Parse(txt_sonuc.Text);
                        hesapGecmisi.Add($"{num2}² = {sonuc}");
                        txt_sonuc.Clear();
                    }                                
                    break;
                default:
                    break;
            }
            txt_sonuc.Text = sonuc.ToString();
        }
    }
}
