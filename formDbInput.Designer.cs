
namespace MediaDB
{
    partial class FormDbInput
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
            this.tabControlInput = new System.Windows.Forms.TabControl();
            this.tabMovieInput = new System.Windows.Forms.TabPage();
            this.btnMovieClear = new System.Windows.Forms.Button();
            this.btnMovieAdd = new System.Windows.Forms.Button();
            this.chkMovieSeen = new System.Windows.Forms.CheckBox();
            this.txtMovieLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMovieRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtMovieGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMovieDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGameInput = new System.Windows.Forms.TabPage();
            this.listBoxAdded = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEntryCommit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGameAdd = new System.Windows.Forms.Button();
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
            this.tabControlInput.SuspendLayout();
            this.tabMovieInput.SuspendLayout();
            this.tabGameInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlInput
            // 
            this.tabControlInput.Controls.Add(this.tabMovieInput);
            this.tabControlInput.Controls.Add(this.tabGameInput);
            this.tabControlInput.Location = new System.Drawing.Point(13, 13);
            this.tabControlInput.Name = "tabControlInput";
            this.tabControlInput.SelectedIndex = 0;
            this.tabControlInput.Size = new System.Drawing.Size(515, 652);
            this.tabControlInput.TabIndex = 0;
            // 
            // tabMovieInput
            // 
            this.tabMovieInput.Controls.Add(this.btnMovieClear);
            this.tabMovieInput.Controls.Add(this.btnMovieAdd);
            this.tabMovieInput.Controls.Add(this.chkMovieSeen);
            this.tabMovieInput.Controls.Add(this.txtMovieLength);
            this.tabMovieInput.Controls.Add(this.label3);
            this.tabMovieInput.Controls.Add(this.txtMovieRating);
            this.tabMovieInput.Controls.Add(this.label5);
            this.tabMovieInput.Controls.Add(this.label4);
            this.tabMovieInput.Controls.Add(this.txtMovieYear);
            this.tabMovieInput.Controls.Add(this.lbl);
            this.tabMovieInput.Controls.Add(this.txtMovieGenre);
            this.tabMovieInput.Controls.Add(this.label6);
            this.tabMovieInput.Controls.Add(this.txtMovieDirector);
            this.tabMovieInput.Controls.Add(this.label2);
            this.tabMovieInput.Controls.Add(this.txtMovieTitle);
            this.tabMovieInput.Controls.Add(this.label1);
            this.tabMovieInput.Location = new System.Drawing.Point(8, 46);
            this.tabMovieInput.Name = "tabMovieInput";
            this.tabMovieInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovieInput.Size = new System.Drawing.Size(499, 598);
            this.tabMovieInput.TabIndex = 0;
            this.tabMovieInput.Text = "Movies";
            this.tabMovieInput.UseVisualStyleBackColor = true;
            // 
            // btnMovieClear
            // 
            this.btnMovieClear.Location = new System.Drawing.Point(191, 515);
            this.btnMovieClear.Name = "btnMovieClear";
            this.btnMovieClear.Size = new System.Drawing.Size(150, 46);
            this.btnMovieClear.TabIndex = 9;
            this.btnMovieClear.Text = "Clear";
            this.btnMovieClear.UseVisualStyleBackColor = true;
            this.btnMovieClear.Click += new System.EventHandler(this.BtnMovieClear_Click);
            // 
            // btnMovieAdd
            // 
            this.btnMovieAdd.Location = new System.Drawing.Point(17, 515);
            this.btnMovieAdd.Name = "btnMovieAdd";
            this.btnMovieAdd.Size = new System.Drawing.Size(150, 46);
            this.btnMovieAdd.TabIndex = 8;
            this.btnMovieAdd.Text = "Add";
            this.btnMovieAdd.UseVisualStyleBackColor = true;
            this.btnMovieAdd.Click += new System.EventHandler(this.BtnMovieAdd_Click);
            // 
            // chkMovieSeen
            // 
            this.chkMovieSeen.AutoSize = true;
            this.chkMovieSeen.Location = new System.Drawing.Point(248, 435);
            this.chkMovieSeen.Name = "chkMovieSeen";
            this.chkMovieSeen.Size = new System.Drawing.Size(110, 36);
            this.chkMovieSeen.TabIndex = 7;
            this.chkMovieSeen.Text = "Seen?";
            this.chkMovieSeen.UseVisualStyleBackColor = true;
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Location = new System.Drawing.Point(248, 241);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(200, 39);
            this.txtMovieLength.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Running Time";
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(17, 435);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(200, 39);
            this.txtMovieRating.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tomato Rating";
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(17, 241);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(200, 39);
            this.txtMovieYear.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(17, 206);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 32);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Year";
            // 
            // txtMovieGenre
            // 
            this.txtMovieGenre.Location = new System.Drawing.Point(17, 336);
            this.txtMovieGenre.Name = "txtMovieGenre";
            this.txtMovieGenre.Size = new System.Drawing.Size(431, 39);
            this.txtMovieGenre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Genre";
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Location = new System.Drawing.Point(17, 148);
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(431, 39);
            this.txtMovieDirector.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Director";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(17, 57);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(431, 39);
            this.txtMovieTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tabGameInput
            // 
            this.tabGameInput.Controls.Add(this.button1);
            this.tabGameInput.Controls.Add(this.txtGameAdd);
            this.tabGameInput.Controls.Add(this.chkGamePlayed);
            this.tabGameInput.Controls.Add(this.txtGamePlatform);
            this.tabGameInput.Controls.Add(this.label8);
            this.tabGameInput.Controls.Add(this.txtGameScore);
            this.tabGameInput.Controls.Add(this.label9);
            this.tabGameInput.Controls.Add(this.label10);
            this.tabGameInput.Controls.Add(this.txtGameYear);
            this.tabGameInput.Controls.Add(this.label11);
            this.tabGameInput.Controls.Add(this.txtGameGenre);
            this.tabGameInput.Controls.Add(this.label12);
            this.tabGameInput.Controls.Add(this.txtGameDeveloper);
            this.tabGameInput.Controls.Add(this.label13);
            this.tabGameInput.Controls.Add(this.txtGameTitle);
            this.tabGameInput.Controls.Add(this.label14);
            this.tabGameInput.Location = new System.Drawing.Point(8, 46);
            this.tabGameInput.Name = "tabGameInput";
            this.tabGameInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabGameInput.Size = new System.Drawing.Size(499, 598);
            this.tabGameInput.TabIndex = 1;
            this.tabGameInput.Text = "Games";
            this.tabGameInput.UseVisualStyleBackColor = true;
            // 
            // listBoxAdded
            // 
            this.listBoxAdded.FormattingEnabled = true;
            this.listBoxAdded.ItemHeight = 32;
            this.listBoxAdded.Location = new System.Drawing.Point(549, 59);
            this.listBoxAdded.Name = "listBoxAdded";
            this.listBoxAdded.Size = new System.Drawing.Size(428, 516);
            this.listBoxAdded.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Added";
            // 
            // btnEntryCommit
            // 
            this.btnEntryCommit.Location = new System.Drawing.Point(549, 611);
            this.btnEntryCommit.Name = "btnEntryCommit";
            this.btnEntryCommit.Size = new System.Drawing.Size(150, 46);
            this.btnEntryCommit.TabIndex = 6;
            this.btnEntryCommit.Text = "Commit";
            this.btnEntryCommit.UseVisualStyleBackColor = true;
            this.btnEntryCommit.Click += new System.EventHandler(this.BtnEntryCommit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGameAdd
            // 
            this.txtGameAdd.Location = new System.Drawing.Point(34, 523);
            this.txtGameAdd.Name = "txtGameAdd";
            this.txtGameAdd.Size = new System.Drawing.Size(150, 46);
            this.txtGameAdd.TabIndex = 24;
            this.txtGameAdd.Text = "Add";
            this.txtGameAdd.UseVisualStyleBackColor = true;
            // 
            // chkGamePlayed
            // 
            this.chkGamePlayed.AutoSize = true;
            this.chkGamePlayed.Location = new System.Drawing.Point(265, 443);
            this.chkGamePlayed.Name = "chkGamePlayed";
            this.chkGamePlayed.Size = new System.Drawing.Size(127, 36);
            this.chkGamePlayed.TabIndex = 23;
            this.chkGamePlayed.Text = "Played?";
            this.chkGamePlayed.UseVisualStyleBackColor = true;
            // 
            // txtGamePlatform
            // 
            this.txtGamePlatform.Location = new System.Drawing.Point(265, 249);
            this.txtGamePlatform.Name = "txtGamePlatform";
            this.txtGamePlatform.Size = new System.Drawing.Size(200, 39);
            this.txtGamePlatform.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "Platform";
            // 
            // txtGameScore
            // 
            this.txtGameScore.Location = new System.Drawing.Point(34, 443);
            this.txtGameScore.Name = "txtGameScore";
            this.txtGameScore.Size = new System.Drawing.Size(200, 39);
            this.txtGameScore.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Meta Score";
            // 
            // txtGameYear
            // 
            this.txtGameYear.Location = new System.Drawing.Point(34, 249);
            this.txtGameYear.Name = "txtGameYear";
            this.txtGameYear.Size = new System.Drawing.Size(200, 39);
            this.txtGameYear.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 32);
            this.label11.TabIndex = 13;
            this.label11.Text = "Year";
            // 
            // txtGameGenre
            // 
            this.txtGameGenre.Location = new System.Drawing.Point(34, 344);
            this.txtGameGenre.Name = "txtGameGenre";
            this.txtGameGenre.Size = new System.Drawing.Size(431, 39);
            this.txtGameGenre.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 32);
            this.label12.TabIndex = 14;
            this.label12.Text = "Genre";
            // 
            // txtGameDeveloper
            // 
            this.txtGameDeveloper.Location = new System.Drawing.Point(34, 156);
            this.txtGameDeveloper.Name = "txtGameDeveloper";
            this.txtGameDeveloper.Size = new System.Drawing.Size(431, 39);
            this.txtGameDeveloper.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 32);
            this.label13.TabIndex = 15;
            this.label13.Text = "Developer";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(34, 65);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(431, 39);
            this.txtGameTitle.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 32);
            this.label14.TabIndex = 16;
            this.label14.Text = "Title";
            // 
            // FormDbInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 696);
            this.Controls.Add(this.btnEntryCommit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxAdded);
            this.Controls.Add(this.tabControlInput);
            this.Name = "FormDbInput";
            this.Text = "Entry Form";
            this.tabControlInput.ResumeLayout(false);
            this.tabMovieInput.ResumeLayout(false);
            this.tabMovieInput.PerformLayout();
            this.tabGameInput.ResumeLayout(false);
            this.tabGameInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInput;
        private System.Windows.Forms.TabPage tabMovieInput;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtMovieDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabGameInput;
        private System.Windows.Forms.TextBox txtMovieLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkMovieSeen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovieGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.ListBox listBoxAdded;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEntryCommit;
        private System.Windows.Forms.Button btnMovieClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtGameAdd;
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
    }
}