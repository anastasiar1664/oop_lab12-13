namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true; // По умолчанию книга доступна
        }
        public void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"+ Книга '{Title}' выдана");
            }
            else
            {
                Console.WriteLine($"- Книга '{Title}' уже выдана");
            }
        }

        public void Return()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"+ Книга '{Title}' возвращена");
            }
            else
            {
                Console.WriteLine($"= Книга '{Title}' уже в библиотеке");
            }
        }
        public override string ToString()
        {
            string status = IsAvailable ? "Доступна" : "Выдана";
            return $"{Id} '{Title}' ({Author}, {Year}) - {status}";
        }
    }
}