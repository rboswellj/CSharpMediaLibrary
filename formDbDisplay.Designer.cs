
namespace MovieDB
{
    partial class FormDbDisplay
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
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.gridMovies = new System.Windows.Forms.DataGridView();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabShows = new System.Windows.Forms.TabPage();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabRecords = new System.Windows.Forms.TabPage();
            this.btnEnterNew = new System.Windows.Forms.Button();
            this.tabCategory.SuspendLayout();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).BeginInit();
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
            this.tabCategory.Size = new System.Drawing.Size(1350, 593);
            this.tabCategory.TabIndex = 0;
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.cmbSearch);
            this.tabMovies.Controls.Add(this.gridMovies);
            this.tabMovies.Controls.Add(this.btnGetAll);
            this.tabMovies.Controls.Add(this.btnSearch);
            this.tabMovies.Controls.Add(this.txtSearch);
            this.tabMovies.Location = new System.Drawing.Point(8, 46);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(1334, 539);
            this.tabMovies.TabIndex = 0;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Title",
            "Director",
            "Genre",
            "Rating (Higher Than)",
            "Rating (Lower Than)"});
            this.cmbSearch.Location = new System.Drawing.Point(371, 30);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(242, 40);
            this.cmbSearch.TabIndex = 5;
            // 
            // gridMovies
            // 
            this.gridMovies.AllowUserToOrderColumns = true;
            this.gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovies.Location = new System.Drawing.Point(37, 88);
            this.gridMovies.Name = "gridMovies";
            this.gridMovies.RowHeadersWidth = 82;
            this.gridMovies.RowTemplate.Height = 41;
            this.gridMovies.Size = new System.Drawing.Size(1266, 424);
            this.gridMovies.TabIndex = 4;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(1153, 30);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(150, 42);
            this.btnGetAll.TabIndex = 3;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.BtnGetAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(997, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(619, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(372, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
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
            // btnEnterNew
            // 
            this.btnEnterNew.Location = new System.Drawing.Point(1076, 614);
            this.btnEnterNew.Name = "btnEnterNew";
            this.btnEnterNew.Size = new System.Drawing.Size(247, 46);
            this.btnEnterNew.TabIndex = 1;
            this.btnEnterNew.Text = "Add New Media";
            this.btnEnterNew.UseVisualStyleBackColor = true;
            this.btnEnterNew.Click += new System.EventHandler(this.BtnEnterNew_Click);
            // 
            // formDbDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 684);
            this.Controls.Add(this.btnEnterNew);
            this.Controls.Add(this.tabCategory);
            this.Name = "formDbDisplay";
            this.Text = "Robert Johnson\'s Media Library";
            this.tabCategory.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).EndInit();
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
        private System.Windows.Forms.DataGridView gridMovies;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnEnterNew;
    }
}

