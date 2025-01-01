using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    public partial class Student : ObservableObject
    {
        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private int age;
    }
}
