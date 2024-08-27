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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyCultureHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void MainStackPanel_Click(object sender, RoutedEventArgs e)
        {
            // Here you can define what happens when the first StackPanel is clicked
            // For example, you can show a new StackPanel or navigate to another view
            ShowNewStackPanel("DesignFrontEndGUI");
        }

        private void EmployeeSpotlights_Click(object sender, RoutedEventArgs e)
        {
            // Here you can define what happens when the second StackPanel is clicked
            ShowNewStackPanel("EmployeeSpotlights");
        }

        private void ShowNewStackPanel(string panelName)
        {
            // Logic to show a new StackPanel based on the panelName
            // You can create new StackPanels dynamically or make hidden ones visible

            if (panelName == "DesignFrontEndGUI")
            {
                // Show or create the stack panel related to "Design a Front-End GUI"
                MessageBox.Show("Design a Front-End GUI panel clicked");
                // Replace this with the actual logic to show the new panel
            }
            else if (panelName == "EmployeeSpotlights")
            {
                // Show or create the stack panel related to "Employee Spotlights"
                MessageBox.Show("Employee Spotlights panel clicked");
                // Replace this with the actual logic to show the new panel
            }

        }
    }
}
