using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Social_Mixy
{
    public partial class Main : Form
    {
        // class scope variables

        // form to handle prize draw
        FormDraw formDraw;
        // stores a list of everyone that has pre-registered to the social mixy
        List<Person> listRegistrants = new List<Person>();
        // stores the number of pre-registrants to the social mixer
        int numRegistrants;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The main method that is executed on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            // creates event handlers for when a file is dragged and dropped onto the form
            this.DragEnter += new DragEventHandler(FormDragEnter);
            this.DragDrop += new DragEventHandler(FormDragDrop);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            // adjusts the width of the list view on resize to match the new parent width
            panelListView.Width = this.Width;
        }

        public void FormDragEnter(object sender, DragEventArgs e)
        {
            // check if the dragged item is a file
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None);
        }

        public void FormDragDrop(object sender, DragEventArgs e)
        {
            // fetch the file path of the dropped file
            string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            // ensures the dropped file is a valid .csv file
            if (Path.GetExtension(filePath).ToLower() == ".csv")
                processFile(filePath);
            else
                MessageBox.Show("Invalid file extension detected! Please ensure the dropped file is of \".csv\" format!");
        }

        public void processFile(string filePath)
        {
            // creates a new list to delete any existing data before processing a new file
            listRegistrants.Clear();
            // stores the number of registrants
            numRegistrants = 0;

            // creates a stream reader to use which is automatically disposed of afterwards
            using (var reader = new StreamReader(filePath))
            {
                // reads the first data to exclue the headings from the csv file
                reader.ReadLine();

                // loop through the data until the end of the stream is reached
                while (!reader.EndOfStream)
                {
                    // splits each data of data by comma
                    string[] data = reader.ReadLine().Split(new string[] { "\",\"" }, StringSplitOptions.None);

                    // check that the data length is valid
                    if (data.Length > 1)
                    {
                        addRegistrant(data);
                    }
                }

                // adds this person to the list view for easy filtering
                updateListview();
            }
        }

        public void addRegistrant(string[] data)
        {
            // increment registerId to track how many people have registered in what order
            numRegistrants++;
            // create a new person object and store it in the list of registered people
            Person p = new Person(data, numRegistrants);
            listRegistrants.Add(p);
        }

        public void updateListview()
        {
            // ensure data is loaded before continuing
            if (listRegistrants is null || listRegistrants.Count < 1)
            {
                Console.WriteLine("Error updating list view, no data was found!");
                return;
            }

            // clear any existing data in the listview
            listViewRegistrants.Items.Clear();

            // iterates through the list of registrants and adds them to the list view
            foreach (Person p in listRegistrants)
            {
                // displays each numRegistrants in the list
                displayRegistrants(p);
            }
        }

        public void displayRegistrants(Person p)
        {
            // creates an item object that can be added to a list view using their registration order number as an id
            ListViewItem item = new ListViewItem(p.numRegistration.ToString());
            // adds the relevant details of each person to each column of the list view
            item.SubItems.Add(p.firstName);
            item.SubItems.Add(p.lastName);
            item.SubItems.Add(p.studentId == -1 ? "N/A" : p.studentId.ToString());
            item.SubItems.Add(p.email);
            item.SubItems.Add(p.isEmailable == true ? "Yes" : "No");
            item.SubItems.Add(p.campus);
            item.SubItems.Add(p.isRideRequiredHamilton == true ? "Yes" : "No");
            item.SubItems.Add(p.isRideRequiredHome == true ? "Yes" : "No");
            item.SubItems.Add(p.studyLevel);
            item.SubItems.Add(p.firstMajor);
            item.SubItems.Add(p.dietaryPrefs);

            // stores the full person object as a tag for later reference to the whole object (in case it's needed)
            item.Tag = p;
            // add this person to the registrants list
            listViewRegistrants.Items.Add(item);
        }

        #region GetMailingList()
        /// <summary>
        /// Copies the e-mail address of all members that wish to receive e-mail reminders to the clipboard
        /// </summary>
        private void buttonEmails_Click(object sender, EventArgs e)
        {
            // return early if there is no data loaded
            if (listRegistrants is null || listRegistrants.Count < 1)
            {
                MessageBox.Show("You must load some data before attempting to do that!");
                return;
            }

            // counts the number of emails added to the clipboard
            int mailingListSize = 0;
            // creates a string to store the mailing list
            string mailingList = "";

            // foreach member in this members list
            foreach (Person p in listRegistrants)
            {
                // if the current member asked to receive emails
                if (p.isEmailable)
                {
                    // adds their email address to the mailing list along with a comma
                    mailingList += p.email + ", ";
                    // increments size counter
                    mailingListSize++;

                } // end if

            } // end foreach

            // removes the comma and whitespace from the end of the string
            mailingList = mailingList.Trim().Remove(mailingList.Length - 2, 1);
            // copies the mailing list to the users clipboard
            Clipboard.SetText(mailingList);
            // informs the user that the mailing list has been copied
            MessageBox.Show($"Successfully copied {mailingListSize}/{listRegistrants.Count} emails from the mailing list to your clipboard!");

        } // end void
        #endregion

        private void buttonStartDraw_Click(object sender, EventArgs e)
        {
            // ensures only one prize form is open at a time
            if (formDraw != null)
                formDraw.Close();

            // creates and displays a new prize form to display prize winners
            formDraw = new FormDraw(listRegistrants);
        }
    }
}
