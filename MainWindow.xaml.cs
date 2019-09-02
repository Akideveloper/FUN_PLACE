using System;
using System.Windows;

namespace FIGHT_TEST_ANIMA {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private double health = 100;
        private int exp = 1;
        private int lvl = 1;

        public MainWindow() {

        }

        private void FIGHT_BUTTON_Click(object sender, RoutedEventArgs e) {

            {

                double Damage = 1;
                int playerStrenght = int.Parse(playerstr.Text);
                int weaponPower = int.Parse(weaponpw.Text);
                int maxPower = playerStrenght + weaponPower;
                int superPower = weaponPower + playerStrenght + 2;
                int minPower = weaponPower;

                //// Experience  + lvl function doesn´t work yet because Muffin!
                //int expp = int.Parse(this.EXP.Text);
                //if (expp >= 10) {
                //    lvl = lvl + 1;
                //}
               

                //if (this.health <= 0) {
                //    exp = 1;
                //}
                //if (lvl > 1) {
                //    Damage = Damage + 2;
                //}

                // sepcial Types of Attacks
                if (this.DOPPELSCHLAG.IsChecked == true) {
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
                    this.FIGHT_TEXT.Text = "DANEBEN EY!";
                }
                if (rV < 100) {
                    Damage = (minPower - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";
                }
                if (rV >= 101 && rV < 150) {
                    Damage = (minPower + 2 - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";
                }
                if (rV >= 151 && rV < 200) {
                    Damage = (minPower + 4 - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";
                }
                if (rV >= 200 && rV < 225) {
                    Damage = (minPower + 6 - enemyVer) * Damage;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";
                }

                if (rV >= 225 && rV < 256) {
                    Damage = maxPower * Damage;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden!";
                }

                if (rV >= 256) {
                    Damage = superPower * Damage;
                    this.FIGHT_TEXT.Text = "Du machst " + Damage + " Punkte Schaden! Das ist ein Volltreffer!";
                }

                // Health system of the enemy
                this.health = health - Damage;
                this.HPBOX.Text = "Der Gegner hat noch " + health + " Leben";
                if (health <= 0) {
                    this.HPBOX.Text = "Der Gegner wurde besiegt!" + "Dein Mometanes Level ist: " + lvl ;
                    health = 100;
                }
            
                
            }
        }
    }
}

