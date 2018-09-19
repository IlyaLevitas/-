using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        const int maxEffect = 20;
        struct course
        {
            int labs;
            double difficultyModifier;
        };
        int lab = 0;                                                //Количествовыполненных лаб
        int effect = 1;                                             //Прогресс за 1 клик
        int exp = 0, expPerClick = 1, sp = 0;                       //Опыт,  очки прокачки
        int LabaDifficullty = 10;                                   //Количество кликов,необходимое для одной лабы

        private void label3_Click(object sender, EventArgs e)
        {
            sp += 1;
            label3.Text = System.Convert.ToString("сп: " + sp);
        }


        public Form1()
        {
            InitializeComponent();
            LabaProgress.Maximum = LabaDifficullty;
            LabaProgress.Step = LabaDifficullty;
            expPerClick = (LabaDifficullty / (lab+1));
            course[] kurs = new course[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LabaProgress.Value += effect;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                LabaProgress.Value = 0; lab++; exp += expPerClick;
                expPerClick = 1 + (LabaDifficullty / (lab + 1));
            }
            if(exp>=100)
            {
                exp -=100;
                sp++;
                label3.Text = System.Convert.ToString("сп: " + sp);
            }
            label1.Text = System.Convert.ToString("лабы: "+lab);
            label2.Text = System.Convert.ToString("опыт: "+exp+"/100");
            if (Visualka.Text != "") Visualka.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sp>0 && effect <= maxEffect)
            {
                sp--;
                effect++;
                if (effect >= (maxEffect / 3)) { Visualka.BackgroundImage = WindowsFormsApp3.Properties.Resources.Визуалка1; }
                if (effect >= (maxEffect / 3 * 2)) { Visualka.BackgroundImage = WindowsFormsApp3.Properties.Resources.Визуалка2; }
                if (effect >= maxEffect) { Visualka.BackgroundImage = WindowsFormsApp3.Properties.Resources.Визуалка3; }
                label3.Text = System.Convert.ToString("сп: " + sp);
                label4.Text = System.Convert.ToString("лаб за клик: " + effect);
            }
        }

    }
}
