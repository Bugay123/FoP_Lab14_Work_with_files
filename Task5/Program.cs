namespace Task5;
class Program
    {
    /*Є два текстових файли з відсортованими за зростанням рядками.
    Отримати третій файл, який міститиме всі слова з обох файлів також
    відсортовані за зростанням. Не допускати однакових слів у третьому файлі.*/

    static void Main(string[] args)
        {
        string fileName1 = "file1.txt";
        string fileName2 = "file2.txt";

        string fileName3 = "file3.txt";

        string[] lines1 = File.ReadAllLines(fileName1);

        string[] lines2 = File.ReadAllLines(fileName2);

        string[] lines = lines1.Concat(lines2).ToArray();

        //Пыдглядав цей вираз на stackoverflow
        string[] uniqueWords = lines
            .SelectMany(line => line.Split(' '))
            .Distinct()
            .OrderBy(x => x)
            .ToArray();

        File.WriteAllLines(fileName3, uniqueWords);
        }
    }




