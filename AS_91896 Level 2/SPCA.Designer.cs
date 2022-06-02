
namespace AS_91896_Level_2
{
    partial class SPCA
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
            this.rtxOutput = new System.Windows.Forms.RichTextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cboBxFood = new System.Windows.Forms.ComboBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.numFood = new System.Windows.Forms.NumericUpDown();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lstBxPetCatalouge = new System.Windows.Forms.ListBox();
            this.cboBxSpecies = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFood)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxOutput
            // 
            this.rtxOutput.Location = new System.Drawing.Point(323, 24);
            this.rtxOutput.Name = "rtxOutput";
            this.rtxOutput.ReadOnly = true;
            this.rtxOutput.Size = new System.Drawing.Size(267, 514);
            this.rtxOutput.TabIndex = 0;
            this.rtxOutput.Text = "";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(88, 52);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 22);
            this.txtBxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(12, 92);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(62, 17);
            this.lblSpecies.TabIndex = 3;
            this.lblSpecies.Text = "Species:";
            // 
            // cboBxFood
            // 
            this.cboBxFood.FormattingEnabled = true;
            this.cboBxFood.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboBxFood.Location = new System.Drawing.Point(32, 203);
            this.cboBxFood.Name = "cboBxFood";
            this.cboBxFood.Size = new System.Drawing.Size(121, 24);
            this.cboBxFood.TabIndex = 5;
            this.cboBxFood.SelectedIndexChanged += new System.EventHandler(this.cboBxFood_SelectedIndexChanged);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(66, 140);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(183, 17);
            this.lblFood.TabIndex = 6;
            this.lblFood.Text = "Daily Food Consumption (g)";
            // 
            // numFood
            // 
            this.numFood.Location = new System.Drawing.Point(195, 205);
            this.numFood.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numFood.Name = "numFood";
            this.numFood.Size = new System.Drawing.Size(92, 22);
            this.numFood.TabIndex = 7;
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.Location = new System.Drawing.Point(171, 246);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(116, 50);
            this.btnAddDetails.TabIndex = 8;
            this.btnAddDetails.Text = "Add Details";
            this.btnAddDetails.UseVisualStyleBackColor = true;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(32, 246);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(116, 50);
            this.btnAddFood.TabIndex = 9;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lstBxPetCatalouge
            // 
            this.lstBxPetCatalouge.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxPetCatalouge.FormattingEnabled = true;
            this.lstBxPetCatalouge.ItemHeight = 25;
            this.lstBxPetCatalouge.Location = new System.Drawing.Point(32, 336);
            this.lstBxPetCatalouge.Name = "lstBxPetCatalouge";
            this.lstBxPetCatalouge.Size = new System.Drawing.Size(255, 129);
            this.lstBxPetCatalouge.TabIndex = 10;
            this.lstBxPetCatalouge.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cboBxSpecies
            // 
            this.cboBxSpecies.FormattingEnabled = true;
            this.cboBxSpecies.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Hamster",
            "Horse"});
            this.cboBxSpecies.Location = new System.Drawing.Point(88, 92);
            this.cboBxSpecies.Name = "cboBxSpecies";
            this.cboBxSpecies.Size = new System.Drawing.Size(100, 24);
            this.cboBxSpecies.TabIndex = 11;
            // 
            // SPCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 550);
            this.Controls.Add(this.cboBxSpecies);
            this.Controls.Add(this.lstBxPetCatalouge);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnAddDetails);
            this.Controls.Add(this.numFood);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.cboBxFood);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.rtxOutput);
            this.Name = "SPCA";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxOutput;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.ComboBox cboBxFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.NumericUpDown numFood;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ListBox lstBxPetCatalouge;
        private System.Windows.Forms.ComboBox cboBxSpecies;
    }
}

