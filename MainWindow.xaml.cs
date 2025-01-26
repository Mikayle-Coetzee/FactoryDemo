using FactoryDemo.Classes;
using System.Windows;

namespace FactoryDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// this toggles the visibility of UI panels based on the selected radio button 
        /// (VehicleRadio or HouseholdRadio).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender == VehicleRadio)
            {
                VehiclePanel.Visibility = Visibility.Visible;
                HouseholdPanel.Visibility = Visibility.Collapsed;
                ContentsValueTextBox.Text = string.Empty;
            }
            else if (sender == HouseholdRadio)
            {
                VehiclePanel.Visibility = Visibility.Collapsed;
                HouseholdPanel.Visibility = Visibility.Visible;
                ModelTextBox.Text = string.Empty;
                ColorTextBox.Text = string.Empty;
                YearTextBox.Text = string.Empty;
            }
            ResultTextBlock.Text = string.Empty;
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// This instantiates a policy factory based on the selected radio button, It collects necessary 
        /// parameter then it displays the generated policy details in a text block
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePolicyButton_Click(object sender, RoutedEventArgs e)
        {
            PolicyFactoryAbstractClass policyFactory = null;
            PolicyAbstractClass policy = null;

            if (VehicleRadio.IsChecked == true)
            {
                policyFactory = new VehiclePolicyFactoryClass();
                string model = ModelTextBox.Text;
                string color = ColorTextBox.Text;
                int year;

                if (!string.IsNullOrEmpty(model) && !string.IsNullOrEmpty(color) && 
                    int.TryParse(YearTextBox.Text, out year))
                {
                    policy = policyFactory.CreatePolicy(model, color, year);
                }

            }
            else if (HouseholdRadio.IsChecked == true)
            {
                policyFactory = new HouseholdPolicyFactoryClass();
                if (decimal.TryParse(ContentsValueTextBox.Text, out decimal contentsValue))
                {
                    contentsValue = decimal.Parse(ContentsValueTextBox.Text);
                    policy = policyFactory.CreatePolicy(contentsValue);
                }
                else
                {
                    policy = null;
                }
            }

            if (policy != null)
            {
                ResultTextBlock.Text = policy.GeneratePolicy();
            }
            else
            {
                ResultTextBlock.Text = "Error creating policy.";
            }
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//
