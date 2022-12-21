// запрашивает с клавиатуры три целых числа и выводит на экран сумму данных чисел
// в прямом и обратном порядке
using System;
namespace Hello {
    class Program {
        static void Main() {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}+{3}", a, b, b, a);
        }
    }
}

// запрашивает с клавиатуры три целых числа и выводит на экран сумму данных чисел
using System;
namespace Hello {
    class Program {
        static void Main() {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a+b);
        }
    }
}

// запрашивает с клавиатуры два вещественных числа и выводит на экран произведение
// данных чисел (с точностью до 1 знака после запятой)
using System;
namespace Hello {
    class Program {
        static void Main() {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double c = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, Math.Round(c, 1));
        }
    }
}

// запрашивает с клавиатуры два вещественных числа и выводит на экран результат деления
// первого числа на второе (с точностью до 3 знаков после запятой)
using System;
namespace Hello {
    class Program {
        static void Main() {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double c = a / b;
            Console.WriteLine("{0}/{1}={2}", a, b, Math.Round(c, 3));
        }
    }
}

// запрашивает с клавиатуры три вещественных числа, и выводит на следующее сообщение
// (вещественные числа выводятся с точностью до 2 знаков после запятой)
using System;
namespace Hello {
    class Program {
        static void Main() {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("({0}+{1})+{2}={3}+({4}+{5})", a.ToString("N2"), Math.Round(b, 2), c.ToString("N2"), a.ToString("N2"), Math.Round(b, 2), c.ToString("N2"));
        }
    }
}

// написать программу, которая спрашивает имя пользователя, а затем приветствует пользователя по имени
using System;
namespace Hello {
    class Program {
        static void Main() {
            Console.Write("What's your name?\n");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
