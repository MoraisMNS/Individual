using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop01
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        

        public MainWindow2(MainWindow2VM vm)
        {

            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();

        }
        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"THE NATIONALITY IS :{this.NationalityText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.ArtCheckbox.IsChecked = this.DancingCheckbox.IsChecked = this.MusicCheckbox.IsChecked = this.CraftCheckbox.IsChecked = this.PoetryCheckbox.IsChecked = this.DramaCheckbox.IsChecked = this.DebatingCheckbox.IsChecked = this.SpeakingCheckbox.IsChecked = this.LitreatureCheckbox.IsChecked = this.DesigningCheckbox.IsChecked = false;
           
        }

        private void ResetButton_Click2(Object sender,RoutedEventArgs e)
        {
            this.CricketCheckbox.IsChecked = this.FootballCheckbox.IsChecked = this.BasketballCheckbox.IsChecked = this.SwimmingCheckbox.IsChecked = this.BaseballCheckbox.IsChecked = this.ElleCheckbox.IsChecked = this.TennisCheckbox.IsChecked = this.TableTennisCheckbox.IsChecked = this.KarateCheckbox.IsChecked = this.ChessCheckbox.IsChecked = false;
        }
        // when we enter reset, the marked one will be reset.


        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.IdentifiedSkillsText.Text += (string)((CheckBox)sender).Content; // when we tick items it helps to add those otems in the length1 part
        }

        private void Checkbox_Checked2(object sender, RoutedEventArgs e)
        {
            this.IdentifiedSportsSkillsText.Text += (string)((CheckBox)sender).Content; // when we tick items it helps to add those otems in the length2 part
        }

        private void SpecialNeedDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.NoteText.Text = (string)value.Content;
        }

        private void FathersNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.GuardianText.Text = this.FathersNameText.Text;
        }

       private void MothersNameText_TextChanged(Object sender, TextChangedEventArgs e)
        {
            this.Guardian2Text.Text = this.MothersNameText.Text;
        }

        
    }
}
