using System;
using System.Text;

namespace Social_Mixy
{
    public class Person
    {
        // the registration number of this person (1 = first person to register, 2 = second...)
        public int numRegistration;
        // the date that this person registered for the event
        public string date;
        // the campus that this person typically attends
        public string campus;
        // true if this person requires a ride from TGA to Ham and back, else false
        public bool isRideRequiredHamilton;
        // true if this person requires a ride home from TGA, else false
        public bool isRideRequiredHome;
        // true if this person is willing to carpool other students, else false
        public bool isCarpoolFriendly;
        // true if this person has accepted our disclaimer notice, else false
        public bool isAcceptingDisclaimer;
        // the number of passengers that this person can carpool
        public string passengerLimit;
        // the association between this person and the university (i.e., Student, Staff or Alumni)
        public string associationType;
        // the first name of this person
        public string firstName;
        // the last name of this person
        public string lastName;
        // the student id of this person
        public int studentId;
        // the level of study of this person (i.e., 1st year, 2nd year, masters etc.,)
        public string studyLevel;
        // the first major of this person
        public string firstMajor;
        // the email address of this person
        public string email;
        // the field of psychology that this person specializes in (staff and alumni only)
        public string specialization;
        // true if this person would like to volunteer to be a panellist, else false
        public bool isVolunteering;
        // true if this person has any dietary preferences, else false
        public bool hasDietaryPrefs;
        // a string denoting the dietary preferences of this person
        public string dietaryPrefs;
        // true if this person would like to receive an update via email
        public bool isEmailable;
        // true if this person completed the bingo activity, else false
        public bool isBingoWinner;
        // extra notes provided by this person
        public string notes;

        public Person(string[] data, int id)
        {
            numRegistration = id;
            setAttributes(data);
            // test print
            printAttributes();
        }
        private void setAttributes(string[] data)
        {
            // sets this persons attributes based on the information passed on construction
            date = data[0].Substring(1, 11).ToString();
            campus = data[1];
            isRideRequiredHamilton = data[2].Contains("Yes");
            isRideRequiredHome = data[3].Contains("Yes");
            isCarpoolFriendly = data[4].Contains("Yeah");
            isAcceptingDisclaimer = data[5].Contains("Yeah");
            passengerLimit = data[6] == "" ? "N/A" : data[6];
            firstName = data[8] == "" ? (data[14] == "" ? data[20] : data[14]) : data[8];
            lastName = data[9] == "" ? (data[15] == "" ? data[21] : data[15]) : data[9];
            studentId = data[10] != "" ? int.Parse(data[10]) : -1;
            studyLevel = data[11] == "" ? null : data[11];
            firstMajor = data[12] == "" ? (data[16] == "" ? null : data[16]) : data[12];
            email = data[13] == "" ? (data[17] == "" ? data[23] : data[17]) : data[13];
            specialization = data[18] == "" ? (data[23] == "" ? null : data[23]) : data[18];
            isVolunteering = data[19] == "No" ? (data[24] == "No" ? false : true) : true;
            hasDietaryPrefs = data[25] == "Yes" ? true : false;
            dietaryPrefs = hasDietaryPrefs == false ? "N/A" : data[26];
            isEmailable = data[27].Contains("Yes");
            isBingoWinner = false;
            notes = data[28];
        }

        public void printAttributes()
        {
            StringBuilder str = new StringBuilder($"Reigstration No: {numRegistration.ToString()} \n");
            str.AppendLine("First Name: " + firstName);
            str.AppendLine("Last Name: " + lastName);
            str.AppendLine("Student Id: " + (studentId == -1 ? "N/A" : studentId.ToString()));
            str.AppendLine("Email: " + email);
            str.AppendLine("Campus: " + campus);
            str.AppendLine("Level of study: " + studyLevel);
            str.AppendLine("First Major: " + firstMajor);
            str.AppendLine("Shuttle required? " + isRideRequiredHamilton);
            str.AppendLine("Ride home required? " + isRideRequiredHome);
            str.AppendLine("Carpool Friendly? " + isCarpoolFriendly);
            str.AppendLine("Approved disclaimer? " + isAcceptingDisclaimer);
            str.AppendLine("Passenger limit: " + passengerLimit);
            str.AppendLine("Registration Date: " + date);
            str.Append("");
            str.Append("/////////////////////////////////////////");

            Console.WriteLine(str);
        }

    }
}
