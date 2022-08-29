
namespace AS_91896_Level_2
{
    partial class Summary
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
            this.btnClear = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.cbxSelectSearch = new System.Windows.Forms.ComboBox();
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.cbxSpecies = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.rtxOutput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(9, 10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(56, 19);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 34);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(8, 98);
            this.numAge.Margin = new System.Windows.Forms.Padding(2);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(91, 20);
            this.numAge.TabIndex = 28;
            this.numAge.Visible = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(6, 37);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(246, 13);
            this.lblQuestion.TabIndex = 27;
            this.lblQuestion.Text = "What would you like the summary to be filtered by?";
            // 
            // cbxSelectSearch
            // 
            this.cbxSelectSearch.FormattingEnabled = true;
            this.cbxSelectSearch.Items.AddRange(new object[] {
            "All",
            "Species",
            "Age"});
            this.cbxSelectSearch.Location = new System.Drawing.Point(8, 54);
            this.cbxSelectSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSelectSearch.Name = "cbxSelectSearch";
            this.cbxSelectSearch.Size = new System.Drawing.Size(92, 21);
            this.cbxSelectSearch.TabIndex = 26;
            this.cbxSelectSearch.Text = "All";
            this.cbxSelectSearch.SelectedIndexChanged += new System.EventHandler(this.cbxSelectSearch_SelectedIndexChanged);
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.Location = new System.Drawing.Point(7, 137);
            this.btnSearchAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(122, 36);
            this.btnSearchAnimal.TabIndex = 24;
            this.btnSearchAnimal.Text = "View Summary";
            this.btnSearchAnimal.UseVisualStyleBackColor = true;
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(8, 81);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 21;
            this.lblAge.Text = "Age";
            this.lblAge.Visible = false;
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
            this.cbxSpecies.Location = new System.Drawing.Point(8, 98);
            this.cbxSpecies.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(92, 21);
            this.cbxSpecies.TabIndex = 20;
            this.cbxSpecies.Visible = false;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(8, 81);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(45, 13);
            this.lblSpecies.TabIndex = 19;
            this.lblSpecies.Text = "Species";
            this.lblSpecies.Visible = false;
            // 
            // rtxOutput
            // 
            this.rtxOutput.Location = new System.Drawing.Point(152, 54);
            this.rtxOutput.Name = "rtxOutput";
            this.rtxOutput.ReadOnly = true;
            this.rtxOutput.Size = new System.Drawing.Size(293, 300);
            this.rtxOutput.TabIndex = 32;
            this.rtxOutput.Text = "";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(496, 366);
            this.Controls.Add(this.rtxOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.cbxSelectSearch);
            this.Controls.Add(this.btnSearchAnimal);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.cbxSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.btnHome);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Summary";
            this.Text = "Summary";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ComboBox cbxSelectSearch;
        private System.Windows.Forms.Button btnSearchAnimal;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cbxSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.RichTextBox rtxOutput;
    }
}