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

namespace FIGHT_TEST_ANIMA
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

           

        }

        private void FIGHT_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            bool Button_Click = true;
            if (Button_Click == true)
            {
                int playerStrenght = 8;
                int weaponPower = 8;
                int playerHealth = 50;
                int maxPower = playerStrenght + weaponPower;
                int minPower = weaponPower;
                int Damage = 0;
                Random randownValue = new Random();
                int rV = randownValue.Next(1, 250);
                this.RVSHOW.Text = Convert.ToString(rV);
                if (rV < 51)
                {
                    Damage = 0;
                    this.FIGHT_TEXT.Text = "DANEBEN EY!";
                }
                if (rV > 51 && rV < 100)

                {
                    Damage = 8;
                    this.FIGHT_TEXT.Text = "Du machst 8 Punkte Schaden";
                }
                if (rV > 101 && rV < 150)
                {
                    Damage = 10;
                    this.FIGHT_TEXT.Text = " Du machst 10 Punkte Schaden";
                }
                if (rV > 151 && rV < 200)
                {
                    Damage = 12;
                    this.FIGHT_TEXT.Text = " Du machst 12 Punkte Schaden";
                }
                if (rV > 201 && rV < 225)
                {
                    Damage = 14;
                    this.FIGHT_TEXT.Text = " Du machst 14 Punkte Schaden";

                }
                if (rV > 226 && rV < 250)
                {
                    Damage = 16;
                   this.FIGHT_TEXT.Text =" Du machst 16 Punkte Schaden";
                }
            }
        }
    }
}
