using System.ComponentModel;

namespace ISS_Bugs
{
    partial class TesterForm
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
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.bugListTable = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.bugListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(128, 166);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(125, 52);
            this.descriptionTextbox.TabIndex = 1;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(128, 68);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(125, 23);
            this.nameTextbox.TabIndex = 2;
            // 
            // bugListTable
            // 
            this.bugListTable.AllowUserToAddRows = false;
            this.bugListTable.AllowUserToDeleteRows = false;
            this.bugListTable.AllowUserToResizeRows = false;
            this.bugListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.nameColumn, this.statusColumn, this.dateColumn, this.idColumn});
            this.bugListTable.Location = new System.Drawing.Point(297, 68);
            this.bugListTable.Name = "bugListTable";
            this.bugListTable.ReadOnly = true;
            this.bugListTable.RowHeadersVisible = false;
            this.bugListTable.RowTemplate.Height = 24;
            this.bugListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bugListTable.Size = new System.Drawing.Size(290, 160);
            this.bugListTable.TabIndex = 4;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 90;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Width = 80;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Inserted In";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name: ";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(160, 245);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(93, 33);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButtonClick);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.logoutButton.Location = new System.Drawing.Point(480, 362);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(90, 29);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(424, 254);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 43);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove from list";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(424, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your bugs";
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bugListTable);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.descriptionTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "TesterForm";
            this.Text = "TesterForm";
            ((System.ComponentModel.ISupportInitialize) (this.bugListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label nameLabel;

        private System.Windows.Forms.DataGridView bugListTable;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.TextBox nameTextbox;

        #endregion
    }
}