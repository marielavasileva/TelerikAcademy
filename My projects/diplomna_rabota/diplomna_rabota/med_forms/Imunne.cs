using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diplomna_rabota.med_forms
{
    public partial class Imunne : Form
    {
        public Imunne()
        {
            InitializeComponent();
        }

        private void months_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int month = Int32.Parse(Value.Text);

                if (month == 1)
                {
                    resultIm.Text = "Имунизация против хепатит В (II прием) ";
                }

                else if (month == 2)
                {
                    resultIm.Text = "Имунизация против полиомиелит , дифтерия , тетанус, коклюш, хемофилус инфлуенце тип II (I прием); Имунизация против пневмококи (I прием)";
                }

                else if (month == 3)
                {
                    resultIm.Text = "Имунизация против полиомиелит , дифтерия , тетанус, коклюш, хемофилус инфлуенце тип II (II прием); Имунизация против пневмококи (II прием)";
                }

                else if (month == 4)
                {
                    resultIm.Text = "Имунизация против полиомиелит , дифтерия , тетанус, коклюш, хемофилус инфлуенце тип II (III прием); Имунизация против пневмококи (III прием)";
                }

                else if (month == 6)
                {
                    resultIm.Text = "Имунизация против хепатит В (III прием )";
                }

                else if (month == 7)
                {
                    resultIm.Text = "Проверка за белег след БЖЦ имунизацията. На децата без белег се прави проба Манту.Отрицателните се имунизират.";
                }

                else if (month == 12)
                {
                    resultIm.Text = "Ремунизация против пневмококи, не по рано от 6 месеца след III-тия прием (IV прием) ";
                }

                else if (month == 13)
                {
                    resultIm.Text = "Имунизация против морбили, паротит и рубеола";
                }

                else if (month == 16)
                {
                    resultIm.Text = "Реимунизация против полиомиелит , дифтерия , тетанус, коклюш, хемофилус инфлуенце тип II (IV прием)";
                }

                else
                {
                    resultIm.Text = "В имунизационния календар не е предвидена имунизация за тази възраст !";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }

        }

        private void years_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int years = Int32.Parse(Value.Text);

                if (years == 6)
                {
                    resultIm.Text = "Реимунизация против полиомиелит , дифтерия , тетанус, коклюш (V прием).";
                }

                else if (years == 7)
                {
                    resultIm.Text = "Реимунизация против туберкулоза след отрицателна проба Манту.";
                }

                else if (years == 11)
                {
                    resultIm.Text = "Реимунизация против туберкулоза след отрицателна проба Манту.";
                }

                else if (years == 12)
                {
                    resultIm.Text = "Реимунизация против морбили, паротит и рубеола ;Реимунизация против дифтерия и тетанус .";
                }

                else if (years == 17)
                {
                    resultIm.Text = "Реимунизация против туберкулоза след отрицателна проба Манту.Реимунизация против дифтерия и тетанус.";
                }

                else if ((years == 25) || (years == 35) || (years == 45) || (years == 55) || (years == 65) || (years == 75) || (years == 85) || (years == 95) || (years == 105))
                {
                    resultIm.Text = "Реимунизация против дифтерия и тетанус .";
                }

                else
                {
                    resultIm.Text = "В имунизационния календар не е предвидена имунизация за тази възраст !";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }

        }

        private void hours_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int hours = Int32.Parse(Value.Text);

                if (hours == 24)
                {
                    resultIm.Text = "Имунизация против хепатит В (I прием).";
                }

                else if (hours == 48)
                {
                    resultIm.Text = "Имунизация против туберкулоза.";
                }

                else
                {
                    resultIm.Text = " В имунизационния календар не е предвидена имунизация за тази възраст !";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }
        }

        
              

        private void ValueIm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ValueIm.Text == "Хепатит В")
            {
                resultIm.Text = "Извършва се на: 24h след раждане, I месец, VI месец!";
            }

            else if (ValueIm.Text == "Туберкулоза (БЦЖ ваксина, след отрицателна Манту проба)")
            {
                resultIm.Text = "Извършва се на:  48 h след раждането, VII месец, 7 години, 11 години, 17 години!";
            }

            else if (ValueIm.Text == "Полиомелит,дифтерия,тетанус,коклюш и хемофилус инфлуенце тип Б")
            {
                resultIm.Text = "Извършва се на: II месец, III месец, IV месец, 16 месец!";
            }

            else if (ValueIm.Text == "Полиомелит,дифтерия,тетанус и коклюш")
            {
                resultIm.Text = "Извършва се на : 6 години";
            }

            else if (ValueIm.Text == "Пневмококи")
            {
                resultIm.Text = "Извършва се на: II месец, III месец, IV месец и 12 месец!";
            }

            else if (ValueIm.Text == "Морбили, паротит и рубеола")
            {
                resultIm.Text = "Извършва се на: 13 месеца и 12 години!";
            }

            else if (ValueIm.Text == "Тетанус и дифтерия")
            {
                resultIm.Text = "Извърша се на: 12 години , 17 години и от 25-тата година през 10 години!";
            }
        }

        private void Imunne_Load(object sender, EventArgs e)
        {

        }

        private void Value_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

