
namespace AS_91896_Level_2
{
    partial class SearchAnimal
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cbxSpecies = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.lstBoxAnimals = new System.Windows.Forms.ListBox();
            this.cbxSearchForSearch = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(10, 10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(56, 24);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(11, 98);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(45, 13);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species";
            this.lblSpecies.Visible = false;
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Parrot",
            "Fox",
            "Rat",
            "Weasel",
            "Fish"});
            this.cbxSpecies.Location = new System.Drawing.Point(11, 115);
            this.cbxSpecies.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(92, 21);
            this.cbxSpecies.TabIndex = 3;
            this.cbxSpecies.Visible = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(11, 98);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            this.lblAge.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 99);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 100);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID Number";
            this.lblID.Visible = false;
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.Location = new System.Drawing.Point(10, 154);
            this.btnSearchAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(122, 36);
            this.btnSearchAnimal.TabIndex = 11;
            this.btnSearchAnimal.Text = "Search Animal";
            this.btnSearchAnimal.UseVisualStyleBackColor = true;
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // lstBoxAnimals
            // 
            this.lstBoxAnimals.FormattingEnabled = true;
            this.lstBoxAnimals.Location = new System.Drawing.Point(147, 71);
            this.lstBoxAnimals.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxAnimals.Name = "lstBoxAnimals";
            this.lstBoxAnimals.Size = new System.Drawing.Size(175, 264);
            this.lstBoxAnimals.TabIndex = 12;
            this.lstBoxAnimals.SelectedIndexChanged += new System.EventHandler(this.lstBoxAnimals_SelectedIndexChanged);
            // 
            // cbxSearchForSearch
            // 
            this.cbxSearchForSearch.FormattingEnabled = true;
            this.cbxSearchForSearch.Items.AddRange(new object[] {
            "Species",
            "Age",
            "Name",
            "ID Number"});
            this.cbxSearchForSearch.Location = new System.Drawing.Point(11, 71);
            this.cbxSearchForSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSearchForSearch.Name = "cbxSearchForSearch";
            this.cbxSearchForSearch.Size = new System.Drawing.Size(92, 21);
            this.cbxSearchForSearch.TabIndex = 13;
            this.cbxSearchForSearch.SelectedIndexChanged += new System.EventHandler(this.cbxSearchForSeearch_SelectedIndexChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(9, 54);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(172, 13);
            this.lblQuestion.TabIndex = 14;
            this.lblQuestion.Text = "What would you like to Search by?";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(11, 115);
            this.numAge.Margin = new System.Windows.Forms.Padding(2);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(91, 20);
            this.numAge.TabIndex = 15;
            this.numAge.Visible = false;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(11, 116);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(92, 20);
            this.txtbxName.TabIndex = 16;
            this.txtbxName.Visible = false;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(11, 116);
            this.numID.Margin = new System.Windows.Forms.Padding(2);
            this.numID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(93, 20);
            this.numID.TabIndex = 17;
            this.numID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numID.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 34);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SearchAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(356, 366);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.cbxSearchForSearch);
            this.Controls.Add(this.lstBoxAnimals);
            this.Controls.Add(this.btnSearchAnimal);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.cbxSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchAnimal";
            this.Text = "SearchAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.ComboBox cbxSpecies;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearchAnimal;
        private System.Windows.Forms.ListBox lstBoxAnimals;
        private System.Windows.Forms.ComboBox cbxSearchForSearch;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Button btnClear;
    }
}