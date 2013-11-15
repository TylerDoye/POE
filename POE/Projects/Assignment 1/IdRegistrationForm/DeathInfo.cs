using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdRegistrationForm
{
    class DeathInfo :BasicInfo
    {
        
        string dateOfDeath = string.Empty;
        string deathEntryNumber = string.Empty;
        string townCityOfDeath = string.Empty;
        string provinceOfDeath = string.Empty;
        string nameOfUndertaker = string.Empty;
        string applicantSurname = string.Empty;
        string applicantInitials = string.Empty;
        string applicantIdNumber = string.Empty;
        string applicantPostalAddress = string.Empty;
        string applicantPostalCode = string.Empty;
        string applicantTelNumber = string.Empty;
        string applicantResidentialAddress = string.Empty;


        //overloaded constructer to hold all the information for passport form
        public DeathInfo(string aFirstName, string aSurname, string aDateOfBirth, string aCountryOfBirth, string aGender, string aIdNumber, string aTelNumber, string aWorkNumber,
           string aDateOfDeath ,string aDeathEntryNumber,string aTownCityOfDeath,string aProvinceOfDeath,string aNameOfUndertaker,string aApplicantSurname ,string aApplicantInitials ,
           string aApplicantIdNumber,string aApplicantPostalAddress ,string aApplicantPostalCode,string aApplicantTelNumber ,string aApplicantResidentialAddress)
            : base(aFirstName, aSurname, aDateOfBirth, aCountryOfBirth, aGender, aIdNumber, aTelNumber, aWorkNumber)
        {
            dateOfDeath = aDateOfDeath;
            deathEntryNumber = aDeathEntryNumber;
            townCityOfDeath = aTownCityOfDeath;
            provinceOfDeath = aProvinceOfDeath;
            nameOfUndertaker = aNameOfUndertaker;
            applicantSurname = aApplicantSurname;
            applicantInitials = aApplicantInitials;
            applicantIdNumber = aApplicantIdNumber;
            applicantPostalAddress = aApplicantPostalAddress;
            applicantPostalCode = aApplicantPostalCode;
            applicantTelNumber = aApplicantTelNumber;
            applicantResidentialAddress = aApplicantResidentialAddress;

        }

        public string DateOfDeath
        {
            get { return dateOfDeath; }
            set { dateOfDeath = value; }
        }

        public string DeathEntryNumber
        {
            get { return deathEntryNumber; }
            set { deathEntryNumber = value; }
        }

        public string TownCityOfDeath
        {
            get { return townCityOfDeath; }
            set { townCityOfDeath = value; }
        }

        public string ProvinceOfDeath
        {
            get { return provinceOfDeath; }
            set { provinceOfDeath = value; }
        }

        public string NameOfUndertaker
        {
            get { return nameOfUndertaker; }
            set { nameOfUndertaker = value; }
        }

        public string ApplicantSurname
        {
            get { return applicantSurname; }
            set { applicantSurname = value; }
        }

        public string ApplicantInitials
        {
            get { return applicantInitials; }
            set { applicantInitials = value; }
        }

        public string ApplicantIdNumber
        {
            get { return applicantIdNumber; }
            set { applicantIdNumber = value; }
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

        public string ApplicantTelNumber
        {
            get { return applicantTelNumber; }
            set { applicantTelNumber = value; }
        }

        public string ApplicantResidentialAddress
        {
            get { return applicantResidentialAddress; }
            set { applicantResidentialAddress = value; }
        }
        //overloaded toString() to get all the values printed
        public string ToString()
        {
            return "Particulars of the deceased\n"+"-------------------------\n" + base.ToString() + "\ndate of death: " + dateOfDeath + "\ndeath entry number: " + deathEntryNumber + "\ntown or city of death: " + townCityOfDeath + "\nprovince of death: " + provinceOfDeath + "\nname of undertaker: " + nameOfUndertaker + "\n\n Partuclars of applicant \n" +"-----------------------"+ "\nSurname: " + applicantSurname + "\nInitials: " + applicantInitials + "\nID number: " + applicantIdNumber + "\npostalAddress: " + applicantPostalAddress + "\npostalCode: " + applicantPostalCode + "\ntel number: " + applicantTelNumber + "\nResidentail Address: " + applicantResidentialAddress;
        }

    }
}
