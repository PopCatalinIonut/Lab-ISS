using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using domain;

namespace ISS_Bugs
{
    public partial class ProgrammerListForm : Form
    {
        public ProgrammerListForm(List<User> programmers)
        {
            InitializeComponent();
            List<string> listItems = null;
            foreach (var el in programmers)
                listItems.Add(el.username);
            var listViewItem = new ListViewItem(listItems.ToArray()); 
            programmersList.Items.Add(listViewItem);
        }
    }
}