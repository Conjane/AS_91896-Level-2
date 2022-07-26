
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(142, 173);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(297, 77);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add Animal to the Index";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(142, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(297, 77);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search for an Animal in the Index";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(142, 367);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(297, 77);
            this.btnSummary.TabIndex = 2;
            this.btnSummary.Text = "Summary of All Animals";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(202, 82);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(167, 31);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "SPCA HOME";
            // 
            // SPCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 550);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "SPCA";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblHome;
    }
}

