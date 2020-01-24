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

        string GenerateName()
        {
            string[] firstNameArray = { "Oliver", "George", "Harry", "Jack", "Jacob", "Noah", "Charlie", "Muhammad", "Thomas", "Oscar", "Olivia", "Amelia", "Emily", "Isla", "Ava", "Jessica", "Isabella", "Lily", "Ella", "Mia" };
            string initials = "AAABBBCCCDDDEEEFFFGGGHHIIJJJJJKKKLLLMMMNNNOPPPQRRRSSSTTTUVWWWXYZ";
            string[] lastNameArray = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Wilson", "Taylor" };
            Random random = new System.Random();
            int firstNameNumber = random.Next(0, firstNameArray.Length - 1);
            int initialsNumber = random.Next(0, initials.Length - 1);
            int lastNameNumber = random.Next(0, lastNameArray.Length - 1);
            return firstNameArray[firstNameNumber] + " " + initials[initialsNumber] + ". " + lastNameArray[lastNameNumber];
        }

        private void Button100Rabbits_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                //string GenerateName()
                //{
                //    string[] firstNameArray = { "Oliver", "George", "Harry", "Jack", "Jacob", "Noah", "Charlie", "Muhammad", "Thomas", "Oscar", "Olivia", "Amelia", "Emily", "Isla", "Ava", "Jessica", "Isabella", "Lily", "Ella", "Mia" };
                //    string initials = "AAABBBCCCDDDEEEFFFGGGHHIIJJJJJKKKLLLMMMNNNOPPPQRRRSSSTTTUVWWWXYZ";
                //    string[] lastNameArray = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Wilson", "Taylor" };
                //    Random random = new System.Random();
                //    int firstNameNumber = random.Next(0, firstNameArray.Length - 1);
                //    int initialsNumber = random.Next(0, initials.Length - 1);
                //    int lastNameNumber = random.Next(0, lastNameArray.Length - 1);
                //    return firstNameArray[firstNameNumber] + " " + initials[initialsNumber] + ". " + lastNameArray[lastNameNumber];
                //}

                var rabbit = new Rabbit();
                rabbit.RabbitName = "Rabbit" + " " + (i + 1) + " (" + GenerateName() + ")";

                //rabbit.RabbitName = "Rabbit" + " " + (i + 1);

                //foreach (var rabbit in rabbits)
                //{
                //    rabbit.RabbitName = "Rabbit" + " " + (i + 1) + " (" + GenerateName() + ")";
                //}
                rabbits.Add(rabbit);
            }

            //for (int i = 0; i < 100; i++)
            //{
            //    foreach (var rabbit in rabbits)
            //    {
            //        rabbit.RabbitName += " (" + GenerateName() + ")";
            //    }
            //}

            foreach (var rabbit in rabbits)
            {
                // rabbit.RabbitName = "Rabbit" + " (" + GenerateName() + ")";
                ListBox100Rabbits.Items.Add(rabbit.RabbitName); // add string name
            }
        }

        private void ButtonAgeRabbits100Times_Click(object sender, RoutedEventArgs e)
        {
            //I don't remember what this was testing
            //for (int i = 0; i < 100; i++)
            //{
            //    var rabbit = new Rabbit();
            //    rabbit.Age = 0;
            //    // rabbit.RabbitName = "Rabbit" + i;
            //    rabbits.Add(rabbit);
            //}

            // for testing purposes
            // ListBoxAgeRabbits100Times.Items.Add("Test:" + " " + " (" + GenerateName() + ")");

            foreach (var rabbit in rabbits)
            {
                for (int i = 0; i < 100; i++)
                {
                    rabbit.Age++;
                }
                ListBoxAgeRabbits100Times.Items.Add(rabbit.RabbitName + ", " + rabbit.Age + " years old");
            }
        }

        private void ListBoxAgeRabbits100Times_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        int deadRabbits = 0;
        int liveRabbits = 0;
        public void CountRabbits_Click(object sender, RoutedEventArgs e)
        {
            foreach (var rabbit in rabbits)
            {
                //for (int i = 0; i < rabbits.Count; i++)
                //{
                    if (rabbit.Age > 10)
                    {
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
        }

        private void CountRabbits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }

    class Rabbit
    {
        public string RabbitName { get; set; }
        public int Age { get; set; }
    }
}
