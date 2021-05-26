using System;
using System.Collections.Generic;
using System.Windows.Forms;
using controllers;
using domain;
using service;

namespace ISS_Bugs
{
    public partial class LoginForm : Form
    {
        private LoginController loginCtrl;
        public LoginForm(LoginController ctrl)
        {
            loginCtrl = ctrl;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
           if (username.Equals("") || password.Equals(""))
                MessageBox.Show("Complete all fields!");
            else{
                try
                {
                    User user = loginCtrl.login(username, password);
                    if (user != null)
                    {
                        usernameTextbox.Text = "";
                        passwordTextbox.Text = "";
                        Hide();
                        if (user.position == "Programmer")
                        {
                            ProgrammerController progCtrl = new ProgrammerController(loginCtrl.appService, user.username);
                            ProgrammerForm progForm = new ProgrammerForm(progCtrl);
                            progForm.loginWin = this;
                            progForm.Show();
                        }
                        else if (user.position == "Tester")
                        {
                            TesterController testerCtrl = new TesterController(loginCtrl.appService, user.username);
                            TesterForm testerForm = new TesterForm(testerCtrl);
                            testerForm.loginWin = this;
                            testerForm.Show();
                        }
                    }
                }
                catch (ServiceException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}