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
    public partial class PassportForm : Form
    {

        
        public string GetPreviousSurname()
        {
            string previousSurname = txtPreviousSurname.Text;

            return previousSurname;
        }

        public string GetPlaceOfBirth()
        {
            string placeOfBirth = txtPlaceOfBirth.Text;

            return placeOfBirth;
        }

        //get method will check which radiobutton is selected
        public string GetMaritalStatus()
        {
            string maritalStatus = string.Empty;
            if(rdbDevorced.Checked)
            {
                maritalStatus = "Devorced";
            }
            else if (rdbMarried.Checked)
            {
                maritalStatus = "Married";
            }
            else if (rdbUnmarried.Checked)
            {
                maritalStatus = "Unmarried";
            }
            else if (rdbWidow.Checked)
            {
                maritalStatus = "Widow";
            }
            else if (rdbWidower.Checked)
            {
                maritalStatus = "Widower";
            }

            return maritalStatus;
        }

        public PassportForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //will close after accept is pressed

            this.Close();
           
         
        }
    }
}
