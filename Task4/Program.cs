namespace Task4;
class Program
    {
    /*Створити консольну програму, що дозволяє писати і читати дані в
    текстовий файл (5 записів). Даними є арифметичні вирази, наприклад, 56/а+b-1.*/

    static void Main(string[] args)
        {
        StreamWriter file = new StreamWriter("/Users/bugay/test1.txt");
        file.WriteLine("56/а+b-1");
        file.WriteLine("а+b-1");
        file.WriteLine("56-1");
        file.WriteLine("56/а*b");
        file.WriteLine("5/а-1");
        file.Close();
        StreamReader reader = new StreamReader("/Users/bugay/test1.txt");
        string line;
        while ((line = reader.ReadLine()) != null)
            {
            Console.WriteLine(line);

            }
        reader.Close();
        }
    }

