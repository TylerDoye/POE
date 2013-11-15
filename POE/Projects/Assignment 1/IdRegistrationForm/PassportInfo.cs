using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdRegistrationForm
{
    class PassportInfo : BasicInfo 
    {
        string previousSurname = string.Empty;
        string placeOfBirth = string.Empty;
        string maritalStatus = string.Empty;
 
        //overloaded constructer for the passport
        public PassportInfo(string aFirstName, string aSurname, string aDateOfBirth, string aCountryOfBirth,string  aGender, string aIdNumber, string aTelNumber, string aWorkNumber,string aPreviousSurname,string aPlaceOfBirth,string aMaritalStatus)
            : base(aFirstName, aSurname, aDateOfBirth, aCountryOfBirth, aGender, aIdNumber, aTelNumber, aWorkNumber)
        {
            previousSurname = aPreviousSurname;
            placeOfBirth = aPlaceOfBirth;
            maritalStatus = aMaritalStatus;

        }

        public string PreviousSurname
        {
            get { return previousSurname; }
            set { previousSurname = value; }
        }


        public string PlaceOfBirth
        {
            get { return placeOfBirth; }
            set { placeOfBirth = value; }
        }


        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }
        //tostring method concatanating all the fields into useful imformation
        public string ToString()
        {
            return "Particulars of applicant\n"+"-------------------"+base.ToString() +"\nprevious surname: "+ previousSurname +"\nplace of birth: "+ placeOfBirth +"\nMarital status: " + maritalStatus;
        }

    }
}
