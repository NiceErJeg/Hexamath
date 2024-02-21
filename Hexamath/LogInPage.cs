using QuestionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexamath
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
            textBoxName.Hide();
            buttonAdd.Hide();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            buttonCreateUser.Hide();
            textBoxName.Show();
            buttonAdd.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChooseUser_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedIndex != -1)
            {
                this.Hide();
                MainPage mainPage = new MainPage((User)comboBoxUsers.SelectedItem);
                mainPage.ShowDialog();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
            {
                this.Hide();
                User user = new User();
                user.Name = textBoxName.Text;
                MainPage mainPage = new MainPage(user);
                mainPage.ShowDialog();
            }
        }
    }
}
