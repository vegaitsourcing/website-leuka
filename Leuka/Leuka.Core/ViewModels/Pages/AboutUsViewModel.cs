﻿using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Generated = Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class AboutUsViewModel  : PageViewModel
    {
        public AboutUsViewModel(IPageContext<Generated.AboutUs> context) : base(context)
        {
            Title = context.Page.Title;
            Description = context.Page.Description;
            Image = context.Page.Image;
            TextList = context.Page.TextList;
            Paragraph = context.Page.RichContent;
            DonatePopups = context.Page.Donate.Select(popup => new DonatePopupViewModel(popup));
        }
        
        public string Title { get; }
        public IHtmlString Description { get; }
        public Generated.Image Image { get; }
        public IEnumerable<string> TextList { get; }
        
        public IHtmlString Paragraph { get; }
        public IEnumerable<DonatePopupViewModel> DonatePopups { get; }
        public static string PopupPartialViewPath => "~/Views/Partials/NestedContent/_DonatePopup.cshtml";
    }
}