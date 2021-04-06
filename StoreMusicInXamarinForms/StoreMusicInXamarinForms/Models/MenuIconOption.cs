using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMusicInXamarinForms.Models
{
    public class MenuIconOption
    {
        public string Image { get; }
        public string Title { get; }

        public MenuIconOption(string title, string image)
        {
            this.Title = title;
            this.Image = image;

        }
    }
}
