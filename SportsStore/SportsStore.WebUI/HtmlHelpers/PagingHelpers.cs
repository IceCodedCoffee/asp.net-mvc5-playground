using SportsStore.WebUI.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace SportsStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();

            TagBuilder tag = new TagBuilder("a");

            if (pagingInfo.CurrentPage > 1)
            {
                tag.MergeAttribute("href", pageUrl(pagingInfo.CurrentPage - 1));
                tag.InnerHtml = "<span class=\"glyphicon glyphicon-backward\"></span>";
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString() + " ");
            }

            if (pagingInfo.CurrentPage > 2)
            {
                tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(1));
                tag.InnerHtml = "1";
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString() + " ");

                if (pagingInfo.CurrentPage > 3)
                {
                    result.Append(" ... ");
                }
            }

            for (int i = pagingInfo.CurrentPage == 1 ? pagingInfo.CurrentPage : pagingInfo.CurrentPage - 1; i <= pagingInfo.CurrentPage + 1 && i <= pagingInfo.TotalPages; i++)
            {
                tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString() + " ");
            }

            if (pagingInfo.CurrentPage < pagingInfo.TotalPages - 1)
            {
                if (pagingInfo.CurrentPage + 2 != pagingInfo.TotalPages)
                {
                    result.Append(" ... ");
                }

                tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(pagingInfo.TotalPages));
                tag.InnerHtml = pagingInfo.TotalPages.ToString();
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString() + " ");
            }

            if (pagingInfo.CurrentPage < pagingInfo.TotalPages)
            {
                tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(pagingInfo.CurrentPage + 1));
                tag.InnerHtml = "<span class=\"glyphicon glyphicon-forward\"></span>";
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }

            return MvcHtmlString.Create(result.ToString());
        }
    }
}