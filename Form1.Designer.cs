
namespace MovieDB
{
    partial class Form1
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
            this.tabCategory = new System.Windows.Forms.TabControl();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabShows = new System.Windows.Forms.TabPage();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabRecords = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabCategory.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.tabMovies);
            this.tabCategory.Controls.Add(this.tabShows);
            this.tabCategory.Controls.Add(this.tabGames);
            this.tabCategory.Controls.Add(this.tabBooks);
            this.tabCategory.Controls.Add(this.tabRecords);
            this.tabCategory.Location = new System.Drawing.Point(12, 12);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.SelectedIndex = 0;
            this.tabCategory.Size = new System.Drawing.Size(1350, 818);
            this.tabCategory.TabIndex = 0;
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.btnSearch);
            this.tabMovies.Controls.Add(this.txtSearch);
            this.tabMovies.Location = new System.Drawing.Point(8, 46);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(1334, 764);
            this.tabMovies.TabIndex = 0;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(782, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(372, 39);
            this.txtSearch.TabIndex = 1;
            // 
            // tabShows
            // 
            this.tabShows.Location = new System.Drawing.Point(8, 46);
            this.tabShows.Name = "tabShows";
            this.tabShows.Padding = new System.Windows.Forms.Padding(3);
            this.tabShows.Size = new System.Drawing.Size(1334, 764);
            this.tabShows.TabIndex = 1;
            this.tabShows.Text = "Shows";
            this.tabShows.UseVisualStyleBackColor = true;
            // 
            // tabGames
            // 
            this.tabGames.Location = new System.Drawing.Point(8, 46);
            this.tabGames.Name = "tabGames";
            this.tabGames.Size = new System.Drawing.Size(1334, 764);
            this.tabGames.TabIndex = 2;
            this.tabGames.Text = "Games";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // tabBooks
            // 
            this.tabBooks.Location = new System.Drawing.Point(8, 46);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Size = new System.Drawing.Size(1334, 764);
            this.tabBooks.TabIndex = 3;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabRecords
            // 
            this.tabRecords.Location = new System.Drawing.Point(8, 46);
            this.tabRecords.Name = "tabRecords";
            this.tabRecords.Size = new System.Drawing.Size(1334, 764);
            this.tabRecords.TabIndex = 4;
            this.tabRecords.Text = "Records";
            this.tabRecords.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1160, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 842);
            this.Controls.Add(this.tabCategory);
            this.Name = "Form1";
            this.Text = "Robert Johnson\'s Media Library";
            this.tabCategory.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCategory;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabShows;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabRecords;
        private System.Windows.Forms.Button btnSearch;
    }
}

