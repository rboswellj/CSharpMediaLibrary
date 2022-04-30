
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
            this.btnMovieSubmit = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlInput.SuspendLayout();
            this.tabMovieInput.SuspendLayout();
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
            this.tabMovieInput.Controls.Add(this.btnMovieSubmit);
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
            // btnMovieSubmit
            // 
            this.btnMovieSubmit.Location = new System.Drawing.Point(17, 515);
            this.btnMovieSubmit.Name = "btnMovieSubmit";
            this.btnMovieSubmit.Size = new System.Drawing.Size(150, 46);
            this.btnMovieSubmit.TabIndex = 3;
            this.btnMovieSubmit.Text = "Add";
            this.btnMovieSubmit.UseVisualStyleBackColor = true;
            this.btnMovieSubmit.Click += new System.EventHandler(this.BtnMovieSubmit_Click);
            // 
            // chkMovieSeen
            // 
            this.chkMovieSeen.AutoSize = true;
            this.chkMovieSeen.Location = new System.Drawing.Point(248, 435);
            this.chkMovieSeen.Name = "chkMovieSeen";
            this.chkMovieSeen.Size = new System.Drawing.Size(110, 36);
            this.chkMovieSeen.TabIndex = 2;
            this.chkMovieSeen.Text = "Seen?";
            this.chkMovieSeen.UseVisualStyleBackColor = true;
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Location = new System.Drawing.Point(248, 241);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(200, 39);
            this.txtMovieLength.TabIndex = 1;
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
            this.txtMovieRating.TabIndex = 1;
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
            this.txtMovieYear.TabIndex = 1;
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
            this.txtMovieGenre.TabIndex = 1;
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
            this.txtMovieDirector.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormDbInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 696);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxAdded);
            this.Controls.Add(this.tabControlInput);
            this.Name = "FormDbInput";
            this.Text = "Entry Form";
            this.tabControlInput.ResumeLayout(false);
            this.tabMovieInput.ResumeLayout(false);
            this.tabMovieInput.PerformLayout();
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
        private System.Windows.Forms.Button btnMovieSubmit;
        private System.Windows.Forms.ListBox listBoxAdded;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}