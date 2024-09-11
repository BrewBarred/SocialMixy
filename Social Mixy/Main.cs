using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Social_Mixy
{
    public partial class Main : Form
    {
        // class scope variables

        // stores a list of everyone that has pre-registered to the social mixy
        List<Person> listRegistrants = new List<Person>();

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
            // stores the number of registrants
            int registerId = 0;

            // creates a stream reader to use which is automatically disposed of afterwards
            using (var reader = new StreamReader(filePath))
            {
                // reads the first line to exclue the headings from the csv file
                reader.ReadLine();

                // loop through the data until the end of the stream is reached
                while (!reader.EndOfStream)
                {
                    // splits each line of data by comma
                    string[] line = reader.ReadLine().Split(new string[] { "\",\"" }, StringSplitOptions.None);

                    // check that the line length is valid
                    if (line.Length > 1)
                    {
                        // increment registerId to track how many people have registered in what order
                        registerId++;
                        // create a new person object to store in the list of registered people
                        Person p = new Person(line, registerId);
                        // adds this person to the list view for easy filtering
                        addToListview(p);
                    }
                }
            }
        }

        public void addToListview(Person p)
        {
            // creates an item object that can be added to a lisat view
            ListViewItem item = new ListViewItem(p.numRegistration.ToString());
            // adds the persons name to this item
            item.SubItems.Add(p.firstName);
            item.SubItems.Add(p.lastName);
            item.SubItems.Add(p.email);
            item.SubItems.Add(p.campus);
            item.SubItems.Add(p.isRideRequiredHamilton.ToString());
            // stores the full person object as a tag for later reference to the whole object
            item.Tag = p;
            listviewRegistrants.Items.Add(item);

        }
    }
}
