using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив тексту
        string[] textArray = {
            "Група ПІ-91 навчається в цьому корпусі.",
            "ПІ-91 активно бере участь у проектах.",
            "На зустрічі були студенти ПІ-91 і ПІ-92.",
            "ПІ-91 — одна з найкращих груп факультету."
        };

        // Слово для пошуку
        string targetWord = "ПІ-91";

        // Запит LINQ для підрахунку кількості повторень слова
        int count = textArray.Sum(line => line.Split(new[] { ' ', '.', ',', '!', '?', '-', '—' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Count(word => word == targetWord));

        // Виведення результату
        Console.WriteLine($"Слово '{targetWord}' зустрічається {count} раз(и) у тексті.");
    }
}
