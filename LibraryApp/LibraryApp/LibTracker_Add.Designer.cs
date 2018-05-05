namespace LibraryApp
{
    partial class LibTracker_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibTracker_Add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudAddRating = new System.Windows.Forms.NumericUpDown();
            this.lbAddGenre = new System.Windows.Forms.ListBox();
            this.mtbAddISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtAddSynopsis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numAddCopies = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddAuthor = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errISBN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipTitle = new System.Windows.Forms.ToolTip(this.components);
            this.tipISBN = new System.Windows.Forms.ToolTip(this.components);
            this.tipAuthor = new System.Windows.Forms.ToolTip(this.components);
            this.tipGenre = new System.Windows.Forms.ToolTip(this.components);
            this.tipRating = new System.Windows.Forms.ToolTip(this.components);
            this.tipCopies = new System.Windows.Forms.ToolTip(this.components);
            this.tipSynopsis = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddCopies)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.nudAddRating);
            this.panel1.Controls.Add(this.lbAddGenre);
            this.panel1.Controls.Add(this.mtbAddISBN);
            this.panel1.Controls.Add(this.txtAddSynopsis);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numAddCopies);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAddClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtAddAuthor);
            this.panel1.Controls.Add(this.txtAddTitle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 259);
            this.panel1.TabIndex = 18;
            // 
            // nudAddRating
            // 
            this.nudAddRating.Location = new System.Drawing.Point(458, 54);
            this.nudAddRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAddRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddRating.Name = "nudAddRating";
            this.nudAddRating.Size = new System.Drawing.Size(120, 20);
            this.nudAddRating.TabIndex = 5;
            this.nudAddRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbAddGenre
            // 
            this.lbAddGenre.FormattingEnabled = true;
            this.lbAddGenre.Items.AddRange(new object[] {
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
            this.lbAddGenre.Location = new System.Drawing.Point(458, 8);
            this.lbAddGenre.Name = "lbAddGenre";
            this.lbAddGenre.Size = new System.Drawing.Size(120, 43);
            this.lbAddGenre.TabIndex = 4;
            // 
            // mtbAddISBN
            // 
            this.mtbAddISBN.Location = new System.Drawing.Point(141, 54);
            this.mtbAddISBN.Mask = "0000000000000";
            this.mtbAddISBN.Name = "mtbAddISBN";
            this.mtbAddISBN.Size = new System.Drawing.Size(118, 20);
            this.mtbAddISBN.TabIndex = 2;
            this.mtbAddISBN.Validating += new System.ComponentModel.CancelEventHandler(this.mtbAddISBN_Validating);
            this.mtbAddISBN.Validated += new System.EventHandler(this.mtbAddISBN_Validated);
            // 
            // txtAddSynopsis
            // 
            this.txtAddSynopsis.Location = new System.Drawing.Point(8, 149);
            this.txtAddSynopsis.MaxLength = 200;
            this.txtAddSynopsis.Multiline = true;
            this.txtAddSynopsis.Name = "txtAddSynopsis";
            this.txtAddSynopsis.Size = new System.Drawing.Size(622, 69);
            this.txtAddSynopsis.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Synopsis:";
            // 
            // numAddCopies
            // 
            this.numAddCopies.Location = new System.Drawing.Point(460, 83);
            this.numAddCopies.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numAddCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddCopies.Name = "numAddCopies";
            this.numAddCopies.Size = new System.Drawing.Size(120, 20);
            this.numAddCopies.TabIndex = 6;
            this.numAddCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "# Copies:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Rating:";
            // 
            // btnAddClear
            // 
            this.btnAddClear.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClear.Location = new System.Drawing.Point(533, 224);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(97, 23);
            this.btnAddClear.TabIndex = 9;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = true;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(430, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddAuthor
            // 
            this.txtAddAuthor.Location = new System.Drawing.Point(139, 85);
            this.txtAddAuthor.MaxLength = 50;
            this.txtAddAuthor.Name = "txtAddAuthor";
            this.txtAddAuthor.Size = new System.Drawing.Size(120, 20);
            this.txtAddAuthor.TabIndex = 3;
            this.txtAddAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddAuthor_Validating);
            this.txtAddAuthor.Validated += new System.EventHandler(this.txtAddAuthor_Validated);
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(140, 20);
            this.txtAddTitle.MaxLength = 50;
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(120, 20);
            this.txtAddTitle.TabIndex = 1;
            this.txtAddTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddTitle_Validating);
            this.txtAddTitle.Validated += new System.EventHandler(this.txtAddTitle_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Created by: Daniel Hope, Jessica Sjostrom and Paul van Roosendaal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sheridan College 2018";
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
            this.menuStrip1.TabIndex = 14;
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
            this.menuItemDelete,
            this.menuItemUpdate});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Name = "menuItemSearch";
            this.menuItemSearch.Size = new System.Drawing.Size(142, 22);
            this.menuItemSearch.Text = "Search";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItemSearch_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(142, 22);
            this.menuItemDelete.Text = "Delete Book";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemUpdate
            // 
            this.menuItemUpdate.Name = "menuItemUpdate";
            this.menuItemUpdate.Size = new System.Drawing.Size(142, 22);
            this.menuItemUpdate.Text = "Update Book";
            this.menuItemUpdate.Click += new System.EventHandler(this.menuItemUpdate_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "Help";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 43);
            this.label3.TabIndex = 19;
            this.label3.Text = "Add New Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // errTitle
            // 
            this.errTitle.ContainerControl = this;
            // 
            // errISBN
            // 
            this.errISBN.ContainerControl = this;
            // 
            // errAuthor
            // 
            this.errAuthor.ContainerControl = this;
            // 
            // LibTracker_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LibTracker_Add";
            this.Text = "LibTracker_Add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddCopies)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddAuthor;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemHome;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numAddCopies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddSynopsis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbAddGenre;
        private System.Windows.Forms.MaskedTextBox mtbAddISBN;
        private System.Windows.Forms.NumericUpDown nudAddRating;
        private System.Windows.Forms.ErrorProvider errTitle;
        private System.Windows.Forms.ErrorProvider errISBN;
        private System.Windows.Forms.ErrorProvider errAuthor;
        private System.Windows.Forms.ToolTip tipTitle;
        private System.Windows.Forms.ToolTip tipISBN;
        private System.Windows.Forms.ToolTip tipAuthor;
        private System.Windows.Forms.ToolTip tipGenre;
        private System.Windows.Forms.ToolTip tipRating;
        private System.Windows.Forms.ToolTip tipCopies;
        private System.Windows.Forms.ToolTip tipSynopsis;
    }
}