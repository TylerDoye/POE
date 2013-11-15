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
    public partial class BirthForm : Form
    {
        //get methods that will be called in basic form to grab the variables
        public string GetBirthNumber()
        {
            return txtBirthEntryNum.Text ;
        }

        public string GetFatherSurname()
        {
            return txtFatherSurname.Text;
        }

        public string GetFatherForename()
        {
            return txtFatherForename.Text;
        }

        public string GetMotherMaidenName()
        {
            return txtMotherMaidenName.Text;
        }

        public string GetMotherForeName()
        {
            return txtMotherForename.Text;
        }

        public string GetApplicantSurname()
        {
            return txtApplicantSurname.Text;
        }

        public string GetApplicantForename()
        {
            return txtApplicantForename.Text;
        }

        public string GetApplicantPostalAddress()
        {
            return txtApplicantPostalAddress.Text;
        }

        public string GetApplicantPostalCode()
        {
            return txtApplicantPostalCode.Text;
        }
     
        public BirthForm()
        {
            InitializeComponent();
        }

        private void BirthForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
