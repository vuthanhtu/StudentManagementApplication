using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Converter
{
    public static class PageIndexToButtonVisibilityConverter
    {
        public static Visibility Convert(int index, int value)
        {
            return index == value ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}
