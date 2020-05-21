using System;

namespace ValueTypeVsReferenceType
{
    public class WebPage
    {
        public int Visit { get; set; }
        public string Url { get; set; }
        public DateTimeOffset PublishTime { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
        public WebPage(int visit, string url )
        {
            Visit = visit;
            Url = url;
            PublishTime = DateTimeOffset.Now.AddYears(-10);
            Console.WriteLine("ctor is running");
        }

        public WebPage()
        {
            
        }

        public string Load()
        {
            Visit += 1;
            return Content;

        }
    }

    public class Author
    {
        public string Name { get; set; }
    }
}