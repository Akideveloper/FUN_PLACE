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
        private int health = 50;
        public MainWindow()
        {
           
        }

        private void FIGHT_BUTTON_Click(object sender, RoutedEventArgs e)
        {
          
               
            {
                int playerStrenght = int.Parse(playerstr.Text);
                int weaponPower = int.Parse(weaponpw.Text);
                int maxPower = playerStrenght + weaponPower;
                int superPower = weaponPower + playerStrenght + 2;
                int minPower = weaponPower;
                int Damage = 0;
                Random randownValue = new Random();
                int rV = randownValue.Next(1, 256);
                int acVV = randownValue.Next(0, 1); //bool?
                int accuracy = rV;
                if (acVV == 0)
                {
                    accuracy = rV + 10;              
                }
                else
                {
                    accuracy = rV - 10;
                }
                this.RVSHOW.Text = Convert.ToString(rV);
                if (rV < 51)
                {
                    Damage = rV/rV-1;
                    this.FIGHT_TEXT.Text = "DANEBEN EY!";
                }
                else  if (rV < 100)

                {
                    Damage = minPower;
                    this.FIGHT_TEXT.Text = "Du machst " + minPower + " Punkte Schaden!";
                }
                if (rV >= 101 && rV < 150)
                {
                    Damage = minPower +2;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";
                }
                if (rV >= 151 && rV < 200)
                {
                    Damage = minPower +4;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";
                }
                if (rV >= 200 && rV < 225)
                {
                    Damage = minPower +6;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";

                }
                if (rV >= 225 && rV < 256)
                {
                     Damage = maxPower;
                     this.FIGHT_TEXT.Text = "Du machst " + maxPower + " Punkte Schaden!";
                }
                if (rV >= 256)
                {
                    Damage = superPower;
                    this.FIGHT_TEXT.Text = "Du machst " + superPower + " Punkte Schaden! Das ist ein Volltreffer!";

                }

                this.health = health - Damage;
                this.HPBOX.Text = "Du hast noch " + health + " Leben";  
                if (health <= 0)
                {
                    this.HPBOX.Text = "Der Gegner wurde besiegt!";
                }
            }
        }

   
    }
}
