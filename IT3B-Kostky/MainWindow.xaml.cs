using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace IT3B_Kostky
{
    public partial class MainWindow : Window
    {
        private kostka[] dice;
        private string filePath = "dice_rolls.txt";

        public MainWindow()
        {
            InitializeComponent();
            dice = new kostka[6];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new kostka();
            }
            UpdateDiceTextBlocks();
        }

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var die in dice)
            {
                die.Roll();
            }
            UpdateDiceTextBlocks();
            AppendRollsToFile();
        }

        private void UpdateDiceTextBlocks()
        {
            Dice1TextBlock.Text = dice[0].Value.ToString();
            Dice2TextBlock.Text = dice[1].Value.ToString();
            Dice3TextBlock.Text = dice[2].Value.ToString();
            Dice4TextBlock.Text = dice[3].Value.ToString();
            Dice5TextBlock.Text = dice[4].Value.ToString();
            Dice6TextBlock.Text = dice[5].Value.ToString();
        }

        private void AppendRollsToFile()
        {


            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {dice[0].Value}, {dice[1].Value}, {dice[2].Value}, {dice[3].Value}, {dice[4].Value}, {dice[5].Value}");
            }


        }
    }
}