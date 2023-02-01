namespace Task1;
class Program
    {
    /*Створити програмно каталог, в ньому 2 підкаталоги. В
    першому підкаталозі створити файл. Потім скопіювати файл в другий
    підкаталог. Видалити файл з першого підкаталогу.*/

    static void Main(string[] args)
        {
        string dirPath = "/Users/bugay/test";
        string fileName = "/testFile.txt";
        if (!Directory.Exists(dirPath))
            {
            Directory.CreateDirectory(dirPath);
            Directory.CreateDirectory(dirPath + "/subtest1");
            Directory.CreateDirectory(dirPath + "/subtest2");
            File.Create(dirPath + "/subtest1" + fileName);
            if (File.Exists(dirPath + "/subtest1" + fileName))
                {
                File.Copy(dirPath + "/subtest1" + fileName, dirPath + "/subtest2" + fileName, true);
                }
            else
                {
                Console.WriteLine("Файл для копіювання не знайдено");
                }

            Console.WriteLine("Файл скопійований");
            if (File.Exists(dirPath + "/subtest2" + fileName))
                {
                File.Delete(dirPath + "/subtest1" + fileName);
                Console.WriteLine("Файл видалено");
                }
            else
                {
                Console.WriteLine("Файл для видалення не знайдено");
                }

            }
        else
            {
            Console.WriteLine("Такий каталог існує");
            }
        }
    }

