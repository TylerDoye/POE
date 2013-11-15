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
    public partial class DeathForm : Form
    {
        //gets for all the values to populate the toString method
        public string GetDateOfDeath()
        {
            return txtDeathDate.Text;
        }

        public string GetDeathEntry()
        {
            return txtDeathNumber.Text;
        }

         public string GetTownOfDeath()
        {
            return txtCityOfDeath.Text;
        }

         public string GetProvinceOfDeath()
        {
            return txtProvinceOFDeath.Text;
        }

         public string GetUndertaker()
        {
            return txtUndertakerName.Text;
        }
         public string GetApplicantSurname()
        {
            return txtSurname.Text;
        }

         public string GetInitials()
        {
            return txtInitials.Text;
        }

         public string GetIdNumber()
        {
            return txtIdNumber.Text;
        }

         public string GetPostalAddress()
        {
            return txtPostalAddress.Text;
        }

         public string GetPostalCode()
        {
            return txtPostalCode.Text;
        }

         public string GetTelNumber()
        {
            return txtTelNumber.Text;
        }
         public string GetResidentialAddress()
        {
            return txtResidential.Text;
        }

        public DeathForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
