
namespace _190133369Task1
{
    partial class Dewey
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReplBook = new System.Windows.Forms.Button();
            this.btnIdentAre = new System.Windows.Forms.Button();
            this.btnFindCallNums = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReplBook
            // 
            this.btnReplBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReplBook.Location = new System.Drawing.Point(35, 250);
            this.btnReplBook.Name = "btnReplBook";
            this.btnReplBook.Size = new System.Drawing.Size(227, 41);
            this.btnReplBook.TabIndex = 0;
            this.btnReplBook.Text = "Replacing books";
            this.btnReplBook.UseVisualStyleBackColor = true;
            this.btnReplBook.Click += new System.EventHandler(this.btnReplBook_Click);
            // 
            // btnIdentAre
            // 
            this.btnIdentAre.Enabled = false;
            this.btnIdentAre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentAre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIdentAre.Location = new System.Drawing.Point(625, 248);
            this.btnIdentAre.Name = "btnIdentAre";
            this.btnIdentAre.Size = new System.Drawing.Size(227, 43);
            this.btnIdentAre.TabIndex = 1;
            this.btnIdentAre.Text = "Identifying areas";
            this.btnIdentAre.UseVisualStyleBackColor = true;
            // 
            // btnFindCallNums
            // 
            this.btnFindCallNums.Enabled = false;
            this.btnFindCallNums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCallNums.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindCallNums.Location = new System.Drawing.Point(330, 250);
            this.btnFindCallNums.Name = "btnFindCallNums";
            this.btnFindCallNums.Size = new System.Drawing.Size(230, 41);
            this.btnFindCallNums.TabIndex = 2;
            this.btnFindCallNums.Text = "Finding call numbers";
            this.btnFindCallNums.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a skill to learn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to the Dewey Decimal System";
            // 
            // btnEx
            // 
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEx.Location = new System.Drawing.Point(841, 12);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(45, 32);
            this.btnEx.TabIndex = 5;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // Dewey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(898, 341);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindCallNums);
            this.Controls.Add(this.btnIdentAre);
            this.Controls.Add(this.btnReplBook);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dewey";
            this.Text = "Dewey Decimal System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplBook;
        private System.Windows.Forms.Button btnIdentAre;
        private System.Windows.Forms.Button btnFindCallNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEx;
    }
}

