namespace soufianeBlog.Models
{
    [Serializable]
    public class Blog
    {
       public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public Blog(string title, string content, string author, DateTime date)
        {
            Title = title;
            Content = content;
            Author = author;
            Date = date;
        }

      
    }
}
