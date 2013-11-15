using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdRegistrationForm
{
    class BasicInfo
    {
        string firstName = string.Empty;
        string surname = string.Empty;
        string dateOfBirth = string.Empty;
        string countryOfBirth = string.Empty;
        string gender = string.Empty;
        string idNumber = string.Empty;
        string telNumber = string.Empty;
        string workNumber = string.Empty;


      

        public BasicInfo(string aFirstName, string aSurname , string aDateOfBirth, string aCountryOfBirth,string aGender, string aIdNumber,string aTelNumber,string aWorkNumber )
        {
            firstName=aFirstName;
            surname= aSurname;
            dateOfBirth= aDateOfBirth;
            countryOfBirth= aCountryOfBirth;
            gender = aGender;
            idNumber= aIdNumber;
            telNumber= aTelNumber;
            workNumber = aWorkNumber;
             
        }
        

        public string TelNumber
        {
            get { return telNumber; }
            set { telNumber = value; }
        }


        public string WorkNumber
        {
            get { return workNumber; }
            set { workNumber = value; }
        }

        public string CountryOfBirth
        {
            get { return countryOfBirth; }
            set { countryOfBirth = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        //overloaded to string to get all the values into one form
       public override string ToString()
        {
            return "firstname: " + firstName + "\nsurname: " + surname + "\ndate of birth: " + dateOfBirth + "\ncountry of birth: " + countryOfBirth + "\nsex: " + gender + " \nID number: " + idNumber + "\nTel number: " + telNumber + "\nworkNumber: " + workNumber;

        }
    }
}
