using SuperParser.Core;
using SuperParser.Core.Freelansim;
using SuperParser.Core.Habr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperParser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser_habr;
        ParserWorker<string[]> parser_freelansim;
        public Form1()
        {
            InitializeComponent();
            parser_habr = new ParserWorker<string[]>(new HabrParser());
            //По заврешению работы парсера будет появляться уведомляющее окно.
            parser_habr.OnComplited += Parser_OnComplited;
            //Заполняем наш listBox заголовками
            parser_habr.OnNewData += Parser_OnNewData;

            parser_freelansim = new ParserWorker<string[]>(new FreelansimParser());
            parser_freelansim.OnComplited += Parser_OnComplited;
            parser_freelansim.OnNewData += Parser_OnNewData;
        }

        public void Parser_OnComplited(object o) { MessageBox.Show("Работа завершена!"); }
        public void Parser_OnNewData(object o, string[] str) { ListTitles.Items.AddRange(str); }

        private void buttonHabr_Click(object sender, EventArgs e)
        {
            //Настройки для парсера
            parser_habr.Settings = new HabrSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            //Парсим!
            parser_habr.Start();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Очищаем listBox
            ListTitles.Items.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            parser_habr.Stop();
            parser_freelansim.Stop();
        }

        private void buttonFreelansim_Click(object sender, EventArgs e)
        {
            //Настройки для парсера
            parser_freelansim.Settings = new FreelansimSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            //Парсим!
            parser_freelansim.Start();
        }
    }
}
