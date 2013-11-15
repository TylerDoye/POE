using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IdRegistrationForm
{
    
    public partial class BasicForm : Form 
    {
        PassportForm passFormObject = new PassportForm();
        BirthForm birthFormObject = new BirthForm();
        DeathForm deathFormObject = new DeathForm();
        Login loginFormObject = new Login();
         
        
      
        public BasicForm()
        {
           
            //makes login show first
            
            
            InitializeComponent();

            cmbRegistration.SelectedIndex = 1;
            
            loginFormObject.ShowDialog();
            
            
        }

        // generate the Id
        public static string GenerateIdNumber(string aDateOfBirth, string aSex, string aCountryOfBirth)
        {
            string idNumber;
            int genderNumber = 0;
            int regionNumber = 1;
            Random rnd = new Random();
            //if statements test radio buttons to  change it to a readable string
            if (aSex.Equals("male"))
            {
                genderNumber = rnd.Next(5000,9999);
            }
            else if (aSex.Equals("female"))
            {
                genderNumber = rnd.Next(1000, 5000);
            }

            //checks if user is from south africa
            if (aCountryOfBirth.Equals("South Africa")||aCountryOfBirth.Equals("south africa"))
            {
                regionNumber = 0;
            }
            idNumber = aDateOfBirth + genderNumber + regionNumber +"8"+"2";

            return idNumber;
        }
              

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            //get the sex of the person
            string sex = string.Empty;
            if (rdbMale.Checked)
            {
                sex = "male";
            }
            else if(rdbFemale.Checked)
            {
                sex = "female";
            }
       //GenerateIdNumber(txtDateOfBirth.Text,sex,txtCountryOfBirth.Text)

            string registraionType = cmbRegistration.Text;

            //iff statement to determine the form opened
            if (registraionType.Equals("Passport"))
            {
                
                passFormObject.ShowDialog();
                //on form open creates object of the info class to get al the information
                PassportInfo passInfo = new PassportInfo(txtName.Text, txtSurname.Text, txtDateOfBirth.Text, txtCountryOfBirth.Text, sex, GenerateIdNumber(txtDateOfBirth.Text, sex, txtCountryOfBirth.Text), txtTelNumber.Text, txtWorkNumber.Text,
                   passFormObject.GetPreviousSurname(), passFormObject.GetPlaceOfBirth(), passFormObject.GetMaritalStatus());
                MessageBox.Show(passInfo.ToString());
            }
            else if (registraionType.Equals("Birth certificate"))
            {
                birthFormObject.ShowDialog();
                BirthInfo birthInfo = new BirthInfo(txtName.Text, txtSurname.Text, txtDateOfBirth.Text, txtCountryOfBirth.Text, sex, GenerateIdNumber(txtDateOfBirth.Text, sex, txtCountryOfBirth.Text), txtTelNumber.Text, txtWorkNumber.Text,
                    birthFormObject.GetBirthNumber(), birthFormObject.GetFatherSurname(), birthFormObject.GetFatherForename(), birthFormObject.GetMotherMaidenName(), birthFormObject.GetMotherForeName(), birthFormObject.GetApplicantSurname(), birthFormObject.GetApplicantForename(), birthFormObject.GetApplicantPostalAddress(), birthFormObject.GetApplicantPostalCode());
                MessageBox.Show(birthInfo.ToString()); 
               
            }
            else if (registraionType.Equals("Death certificate"))
            {
                deathFormObject.ShowDialog();
                DeathInfo deathInfo = new DeathInfo(txtName.Text, txtSurname.Text, txtDateOfBirth.Text, txtCountryOfBirth.Text, sex, GenerateIdNumber(txtDateOfBirth.Text, sex, txtCountryOfBirth.Text), txtTelNumber.Text, txtWorkNumber.Text,
                   deathFormObject.GetDateOfDeath(), deathFormObject.GetDeathEntry(), deathFormObject.GetTownOfDeath(), deathFormObject.GetProvinceOfDeath(), deathFormObject.GetUndertaker(), deathFormObject.GetApplicantSurname(), deathFormObject.GetInitials(), deathFormObject.GetIdNumber(), deathFormObject.GetPostalAddress(), deathFormObject.GetPostalCode(), deathFormObject.GetTelNumber(), deathFormObject.GetResidentialAddress());
                MessageBox.Show(deathInfo.ToString());
            }



            
        }

        private void BasicForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
