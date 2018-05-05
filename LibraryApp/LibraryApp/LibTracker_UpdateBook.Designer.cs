namespace LibraryApp
{
    partial class LibTracker_UpdateBook
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateSynopsis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudUpdateRating = new System.Windows.Forms.NumericUpDown();
            this.lbUpdateGenre = new System.Windows.Forms.ListBox();
            this.numUpdateCopies = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateAuthor = new System.Windows.Forms.TextBox();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUpdate = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.errTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGenre = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipTitle = new System.Windows.Forms.ToolTip(this.components);
            this.tipAuthor = new System.Windows.Forms.ToolTip(this.components);
            this.tipGenre = new System.Windows.Forms.ToolTip(this.components);
            this.tipRating = new System.Windows.Forms.ToolTip(this.components);
            this.tipCopies = new System.Windows.Forms.ToolTip(this.components);
            this.tipSynopsis = new System.Windows.Forms.ToolTip(this.components);
            this.errCopies = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Created by: Daniel Hope, Jessica Sjostrom and Paul van Roosendaal";
            // 
            // txtUpdateSynopsis
            // 
            this.txtUpdateSynopsis.Location = new System.Drawing.Point(8, 223);
            this.txtUpdateSynopsis.MaxLength = 300;
            this.txtUpdateSynopsis.Multiline = true;
            this.txtUpdateSynopsis.Name = "txtUpdateSynopsis";
            this.txtUpdateSynopsis.Size = new System.Drawing.Size(236, 69);
            this.txtUpdateSynopsis.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Synopsis:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.nudUpdateRating);
            this.panel1.Controls.Add(this.lbUpdateGenre);
            this.panel1.Controls.Add(this.txtUpdateSynopsis);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numUpdateCopies);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnUpdateClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtUpdateAuthor);
            this.panel1.Controls.Add(this.txtUpdateTitle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 328);
            this.panel1.TabIndex = 24;
            // 
            // nudUpdateRating
            // 
            this.nudUpdateRating.Location = new System.Drawing.Point(126, 135);
            this.nudUpdateRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudUpdateRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpdateRating.Name = "nudUpdateRating";
            this.nudUpdateRating.Size = new System.Drawing.Size(120, 20);
            this.nudUpdateRating.TabIndex = 19;
            this.nudUpdateRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbUpdateGenre
            // 
            this.lbUpdateGenre.FormattingEnabled = true;
            this.lbUpdateGenre.Items.AddRange(new object[] {
            "Biography",
            "Science Fiction",
            "Drama",
            "Action and Adventure",
            "Romance",
            "Mystery",
            "Horror",
            "Self Help",
            "Health",
            "Guide",
            "Travel",
            "Children\'s",
            "Religion, Spirituality & New Age",
            "Science",
            "Fantasy",
            "Cookbooks",
            "Comics",
            "Journals",
            "Math",
            "Poetry",
            "Other"});
            this.lbUpdateGenre.Location = new System.Drawing.Point(125, 99);
            this.lbUpdateGenre.Name = "lbUpdateGenre";
            this.lbUpdateGenre.Size = new System.Drawing.Size(120, 30);
            this.lbUpdateGenre.TabIndex = 18;
            // 
            // numUpdateCopies
            // 
            this.numUpdateCopies.Location = new System.Drawing.Point(125, 166);
            this.numUpdateCopies.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpdateCopies.Name = "numUpdateCopies";
            this.numUpdateCopies.Size = new System.Drawing.Size(120, 20);
            this.numUpdateCopies.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "# Copies:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Rating:";
            // 
            // btnUpdateClear
            // 
            this.btnUpdateClear.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClear.Location = new System.Drawing.Point(147, 298);
            this.btnUpdateClear.Name = "btnUpdateClear";
            this.btnUpdateClear.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateClear.TabIndex = 9;
            this.btnUpdateClear.Text = "Clear";
            this.btnUpdateClear.UseVisualStyleBackColor = true;
            this.btnUpdateClear.Click += new System.EventHandler(this.btnUpdateClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(8, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateAuthor
            // 
            this.txtUpdateAuthor.Location = new System.Drawing.Point(124, 73);
            this.txtUpdateAuthor.MaxLength = 50;
            this.txtUpdateAuthor.Name = "txtUpdateAuthor";
            this.txtUpdateAuthor.Size = new System.Drawing.Size(120, 20);
            this.txtUpdateAuthor.TabIndex = 6;
            this.txtUpdateAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateAuthor_Validating);
            this.txtUpdateAuthor.Validated += new System.EventHandler(this.txtUpdateAuthor_Validated);
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(125, 42);
            this.txtUpdateTitle.MaxLength = 50;
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(120, 20);
            this.txtUpdateTitle.TabIndex = 4;
            this.txtUpdateTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateTitle_Validating);
            this.txtUpdateTitle.Validated += new System.EventHandler(this.txtUpdateTitle_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sheridan College 2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 43);
            this.label3.TabIndex = 25;
            this.label3.Text = "Update Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryApp.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(562, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHome,
            this.optionsToolStripMenuItem,
            this.menuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemHome
            // 
            this.menuItemHome.Name = "menuItemHome";
            this.menuItemHome.Size = new System.Drawing.Size(52, 20);
            this.menuItemHome.Text = "Home";
            this.menuItemHome.Click += new System.EventHandler(this.menuItemHome_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSearch,
            this.menuItemAdd,
            this.menuItemDelete});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Name = "menuItemSearch";
            this.menuItemSearch.Size = new System.Drawing.Size(137, 22);
            this.menuItemSearch.Text = "Search";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItemSearch_Click);
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(137, 22);
            this.menuItemAdd.Text = "Add Book";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(137, 22);
            this.menuItemDelete.Text = "Delete Book";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "Help";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdate.Location = new System.Drawing.Point(287, 169);
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.Size = new System.Drawing.Size(408, 243);
            this.dgvUpdate.TabIndex = 17;
            this.dgvUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdate_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Select a book to update";
            // 
            // errTitle
            // 
            this.errTitle.ContainerControl = this;
            // 
            // errAuthor
            // 
            this.errAuthor.ContainerControl = this;
            // 
            // errGenre
            // 
            this.errGenre.ContainerControl = this;
            // 
            // errCopies
            // 
            this.errCopies.ContainerControl = this;
            // 
            // LibTracker_UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 431);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LibTracker_UpdateBook";
            this.Text = "LibTracker_UpdateBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateSynopsis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numUpdateCopies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateAuthor;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemHome;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.DataGridView dgvUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbUpdateGenre;
        private System.Windows.Forms.NumericUpDown nudUpdateRating;
        private System.Windows.Forms.ErrorProvider errTitle;
        private System.Windows.Forms.ErrorProvider errAuthor;
        private System.Windows.Forms.ErrorProvider errGenre;
        private System.Windows.Forms.ToolTip tipTitle;
        private System.Windows.Forms.ToolTip tipAuthor;
        private System.Windows.Forms.ToolTip tipGenre;
        private System.Windows.Forms.ToolTip tipRating;
        private System.Windows.Forms.ToolTip tipCopies;
        private System.Windows.Forms.ToolTip tipSynopsis;
        private System.Windows.Forms.ErrorProvider errCopies;
    }
}