using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Desktop01
{
    public partial class AddUserVM : ObservableObject

    {
        
   
        [ObservableProperty]
        public string firstname;


        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string department;

        [ObservableProperty]
        public string academicadvisor;

     

        //To change the tile



        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public BitmapImage selectedImage;

      

        public AddUserVM(User u)
        {
            Student = u;
          
            firstname  = Student.FirstName;
            lastname = Student.LastName;
            age = Student.Age;
            gpa = Student.GPA;
            dateofbirth = Student.DateOfBirth;
            selectedImage=Student.Image;
            department = Student.Department;
            academicadvisor = Student.AcademicAdvisor;



        }
        public AddUserVM()
        {
            
        }


        //get image 
        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(dialog.FileName));
               
                MessageBox.Show("IMAGE IS UPLOADED SUCCESSFULLY!", "SUCCESSFULL");
            }
        }






        public User Student { get; private set; }
        public Action CloseAction { get; internal set; }
        
        [RelayCommand]
        public void Save()
        {
          
            
            
            if (gpa<0 || gpa>4) {
                MessageBox.Show("GPA VALUE MUST BE BETWEEN 0 AND 4.", "ERROR" );
                return;
            }
            if(Student==null)
            {

                Student = new User()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                    DateOfBirth = dateofbirth,
                    Image = selectedImage,
                    GPA = gpa,
                    Department = department,
                    AcademicAdvisor = academicadvisor,

                };


            }
            else
            {
                
                Student.FirstName = firstname;
                Student.LastName = lastname;
                Student.Age = age;
                Student.GPA = gpa;
                Student.Image = selectedImage;
                Student.DateOfBirth = dateofbirth;
                Student.Department = department;
                Student.AcademicAdvisor= academicadvisor;
                
                
                
            }
           
            if(Student.FirstName != null )
            {
                CloseAction();
            }
            Application.Current.MainWindow.Show();

               
            

        }

        [RelayCommand]

        public void CloseAddUserVM()
        {
            if(Student!=null)
            {
                Student = new User()
                {
                    FirstName = null,
                    LastName = null,
                    Age = 0,
                    GPA= 0,
                    Image = null,
                    DateOfBirth = null,
                    Department = null,
                    AcademicAdvisor = null

                   

                };
       
                }
            else
            {
                Student.FirstName = firstname;
                Student.LastName = lastname;
                Student.Age = age;
                Student.GPA = gpa;
                Student.Image = selectedImage;
                Student.DateOfBirth = dateofbirth;
                Student.Department = department;
                Student.AcademicAdvisor = academicadvisor;
            }
            CloseAction();

            Application.Current.MainWindow.Show();
        }
        }
    }

