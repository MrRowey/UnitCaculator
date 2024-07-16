using System;
using System.Windows;

namespace UCalc
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

        private static string GetEnergyMulti(double MassCost, double EnergyCost)
        {
            // Caculating the Energy Multiplier
            double EMultCalc = EnergyCost / MassCost;

            // Convert to String
            String EMultString = Convert.ToString(Math.Round(EMultCalc, 2));

            // Return the Energy Multiplier
            return EMultString;
        }

        private static string GetBuildTimeMulti(double MassCost, double BuildTime)
        {
            // Caculating the Build Time Multiplier
            double BTMultCalc = BuildTime / MassCost;

            // Convert to String
            String BTMultString = Convert.ToString(Math.Round(BTMultCalc, 2));

            // Return the Build Time Multiplier
            return BTMultString;
        }

        private void Button_Caculate_Mulit_Click(object sender, RoutedEventArgs e)
        {
            // Getting the users Input
            double EnergyCost = Convert.ToDouble(EnergyCostInput.Text);
            double MassCost = Convert.ToDouble(MassCostInput.Text);
            double BuildTime = Convert.ToDouble(BuildTimeCostInput.Text);

            // Caculate the Energy and Build Time Multipliers
            string EResult = GetEnergyMulti(MassCost, EnergyCost);
            string BTResult = GetBuildTimeMulti(MassCost, BuildTime);

            // Display the Results
            MulitResult.Text = "Energy Mulit: " + EResult + "\nBuild Time Multi: " + BTResult;
        }

        private void Button_Clear_Mulitplier_Click(object sender, RoutedEventArgs e)
        {
            MulitResult.Text = "";
        }


        private static string GetEnergyCost(double MassCost, double EnergyMulti)
        {
            // Caculate the Energy and Build Time Multipliers

            double ECostCalc = MassCost * EnergyMulti;

            // Convert to String
            String ECostString = Convert.ToString(ECostCalc);

            return ECostString;
        }

        private static string GetBuildTime(double MassCost, double BuildTimeMulti)
        {
            // Caculate the Energy and Build Time Multipliers

            double BTCalc = MassCost * BuildTimeMulti;

            // Convert to String
            String BTString = Convert.ToString(BTCalc);

            return BTString;
        }

        private void Button_Calculate_Cost_Click(object sender, RoutedEventArgs e)
        {
            // Getting the users Input
            double EnergyMulit = Convert.ToDouble(NewEMultiInput.Text);
            double MassCost = Convert.ToDouble(NewMCostInput.Text);
            double BuildTimeMulit = Convert.ToDouble(NewBTMultiInput.Text);


            string EResult = GetEnergyCost(MassCost, EnergyMulit);
            string BTResult = GetBuildTime(MassCost, BuildTimeMulit);

            NewCostResult.Text = "Mass Cost: " + MassCost + "\nEnergy Cost: " + EResult + "\nBuild Time: " + BTResult;

        }

        private void Button_Clear_Cost_Click(object sender, RoutedEventArgs e)
        {
            NewCostResult.Text = "";
        }
    }
}
