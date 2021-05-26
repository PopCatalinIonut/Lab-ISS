using System;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Windows.Forms;
using controllers;
using domain;
using domain.validator;
using LinqToDB.Common;

namespace ISS_Bugs
{
    public partial class TesterForm : Form
    {
        private TesterController testerCtrl;
        public LoginForm loginWin { get; set; }
        public TesterForm(TesterController testerController)
        {
            this.testerCtrl = testerController;
            InitializeComponent();
            initBugList();
        }

        private void initBugList()
        {
            bugListTable.Rows.Clear();
            var elems = testerCtrl.getInsertedBugs();
            foreach (var elem in elems) {
                bugListTable.Rows.Add(elem.name, elem.status, elem.date, elem.id);
            }
        }
        
        private void insertButtonClick(object sender, EventArgs e)
        {
            string name = this.nameTextbox.Text;
            string description = this.descriptionTextbox.Text;
            if (name.IsNullOrEmpty() || description.IsNullOrEmpty())
                MessageBox.Show("Complete all fields!");
            else
            {
                try
                {
                    DateTime date = DateTime.Now;
                    string foundBy = testerCtrl.currentUser;
                    Bug bug = new Bug(name, description, foundBy, date, Status.Unresolved);
                    Bug inserted = testerCtrl.insertBug(bug);
                    bugListTable.Rows.Add(inserted.name, inserted.status,inserted.date,inserted.id);
                }
                catch (ValidationException exc) { MessageBox.Show(exc.Message); } 
                catch (ServerException exc) { MessageBox.Show(exc.Message); }
            }
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            var selected = bugListTable.SelectedRows[0].Cells[3].Value.ToString();
            var elem = Int32.Parse(bugListTable.SelectedRows[0].Cells[3].Value.ToString());
    
            if(testerCtrl.deleteBug(elem)!=0)
            {
                bugListTable.Rows.RemoveAt(bugListTable.SelectedRows[0].Index);
            }
            else  MessageBox.Show("Couldn't remove!");
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            testerCtrl.logout();
            Hide();
            loginWin.Show();
        }
    }
}