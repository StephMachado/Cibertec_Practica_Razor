using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class ImageHelper
    {
        public static IHtmlString Image(string src)
        {
            var builder = new TagBuilder("img");
            if (String.IsNullOrEmpty(src))
                src = "Images/FotoNoExiste.jpg";   
            builder.MergeAttribute("src", src);
            builder.MergeAttribute("height", "100");
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}
