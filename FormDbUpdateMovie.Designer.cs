
namespace MediaDB
{
    partial class FormDbUpdateMovie
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
            this.btnMovieUpdate = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.Location = new System.Drawing.Point(21, 509);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(150, 46);
            this.btnMovieUpdate.TabIndex = 24;
            this.btnMovieUpdate.Text = "Update";
            this.btnMovieUpdate.UseVisualStyleBackColor = true;
            this.btnMovieUpdate.Click += new System.EventHandler(this.BtnMovieUpdate_Click);
            // 
            // chkMovieSeen
            // 
            this.chkMovieSeen.AutoSize = true;
            this.chkMovieSeen.Location = new System.Drawing.Point(252, 429);
            this.chkMovieSeen.Name = "chkMovieSeen";
            this.chkMovieSeen.Size = new System.Drawing.Size(110, 36);
            this.chkMovieSeen.TabIndex = 23;
            this.chkMovieSeen.Text = "Seen?";
            this.chkMovieSeen.UseVisualStyleBackColor = true;
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Location = new System.Drawing.Point(252, 235);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(200, 39);
            this.txtMovieLength.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Running Time";
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(21, 429);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(200, 39);
            this.txtMovieRating.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tomato Rating";
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(21, 235);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(200, 39);
            this.txtMovieYear.TabIndex = 19;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(21, 200);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 32);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Year";
            // 
            // txtMovieGenre
            // 
            this.txtMovieGenre.Location = new System.Drawing.Point(21, 330);
            this.txtMovieGenre.Name = "txtMovieGenre";
            this.txtMovieGenre.Size = new System.Drawing.Size(431, 39);
            this.txtMovieGenre.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Genre";
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Location = new System.Drawing.Point(21, 142);
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(431, 39);
            this.txtMovieDirector.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Director";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(21, 51);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(431, 39);
            this.txtMovieTitle.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title";
            // 
            // FormDbUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 595);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.chkMovieSeen);
            this.Controls.Add(this.txtMovieLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovieRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovieYear);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtMovieGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMovieDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.label1);
            this.Name = "FormDbUpdateMovie";
            this.Text = "Update Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.CheckBox chkMovieSeen;
        private System.Windows.Forms.TextBox txtMovieLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtMovieGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMovieDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label label1;
    }
}