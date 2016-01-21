using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GUI.Resources
{
    class ImageButton : Button
    {
        public string HoverImageSource
        {
            get
            {
                return (string)GetValue(SecurityIdProperty);
            }
            set { SetValue(SecurityIdProperty, value); }
        }
        public static readonly DependencyProperty
            SecurityIdProperty =
            DependencyProperty.Register("HoverImageSource",
            typeof(string), typeof(ImageButton),
            new PropertyMetadata(""));

    }
}
