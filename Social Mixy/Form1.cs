using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Social_Mixy
{
    public partial class FormDraw : Form
    {
        // stores each registrant involved in this draw
        List<Person> registrants = new List<Person>();
        // stores each prize winner in the order that they are drawn
        string[] arrayWinners = null;
        // keeps track of which prize winner we are up to in the array for forward/backtracking
        int index = -1;

        public FormDraw(List<Person> registrantList)
        {
            InitializeComponent();
            checkData(registrantList);
            loadWinners();
            setText("How to win: \n\n\n1. Only those that pre-registered to this event are eligible to win \n\n2. Those who follow our socials and have completed our bingo have 2x chances of winning a prize \n\n3. It 'is' possible to win more than one prize, but not to win more than that - winners have 1 entry removed from the prize pool once drawn \n\n4. If a WPSA committee members' name is drawn, they cannot win a prize, instead, they must sink a vessel! 👀\n\n\n\nGoodluck!\n\n\n\n- WPSA ❤️");
        }

        private void checkData(List<Person> registrantList)
        {
            if (registrantList == null | registrantList.Count < 1)
            {
                MessageBox.Show("Unable to start a draw... Please ensure data has been loaded first!");
                this.Close();
            }
            else
            {
                registrants = registrantList;
                this.Show();
            }
        }

        private void loadWinners()
        {
            // uses the random class to convert the ordered list into a random array of names
            Random rand = new Random();

            // create a list of people including double entries for those that completed the bingo
            var enhancedList = registrants
            .Select(p => new { Person = p, Duplicate = p.isBingoWinner ? 2 : 1 })
            .SelectMany(p => Enumerable.Repeat($"{p.Person.firstName} {p.Person.lastName}", p.Duplicate))
            .ToList();

            // Shuffle the list
            var random = new Random();
            arrayWinners = enhancedList
                .OrderBy(_ => random.Next())
                .ToArray();

            StringBuilder sB = new StringBuilder();
            // Output randomized names
            foreach (var name in arrayWinners)
            {
                sB.Append(name);
                sB.Append(", ");
            }

            Console.WriteLine(sB.ToString());
        }

        private void FormDraw_KeyDown(object sender, KeyEventArgs e)
        {
            // allows the user to navigate through each winner using hotkeys
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Right)
                index++;
            else if (e.KeyCode == Keys.Left)
                index--;

            drawName();
        }

        private void setText(string text)
        {
            // update the display string to match the passed text
            labelDisplay.Text = text;

        }

        /// <summary>
        /// Displays the next context message from the context array
        /// </summary>
        /// <param name="index"></param>
        private void drawName()
        {
            // ensure the winners array is populated before countinuing
            if (arrayWinners is null)
            {
                Console.WriteLine("Unable to draw a name, arrayWinners was null!");
                return;
            }

            // prevents the user from going out of bounds when back-tracking
            if (index < 0)
                index = 0;

            // displays a message once the end of the winners list has been reached (not necessary)
            if (index > arrayWinners.Length - 1)
                setText("No more entries to display!\n\nCongratulations to the winners! Please see one of the WPSA reps to claim your prize");
            else
                setText(arrayWinners[index]);
        }
    }
}
