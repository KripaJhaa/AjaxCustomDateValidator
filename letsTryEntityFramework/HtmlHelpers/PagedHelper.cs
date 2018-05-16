

namespace letsTryEntityFramework.HtmlHelpers
{
    using System.Web;
    using System.Web.Mvc;
    public static class PagedHelper
    {
        public static IHtmlString Paging(int firstPage, int PageNumber)
        {
            
            var pagingDiv = new TagBuilder("div");
            pagingDiv.AddCssClass("paging-container");

            var ul = new TagBuilder("ul");
            ul.AddCssClass("paging-list");

            for (int page = 1; page <= PageNumber; ++page)
            {
                var li = new TagBuilder("li");
                if (page == firstPage)
                {
                    li.AddCssClass("active");
                }
                li.AddCssClass("paging-listitem");

                var anchorTag = new TagBuilder("a");
                anchorTag.AddCssClass("listitem-data");
                anchorTag.InnerHtml = page.ToString();
                anchorTag.MergeAttribute("href", "/Students?page=" + page);
                li.InnerHtml = anchorTag.ToString();
                ul.InnerHtml += li.ToString();

            }

            pagingDiv.InnerHtml = ul.ToString();
            return new MvcHtmlString(pagingDiv.ToString(TagRenderMode.Normal));
        }
    }
}