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
    public partial class Login : Form
    {

        
        
        
        public Login()
        {
            
            InitializeComponent();
           
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] username = new string[3] { "bob", "rob", "nob" };
            string[] password = new string[3] { "bob", "bor", "bon" };

            
                        // if checks the array to see if the textfields match
                     if (username.Contains(txtUserName.Text) && password.Contains(txtPassword.Text))
                        {
                        this.Close();
                        }
                    else if((string.IsNullOrEmpty(txtUserName.Text))||(string.IsNullOrEmpty(txtPassword.Text)))
                         {
                        // if the textboxes are empty it will give an error
                            MessageBox.Show("please enter sonme data in the fields");
                         }
                     else {
                         MessageBox.Show("error the username or password was incorrect try again");
                    }

                }

        private void Login_Load(object sender, EventArgs e)
        {
        
        }

        private void Register_Click(object sender, EventArgs e)
        {

             if((string.IsNullOrEmpty(txtUserName.Text))||(string.IsNullOrEmpty(txtPassword.Text)))
          {
                  // if the textboxes are empty it will give an error
                 MessageBox.Show("please enter some data in the fields");
          }
             else 
             {
                 MessageBox.Show("are you sure you are ok with this username and password");
                     this.Close();
             }
        }
            
         
            
                
        }
    }

