namespace BohatecProjekt
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textEmployeeSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewEmployee.FullRowSelect = true;
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(12, 56);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(610, 382);
            this.listViewEmployee.TabIndex = 8;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Id";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Position";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Surname";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Birth Date";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "E-mail";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Phone Num.";
            this.columnHeader8.Width = 80;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(713, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textEmployeeSearch
            // 
            this.textEmployeeSearch.Location = new System.Drawing.Point(127, 19);
            this.textEmployeeSearch.Name = "textEmployeeSearch";
            this.textEmployeeSearch.Size = new System.Drawing.Size(148, 20);
            this.textEmployeeSearch.TabIndex = 14;
            this.textEmployeeSearch.TextChanged += new System.EventHandler(this.textEmployeeSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search for employees";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEmployeeSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.listViewEmployee);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TextBox textEmployeeSearch;
        private System.Windows.Forms.Label label3;
    }
}