using System;
using System.Collections.Generic;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main (string[] args)
        {
            var array = new List<WebPage>();
            var info = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                var w = new WebPage();
                
                array.Add(w);
            }
            
        }

        void VisitPage (WebPage page)
        {
            page.Visit+=10;
        }
    }
}