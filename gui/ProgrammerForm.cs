using System;
using System.Collections.Generic;
using System.Windows.Forms;
using controllers;
using domain;

namespace ISS_Bugs
{
    public partial class ProgrammerForm : Form
    {
        private ProgrammerController progCtrl;
        public LoginForm loginWin { get; set; }
        public ProgrammerForm(ProgrammerController programmerController)
        {
            progCtrl = programmerController;
            InitializeComponent();
            initBugList();
        }

        private void ProgrammerForm_Load(object sender, EventArgs e)
        {
            this.Show();
        }
        private void initBugList()
        {
            bugsTable.Rows.Clear();
            var elems = progCtrl.getBugs();
            foreach (var elem in elems) {
                bugsTable.Rows.Add(elem.name,elem.description, elem.status, elem.foundBy, elem.id);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            progCtrl.logout();
            this.Hide();
            loginWin.Show();
        }

        private void markResolvedButton_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(bugsTable.SelectedRows[0].Cells[4].Value.ToString());
            progCtrl.updateBugStatus(id,Status.Resolved);
            initBugList();
        }

        private void programmerListButton_Click(object sender, EventArgs e)
        {
            List<User> programmersList = progCtrl.getAllProgrammers();
            ProgrammerListForm progForm = new ProgrammerListForm(programmersList);
            progForm.Show();
        }
    }
}