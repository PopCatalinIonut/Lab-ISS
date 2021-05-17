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
            this.programmersList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // programmersList
            // 
            this.programmersList.Location = new System.Drawing.Point(1, -1);
            this.programmersList.Name = "programmersList";
            this.programmersList.Size = new System.Drawing.Size(278, 241);
            this.programmersList.TabIndex = 0;
            this.programmersList.UseCompatibleStateImageBehavior = false;
            // 
            // ProgrammerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 239);
            this.Controls.Add(this.programmersList);
            this.Name = "ProgrammerListForm";
            this.Text = "ProgrammerListForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView programmersList;

        #endregion
    }
}