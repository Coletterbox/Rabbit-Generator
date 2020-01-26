﻿using System;
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

namespace Rabbits1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        public MainWindow()
        {
            InitializeComponent();
        }

        Random random = new System.Random();

        string GenerateName()
        {
            string[] firstNameArray = { "Oliver", "George", "Harry", "Jack", "Jacob", "Noah", "Charlie", "Muhammad", "Thomas", "Oscar", "Olivia", "Amelia", "Emily", "Isla", "Ava", "Jessica", "Isabella", "Lily", "Ella", "Mia" };
            string initials = "AAABBBCCCDDDEEEFFFGGGHHIIJJJJJKKKLLLMMMNNNOPPPQRRRSSSTTTUVWWWXYZ";
            string[] lastNameArray = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Wilson", "Taylor" };
            // Random random = new System.Random();
            int firstNameNumber = random.Next(0, firstNameArray.Length - 1);
            int initialsNumber = random.Next(0, initials.Length - 1);
            int lastNameNumber = random.Next(0, lastNameArray.Length - 1);
            return firstNameArray[firstNameNumber] + " " + initials[initialsNumber] + ". " + lastNameArray[lastNameNumber];
        }

        private void Button100Rabbits_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                var rabbit = new Rabbit();
                rabbit.RabbitName = "Rabbit" + " " + (i + 1) + " (" + GenerateName() + ")";
                rabbit.isLiving = true;
                rabbit.isZombie = false;
                rabbits.Add(rabbit);
            }

            foreach (var rabbit in rabbits)
            {
                ListBox100Rabbits.Items.Add(rabbit.RabbitName); // add string name
            }
        }

        //int zombieRabbits = 0;

        private void ButtonAgeRabbits100Times_Click(object sender, RoutedEventArgs e)
        {
            foreach (var rabbit in rabbits)
            {
                for (int i = 0; i < 100; i++)
                {
                    rabbit.Age++;
                }
                ListBoxAgeRabbits100Times.Items.Add(rabbit.RabbitName + ", " + rabbit.Age + " years old");
            }

            // every century, there is a wave of zombies
            //Random random = new Random();
            //int newZombieRabbits = random.Next(0, deadRabbits);
            //deadRabbits -= newZombieRabbits;
            //zombieRabbits += newZombieRabbits;
        }

        private void ListBoxAgeRabbits100Times_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        int deadRabbits = 0;
        int liveRabbits = 0;
        public void CountRabbits_Click(object sender, RoutedEventArgs e)
        {
            deadRabbits = 0;
            liveRabbits = 0;
            foreach (var rabbit in rabbits)
            {
                //for (int i = 0; i < rabbits.Count; i++)
                //{
                    if (rabbit.Age > 10)
                    {
                        rabbit.isLiving = false;
                        deadRabbits++;
                    }
                    else
                    {
                        liveRabbits++;
                    }
                //}
            }
            ListBoxCountRabbits.Items.Add("There are " + liveRabbits + " living rabbits.");
            ListBoxCountRabbits.Items.Add("There are " + deadRabbits + " dead rabbits.");
            //ListBoxCountRabbits.Items.Add("There are " + zombieRabbits + " zombie rabbits.");
        }

        private void CountRabbits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ButtonAgeRabbitsOnce_Click(object sender, RoutedEventArgs e)
        {
            foreach (var rabbit in rabbits)
            {
                rabbit.Age++;
                ListBoxAgeRabbitsOnce.Items.Add(rabbit.RabbitName + ", " + rabbit.Age + " years old");
            }
        }

        private void ListBoxAgeRabbitsOnce_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    class Rabbit
    {
        public string RabbitName { get; set; }
        public int Age { get; set; }
        public bool isLiving { get; set; }
        public bool isZombie { get; set; }
    }
}
