using System;

class Books
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    public void Info()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Объем в листах: {Pages}");
    }
}

class Program
{
    static void Main()
    {
        Books book = new Books
        {
            Title = "Я такой как все",
            Author = "Олег Тиньков",
            Year = 2020,
            Pages = 374
        };

        book.Info();
        Console.ReadKey();
    }
}