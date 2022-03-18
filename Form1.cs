using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : MaterialForm
    {


        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            Process.Start(@"doc\elevator.html");

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"doc\azc.html");
        }

        private void materialButton3_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"doc\gla.html");
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\mys.html");
        }

        private void materialMultiLineTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\GLAV.html");
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\ЮР.html");
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\ДЕРЖАВНА РЕЄСТРАЦІЯ СОРТІВ РОСЛИН В УКРАЇНІ.html");
        }

        private void materialButton17_Click(object sender, EventArgs e)
        {
            
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void materialMultiLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\index.html");
        }

        private void materialButton18_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\УТИЛІЗАЦІЇ ПЕСТИЦИДІВ.html"); 
        }

        private void materialButton21_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\ZZR.html");
        }

        private void materialButton19_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\pit\index2.html");
        }

        private void materialButton20_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\Препаративні форми пестицидів, агрохімікатів та добрив.html");
        }

        private void materialMultiLineTextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialMultiLineTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton9_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"doc\GLAVNAY.html");
        }

        private void materialButton17_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"doc\GLAVN.html");
        }

        private void materialMultiLineTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton22_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\index3.html");
        }

        private void materialButton23_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\index4.html");
        }

        private void materialButton24_Click(object sender, EventArgs e)
        {
            Process.Start(@"doc\index5.html");
        }
    }
}
