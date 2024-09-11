using System.Collections.Generic;
using System.Windows.Forms;

namespace Social_Mixy
{
    public partial class FormDraw : Form
    {
        // stores each registrant involved in this draw
        List<Person> registrants = new List<Person>();
        // keeps track of the current position in the array to allow forward/back tracking between names
        int index = 0;
        // stores each context string to be displayed on load and between each prize winners name for context and dramatic effect
        string[] contextArray = { "Ready to draw...", "test1", "test2" };

        public FormDraw(List<Person> registrantList)
        {
            InitializeComponent();
            checkData(registrantList);
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

        private void FormDraw_KeyDown(object sender, KeyEventArgs e)
        {
            // allows the user to navigate through each winner using hotkeys
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Right)
                index++;
            else if (e.KeyCode == Keys.Left)
                index--;

            setContext();
        }

        private void labelDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                index++;

            setContext();
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
        private void setContext()
        {
            // ensure the index cannot throw an out of bounds error
            if (index < 0)
                index = 0;
            else if (index > contextArray.Length - 1)
                index = contextArray.Length - 1;

            labelDisplay.Text = contextArray[index];
        }
    }
}
