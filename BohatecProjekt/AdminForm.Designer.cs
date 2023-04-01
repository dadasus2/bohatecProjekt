namespace BohatecProjekt
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.textEmployeeSearch = new System.Windows.Forms.TextBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEmpAdd = new System.Windows.Forms.Button();
            this.buttonEmpDelete = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search for users";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textUserSearch
            // 
            this.textUserSearch.Location = new System.Drawing.Point(105, 61);
            this.textUserSearch.Name = "textUserSearch";
            this.textUserSearch.Size = new System.Drawing.Size(121, 20);
            this.textUserSearch.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 324);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "role";
            this.columnHeader2.Width = 80;
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(227, 96);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonUserAdd.TabIndex = 4;
            this.buttonUserAdd.Text = "Add";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Location = new System.Drawing.Point(227, 125);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonUserDelete.TabIndex = 5;
            this.buttonUserDelete.Text = "Delete";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search for employees";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(369, 96);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(408, 324);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // textEmployeeSearch
            // 
            this.textEmployeeSearch.Location = new System.Drawing.Point(629, 61);
            this.textEmployeeSearch.Name = "textEmployeeSearch";
            this.textEmployeeSearch.Size = new System.Drawing.Size(148, 20);
            this.textEmployeeSearch.TabIndex = 8;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id";
            this.columnHeader3.Width = 30;
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
            // buttonEmpAdd
            // 
            this.buttonEmpAdd.Location = new System.Drawing.Point(294, 397);
            this.buttonEmpAdd.Name = "buttonEmpAdd";
            this.buttonEmpAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpAdd.TabIndex = 9;
            this.buttonEmpAdd.Text = "Add";
            this.buttonEmpAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEmpDelete
            // 
            this.buttonEmpDelete.Location = new System.Drawing.Point(294, 368);
            this.buttonEmpDelete.Name = "buttonEmpDelete";
            this.buttonEmpDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpDelete.TabIndex = 10;
            this.buttonEmpDelete.Text = "Delete";
            this.buttonEmpDelete.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(702, 17);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonEmpDelete);
            this.Controls.Add(this.buttonEmpAdd);
            this.Controls.Add(this.textEmployeeSearch);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textUserSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox textEmployeeSearch;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonEmpAdd;
        private System.Windows.Forms.Button buttonEmpDelete;
        private System.Windows.Forms.Button buttonLogout;
    }
}