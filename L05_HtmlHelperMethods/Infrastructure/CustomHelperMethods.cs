using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace L05_HtmlHelperMethods.Infrastructure
{
    public static class CustomHelperMethods
    {
        public static MvcHtmlString UnorderedList(this HtmlHelper helper, string[] items)
        {
            TagBuilder tag = new TagBuilder("ul");
            foreach (var item in items)
            {
                TagBuilder liTag = new TagBuilder("li");
                liTag.SetInnerText(item);
                tag.InnerHtml += liTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }
    }
}