using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using CoverflowIssue.Controls;

namespace CoverflowIssue.ViewModels
{
    public class CarouselIssueItemViewModel
    {
        public Color BgColor { get; set; }
        public string Title { get; set; }
        public Color TitleColor { get; set; }
        public FLowTypes flow { get; set; }
    }
}
