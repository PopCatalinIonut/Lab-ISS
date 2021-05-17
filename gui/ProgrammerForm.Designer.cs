using System.ComponentModel;

namespace ISS_Bugs
{
    partial class ProgrammerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bugsTable = new System.Windows.Forms.DataGridView();
            this.namecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.markResolvedButton = new System.Windows.Forms.Button();
            this.programmerListButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.bugsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bugsTable
            // 
            this.bugsTable.AllowUserToAddRows = false;
            this.bugsTable.AllowUserToDeleteRows = false;
            this.bugsTable.AllowUserToResizeRows = false;
            this.bugsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.namecolumn, this.descriptionColumn, this.statusColumn, this.insertedBy, this.idColumn});
            this.bugsTable.Location = new System.Drawing.Point(0, 94);
            this.bugsTable.Name = "bugsTable";
            this.bugsTable.RowHeadersVisible = false;
            this.bugsTable.RowTemplate.Height = 24;
            this.bugsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bugsTable.Size = new System.Drawing.Size(459, 290);
            this.bugsTable.TabIndex = 0;
            // 
            // namecolumn
            // 
            this.namecolumn.HeaderText = "Name";
            this.namecolumn.Name = "namecolumn";
            this.namecolumn.Width = 70;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.Width = 120;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Width = 70;
            // 
            // insertedBy
            // 
            this.insertedBy.HeaderText = "Inserted By";
            this.insertedBy.Name = "insertedBy";
            this.insertedBy.Width = 80;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(113, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current bug list";
            // 
            // markResolvedButton
            // 
            this.markResolvedButton.Location = new System.Drawing.Point(167, 410);
            this.markResolvedButton.Name = "markResolvedButton";
            this.markResolvedButton.Size = new System.Drawing.Size(132, 31);
            this.markResolvedButton.TabIndex = 2;
            this.markResolvedButton.Text = "Mark as resolved";
            this.markResolvedButton.UseVisualStyleBackColor = true;
            this.markResolvedButton.Click += new System.EventHandler(this.markResolvedButton_Click);
            // 
            // programmerListButton
            // 
            this.programmerListButton.Location = new System.Drawing.Point(518, 118);
            this.programmerListButton.Name = "programmerListButton";
            this.programmerListButton.Size = new System.Drawing.Size(93, 60);
            this.programmerListButton.TabIndex = 3;
            this.programmerListButton.Text = "View programmer list";
            this.programmerListButton.UseVisualStyleBackColor = true;
            this.programmerListButton.Click += new System.EventHandler(this.programmerListButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(518, 235);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(93, 32);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ProgrammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.programmerListButton);
            this.Controls.Add(this.markResolvedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bugsTable);
            this.Name = "ProgrammerForm";
            this.Text = "ProgrammerForm";
            this.Load += new System.EventHandler(this.ProgrammerForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.bugsTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;

        private System.Windows.Forms.Button markResolvedButton;
        private System.Windows.Forms.Button programmerListButton;
        private System.Windows.Forms.Button logoutButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView bugsTable;

        #endregion
    }
}