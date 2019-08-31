﻿using System;
using System.Windows;

namespace FIGHT_TEST_ANIMA {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private int health = 100;
        public MainWindow() {

        }

        private void FIGHT_BUTTON_Click(object sender, RoutedEventArgs e) {


            {

                int playerStrenght = int.Parse(playerstr.Text);
                int weaponPower = int.Parse(weaponpw.Text);
                int maxPower = playerStrenght + weaponPower;
                int superPower = weaponPower + playerStrenght + 2;
                int minPower = weaponPower;
                int Damage = 1;
                if (this.DOPPELSCHLAG.IsChecked == true) {
                    Damage = Damage * 2;
                }
                Random randownValue = new Random();
                int rV = randownValue.Next(1, 256);
                int acVV = randownValue.Next(0, 1); //bool?
                int accuracy = rV;
                int enemyVer = int.Parse(enemyVERB.Text);
                if (acVV == 0) {
                    accuracy = rV + 10;
                } else {
                    accuracy = rV - 10;
                }
                this.RVSHOW.Text = Convert.ToString(rV);
                if (rV < 51) {
                    Damage = (rV / rV - 1) * Damage;
                    this.FIGHT_TEXT.Text = "DANEBEN EY!";
                } else if (rV < 100) {
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
                    this.FIGHT_TEXT.Text = "Du machst " + maxPower + " Punkte Schaden!";
                }
                if (rV >= 256) {
                    Damage = superPower * Damage;
                    this.FIGHT_TEXT.Text = "Du machst " + superPower + " Punkte Schaden! Das ist ein Volltreffer!";
                }
                this.health = health - Damage;
                this.HPBOX.Text = "Der Gegner hat noch " + health + " Leben";
                if (health <= 0) {
                    this.HPBOX.Text = "Der Gegner wurde besiegt!";
                    health = 100;
                }
            }
        }
    }
}
