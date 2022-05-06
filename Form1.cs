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
            Process.Start(@"");
        }

        private void Продавці(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Виробники_СГ_техніки(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Виробники_препаратів(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Перелік_юр_компаній(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Реєстрація_сортів_в_Україні(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Максимальні_допустимі_рівні_вмісту_пестицидів(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Утилізації_пестицидів(object sender, EventArgs e)
        {
            Process.Start(@""); 
        }

        private void Правила_поводження_з_тарою_від_ЗЗР(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Основні_питання_попестицидах(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Препаративні_форми_пестицидів_агрохімікатів_добрив(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Діючи_речовини_що_заборонені_в_Україні(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Групи_діючих_речовин(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void Технології_від_компаній(object sender, EventArgs e)
        {
            Process.Start(@"");
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            Тиску f = new Тиску();
            f.ShowDialog();
        }
    }
}
