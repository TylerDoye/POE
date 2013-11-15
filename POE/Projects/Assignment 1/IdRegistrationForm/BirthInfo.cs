using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdRegistrationForm 
{
    class BirthInfo : BasicInfo
    {

        string birthEntryNumber = string.Empty;
        string applicantPostalCode = string.Empty;
        string fatherSurname = string.Empty;
        string fatherForename = string.Empty;
        string motherMaidenName = string.Empty;
        string motherForename = string.Empty;
        string applicantSurname = string.Empty;
        string applicantPostalAddress = string.Empty;
        string applicantForename = string.Empty;

        //constructer that will hold all the variables
        public BirthInfo(string aFirstName, string aSurname, string aDateOfBirth, string aCountryOfBirth,string aGender, string aIdNumber, string aTelNumber, string aWorkNumber,
            string aBirthentryNumber, string aFatherSurname, string aFatherForename, string aMotherMaidenName, string aMotherForename, string aApplicantSurname, string aApplicantForename, string aApplicantPostalAddress, string aApplicantPostalCode)
            : base(aFirstName, aSurname, aDateOfBirth, aCountryOfBirth,aGender, aIdNumber, aTelNumber, aWorkNumber)
        {
            birthEntryNumber = aBirthentryNumber;
            fatherForename = aFatherForename;
            fatherSurname = aFatherSurname;
            motherForename = aMotherForename;
            motherMaidenName = aMotherMaidenName;
            applicantSurname = aApplicantSurname;
            applicantForename = aApplicantForename;
            applicantPostalAddress = aApplicantPostalAddress;
            applicantPostalCode = aApplicantPostalCode;
        }

        public string BirthEntryNumber
        {
            get { return birthEntryNumber; }
            set { birthEntryNumber = value; }
        }
        
        public string FatherSurname
        {
            get { return fatherSurname; }
            set { fatherSurname = value; }
        }

        public string FatherForename
        {
            get { return fatherForename; }
            set { fatherForename = value; }
        }
        
        public string MotherMaidenName
        {
            get { return motherMaidenName; }
            set { motherMaidenName = value; }
        }
       
        public string MotherForename
        {
            get { return motherForename; }
            set { motherForename = value; }
        }
       
        public string ApplicantSurname
        {
            get { return applicantSurname; }
            set { applicantSurname = value; }
        }
        
        public string ApplicantForename
        {
            get { return applicantForename; }
            set { applicantForename = value; }
        }

        public string ApplicantPostalAddress
        {
            get { return applicantPostalAddress; }
            set { applicantPostalAddress = value; }
        }
        
        public string ApplicantPostalCode
        {
            get { return applicantPostalCode; }
            set { applicantPostalCode = value; }
        }

        //overloaded tostring method that will get all the values into one form
        public string ToString()
        {
            return "Particulars of born\n" + "------------------\n" + base.ToString() + "\nbirth entry number: " + birthEntryNumber +"\nParticulars of father\n"+"--------------------"+ "\nfather forename: " + fatherForename + "\nfather surname: " + fatherSurname +  "\nParticulars of mother\n"+"--------------------"+"\nmother forename: " + motherForename + "\nmother maiden name: " + motherMaidenName  +"\nParticulars of applicant\n"+"--------------------"+ "\napplicant surname: " + applicantSurname + "\napplicant forename: " + applicantForename + "\napplicant posal address: " + applicantPostalAddress+ "\napplicant postal code:" + applicantPostalCode ;
        } 
        

    }
}
