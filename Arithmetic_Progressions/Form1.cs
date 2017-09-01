using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


              
        
        private void button_Fibonacci_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(textBox_Boundary.Text);
            string Fibonacci_Output = "";
            //запись в стринговую переменную объединения массива чисел Фибоначчи через разделитель - пробел
            Fibonacci_Output += String.Join(" ", Fibonacci(limit));
            richTextBox_Output.Text += Fibonacci_Output + Environment.NewLine;
        }


        private void button_Simple_Numbers_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(textBox_Boundary.Text);
            string Simple_Output = "";
            Simple_Output += String.Join(" ", SimpleNumbers(limit));
            richTextBox_Output.Text += Simple_Output + Environment.NewLine;
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


        private void button_Lucas_Click(object sender, EventArgs e)
        {
            //https://oeis.org/A000032
            int limit = int.Parse(textBox_Boundary.Text);
            string Lucas_Output = "";
            Lucas_Output += String.Join(" ", Lucas(limit));
            richTextBox_Output.Text += Lucas_Output + Environment.NewLine;
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


        private void button_Catalan_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(textBox_Boundary.Text);
            string Catalan_Output = "";
            Catalan_Output += String.Join(" ", Catalan(limit));
            richTextBox_Output.Text += Catalan_Output + Environment.NewLine;
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

        private void button_Factorials_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(textBox_Boundary.Text);
            string Factorial_Output = "";
            Factorial_Output += String.Join(" ", Factorials(limit));
            richTextBox_Output.Text += Factorial_Output + Environment.NewLine;
        }

        private void button_Squares_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(textBox_Boundary.Text);
            string Squares_Output = "";
            Squares_Output += String.Join(" ", Squares(limit));
            richTextBox_Output.Text += Squares_Output + Environment.NewLine;
        }

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

        private void button_Central_Click(object sender, EventArgs e)
        {
            //	Central polygonal numbers (the Lazy Caterer's sequence): n(n+1)/2 + 1; or, maximal number of pieces formed when slicing a pancake with n cuts. 
            //http://oeis.org/A000124
            int limit = int.Parse(textBox_Boundary.Text);
            string Central_Output = "";
            Central_Output += String.Join(" ", Central(limit));
            richTextBox_Output.Text += Central_Output + Environment.NewLine;
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
