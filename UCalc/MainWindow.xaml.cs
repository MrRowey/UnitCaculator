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

        #region Multiplier Caculation

        private double GetEnergyMulti(double MassCost, double EnergyCost)
        {
            // Caculating the Energy Multiplier
            double EnergyMultiCaculation = EnergyCost / MassCost;

            // Round to 2 decimal places
            double EnergyMulti = Math.Round(EnergyMultiCaculation, 2);

            // Return the Energy Multiplier
            return EnergyMulti;
        }

        private double GetBuildTimeMulti(double MassCost, double BuildTime)
        {
            // Caculating the Build Time Multiplier
            double BuildTimeCaculation = BuildTime / MassCost;

            // Round to 2 decimal places
            double BuildTimeMulti = Math.Round(BuildTimeCaculation, 2);

            // Return the Build Time Multiplier
            return BuildTimeMulti;
        }

        private void Button_Caculate_Mulit_Click(object sender, RoutedEventArgs e)
        {
            // Getting the users Input
            double EnergyCost = Convert.ToDouble(EnergyCostInput.Text);
            double MassCost = Convert.ToDouble(MassCostInput.Text);
            double BuildTime = Convert.ToDouble(BuildTimeCostInput.Text);

            // Caculate the Energy and Build Time Multipliers
            double EnergyMultiResult = GetEnergyMulti(MassCost, EnergyCost);
            double BuildTimeMultiResult = GetBuildTimeMulti(MassCost, BuildTime);

            // Display the Results
            MulitResult.Text = "Energy Mulit: " + EnergyMultiResult + "\nBuild Time Multi: " + BuildTimeMultiResult;
        }

        private void Button_Clear_Mulitplier_Click(object sender, RoutedEventArgs e)
        {
            MulitResult.Text = "";
        }

        #endregion

        #region New Cost Caculation

        private double GetEnergyCost(double MassCost, double EnergyMulti)
        {
            // Caculate the Energy Cost
            double EnergyCostCaculation = MassCost * EnergyMulti;

            // Round to 2 decimal places
            double EnergyCost = Math.Round(EnergyCostCaculation, 2);
            
            // Return the Energy Cost
            return EnergyCost;
        }

        private double GetBuildTime(double MassCost, double BuildTimeMulti)
        {
            // Caculate the Build Time
            double BuildTimeCaculation = MassCost * BuildTimeMulti;

            // Round to 2 decimal places
            double BuildTime = Math.Round(BuildTimeCaculation, 2);

            // Return the Build Time
            return BuildTime;
        }

        private string CaculatePercentDiffrence(double OldValue, double NewValue)
        {
            double Increese = NewValue - OldValue;
            double result = (Increese / OldValue) * 100;

            if (result < 0)
            {
                return Convert.ToString(Math.Round(result, 2)) + "%";
            }
            else
            {
                return "+" + Convert.ToString(Math.Round(result, 2)) + "%";
            }
        }


        private void Button_Calculate_Cost_Click(object sender, RoutedEventArgs e)
        {
            double MassCost = Convert.ToDouble(MassCostInput.Text);
            double EnergyCost = Convert.ToDouble(EnergyCostInput.Text);
            double BuildTime = Convert.ToDouble(BuildTimeCostInput.Text);
            double NewMassCost = Convert.ToDouble(NewMCostInput.Text);
            double NewEnergyMulti = Convert.ToDouble(NewEMultiInput.Text);
            double NewBuildTimeMulti = Convert.ToDouble(NewBTMultiInput.Text);

            // Getting the users Input
            double EnergyResult = GetEnergyCost(MassCost, NewEnergyMulti);
            double BuildTimeResult = GetBuildTime(MassCost, NewBuildTimeMulti);

            string EnergyPercent = CaculatePercentDiffrence(EnergyCost, EnergyResult);
            string BuildTimePercent = CaculatePercentDiffrence(BuildTime, BuildTimeResult);
            string MassPercent = CaculatePercentDiffrence(MassCost, NewMassCost);

            NewCostResult.Text = "Mass Cost: " + NewMassCost + " ( "+ MassPercent +")" + "\nEnergy Cost: " + EnergyResult + " ( "+ EnergyPercent + ")"+ "\nBuild Time: " + BuildTimeResult + " (" + BuildTimePercent + ")";

        }

        private void Button_Clear_Cost_Click(object sender, RoutedEventArgs e)
        {
            NewCostResult.Text = "";
        }

        #endregion





    }
}