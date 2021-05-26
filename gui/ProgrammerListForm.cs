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
            foreach (var el in programmers)
            {
                progView.Rows.Add(el.username);
            }
        }
    }
}