using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Module { get; set; } = new List<Module>();
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
        public Course(string title, string url) : base(title, url)
        {

        }
    }
}