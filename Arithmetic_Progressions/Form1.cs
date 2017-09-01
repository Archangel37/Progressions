using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Numerics;

namespace Arithmetic_Progressions
{
    public partial class Progressions : Form
    {
        public Progressions()
        {
            InitializeComponent();
        }

        public int limit;
        public string Output = "";
        public string NameOfOperation = "";
        


        private void CRT_and_to_Buff()
        {
            richTextBox_Output.Text = "";//очищаем большой текстбокс
            limit = int.Parse(textBox_Boundary.Text);
            //тут надо как-то выбрать то, что готово, можно использовать переключатель switch
            switch (NameOfOperation)
            {
                case "Fibonacci":
                    {
                        Output = String.Join(" ", Fibonacci(limit));
                        richTextBox_Output.Text += Output + Environment.NewLine;
                    }
                    break;
                case "Simple":
                    {
                        Output = String.Join(" ", SimpleNumbers(limit));
                        richTextBox_Output.Text += Output + Environment.NewLine;
                    }
                    break;
                case "Lucas":
                    {
                        Output = String.Join(" ", Lucas(limit));
                        richTextBox_Output.Text += Output + Environment.NewLine;
                    }
                    break;
                case "Catalan":
                    {
                        Output = String.Join(" ", Catalan(limit));
                        richTextBox_Output.Text += Output + Environment.NewLine;
                    }
                    break;
                case "Factorials":
                    {
                        Output = String.Join(" ", Factorials(limit));
                        richTextBox_Output.Text += Output + Environment.NewLine;
                    }
                    break;
                case "Squares":
                    {
                        Output = String.Join(" ", Squares(limit));
                        richTextBox_Output.Text += Output + Environment.NewLine;
                    }
                    break;
                case "Central":
                    {
                        Output = String.Join(" ", Central(limit));
                        richTextBox_Output.Text += Output + Environment.NewLine;
                    }
                    break;

            }
        }
      
        
        private void button_Fibonacci_Click(object sender, EventArgs e)
        {
            NameOfOperation = "Fibonacci";
            CRT_and_to_Buff();
        }

        private void button_Simple_Numbers_Click(object sender, EventArgs e)
        {
            NameOfOperation = "Simple";
            CRT_and_to_Buff();
        }

        private void button_Lucas_Click(object sender, EventArgs e)
        {
            //https://oeis.org/A000032
            NameOfOperation = "Lucas";
            CRT_and_to_Buff();
        }

        private void button_Catalan_Click(object sender, EventArgs e)
        {
            NameOfOperation = "Catalan";
            CRT_and_to_Buff();
        }

        private void button_Factorials_Click(object sender, EventArgs e)
        {
            NameOfOperation = "Factorials";
            CRT_and_to_Buff();
        }

        private void button_Squares_Click(object sender, EventArgs e)
        {
            NameOfOperation = "Squares";
            CRT_and_to_Buff();
        }

        private void button_Central_Click(object sender, EventArgs e)
        {
            //	Central polygonal numbers (the Lazy Caterer's sequence): n(n+1)/2 + 1; or, maximal number of pieces formed when slicing a pancake with n cuts. 
            //http://oeis.org/A000124
            NameOfOperation = "Central";
            CRT_and_to_Buff();
        }


        //заполнение массива чисел Фибоначчи
        static BigInteger[] Fibonacci(int k)
        {
            BigInteger[] Fib_number = new BigInteger[k+1];
            Fib_number[0] = 0;
            for (int i = 1; i <= k; i++)
            {
                if (i < 3)
                {
                    Fib_number[i] = 1;        
                }
                else
                {
                    Fib_number[i] = Fib_number[i - 1] + Fib_number[i - 2];        
                }
            }
        return Fib_number;
        }
        //заполнение массива чисел Фибоначчи


        //заполнение массива простых чисел
        static BigInteger[] SimpleNumbers(int z)
        {
            BigInteger[] Simple = new BigInteger[z + 1];
            Simple[0] = 1;
            Simple[1] = 2;
            for (int j = 2; j <= z; j++)
            {
                BigInteger temp = Simple[j - 1] + 1;
                while (!isSimple(temp))
                {
                    temp++;
                }
                Simple[j] = temp;
            }
            return Simple;
        }

      //метод который определяет простое число или нет
        private static bool isSimple(BigInteger N)
        {
            //чтоб убедится простое число или нет достаточно проверить не делится ли 
            //число на числа до его половины, по факту - до квадратного корня, но с биг интеджерами нужно отдельный метод писать и будет это дольше
            for (BigInteger i = 2; i <= (BigInteger)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        //заполнение массива чисел Лукаса
        static BigInteger[] Lucas(int u)
        {
            BigInteger[] Lucas_number = new BigInteger[u + 1];
            Lucas_number[0] = 0;
            Lucas_number[1] = 2;
            Lucas_number[2] = 1;
            for (int i = 3; i <= u; i++)
            {              
                    Lucas_number[i] = Lucas_number[i - 1] + Lucas_number[i - 2];
            }
            return Lucas_number;
        }

        //заполнение массива чисел Каталана
        static BigInteger[] Catalan(int p)
        {
            BigInteger[] Catalan_number = new BigInteger[p + 1];//тут нулевое число - базис =1, а p - это по-сути число с номером p+1
            Catalan_number[0] = 1;
            Catalan_number[1] = 1;
            Catalan_number[2] = 2;
            for (int i = 3; i <= p; i++)
            {
                Catalan_number[i] = (2*(2*i-1)*Catalan_number[i-1])/(i+1);
            }
            return Catalan_number;
        }

        //факториалы чисел
        static BigInteger[] Factorials(int y)
        {
            BigInteger[] Factorial = new BigInteger[y + 1];
            Factorial[0] = 1;
            for (int i = 1; i <= y; i++)
            {
                Factorial[i] = Factorial[i-1] * i;
            }
            return Factorial;
        }

        //квадраты чисел
        static BigInteger[] Squares(int y)
        {
            BigInteger[] Square = new BigInteger[y + 1];
            Square[0] = 0;
            for (int i = 1; i <= y; i++)
            {
                Square[i] = i * i;
            }
            return Square;
        }


        //без BigInteger на умножение на 70к примерно выдаёт отрицательные значения
        static BigInteger[] Central(int y)
        {
           
            BigInteger[] Centr = new BigInteger[y+1];
            for (int i = 0; i <= y; i++)
            {
                Centr[i] = (new BigInteger(i) * new BigInteger(i + 1)) / 2 + 1;
            }
            return Centr;
        }


    }
}
