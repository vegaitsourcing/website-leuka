﻿using Leuka.Models.Generated;
using System;

namespace Leuka.Core.ViewModels.Shared
{
    public class ButtonViewModel : IContentViewModel
    {
        public ButtonViewModel(Button button)
        {
            ButtonColor = button.ButtonColor;
            ButtonStyle = button.ButtonStyle;
            Link = button.Link.Url;
            Text = button.LinkTitle;
            SetButonClass(button);
        }

        public string ButtonColor { get; set; }

        public string ButtonStyle { get; set; }

        public string Link { get; set; }

        public string Text { get; set; }

        public string ButtonClass { get; private set; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Button.cshtml";

        public const string RegularButtonTypeName = "Regular";

        public const string StrokedButtonTypeName = "Stroked";

        public const string LinkButtonTypeName = "Link";

        private void SetButonClass(Button button)
        {
            switch (button.ButtonStyle)
            {
                case RegularButtonTypeName:
                    ButtonClass = $"button-{button.ButtonColor.ToLower()}";
                    break;
                case StrokedButtonTypeName:
                    ButtonClass = $"button-{StrokedButtonTypeName.ToLower()}";
                    break;
                case LinkButtonTypeName:
                    ButtonClass = $"button-{LinkButtonTypeName.ToLower()}";
                    break;
                default:
                    ButtonClass = "button";
                    break;
            }
        }
    }
}