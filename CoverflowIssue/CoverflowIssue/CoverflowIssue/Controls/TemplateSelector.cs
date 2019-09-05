using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using CoverflowIssue.ViewModels;

namespace CoverflowIssue.Controls
{
   public  class TemplateSelector:DataTemplateSelector
    {
        public DataTemplate FirstTemplate { get; set; }
        public DataTemplate SecondTemplate { get; set; }
        public DataTemplate ThirdTemplate { get; set; }
        public DataTemplate FourthTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is CarouselIssueItemViewModel carouselItem)
            {
                switch (carouselItem.flow)
                {
                    case FLowTypes.First:
                        return FirstTemplate;

                    case FLowTypes.Second:
                        return SecondTemplate;

                    case FLowTypes.Third:
                        return ThirdTemplate;

                    case FLowTypes.Fourth:
                        return FourthTemplate;

                    default:
                        return FirstTemplate;
                }
            }
            return default;
        }
    }
}
