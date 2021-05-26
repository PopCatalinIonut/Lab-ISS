using System.ComponentModel;

namespace ISS_Bugs
{
    partial class ProgrammerListForm
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
            this.progView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.progView)).BeginInit();
            this.SuspendLayout();
            // 
            // progView
            // 
            this.progView.AllowUserToAddRows = false;
            this.progView.AllowUserToDeleteRows = false;
            this.progView.AllowUserToResizeColumns = false;
            this.progView.AllowUserToResizeRows = false;
            this.progView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.nameColumn});
            this.progView.Location = new System.Drawing.Point(60, -2);
            this.progView.Name = "progView";
            this.progView.RowHeadersVisible = false;
            this.progView.RowTemplate.Height = 24;
            this.progView.Size = new System.Drawing.Size(163, 300);
            this.progView.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 120;
            // 
            // ProgrammerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.progView);
            this.Name = "ProgrammerListForm";
            this.Text = "ProgrammerListForm";
            ((System.ComponentModel.ISupportInitialize) (this.progView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;

        private System.Windows.Forms.DataGridView progView;

        #endregion
    }
}