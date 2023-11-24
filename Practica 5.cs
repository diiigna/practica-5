using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

// Задание 1

//namespace PiD6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string num0;
//            num0 = Interaction.InputBox(
//                "Введите число"
//                );
//            int num1 = XmlConvert.ToInt32(num0 );
//            if ( num1 % 3 == 0 && num1 % 7 == 0 ) {
//                string txt = num1 + " Делится на 3 и на 7 без остатка";
//                MessageBox.Show( txt );
//            }
//            else
//            {
//                string txt = num1 + " Не делится одновременно на 3 и на 7 без остатка";
//                MessageBox.Show(txt );
//            }
//        }

//    }
//}

// Задание 2

//namespace PiD6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string first, second;
//            first = Interaction.InputBox(
//                "Введите первое число"
//                );
//            second = Interaction.InputBox(
//                "Введите второе число"
//                );

//            int num0 = Convert.ToInt32(first);
//            int num1 = Convert.ToInt32(second);
//            if (num0 > num1)
//            {
//                string txt = num0 + " больше чем " + num1;
//                MessageBox.Show(txt);
//            }
//            else if (num1 > num0)
//                    {
//                string txt = num1 + " больше чем " + num0;
//                MessageBox.Show(txt);
//            }
//            else
//            {
//                string txt = num1 + " равно " + num0;
//                MessageBox.Show(txt);
//            }
//        }

//    }
//}

// Задание 3

//namespace PiD6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int input3;
//            int sum1 = Convert.ToInt32(Interaction.InputBox("Введите число:"));
//            int input1 = Convert.ToInt32(Interaction.InputBox("Введите число: "));
//            for (int i = sum1; input1 != 0; ++i)
//            {
//                input3 = Convert.ToInt32(Interaction.InputBox("Введите число"));
//                if (input3 != 0)
//                {
//                    sum1 += input3;
//                    MessageBox.Show($"Сумма + введенное число = {sum1}");
//                }
//                else if (input3 == 0)
//                {
//                    break;
//                }
//            }




//        }

//    }
//}

//Задание 4
//namespace PiD6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string first;




//                first = Interaction.InputBox(
//               "Введите число"
//               );
//            int num0 = Convert.ToInt32(first);
//            switch (num0)
//            {
//                case 1:
//                    string txt = first + " Понедельник";
//                    MessageBox.Show(txt);
//                    break;
//                case 2:
//                    string txt1 = first + " Вторник";
//                    MessageBox.Show(txt1);
//                    break;
//                case 3:
//                    string txt2 = first + " Среда";
//                    MessageBox.Show(txt2);
//                    break;
//                case 4:
//                    string txt3 = first + " Четверг";
//                    MessageBox.Show(txt3);
//                    break;
//                case 5:
//                    string txt4 = first + " Пятница";
//                    MessageBox.Show(txt4);
//                    break;
//                case 6:
//                    string txt5 = first + " Суббота";
//                    MessageBox.Show(txt5);
//                    break;
//                case 7:
//                    string txt6 = first + " Воскресенье";
//                    MessageBox.Show(txt6);
//                    break;
//                default:
//                    string txt7 = "Введите число от 1 до 7 включительно";
//                    MessageBox.Show(txt7);
//                    break;
//                    }
//                }
//            }
//           }

// Задание 5
//namespace PiD6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string first;
//            first = Interaction.InputBox(
//           "Введите число"
//           );

//            switch (first)
//            {
//                case "Понедельник":
//                    string txt = first + " 1";
//                    MessageBox.Show(txt);
//                    break;
//                case "Вторник":
//                    string txt1 = first + " 2";
//                    MessageBox.Show(txt1);
//                    break;
//                case "Среда":
//                    string txt2 = first + " 3";
//                    MessageBox.Show(txt2);
//                    break;
//                case "Четверг":
//                    string txt3 = first + " 4";
//                    MessageBox.Show(txt3);
//                    break;
//                case "Пятница":
//                    string txt4 = first + " 5";
//                    MessageBox.Show(txt4);
//                    break;
//                case "Суббота":
//                    string txt5 = first + " 6";
//                    MessageBox.Show(txt5);
//                    break;
//                case "Воскресенье":
//                    string txt6 = first + " 7";
//                    MessageBox.Show(txt6);
//                    break;
//                default:
//                    string txt7 = "Введите Понедельник, Вторник, Среда, Четверг, Пятница, Суббота или Воскресенье";
//                    MessageBox.Show(txt7);
//                    break;
//            }
//        }
//    }
//}

//Задание 6
namespace PiD6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first;
            first = Interaction.InputBox(
           "Введите число"
           );
            int num0 = 1; int num1 = 1; int num2 = 0;
            int num3 = Convert.ToInt32(first);

            for (int i = 0; i < num3; i++)
            {
                Console.WriteLine($"{num0}");
                Console.WriteLine($"{num1}");
                num2 = num0 + num1;
                num0 = num1 + num2;
            }

            string num4 = Convert.ToString(num0);
            string txt = num4;
            MessageBox.Show(txt);

        }
    }
}
