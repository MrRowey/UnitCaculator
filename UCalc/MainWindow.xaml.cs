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

namespace UCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Declaring the variables
        int MassCost;
        int NewMassCost;
        int EnergyMulti;
        int BuildTimeMulti;
        int EnergyCost;
        int BuildTime;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Getting the users Input
            EnergyCost = Convert.ToInt32(ECostInput.Text);
            MassCost = Convert.ToInt32(MCostInput.Text);
            BuildTime = Convert.ToInt32(BTCostInput.Text);

            string EResult = CaculateEMult(MassCost, EnergyCost);
            string BTResult = CaculateBTMult(MassCost, BuildTime);

            EMultiResult.Text = EResult;
            BTMultiResult.Text = BTResult;

        }
        public static string CaculateEMult(int MassCost, int EnergyCost)
        {
            // Caculate the Energy and Build Time Multipliers

            // Local Varables
            double EMultCalc;

            // Energy Multiplier

            EMultCalc = EnergyCost / MassCost;

            // Convert to String
            String EMultString = Convert.ToString(Math.Round(EMultCalc, 2));

            return EMultString;
        }

        public static string CaculateBTMult(int MassCost, int BuildTime)
        {
            // Caculate the Energy and Build Time Multipliers

            // Local Varables
            double BTMultCalc;

            // Energy Multiplier

            BTMultCalc = BuildTime / MassCost;

            // Convert to String
            String BTMultString = Convert.ToString(Math.Round(BTMultCalc, 2));

            return BTMultString;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            ECostInput.Text = "";
            MCostInput.Text = "";
            BTCostInput.Text = "";
            EMultiResult.Text = "";
            BTMultiResult.Text = "";
        }

        private void Button_Calculate2_Click(object sender, RoutedEventArgs e)
        {
            NewMassCost = Convert.ToInt32(NewMCostInput.Text);
            EnergyMulti = Convert.ToInt32(NewEMultiInput.Text);
            BuildTimeMulti = Convert.ToInt32(NewBTMultiInput.Text);

            string NewEneryCost = CaculateEnergyCost(NewMassCost, EnergyMulti);
            string NewBuilTime = CaculateBuilTime(NewMassCost, BuildTimeMulti);

            ECostResult.Text = NewEneryCost;
            BTCostResult.Text = NewBuilTime;
        }

        public static string CaculateEnergyCost(int NewMassCost, int EnergyMulti)
        {
            // Caculate the Energy and Build Time Multipliers

            // Local Varables
            int ECostCalc;

            // Energy Multiplier

            ECostCalc = NewMassCost * EnergyMulti;

            // Convert to String
            String ECostString = Convert.ToString(ECostCalc);

            return ECostString;
        }

        public static string CaculateBuilTime(int NewMassCost, int BuildTimeMulti)
        {
            // Caculate the Energy and Build Time Multipliers

            // Local Varables
            int BTCalc;

            // Energy Multiplier

            BTCalc = NewMassCost * BuildTimeMulti;

            // Convert to String
            String BTString = Convert.ToString(BTCalc);

            return BTString;
        }

        private void Button_Clear2_Click(object sender, RoutedEventArgs e)
        {
            NewMCostInput.Text = "";
            NewEMultiInput.Text = "";
            NewBTMultiInput.Text = "";
            ECostResult.Text = "";
            BTCostResult.Text = "";
        }
    }
}
