using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Scriban;
using System.Linq;

namespace MVC
{
    public class ProductController
    {
        public static void GenerateHTML()
        {
            string htmlPage = File.ReadAllText("../../../View/HTMLPage1.html");
            var template = Template.Parse(htmlPage);

            using (var context = new ProductContext())
            {
                var result = template.Render(new { Products = context.Products.ToList() });

                File.WriteAllText("./Result.html", result);
            }
        }

    }
}
