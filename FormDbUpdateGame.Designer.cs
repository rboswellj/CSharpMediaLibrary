
namespace MediaDB
{
    partial class FormDbUpdateGame
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
            this.btnGameUpdate = new System.Windows.Forms.Button();
            this.chkGamePlayed = new System.Windows.Forms.CheckBox();
            this.txtGamePlatform = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGameScore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGameYear = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGameGenre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGameDeveloper = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGameDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGameUpdate
            // 
            this.btnGameUpdate.Location = new System.Drawing.Point(21, 513);
            this.btnGameUpdate.Name = "btnGameUpdate";
            this.btnGameUpdate.Size = new System.Drawing.Size(150, 46);
            this.btnGameUpdate.TabIndex = 40;
            this.btnGameUpdate.Text = "Update";
            this.btnGameUpdate.UseVisualStyleBackColor = true;
            this.btnGameUpdate.Click += new System.EventHandler(this.BtnGameUpdate_Click);
            // 
            // chkGamePlayed
            // 
            this.chkGamePlayed.AutoSize = true;
            this.chkGamePlayed.Location = new System.Drawing.Point(252, 433);
            this.chkGamePlayed.Name = "chkGamePlayed";
            this.chkGamePlayed.Size = new System.Drawing.Size(127, 36);
            this.chkGamePlayed.TabIndex = 39;
            this.chkGamePlayed.Text = "Played?";
            this.chkGamePlayed.UseVisualStyleBackColor = true;
            // 
            // txtGamePlatform
            // 
            this.txtGamePlatform.Location = new System.Drawing.Point(252, 239);
            this.txtGamePlatform.Name = "txtGamePlatform";
            this.txtGamePlatform.Size = new System.Drawing.Size(200, 39);
            this.txtGamePlatform.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Platform";
            // 
            // txtGameScore
            // 
            this.txtGameScore.Location = new System.Drawing.Point(21, 433);
            this.txtGameScore.Name = "txtGameScore";
            this.txtGameScore.Size = new System.Drawing.Size(200, 39);
            this.txtGameScore.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Meta Score";
            // 
            // txtGameYear
            // 
            this.txtGameYear.Location = new System.Drawing.Point(21, 239);
            this.txtGameYear.Name = "txtGameYear";
            this.txtGameYear.Size = new System.Drawing.Size(200, 39);
            this.txtGameYear.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 32);
            this.label11.TabIndex = 29;
            this.label11.Text = "Year";
            // 
            // txtGameGenre
            // 
            this.txtGameGenre.Location = new System.Drawing.Point(21, 334);
            this.txtGameGenre.Name = "txtGameGenre";
            this.txtGameGenre.Size = new System.Drawing.Size(431, 39);
            this.txtGameGenre.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 32);
            this.label12.TabIndex = 30;
            this.label12.Text = "Genre";
            // 
            // txtGameDeveloper
            // 
            this.txtGameDeveloper.Location = new System.Drawing.Point(21, 146);
            this.txtGameDeveloper.Name = "txtGameDeveloper";
            this.txtGameDeveloper.Size = new System.Drawing.Size(431, 39);
            this.txtGameDeveloper.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 32);
            this.label13.TabIndex = 31;
            this.label13.Text = "Developer";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(21, 55);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(431, 39);
            this.txtGameTitle.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 32);
            this.label14.TabIndex = 32;
            this.label14.Text = "Title";
            // 
            // btnGameDelete
            // 
            this.btnGameDelete.Location = new System.Drawing.Point(177, 513);
            this.btnGameDelete.Name = "btnGameDelete";
            this.btnGameDelete.Size = new System.Drawing.Size(150, 46);
            this.btnGameDelete.TabIndex = 40;
            this.btnGameDelete.Text = "Delete";
            this.btnGameDelete.UseVisualStyleBackColor = true;
            this.btnGameDelete.Click += new System.EventHandler(this.BtnGameDelete_Click);
            // 
            // FormDbUpdateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 601);
            this.Controls.Add(this.btnGameDelete);
            this.Controls.Add(this.btnGameUpdate);
            this.Controls.Add(this.chkGamePlayed);
            this.Controls.Add(this.txtGamePlatform);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGameScore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGameYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGameGenre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGameDeveloper);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGameTitle);
            this.Controls.Add(this.label14);
            this.Name = "FormDbUpdateGame";
            this.Text = "FormDbUpdateGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameUpdate;
        private System.Windows.Forms.CheckBox chkGamePlayed;
        private System.Windows.Forms.TextBox txtGamePlatform;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGameScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGameYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGameGenre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGameDeveloper;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGameDelete;
    }
}