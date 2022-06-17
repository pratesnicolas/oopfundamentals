namespace Balta.ContentContext
{ 
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; } = new List<CareerItem>();
        public int TotalCourses => Items.Count;

        public Career(string title, string url) : base(title, url)
        {

        }
    }
}