using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CoverflowIssue.Controls;
using Xamarin.Forms;

namespace CoverflowIssue.ViewModels
{
    public class CaroueselIssueViewModel
    {
        public ObservableCollection<CarouselIssueItemViewModel> CardItems { get; set; }
        private void LoadData()
        {
            CardItems = new ObservableCollection<CarouselIssueItemViewModel>
            {
                GetOne(),
                GetTwo(),
                GetThree(),
                GetFour()
            };
        }

        public CaroueselIssueViewModel()
        {
            LoadData();
        }

        private CarouselIssueItemViewModel GetOne()
        {
            return new CarouselIssueItemViewModel
            {
                BgColor = Color.FromHex("#02336B"),
                Title = "Title1",
                TitleColor = Color.FromHex("FFFFFF"),
                flow = FLowTypes.First
            };
        }
        private CarouselIssueItemViewModel GetTwo()
        {
            return new CarouselIssueItemViewModel
            {
                BgColor = Color.FromHex("#56BBB1"),
                Title = "Title2",
                TitleColor = Color.FromHex("FFFFFF"),
                flow = FLowTypes.Second
            };
        }
        private CarouselIssueItemViewModel GetThree()
        {
            return new CarouselIssueItemViewModel
            {
                BgColor = Color.FromHex("#464E9C"),
                Title = "Title3",
                TitleColor = Color.FromHex("FFFFFF"),
                flow = FLowTypes.Third
            };
        }
        private CarouselIssueItemViewModel GetFour()
        {
            return new CarouselIssueItemViewModel
            {
                BgColor = Color.FromHex("#7995BC"),
                Title = "Title4",
                TitleColor = Color.FromHex("FFFFFF"),
                flow = FLowTypes.Fourth
            };
        }
    }
}
