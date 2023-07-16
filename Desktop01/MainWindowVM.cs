using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Desktop01
{
    public  partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public  ObservableCollection<User> users;
        [ObservableProperty]
        public User selectedUser=null;

        [ObservableProperty]
        public ObservableCollection<User2> users2;
        [ObservableProperty]
        public User2 selectedUser2 = null;

        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }




        [RelayCommand]
        public void messeag()
        {

            MessageBox.Show($"{selectedUser.FirstName} GPA VALUE MUST BE BETWEEN 0 AND 4.", "ERROR");
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddUserVM();
            vm.title = "ADD USER";
            AddUserWindow window = new AddUserWindow(vm);
            window.ShowDialog();

            if (vm.Student.FirstName != null)
            {
                users.Add(vm.Student);
            }
        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                users.Remove(selectedUser);
                MessageBox.Show($"{name} is deleted successfully.", "DELETED \a ");
                
            }
            else
            {
                MessageBox.Show("PLEASE SELECT A STUDENT TO DELETE.", "ERROR");


            }
        }
        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                vm.title = "EDIT USER";

               
                var window = new AddUserWindow(vm);
                

                window.ShowDialog();


                int index = users.IndexOf(selectedUser);
                users.RemoveAt(index);
                users.Insert(index, vm.Student);



            }
            else
            {
                MessageBox.Show("PLEASE SELECT A STUDENT", "WARNING!");
            }
        }
            
        public  MainWindowVM()
        {
            users = new ObservableCollection<User>();
            BitmapImage image1 = new BitmapImage(new Uri("/Model/Images/1.png", UriKind.Relative));
            users.Add(new User(24, "Nirasha", "Morais", "23/09/1999",image1,"Computer"," Dr.Chathura Seneviratne",3.2));
            BitmapImage image2 = new BitmapImage(new Uri("/Model/Images/2.png", UriKind.Relative));
            users.Add(new User(25, "Mahesha", "Morais", "23/09/1999",image2,"Civil"," Dr. Kashyapa Madhubashith",3.4));
            BitmapImage image3 = new BitmapImage(new Uri("/Model/Images/3.png", UriKind.Relative));
            users.Add(new User(23, "Praveen", "Shyamal", "22/12/1997", image3, " Electrical","Prof.Liam Sander",2.8));
            BitmapImage image4= new BitmapImage(new Uri("/Model/Images/4.png", UriKind.Relative));
            users.Add(new User(26, "Shaveena", "Miriam", "18/1/2000", image4, "Mechanical"," Mr.Sampath Krandeniya",3.9));

        }
        [RelayCommand]
        public void AddInfo()
        {
            var vm = new MainWindow2VM();
            vm.title2 = "MORE INFORMATION";
            MainWindow2 window = new MainWindow2(vm);
            window.ShowDialog();

            if (vm.Student2.Nationality != null)
            {
                users2.Add(vm.Student2);
            }
        }
    }
}
