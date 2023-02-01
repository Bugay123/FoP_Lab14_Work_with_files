using System.Linq.Expressions;

namespace Task2;
class Program
    {
    /*В консольному арифметичному калькуляторі замість консольного
    введення-виведення реалізувати роботу з файлом. Вхідний файл містить
    обчислюваний вираз. Вихідний – обчислюваний вираз, текст
    "Результат= " і сам результат обчислення.*/
    static void Main(string[] args)
        {
        string taskFile = File.ReadAllText("/Users/bugay/test/testFile.txt");
        string resultFile = "/Users/bugay/test/result.txt";

        try
            {
            string[] parts = taskFile.Split(' ');
            double num1 = Convert.ToDouble(parts[0]);
            string op = parts[1];
            double num2 = Convert.ToDouble(parts[2]);
            Console.WriteLine("Прочитано");

            if (op == "+")
                {
                double result = num1 + num2;
                File.WriteAllText(resultFile, "Результат = " + result.ToString());
                }
            else if (op == "-")
                {
                double result = num1 + num2;
                File.WriteAllText(resultFile, "Результат = " + result.ToString());
                }
            else if (op == "*")
                {
                double result = num1 + num2;
                File.WriteAllText(resultFile, "Результат = " + result.ToString());
                }
            else if (op == "/")
                {
                double result = num1 + num2;
                File.WriteAllText(resultFile, "Результат = " + result.ToString());
                }
            else
                {
                File.WriteAllText(resultFile, "Невизначена операція");
                }
            Console.WriteLine("Виконано");
            }
        catch (Exception e)
            {
            Console.WriteLine("Формат виразу: {num1}{ }{op}{ }{num2}");
            }
        }
    }
