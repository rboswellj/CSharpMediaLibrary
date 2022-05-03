using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediaDB
{
    public partial class FormDbDisplay : Form
    {
        //Todo: Add Remove option for listBox items before committing.
        public FormDbDisplay()
        {
            InitializeComponent();
            GetAll("Movies");

            cmbMovieSearch.SelectedIndex = 0;
            cmbGameSearch.SelectedIndex = 0;
        }

        readonly BindingSource _binder = new BindingSource();
        //public static string ConString = Config.ConString;
        public static string ConString = Properties.Settings.Default.mDB;
        public static Movie selectedMovie;
        public static int selectedMovieID;
        public static Game selectedGame;
        public static int selectedGameID;

        #region Grid Format
        private void GridMovieFormat()
        {
            // Changing width on data grid cells, since the auto sizing is a nightmare
            gridMovies.Columns[0].Width = 70;
            gridMovies.Columns[1].Width = 300;
            gridMovies.Columns[2].Width = 100;
            gridMovies.Columns[3].Width = 250;
            gridMovies.Columns[4].Width = 200;
            gridMovies.Columns[5].Width = 110;
            gridMovies.Columns[6].Width = 80;
            gridMovies.Columns[7].Width = 70;
        }
        private void GridGameFormat()
        {
            // Changing width on data grid cells, since the auto sizing is a nightmare
            gridGames.Columns[0].Width = 70;
            gridGames.Columns[1].Width = 300;
            gridGames.Columns[2].Width = 100;
            gridGames.Columns[3].Width = 200;
            gridGames.Columns[4].Width = 110;
            gridGames.Columns[5].Width = 100;
            gridGames.Columns[6].Width = 70;
            gridGames.Columns[7].Width = 210;
        }

        #endregion

        #region Methods
        private void Search(string cat)
        {
            // Search by title
            string searchStr = String.Empty;
            string searchCat;
            string procedure = String.Empty;
            string param = String.Empty;

            // Switch which DB is being searched
            switch (cat)
            {
                case "Movies":
                    searchCat = cmbMovieSearch.Text;
                    searchStr = txtMovieSearch.Text;
                    // Category of search in combo box dictates procedure and params
                    //MessageBox.Show("Searching Movies");
                    switch (searchCat)
                    {
                        case "Title":
                            //MessageBox.Show("Searching Title");
                            procedure = "GetMovieByTitle";
                            param = "@title";
                            break;
                        case "Genre":
                            procedure = "GetMovieByGenre";
                            param = "@genre";
                            break;
                        case "Director":
                            procedure = "GetMovieByDirector";
                            param = "@director";
                            break;
                        default:
                            //MessageBox.Show("Searching Title");
                            procedure = "GetMovieByTitle";
                            param = "@title";
                            break;
                    }
                    break;
                case "Games":
                    //MessageBox.Show("Searching Games");
                    searchCat = cmbGameSearch.Text;
                    searchStr = txtGameSearch.Text;
                    // Category of search in combo box dictates procedure and params
                    switch (searchCat)
                    {
                        case "Title":
                            //MessageBox.Show("Searching Title");
                            procedure = "GetGameByTitle";
                            param = "@title";
                            break;
                        case "Genre":
                            procedure = "GetGameByGenre";
                            param = "@genre";
                            break;
                        case "Developer":
                            procedure = "GetGameByDeveloper";
                            param = "@developer";
                            break;
                        case "Platform":
                            procedure = "GetGameByPlatform";
                            param = "@platform";
                            break;
                        default:
                            procedure = "GetGameByTitle";
                            param = "@title";
                            break;
                    }
                    break;
            }

            try
            {
                //MessageBox.Show("Sql Connection Starting");
                //MessageBox.Show($"Procedure {procedure}");
                //MessageBox.Show($"param {param}");
                //MessageBox.Show($"Cat {searchCat}");
                //MessageBox.Show($"String {searchStr}");

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter(param, $"%{searchStr}%"));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                switch (cat)
                {
                    case "Movies":
                        gridMovies.DataSource = _binder;
                        GridMovieFormat();
                        break;
                    case "Games":
                        gridGames.DataSource = _binder;
                        GridGameFormat();
                        break;
                }
                _binder.DataSource = dataTable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetAll(string cat)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("getAll" + cat, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                _binder.DataSource = dataTable;
                switch (cat)
                {
                    case "Movies":
                        gridMovies.DataSource = _binder;
                        GridMovieFormat();
                        break;
                    case "Games":
                        gridGames.DataSource = _binder;
                        GridGameFormat();
                        break;
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }


        #endregion

        #region Events

        // Window Events
        private void TabCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCategory.SelectedTab == tabGames)
            {
                GetAll("Games");
            }
            else if (tabCategory.SelectedTab == tabMovies)
            {
                GetAll("Movies");
            }
        }
        private void BtnEnterNew_Click(object sender, EventArgs e)
        {
            // Opens Input window
            FormDbInput newInput = new FormDbInput();
            newInput.Show();
            newInput.FormClosed += new FormClosedEventHandler(EnterNewClosed);
        }

        private void EnterNewClosed(object sender, FormClosedEventArgs e)
        {
            tabCategory.SelectedTab = tabMovies;
            GetAll("Movies");
        }

        // Movie Tab Events
        private void BtnMovieSearch_Click(object sender, EventArgs e)
        {
            Search("Movies");
        }

        private void BtnMovieGetAll_Click(object sender, EventArgs e)
        {
            GetAll("Movies");
        }
        private void TxtMovieSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search("Movies");
            }
        }

        private void GridMovies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridMovies.Rows[e.RowIndex];
            selectedMovieID = Convert.ToInt32(row.Cells[0].Value.ToString());
            selectedMovie = new Movie(row.Cells[1].Value.ToString(),
                Convert.ToInt32(row.Cells[2].Value.ToString()),
                row.Cells[3].Value.ToString(),
                row.Cells[5].Value.ToString(),
                Convert.ToInt32(row.Cells[6].Value.ToString()),
                Convert.ToInt32(row.Cells[7].Value.ToString()),
                row.Cells[4].Value.ToString()
            );
            FormDbUpdateMovie newUpdateMovie = new FormDbUpdateMovie();
            newUpdateMovie.Show();
            newUpdateMovie.FormClosed += new FormClosedEventHandler(UpdateMovieClosed);
        }

        private void UpdateMovieClosed(object sender, FormClosedEventArgs e)
        {
            // Refresh Movie table after update
            GetAll("Movies");
        }

        // Game Tab Events
        private void BtnGameGetAll_Click(object sender, EventArgs e)
        {
            GetAll("Games");
        }

        private void BtnGameSearch_Click(object sender, EventArgs e)
        {
            Search("Games");
        }

        private void TxtGameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search("Games");
            }
        }

        private void GridGames_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridMovies.Rows[e.RowIndex];
            selectedGameID = Convert.ToInt32(row.Cells[0].Value.ToString());
            selectedGame = new Game(row.Cells[1].Value.ToString(),
                Convert.ToInt32(row.Cells[2].Value.ToString()),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                Convert.ToInt32(row.Cells[5].Value.ToString()),
                Convert.ToInt32(row.Cells[6].Value.ToString()),
                row.Cells[7].Value.ToString()

            );
            FormDbUpdateGame newUpdateGame = new FormDbUpdateGame();
            newUpdateGame.Show();
            newUpdateGame.FormClosed += new FormClosedEventHandler(UpdateGameClosed);
        }
        private void UpdateGameClosed(object sender, FormClosedEventArgs e)
        {
            // Refresh Games table after update
            GetAll("Games");
        }

        #endregion
    }
}
