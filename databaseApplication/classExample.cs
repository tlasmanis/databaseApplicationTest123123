using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseApplication
{
    public partial class classExample : Form
    {
        public classExample()
        {
            InitializeComponent();
        }

        private void classExample_Load(object sender, EventArgs e)
        {
            setup();
        }
        private void setup()
        {
            this.Size = new Size(570, 654); //resizes the form
            panSQL.Location = new Point(12, 12); //moves the sqlpanel in the same position as the other panel
            panSQL.Visible = false; //hides the sql panel

            //sets the text for every textbox
            tbCreateName.Text = "Enter name";
            tbCreateNameOnly.Text = "Enter name";
            tbCreatePostcode.Text = "Enter postcode";
            tbReadName.Text = "Name to search";
            tbDatabase.Text = "Database address";
            tbDatabaseName.Text = "DB Name";
            tbPassword.Text = "DB user password";
            tbUsername.Text = "DB user name";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            tbPassword.Text = "";
        } 

        private void tbDatabase_MouseDown(object sender, MouseEventArgs e)
        {
            tbDatabase.Text = "";
        }

        private void tbDatabaseName_Enter(object sender, EventArgs e)
        {
            tbDatabaseName.Text = "";
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            tbUsername.Text = "";
        }
    }
}
