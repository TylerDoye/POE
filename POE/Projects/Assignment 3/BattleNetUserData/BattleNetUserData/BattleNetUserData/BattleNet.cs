using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace BattleNetUserData
{
    public partial class frmBattleNet : Form
    {
        string sqlConn = @"Data Source=ZERABANE-PC\SQLEXPRESS;Initial Catalog=BattleNet;Integrated Security=True";
        SqlConnection dbConn;
        

        public frmBattleNet()
        {
            InitializeComponent();

            try
            {

               dbConn = new SqlConnection(sqlConn);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabDiablo.Enabled = false;
            tabStarcraft.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            try
            {
                string sqlUser = @"select * from tblUser where username = '" + txtUsernameSearch.Text + "'";

                SqlCommand sqlCmd = new SqlCommand(sqlUser, dbConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                reader.Read();


                txtUserBattleTag.Text = reader[0].ToString();
                txtUserDiablo.Text = reader[2].ToString();
                txtUserStarcraft.Text = reader[3].ToString();
                txtUserFriendsCount.Text = reader[4].ToString();
                reader.Close();

                if (txtUserDiablo.Text == "True")
                {
                    tabDiablo.Enabled = true;

                    string sqlDiablo = @"select u.username, d.diabloID, d.NumberOfChars ,d.favouriteChar, d.HighestLevel, d.goldAmount, d.clanName from tblDiablo3 d join tblUser u on u.battleTag = d.battleTag where u.username = '" + txtUsernameSearch.Text + "'";

                    SqlCommand sqlDiabloCmd = new SqlCommand(sqlDiablo, dbConn);
                    SqlDataReader readerDiablo = sqlDiabloCmd.ExecuteReader();
                    readerDiablo.Read();

                    txtDiabloUsername.Text = readerDiablo[0].ToString();
                    txtDiabloID.Text = readerDiablo[1].ToString();
                    txtDiabloNumChars.Text = readerDiablo[2].ToString();
                    txtDiabloFavChar.Text = readerDiablo[3].ToString();
                    txtDiabloHighestLevel.Text = readerDiablo[4].ToString();
                    txtDiabloGold.Text = readerDiablo[5].ToString();
                    txtDiabloClanName.Text = readerDiablo[6].ToString();

                    readerDiablo.Close();
                }

                if (txtUserStarcraft.Text == "True")
                {
                    tabStarcraft.Enabled = true;

                    string sqlStarcraft = @"select u.username,s.StarcraftID,s.ExpansionLevel,s.PreferedRace,s.clanName,s.averageApm,s.wins,s.losses from tblStarcraft2 s join tblUser u on u.battleTag = s.BattleTag where u.UserName = '" + txtUsernameSearch.Text + "'";

                    SqlCommand sqlStarcraftCmd = new SqlCommand(sqlStarcraft, dbConn);
                    SqlDataReader readerStarcraft = sqlStarcraftCmd.ExecuteReader();
                    readerStarcraft.Read();

                    txtStarcraftUsername.Text = readerStarcraft[0].ToString();
                    txtStarcraftID.Text = readerStarcraft[1].ToString();
                    txtStarcraftExpansion.Text = readerStarcraft[2].ToString();
                    txtStarcraftRace.Text = readerStarcraft[3].ToString();
                    txtStarcraftClanName.Text = readerStarcraft[4].ToString();
                    txtStacraftAverageapm.Text = readerStarcraft[5].ToString();
                    txtStarcraftWins.Text = readerStarcraft[6].ToString();
                    txtStarcraftLosses.Text = readerStarcraft[7].ToString();

                    readerStarcraft.Close();
                }

            }
            catch (IndexOutOfRangeException ior)
            {
                MessageBox.Show(ior.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex);
            }
            
          

            dbConn.Close();

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
           
            Random tagGen = new Random();
            int newTag = tagGen.Next(0, 9999);
            
            string newBattleTag = txtUsernameSearch.Text + "#" + newTag.ToString();
            string sqlAddUser = "insert Into tblUser(battleTag,Username,diablo3,starcraft2,friendsCount) values ('"+ newBattleTag+"','"+txtUsernameSearch.Text+"','"+"0',"+"'0',"+"'0'"+")";

            SqlCommand sqlCmdAddUser = new SqlCommand(sqlAddUser, dbConn);
           if(MessageBox.Show("Would you like to add a game key?", "Claim Game Key", MessageBoxButtons.YesNo)==DialogResult.Yes)
           {
               MessageBox.Show("Yes clicked");
           }
            else
           {
               MessageBox.Show("No clicked");
           }

            dbConn.Open();

            sqlCmdAddUser.ExecuteNonQuery();

            dbConn.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUsernameSearch.Text;
          
            string sqlDeleteUser = "Delete From tblStarcraft2 where battleTag like '" +username+"%'" + " Delete From tblDiablo3 where battleTag like '" + username+ "%'" + " Delete from tblUser where username = '" + username +"'";
            
            SqlCommand sqlCmdDeleteUser = new SqlCommand(sqlDeleteUser, dbConn);


            dbConn.Open();

            sqlCmdDeleteUser.ExecuteNonQuery();

            dbConn.Close();
        }
    }
}
