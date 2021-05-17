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
        private Dictionary<string,UserController> loggedUsers;
        public LoginForm(LoginController ctrl)
        {
            loginCtrl = ctrl;
            loggedUsers = new Dictionary<string,UserController>();
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextbox.Text;
            string password = this.passwordTextbox.Text;
            try
            {
                User user = loginCtrl.login(username, password);
                if (user != null)
                {
                    if (user.position == "Programmer")
                    {
                        ProgrammerController progCtrl = new ProgrammerController(loginCtrl.service);
                        loggedUsers.Add(username, progCtrl);
                        ProgrammerForm progForm = new ProgrammerForm(progCtrl);
                        progForm.loginWin = this;
                        progForm.Show();
                    }
                    else if (user.position == "Tester")
                    {
                        TesterController testerCtrl = new TesterController(loginCtrl.service, user.username);
                        loggedUsers.Add(username, testerCtrl);
                        TesterForm testerForm = new TesterForm(testerCtrl);
                        testerForm.loginWin = this;
                        testerForm.Show();
                    }
                }
            }
            catch (ServiceException exc) { MessageBox.Show(exc.Message); }
        }
    }
}