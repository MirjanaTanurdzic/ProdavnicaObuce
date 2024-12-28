using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProdavnicaObuceM.Helper
{
    public static class Helper
    {
        public static MvcHtmlString slikaHelper(string src) 
        {
            var tagBuilder = new TagBuilder("div");
            var imgTag = new TagBuilder("img");
            imgTag.Attributes.Add("src", src);
            tagBuilder.InnerHtml = imgTag.ToString();
            tagBuilder.AddCssClass("slika");

            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}