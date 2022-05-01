
namespace MediaDB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabCategory.Location = new System.Drawing.Point(12, 12);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.SelectedIndex = 0;
            this.tabCategory.Size = new System.Drawing.Size(1350, 834);
            this.tabCategory.TabIndex = 0;
            this.tabCategory.SelectedIndexChanged += new System.EventHandler(this.TabCategory_SelectedIndexChanged);
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
            this.tabMovies.Size = new System.Drawing.Size(1334, 780);
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
            "Genre"});
            this.cmbMovieSearch.Location = new System.Drawing.Point(371, 30);
            this.cmbMovieSearch.Name = "cmbMovieSearch";
            this.cmbMovieSearch.Size = new System.Drawing.Size(242, 40);
            this.cmbMovieSearch.TabIndex = 5;
            // 
            // gridMovies
            // 
            this.gridMovies.AllowUserToAddRows = false;
            this.gridMovies.AllowUserToDeleteRows = false;
            this.gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMovies.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridMovies.Location = new System.Drawing.Point(34, 88);
            this.gridMovies.Name = "gridMovies";
            this.gridMovies.ReadOnly = true;
            this.gridMovies.RowHeadersWidth = 82;
            this.gridMovies.RowTemplate.Height = 41;
            this.gridMovies.Size = new System.Drawing.Size(1266, 660);
            this.gridMovies.TabIndex = 4;
            this.gridMovies.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMovies_CellContentDoubleClick);
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
            this.txtMovieSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMovieSearch_KeyUp);
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
            this.tabGames.Size = new System.Drawing.Size(1334, 780);
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
            this.cmbGameSearch.Location = new System.Drawing.Point(371, 30);
            this.cmbGameSearch.Name = "cmbGameSearch";
            this.cmbGameSearch.Size = new System.Drawing.Size(242, 40);
            this.cmbGameSearch.TabIndex = 10;
            // 
            // gridGames
            // 
            this.gridGames.AllowUserToAddRows = false;
            this.gridGames.AllowUserToDeleteRows = false;
            this.gridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridGames.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridGames.Location = new System.Drawing.Point(34, 88);
            this.gridGames.Name = "gridGames";
            this.gridGames.ReadOnly = true;
            this.gridGames.RowHeadersWidth = 100;
            this.gridGames.RowTemplate.Height = 41;
            this.gridGames.Size = new System.Drawing.Size(1266, 660);
            this.gridGames.TabIndex = 9;
            this.gridGames.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGames_CellContentDoubleClick);
            // 
            // btnGameGetAll
            // 
            this.btnGameGetAll.Location = new System.Drawing.Point(1153, 30);
            this.btnGameGetAll.Name = "btnGameGetAll";
            this.btnGameGetAll.Size = new System.Drawing.Size(150, 42);
            this.btnGameGetAll.TabIndex = 8;
            this.btnGameGetAll.Text = "Get All";
            this.btnGameGetAll.UseVisualStyleBackColor = true;
            this.btnGameGetAll.Click += new System.EventHandler(this.BtnGameGetAll_Click);
            // 
            // btnGameSearch
            // 
            this.btnGameSearch.Location = new System.Drawing.Point(997, 31);
            this.btnGameSearch.Name = "btnGameSearch";
            this.btnGameSearch.Size = new System.Drawing.Size(150, 42);
            this.btnGameSearch.TabIndex = 7;
            this.btnGameSearch.Text = "Search";
            this.btnGameSearch.UseVisualStyleBackColor = true;
            this.btnGameSearch.Click += new System.EventHandler(this.BtnGameSearch_Click);
            // 
            // txtGameSearch
            // 
            this.txtGameSearch.Location = new System.Drawing.Point(619, 32);
            this.txtGameSearch.Name = "txtGameSearch";
            this.txtGameSearch.Size = new System.Drawing.Size(372, 39);
            this.txtGameSearch.TabIndex = 6;
            this.txtGameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtGameSearch_KeyUp);
            // 
            // btnEnterNew
            // 
            this.btnEnterNew.Location = new System.Drawing.Point(1076, 866);
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
            this.ClientSize = new System.Drawing.Size(1374, 943);
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

