namespace Task3;
class Program
    {
    /*Створити текстовий файл з реченьу країнською мовою. Вивести зміст
    файлу на консоль, щоб відображалися українські літери. Підрахувати
    кількість рядків у файлі.*/
    static void Main(string[] args)
        {
        string file = "/Users/bugay/test.txt";
        string text = "Створити текстовий файл з речень українською мовою.\nВивести зміст файлу на консоль, щоб відображалися українські літери.\nПідрахувати кількість рядків у файлі.";
        File.WriteAllText(file, text);
        string read = File.ReadAllText(file);
        Console.WriteLine(read);

        int count = 0;
        StreamReader readFile = new StreamReader(file);
        while ((readFile.ReadLine()) != null)
            {
            count++;
            }
        Console.WriteLine("Кількість рядків у файлі: " + count);
        }
    }

