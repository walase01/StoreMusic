using StoreMusicInXamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMusicInXamarinForms.ViewModels
{
    public class HomeViewModel
    {
        public MenuIconOption IconText1 => new MenuIconOption("Breathe", "breath");
        public MenuIconOption IconText2 => new MenuIconOption("Sleep", "Sleep");
        public MenuIconOption IconText3 => new MenuIconOption("Anxiety", "anxiety");
        public MenuIconOption IconText4 => new MenuIconOption("Stress", "stress");

        public MenuIconOption iconOption1 => new MenuIconOption("Today", "Today");
        public MenuIconOption iconOption2 => new MenuIconOption("Yoga", "yoga");
        public MenuIconOption iconOption3 => new MenuIconOption("Meditation", "meditation");
        public MenuIconOption iconOption4 => new MenuIconOption("Meal", "meal");
        public MenuIconOption iconOption5 => new MenuIconOption("profile", "profile");
        public string SubTitle { get; set; } 

        public string TreeImage { get; set; }

        public string TextImageTree { get; set; }
        public string DetailImageTree { get; set; }

        public string SubTitle2 { get; set; }

        public HomeViewModel()
        {
            this.SubTitle = "Daily meditations";
            this.TreeImage = "tree.jpg";
            this.TextImageTree = "Rest & Relax";
            this.DetailImageTree = "30 mins";
            this.SubTitle2 = "New Music";


        }

    }
}
