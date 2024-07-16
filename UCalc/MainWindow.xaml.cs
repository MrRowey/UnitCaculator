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

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Getting the users Input
            double EnergyCost = Convert.ToDouble(ECostInput.Text);
            double MassCost = Convert.ToDouble(MCostInput.Text);
            double BuildTime = Convert.ToDouble(BTInput.Text);


            string EResult = CaculateEMult(MassCost, EnergyCost);
            string BTResult = CaculateBTMult(MassCost, BuildTime);

            EMultiInput.Text = EResult;
            BTMultiInput.Text = BTResult;

        }
        public static string CaculateEMult(double MassCost, double EnergyCost)
        {
            // Caculate the Energy and Build Time Multipliers

            // Energy Multiplier

            double EMultCalc = EnergyCost / MassCost;

            // Convert to String
            String EMultString = Convert.ToString(Math.Round(EMultCalc, 2));

            return EMultString;
        }

        public static string CaculateBTMult(double MassCost, double BuildTime)
        {
            // Caculate the Energy and Build Time Multipliers

            // Energy Multiplier
            double BTMultCalc = BuildTime / MassCost;

            // Convert to String
            String BTMultString = Convert.ToString(Math.Round(BTMultCalc, 2));

            return BTMultString;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            ECostInput.Text = "";
            MCostInput.Text = "";
            BTInput.Text = "";
            EMultiInput.Text = "";
            BTMultiInput.Text = "";
        }

        public static string CaculateEnergyCost(double NewMassCost, double EnergyMulti)
        {
            // Caculate the Energy and Build Time Multipliers

            // Energy Multiplier

            double ECostCalc = NewMassCost * EnergyMulti;

            // Convert to String
            String ECostString = Convert.ToString(ECostCalc);

            return ECostString;
        }

        public static string CaculateBuilTime(double NewMassCost, double BuildTimeMulti)
        {
            // Caculate the Energy and Build Time Multipliers

            // Energy Multiplier

            double BTCalc = NewMassCost * BuildTimeMulti;

            // Convert to String
            String BTString = Convert.ToString(BTCalc);

            return BTString;
        }

        public static string CaculateEnegyCostDiffrence(double EnergyCost, double NewEnergyCost)
        {
            // Caculate the Energy and Build Time Multipliers

            double AbsolueDiffrence = Math.Abs(EnergyCost - NewEnergyCost);
            double Average = (EnergyCost + NewEnergyCost) / 2;

            double ECostCalc = AbsolueDiffrence / Average / 2;

            double ECostCalcRounded = Math.Round(ECostCalc, 2);
            double ECostPercentage = ECostCalcRounded * 100;

            // Convert to String
            String ECostPercentString = Convert.ToString(ECostPercentage);

            return ECostPercentString;
        }


        private void Button_Recaculate_Click(object sender, RoutedEventArgs e)
        {
            double NewMassCost = Convert.ToDouble(NewMCostInput.Text);
            double NewEnergyMulti = Convert.ToDouble(NewEMultiInput.Text);
            double NewBuildTimeMulti = Convert.ToDouble(BTMultiInput.Text);

            string NewEneryCost = CaculateEnergyCost(NewMassCost, NewEnergyMulti);
            string NewBuilTime = CaculateBuilTime(NewMassCost, NewBuildTimeMulti);
            string MassCost = Convert.ToString(NewMassCost);

            NewUnitStatsBox.Text = "Mass Cost: " + MassCost + "\nEnergy Cost: " + NewEneryCost + "\nBuild Time: " + NewBuilTime;
        }

        private void Button_Recaculate_Clear_Click(object sender, RoutedEventArgs e)
        {
            NewMCostInput.Text = "";
            NewEMultiInput.Text = "";
            NewBTMultiInput.Text = "";
        }
    }
}
