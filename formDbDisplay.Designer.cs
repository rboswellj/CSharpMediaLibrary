
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
            this.cmbMovieSearch = new System.Windows.Forms.ComboBox();
            this.gridMovies = new System.Windows.Forms.DataGridView();
            this.btnMovieGetAll = new System.Windows.Forms.Button();
            this.btnMovieSearch = new System.Windows.Forms.Button();
            this.txtMovieSearch = new System.Windows.Forms.TextBox();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.cmbGameSearch = new System.Windows.Forms.ComboBox();
            this.gridGames = new System.Windows.Forms.DataGridView();
            this.btnGameGetAll = new System.Windows.Forms.Button();
            this.btnGameSearch = new System.Windows.Forms.Button();
            this.txtGameSearch = new System.Windows.Forms.TextBox();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabRecords = new System.Windows.Forms.TabPage();
            this.btnEnterNew = new System.Windows.Forms.Button();
            this.tabCategory.SuspendLayout();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).BeginInit();
            this.tabGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.tabMovies);
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
            this.tabMovies.Controls.Add(this.cmbMovieSearch);
            this.tabMovies.Controls.Add(this.gridMovies);
            this.tabMovies.Controls.Add(this.btnMovieGetAll);
            this.tabMovies.Controls.Add(this.btnMovieSearch);
            this.tabMovies.Controls.Add(this.txtMovieSearch);
            this.tabMovies.Location = new System.Drawing.Point(8, 46);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(1334, 539);
            this.tabMovies.TabIndex = 0;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // cmbMovieSearch
            // 
            this.cmbMovieSearch.FormattingEnabled = true;
            this.cmbMovieSearch.Items.AddRange(new object[] {
            "Title",
            "Director",
            "Genre",
            "Rating (Higher Than)",
            "Rating (Lower Than)"});
            this.cmbMovieSearch.Location = new System.Drawing.Point(371, 30);
            this.cmbMovieSearch.Name = "cmbMovieSearch";
            this.cmbMovieSearch.Size = new System.Drawing.Size(242, 40);
            this.cmbMovieSearch.TabIndex = 5;
            // 
            // gridMovies
            // 
            this.gridMovies.AllowUserToOrderColumns = true;
            this.gridMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovies.Location = new System.Drawing.Point(37, 88);
            this.gridMovies.Name = "gridMovies";
            this.gridMovies.RowHeadersWidth = 82;
            this.gridMovies.RowTemplate.Height = 41;
            this.gridMovies.Size = new System.Drawing.Size(1266, 424);
            this.gridMovies.TabIndex = 4;
            // 
            // btnMovieGetAll
            // 
            this.btnMovieGetAll.Location = new System.Drawing.Point(1153, 30);
            this.btnMovieGetAll.Name = "btnMovieGetAll";
            this.btnMovieGetAll.Size = new System.Drawing.Size(150, 42);
            this.btnMovieGetAll.TabIndex = 3;
            this.btnMovieGetAll.Text = "Get All";
            this.btnMovieGetAll.UseVisualStyleBackColor = true;
            this.btnMovieGetAll.Click += new System.EventHandler(this.BtnMovieGetAll_Click);
            // 
            // btnMovieSearch
            // 
            this.btnMovieSearch.Location = new System.Drawing.Point(997, 31);
            this.btnMovieSearch.Name = "btnMovieSearch";
            this.btnMovieSearch.Size = new System.Drawing.Size(150, 42);
            this.btnMovieSearch.TabIndex = 2;
            this.btnMovieSearch.Text = "Search";
            this.btnMovieSearch.UseVisualStyleBackColor = true;
            this.btnMovieSearch.Click += new System.EventHandler(this.BtnMovieSearch_Click);
            // 
            // txtMovieSearch
            // 
            this.txtMovieSearch.Location = new System.Drawing.Point(619, 32);
            this.txtMovieSearch.Name = "txtMovieSearch";
            this.txtMovieSearch.Size = new System.Drawing.Size(372, 39);
            this.txtMovieSearch.TabIndex = 1;
            // 
            // tabGames
            // 
            this.tabGames.Controls.Add(this.cmbGameSearch);
            this.tabGames.Controls.Add(this.gridGames);
            this.tabGames.Controls.Add(this.btnGameGetAll);
            this.tabGames.Controls.Add(this.btnGameSearch);
            this.tabGames.Controls.Add(this.txtGameSearch);
            this.tabGames.Location = new System.Drawing.Point(8, 46);
            this.tabGames.Name = "tabGames";
            this.tabGames.Size = new System.Drawing.Size(1334, 539);
            this.tabGames.TabIndex = 2;
            this.tabGames.Text = "Games";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // cmbGameSearch
            // 
            this.cmbGameSearch.FormattingEnabled = true;
            this.cmbGameSearch.Items.AddRange(new object[] {
            "Title",
            "Developer",
            "Platform",
            "Genre"});
            this.cmbGameSearch.Location = new System.Drawing.Point(368, 28);
            this.cmbGameSearch.Name = "cmbGameSearch";
            this.cmbGameSearch.Size = new System.Drawing.Size(242, 40);
            this.cmbGameSearch.TabIndex = 10;
            // 
            // gridGames
            // 
            this.gridGames.AllowUserToOrderColumns = true;
            this.gridGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGames.Location = new System.Drawing.Point(34, 86);
            this.gridGames.Name = "gridGames";
            this.gridGames.RowHeadersWidth = 82;
            this.gridGames.RowTemplate.Height = 41;
            this.gridGames.Size = new System.Drawing.Size(1266, 424);
            this.gridGames.TabIndex = 9;
            // 
            // btnGameGetAll
            // 
            this.btnGameGetAll.Location = new System.Drawing.Point(1150, 28);
            this.btnGameGetAll.Name = "btnGameGetAll";
            this.btnGameGetAll.Size = new System.Drawing.Size(150, 42);
            this.btnGameGetAll.TabIndex = 8;
            this.btnGameGetAll.Text = "Get All";
            this.btnGameGetAll.UseVisualStyleBackColor = true;
            // 
            // btnGameSearch
            // 
            this.btnGameSearch.Location = new System.Drawing.Point(994, 29);
            this.btnGameSearch.Name = "btnGameSearch";
            this.btnGameSearch.Size = new System.Drawing.Size(150, 42);
            this.btnGameSearch.TabIndex = 7;
            this.btnGameSearch.Text = "Search";
            this.btnGameSearch.UseVisualStyleBackColor = true;
            // 
            // txtGameSearch
            // 
            this.txtGameSearch.Location = new System.Drawing.Point(616, 30);
            this.txtGameSearch.Name = "txtGameSearch";
            this.txtGameSearch.Size = new System.Drawing.Size(372, 39);
            this.txtGameSearch.TabIndex = 6;
            // 
            // tabBooks
            // 
            this.tabBooks.Location = new System.Drawing.Point(8, 46);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Size = new System.Drawing.Size(1334, 539);
            this.tabBooks.TabIndex = 3;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabRecords
            // 
            this.tabRecords.Location = new System.Drawing.Point(8, 46);
            this.tabRecords.Name = "tabRecords";
            this.tabRecords.Size = new System.Drawing.Size(1334, 539);
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
            // FormDbDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 684);
            this.Controls.Add(this.btnEnterNew);
            this.Controls.Add(this.tabCategory);
            this.Name = "FormDbDisplay";
            this.Text = "Robert Johnson\'s Media Library";
            this.tabCategory.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).EndInit();
            this.tabGames.ResumeLayout(false);
            this.tabGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCategory;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TextBox txtMovieSearch;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabRecords;
        private System.Windows.Forms.Button btnMovieSearch;
        private System.Windows.Forms.DataGridView gridMovies;
        private System.Windows.Forms.Button btnMovieGetAll;
        private System.Windows.Forms.ComboBox cmbMovieSearch;
        private System.Windows.Forms.Button btnEnterNew;
        private System.Windows.Forms.ComboBox cmbGameSearch;
        private System.Windows.Forms.DataGridView gridGames;
        private System.Windows.Forms.Button btnGameGetAll;
        private System.Windows.Forms.Button btnGameSearch;
        private System.Windows.Forms.TextBox txtGameSearch;
    }
}

