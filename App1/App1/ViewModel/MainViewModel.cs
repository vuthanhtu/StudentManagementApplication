using App1.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    public partial class MainViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<Student> _students;
        [ObservableProperty]
        private ObservableCollection<Student> _listStudentToShow;
        [ObservableProperty]
        private int _indexPage = 1;
        [ObservableProperty]
        private int _page;
        private const int NUMBER_ITEM_TO_SHOW = 10;
        public MainViewModel()
        {
            _students = new ObservableCollection<Student>();
            LoadListStudent();
            _page = _students.Count / NUMBER_ITEM_TO_SHOW + (_students.Count % NUMBER_ITEM_TO_SHOW > 0 ? 1 : 0);
            LoadListStudentToShow();
        }
        private void LoadListStudent()
        {
            for(int i = 1; i <= 55; i++)
            {
                Student student = new Student()
                {
                    Id = i,
                    Name = $"Student {i}",
                    Age = new Random().Next(10, 20)
                };
                Students.Add(student);
            }
        }

        private void LoadListStudentToShow()
        {
            List<Student> listStudent = new List<Student>();
            for (int i = (IndexPage - 1) * NUMBER_ITEM_TO_SHOW; i <= IndexPage * NUMBER_ITEM_TO_SHOW - 1 && i < Students.Count; i++)
            {
                listStudent.Add(Students[i]);
            }
            ListStudentToShow = new ObservableCollection<Student>(listStudent);
        }

        [RelayCommand]
        private void BackPreviousPage()
        {
            if(IndexPage == 1)
            {
                return;
            }
            IndexPage--;
            LoadListStudentToShow();
        }

        [RelayCommand]
        private void NextPage()
        {
            if (IndexPage == Page)
            {
                return;
            }
            IndexPage++;
            LoadListStudentToShow();
        }
    }
}
