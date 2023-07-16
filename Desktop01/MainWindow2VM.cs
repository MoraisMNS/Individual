using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Desktop01
{
    public partial class MainWindow2VM : ObservableObject
    {
        [ObservableProperty]
        public string nationality;

        [ObservableProperty]
        public string religion;

        [ObservableProperty]
        public string fathersname;

        [ObservableProperty]
        public string mothersname;

        [ObservableProperty]
        public string fathersoccupation;

        [ObservableProperty]
        public string mothersoccupation;

        [ObservableProperty]
        public string title2;
        public MainWindow2VM(User2 w)
        {
            Student2 = w;

            nationality = Student2.Nationality;
            religion = Student2.Religion;
            fathersname = Student2.FathersName;
            mothersname = Student2.MothersName;
            fathersoccupation = Student2.FathersOccupation;
            mothersoccupation = Student2.MothersOccupation;
        }

        public MainWindow2VM()
        {

        }

        public User2 Student2 { get; private set; }
        public Action CloseAction { get; internal set; }
        [RelayCommand]
        public void Save2()
        {
            if (Student2 == null)
            {
                Student2 = new User2();
                {
                    Nationality = nationality;
                    Religion = religion; ;
                    Fathersname = fathersname;
                    Mothersname = mothersname;
                    Fathersoccupation= fathersoccupation;
                    Mothersoccupation = mothersoccupation;
                };

            }
            else
            {
                Student2.Nationality = nationality;
                Student2.Religion = religion;
                Student2.FathersName = fathersname;
                Student2.MothersName = mothersname;
                Student2.FathersOccupation = fathersoccupation;
                Student2.MothersOccupation = mothersoccupation;

            }

            if (Student2.Nationality != null)
            {

                CloseAction();
                MessageBox.Show("THE INFORMATION IS ADDED TO THE SYSTEM SUCCESSFULLY!!");
            }
            // Application.Current.MainWindow.Show();
            
        }
    }
}
