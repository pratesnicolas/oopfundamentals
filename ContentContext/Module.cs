using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Module : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; } = new List<Lecture>();
    }
}