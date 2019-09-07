using System;
using System.Windows;

namespace FIGHT_TEST_ANIMA {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private double health = 100;

        public MainWindow() {

        }

        private void FIGHT_BUTTON_Click(object sender, RoutedEventArgs e) {

            {

                double Damage = 1;
                int playerStrenght = int.Parse(playerStr.Text);
                int weaponPower = int.Parse(weaponPw.Text);
                int maxPower = playerStrenght + weaponPower;
                int superPower = weaponPower + playerStrenght + 2;
                int minPower = weaponPower;

                // sepcial Types of Attacks
                if (this.doublePunch.IsChecked == true) {
                    Damage = Damage * 2;
                }
                if (this.EFFECTIV.IsChecked == true) {
                    Damage = Damage * 2;
                } else {
                    Damage = 0.5;
                }

                // randown value gets created 
                Random randownValue = new Random();
                int rV = randownValue.Next(1, 256);
                this.RVSHOW.Text = Convert.ToString(rV);

                // accurency gets created
                int acVV = randownValue.Next(0, 1); //bool?
                int accuracy = rV;
                int enemyVer = int.Parse(enemyVERB.Text);

                if (acVV == 0) {
                    accuracy = rV + 10;
                } else {
                    accuracy = rV - 10;
                }
                
                // randown value 
                if (rV < 51) {
                    Damage = (rV / rV - 1) * Damage;
                    this.FIGHT_TEXT.Text = "NO HIT!";
                }
                if (rV < 100) {
                    Damage = (minPower - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "You did " + Damage + " Damage!";
                }
                if (rV >= 101 && rV < 150) {
                    Damage = (minPower + 2 - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "You did " + Damage + " Damage!";
                }
                if (rV >= 151 && rV < 200) {
                    Damage = (minPower + 4 - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "You did " + Damage + " Damage!";
                }
                if (rV >= 200 && rV < 225) {
                    Damage = (minPower + 6 - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "You did " + Damage + " Damage!";
                }

                if (rV >= 225 && rV < 256) {
                    Damage = maxPower * Damage;
                    this.FIGHT_TEXT.Text = "You did  " + Damage + " Damage!";
                }

                if (rV >= 256) {
                    Damage = superPower * Damage;
                    this.FIGHT_TEXT.Text = "You did " + Damage + " Damage! WOW this is max. Damage!";
                }

                // Health system of the enemy double health see in Line 9
                this.health = health - Damage;
                this.HPBOX.Text = "The Enemey has only " + health + " Life left";
                if (health <= 0) {
                    this.HPBOX.Text = "The Enemey got destroyed!";
                    health = 100;
                }
            
                
            }
        }
    }
}

