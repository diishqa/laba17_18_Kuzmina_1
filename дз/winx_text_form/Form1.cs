using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace winx_text_form
{
    public partial class Form1 : Form
    {
        private int bloom = 0;
        private int stella = 0;
        private int flora = 0;
        private int layla = 0;
        private int musa = 0;
        private int tekna = 0;
        private int vopIndex = 0;
        public Form1()
        {
            InitializeComponent();
            Voprosi();
        }
        private void Voprosi()
        {
            switch(vopIndex)
            {
                case 0:
                    vop.Text = "Какой твой любимый цвет?";
                    button1.Text = "Красный";
                    button2.Text = "Синий";
                    button3.Text = "Зеленый";
                    break;
                case 1:
                    vop.Text = "Какое твое любимое занятие?";
                    button1.Text = "Танцы";
                    button2.Text = "Чтение";
                    button3.Text = "Спорт";
                    break;
                case 2:
                    vop.Text = "Какая твоя главная черта?";
                    button1.Text = "Сила";
                    button2.Text = "Красота";
                    button3.Text = "Ум";
                    break;
                case 3:
                    vop.Text = "Вопрос 4: Что для тебя важнее?";
                    button1.Text = "Лидерство";
                    button2.Text = "Дружба";
                    button3.Text = "Природа";
                    break;
                case 4:
                    vop.Text = "Вопрос 5: Любимый предмет?";
                    button1.Text = "Наука и техника";
                    button2.Text = "Искусство и музыка";
                    button3.Text = "Спорт";
                    break;
                case 5:
                    vop.Text = "Вопрос 6: Как проводишь время?";
                    button1.Text = "Читаю";
                    button2.Text = "С друзьями";
                    button3.Text = "На природе";
                    break;
                case 6:
                    vop.Text = "Вопрос 7: Что важнее в друзьях?";
                    button1.Text = "Верность";
                    button2.Text = "Весёлость";
                    button3.Text = "Творчество";
                    break;
                case 7:
                    vop.Text = "Вопрос 8: Любимый элемент?";
                    button1.Text = "Огонь";
                    button2.Text = "Вода";
                    button3.Text = "Технологии";
                    break;
                default:
                    Result();
                    break;
            }
        }
        private void Otvet(int op)
        {
            switch (vopIndex)
            {
                case 0:
                    if (op == 1) bloom++;
                    if (op == 2) stella++;
                    if (op == 3) flora++;
                    break;
                case 1:
                    if (op == 1) layla++;
                    if (op == 2) stella++;
                    if (op == 3) musa++;
                    break;
                case 2:
                    if (op == 1) bloom++;
                    if (op == 2) stella++;
                    if (op == 3) tekna++;
                    break;
                case 3:
                    if (op == 1) bloom++;
                    if (op == 2) layla++;
                    if (op == 3) flora++;
                    break;
                case 4:
                    if (op == 1) tekna++;
                    if (op == 2) musa++;
                    if (op == 3) layla++;
                    break;
                case 5:
                    if (op == 1) bloom++;
                    if (op == 2) stella++;
                    if (op == 3) flora++;
                    break;
                case 6:
                    if (op == 1) layla++;
                    if (op == 2) stella++;
                    if (op == 3) musa++;
                    break;
                case 7:
                    if (op == 1) bloom++;
                    if (op == 2) layla++;
                    if (op == 3) tekna++;
                    break;
            }
            vopIndex++;
            Voprosi();
        }

        private void vop_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otvet(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otvet(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otvet(3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Result()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();

            string winner = "Блум";
            int maxScore = bloom;

            if (stella > maxScore) { maxScore = stella; winner = "Стелла"; }
            if (flora > maxScore) { maxScore = flora; winner = "Флора"; }
            if (layla > maxScore) { maxScore = layla; winner = "Лейла"; }
            if (musa > maxScore) { maxScore = musa; winner = "Муза"; }
            if (tekna > maxScore) { maxScore = tekna; winner = "Текна"; }

            vop.Text = $"Ты - {winner}!";

            switch (winner)
            {
                case "Блум":
                    pictureBox1.Image = Properties.Resources.блум;
                    break;
                case "Стелла":
                    pictureBox1.Image = Properties.Resources.стела;
                    break;
                case "Флора":
                    pictureBox1.Image = Properties.Resources.флора;
                    break;
                case "Лейла":
                    pictureBox1.Image = Properties.Resources.лейла;
                    break;
                case "Муза":
                    pictureBox1.Image = Properties.Resources.муза;
                    break;
                case "Текна":
                    pictureBox1.Image = Properties.Resources.текна;
                    break;
            }




        }
    }
}
