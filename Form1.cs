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
using Селецька;

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

        private void Карта_елеваторів(object sender, EventArgs e)
        {
            Перегляд f  = new Перегляд ();
            f.ShowDialog();

        }
        private void Ціни_на_пальне(object sender, EventArgs e)
        {
            Tsina f = new Tsina();
            f.ShowDialog();
        }

        private void Продавці(object sender, EventArgs e)
        {
            Prodavci f = new Prodavci();
            f.ShowDialog();
        }

        private void Виробники_СГ_техніки(object sender, EventArgs e)
        {
            SG f = new SG();
            f.ShowDialog();
        }

        private void Виробники_препаратів(object sender, EventArgs e)
        {
            Vyrobniki f = new Vyrobniki();
            f.ShowDialog();
        }

        private void Перелік_юр_компаній(object sender, EventArgs e)
        {
            YR_Komp f = new YR_Komp();
            f.ShowDialog();
        }

        private void Реєстрація_сортів_в_Україні(object sender, EventArgs e)
        {
            Ukraine f = new Ukraine();
            f.ShowDialog();
        }

        private void Максимальні_допустимі_рівні_вмісту_пестицидів(object sender, EventArgs e)
        {
           
        }

        private void Утилізації_пестицидів(object sender, EventArgs e)
        {
          
        }

        private void Правила_поводження_з_тарою_від_ЗЗР(object sender, EventArgs e)
        {
           
        }

        private void Основні_питання_попестицидах(object sender, EventArgs e)
        {
    
        }

        private void Препаративні_форми_пестицидів_агрохімікатів_добрив(object sender, EventArgs e)
        {
         
        }

        private void Діючи_речовини_що_заборонені_в_Україні(object sender, EventArgs e)
        {
            Діючи f = new Діючи();
            f.ShowDialog();
        }

        private void Групи_діючих_речовин(object sender, EventArgs e)
        {
            Group f = new Group();
            f.ShowDialog();
        }

        private void Технології_від_компаній(object sender, EventArgs e)
        {
           
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            Тиску f = new Тиску();
            f.ShowDialog();
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            Температура f = new Температура();
            f.ShowDialog();
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            Площа f = new Площа();
            f.ShowDialog();
        }

        private void materialButton14_Click(object sender, EventArgs e)
        {
            Паливо f = new Паливо();
            f.ShowDialog();
        }

        private void materialButton15_Click(object sender, EventArgs e)
        {
            Маса f = new Маса();
            f.ShowDialog();
        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            Об_єм f = new Об_єм();
            f.ShowDialog();        
        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            Довжина f = new Довжина();
            f.ShowDialog();
        }
    }
}
