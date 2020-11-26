using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class Form1 : Form
    {
        int counterOpened;
        int[] pair;
        int[] distibutionPair;
        int[] opened;
        PictureBox[] arrayPictureBox;        
        public Form1()
        {
            InitializeComponent();
            pair = new int[8];
            distibutionPair = new int[16];
            opened = new int[2];
            counterOpened = 0;
            arrayPictureBox = new PictureBox [16];
            arrayPictureBox[0] = pictureBox1;
            arrayPictureBox[1] = pictureBox2;
            arrayPictureBox[2] = pictureBox3;
            arrayPictureBox[3] = pictureBox4;
            arrayPictureBox[4] = pictureBox5;
            arrayPictureBox[5] = pictureBox6;
            arrayPictureBox[6] = pictureBox7;
            arrayPictureBox[7] = pictureBox8;
            arrayPictureBox[8] = pictureBox9;
            arrayPictureBox[9] = pictureBox10;
            arrayPictureBox[10] = pictureBox11;
            arrayPictureBox[11] = pictureBox12;
            arrayPictureBox[12] = pictureBox13;
            arrayPictureBox[13] = pictureBox14;
            arrayPictureBox[14] = pictureBox15;
            arrayPictureBox[15] = pictureBox16;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Распределение Box-сов по панали
            //Создание 1 ряда 
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            pictureBox1.Width = panel1.Width / 4;
            pictureBox1.Height = panel1.Height / 4;

            pictureBox2.Top = 0;
            pictureBox2.Left = panel1.Width / 4;
            pictureBox2.Width = panel1.Width / 4;
            pictureBox2.Height = panel1.Height / 4;
            
            pictureBox3.Top = 0;
            pictureBox3.Left = panel1.Width / 2;
            pictureBox3.Width = panel1.Width / 4;
            pictureBox3.Height = panel1.Height / 4;

            pictureBox4.Top = 0;
            pictureBox4.Left = panel1.Width *3/ 4;
            pictureBox4.Width = panel1.Width / 4;
            pictureBox4.Height = panel1.Height / 4;

            //Создание 2 ряда
            pictureBox5.Top = panel1.Height / 4;
            pictureBox5.Left = 0;
            pictureBox5.Width = panel1.Width / 4;
            pictureBox5.Height = panel1.Height / 4;

            pictureBox6.Top = panel1.Height / 4;
            pictureBox6.Left = panel1.Width / 4;
            pictureBox6.Width = panel1.Width / 4;
            pictureBox6.Height = panel1.Height / 4;

            pictureBox7.Top = panel1.Height / 4;
            pictureBox7.Left = panel1.Width / 2;
            pictureBox7.Width = panel1.Width / 4;
            pictureBox7.Height = panel1.Height / 4;

            pictureBox8.Top = panel1.Height / 4;
            pictureBox8.Left = panel1.Width * 3 / 4;
            pictureBox8.Width = panel1.Width / 4;
            pictureBox8.Height = panel1.Height / 4;

            //Создание 3 ряда
            pictureBox9.Top = panel1.Height / 2;
            pictureBox9.Left = 0;
            pictureBox9.Width = panel1.Width / 4;
            pictureBox9.Height = panel1.Height / 4;

            pictureBox10.Top = panel1.Height / 2;
            pictureBox10.Left = panel1.Width / 4;
            pictureBox10.Width = panel1.Width / 4;
            pictureBox10.Height = panel1.Height / 4;

            pictureBox11.Top = panel1.Height / 2;
            pictureBox11.Left = panel1.Width / 2;
            pictureBox11.Width = panel1.Width / 4;
            pictureBox11.Height = panel1.Height / 4;

            pictureBox12.Top = panel1.Height / 2;
            pictureBox12.Left = panel1.Width * 3 / 4;
            pictureBox12.Width = panel1.Width / 4;
            pictureBox12.Height = panel1.Height / 4;

            //Создание 4 ряда 
            pictureBox13.Top = panel1.Height * 3/ 4;
            pictureBox13.Left = 0;
            pictureBox13.Width = panel1.Width / 4;
            pictureBox13.Height = panel1.Height / 4;

            pictureBox14.Top = panel1.Height * 3 / 4;
            pictureBox14.Left = panel1.Width / 4;
            pictureBox14.Width = panel1.Width / 4;
            pictureBox14.Height = panel1.Height / 4;

            pictureBox15.Top = panel1.Height * 3 / 4;
            pictureBox15.Left = panel1.Width / 2;
            pictureBox15.Width = panel1.Width / 4;
            pictureBox15.Height = panel1.Height / 4;

            pictureBox16.Top = panel1.Height * 3 / 4;
            pictureBox16.Left = panel1.Width * 3 / 4;
            pictureBox16.Width = panel1.Width / 4;
            pictureBox16.Height = panel1.Height / 4;
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            int numberPair = 0;
            int[] randomPair;
            randomPair = new int[8];
            Random R;
            R = new Random();
            counterOpened = 0;
            //Создание пар
            //Рандомный Выбор картинки
            for (int i = 0; i < 8; i++) 
            {
                Mark:
                pair[i] = R.Next(16);
                randomPair[i] = pair[i];
                //Проверка на уникальность изображения
                if (i != 0)
                    for (int j = 0; j < i; j++)
                    {
                        if (randomPair[i] == randomPair[j])
                            goto Mark;
                    }
                
            }
            //Обозначение не ипользованной пары
            for (int i = 0; i < 16; i++)
            {
                distibutionPair[i] = -1;
            }
            //Присвоение рандомной паре изображение
            while (numberPair != 8)
            {
                int n1 = R.Next(16);
                int n2 = R.Next(16);
                if (n1 == n2)
                    continue;
                if (distibutionPair[n1] == -1 && distibutionPair[n2] == -1)
                {
                    distibutionPair[n1] = distibutionPair[n2] = pair[numberPair];
                    numberPair++;
                }
            }
            //Отображение перевернутых карт.
            for (int i = 0; i < 16; i++)
            {
                arrayPictureBox[i].Visible = true;
                arrayPictureBox[i].BackgroundImage = imageList1.Images[16];
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = Convert.ToInt32(p.Tag);
            //Закрытие первой открытой картинки при нажатии на третью
            if (counterOpened == 2)
            {
                if (opened[1] != index)
                {
                    arrayPictureBox[opened[0]].BackgroundImage = imageList1.Images[16];
                    opened[0] = opened[1];
                }
                counterOpened--;
            }
            opened[counterOpened] = index;
            counterOpened++;
            p.BackgroundImage = imageList1.Images[distibutionPair[index]];
            //Скрутие двух одинаковых картинок
            if (counterOpened == 2 && opened[0] != opened[1])
            {
                if (distibutionPair[opened[0]] == distibutionPair[opened[1]])
                {
                    arrayPictureBox[opened[0]].Visible = false;
                    arrayPictureBox[opened[1]].Visible = false;
                }
            }            
        }
    }
}
