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

        private void Button100Rabbits_Click(object sender, RoutedEventArgs e)
        {
            string GenerateName()
            {
                string[] firstNameArray = { "Oliver", "George", "Harry", "Jack", "Jacob", "Noah", "Charlie", "Muhammad", "Thomas", "Oscar", "Olivia", "Amelia", "Emily", "Isla", "Ava", "Jessica", "Isabella", "Lily", "Ella", "Mia" };
                string initials = "AAABBBCCCDDDEEEFFFGGGHHIIJJJJJKKKLLLMMMNNNOPPPQRRRSSSTTTUVWWWXYZ";
                string[] lastNameArray = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Wilson", "Anderson", "Taylor" };
                Random random = new System.Random();
                int firstNameNumber = random.Next(0, firstNameArray.Length-1);
                int initialsNumber = random.Next(0, initials.Length - 1);
                int lastNameNumber = random.Next(0, lastNameArray.Length - 1);
                // Console.WriteLine(firstNameArray[firstNameNumber]);
                return firstNameArray[firstNameNumber] + " " + initials[initialsNumber] + ". " + lastNameArray[lastNameNumber];
            }
            // GenerateName();

            for (int i = 0; i < 100; i++)
            {
                var rabbit = new Rabbit();
                rabbit.RabbitName = "Rabbit" + " " + i+1 + " (" + GenerateName() + ")";
                rabbits.Add(rabbit);
            }

            foreach (var rabbit in rabbits)
            {
                ListBox100Rabbits.Items.Add(rabbit.RabbitName); // add string name
            }
        }
    }

    class Rabbit
    {
        public string RabbitName { get; set; }
    }
}
