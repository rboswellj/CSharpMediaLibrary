using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using MediaDB;
using System.Data.SqlClient;


namespace MediaDB
{
    public partial class FormDbInput : Form
    {
        public FormDbInput()
        {
            InitializeComponent();
        }

        public static string ConString = Config.ConString;

        List<Movie> MovieList = new List<Movie>();
        List<Game> GameList = new List<Game>();
        public static string MsgInvalid = "Invalid Entries. Please double check fields";
        public static string MsgCommit = "Changes Committed";
        public string[] MovieFields = { "Title", "Year", "Director", "Length", "Rating", "Genre" };
        public string[] GameFields = { "Title", "Year", "Developer", "Platform", "Score", "Genre" };

        // Creates new instances of category classes and adds to a list, rather than push
        // individual additions directly to the db. This feels cleaner
        // Because you only make one DB call for the whole input operation
        // Adds new objects into a list box so they can be inspected before commiting
        private void PopulateListBox(List<Movie> list)
        {
            foreach (Movie m in list)
            {
                listBoxAdded.Items.Add("M: " + m.Title);
            }
        }

        private void PopulateListBox(List<Game> list)
        {
            foreach (Game g in list)
            {
                listBoxAdded.Items.Add("G: " + g.Title);
            }
        }

        private void ClearFields(string[] arr, string category)
        {
            // Clear out text boxes for all fields named in arr, with category
            // Fields named with txt + Category + FieldName format
            foreach (string name in arr)
            {
                Control[] contArray = this.Controls.Find("txt" + category + name, true);
                contArray[0].Text = "";
            }
            chkMovieSeen.Checked = false;
            chkGamePlayed.Checked = false;
        }

        private void Add(string cat)
        {
            // Switch to determine what table is being updates.
            // Validation handled inside classes using System.ComponentModel.DataAnnotations;
            // Will throw exception if validation standards not met.
            // Prompts to check entries and try again.
            switch (cat)
            {
                case "Movies":
                    int seen = chkMovieSeen.Checked ? 1 : 0;
                    // Check to see if we are updating an item already in the list,
                    // Or adding a new item
                    if (!listBoxAdded.Items.Contains("M: " + txtMovieTitle.Text))
                    {
                        try
                        {
                            MovieList.Add(new Movie(
                                txtMovieTitle.Text, 
                                Convert.ToInt32(txtMovieYear.Text), 
                                txtMovieDirector.Text, 
                                txtMovieLength.Text, 
                                Convert.ToInt32(txtMovieRating.Text), 
                                seen, txtMovieGenre.Text
                            ));
                            listBoxAdded.ClearSelected();
                            listBoxAdded.Items.Clear();
                            PopulateListBox(MovieList);
                            PopulateListBox(GameList);
                            ClearFields(MovieFields, "Movie");

                        }
                        catch
                        {
                            MessageBox.Show(MsgInvalid);
                        }

                    } 
                    else
                    {
                        var selectedMovie = MovieList.FirstOrDefault(
                            m => m.Title == txtMovieTitle.Text);
                        selectedMovie.Title = txtMovieTitle.Text;
                        selectedMovie.Director = txtMovieDirector.Text;
                        selectedMovie.Year = Convert.ToInt32(txtMovieYear.Text);
                        selectedMovie.Length = TimeSpan.Parse(txtMovieLength.Text);
                        selectedMovie.Rating = Convert.ToInt32(txtMovieRating.Text);
                        selectedMovie.Genre = txtMovieGenre.Text;
                        selectedMovie.Seen = chkMovieSeen.Checked ? 1 : 0;
                        listBoxAdded.ClearSelected();
                        listBoxAdded.Items.Clear();
                        PopulateListBox(MovieList);
                        PopulateListBox(GameList);
                        ClearFields(MovieFields, "Movie");
                    }
                    break;
                    
                case "Games":
                    int played = chkGamePlayed.Checked ? 1 : 0;
                    if (!listBoxAdded.Items.Contains("G: " + txtGameTitle.Text))
                    {
                        try
                        {
                            GameList.Add(new Game(
                                txtGameTitle.Text,
                                Convert.ToInt32(txtGameYear.Text),
                                txtGameDeveloper.Text,
                                txtGamePlatform.Text,
                                Convert.ToInt32(txtGameScore.Text),
                                played, txtGameGenre.Text
                            ));
                            listBoxAdded.ClearSelected();
                            listBoxAdded.Items.Clear();
                            PopulateListBox(MovieList);
                            PopulateListBox(GameList);
                            ClearFields(GameFields, "Game");
                        }
                        catch
                        {
                            MessageBox.Show(MsgInvalid);
                        }
                    }
                    else
                    {
                        var selectedGame = GameList.FirstOrDefault(
                            g => g.Title == txtGameTitle.Text);
                        selectedGame.Title = txtGameTitle.Text;
                        selectedGame.Developer = txtGameDeveloper.Text;
                        selectedGame.Year = Convert.ToInt32(txtGameYear.Text);
                        selectedGame.Platform = txtGamePlatform.Text;
                        selectedGame.Score = Convert.ToInt32(txtGameScore.Text);
                        selectedGame.Genre = txtGameGenre.Text;
                        selectedGame.Played = chkGamePlayed.Checked ? 1 : 0;
                        listBoxAdded.ClearSelected();
                        listBoxAdded.Items.Clear();
                        PopulateListBox(MovieList);
                        PopulateListBox(GameList);
                        ClearFields(GameFields, "Game");
                    }
                    break;
            }

        }

        // Whole window events

        private void BtnEntryCommit_Click(object sender, EventArgs e)
        {
            var confirmed = MessageBox.Show("Are you sure you want to commit these items?", 
                "Confirm", MessageBoxButtons.YesNo);
            if(confirmed == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                foreach (Movie m in MovieList)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("AddMovie", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@title", m.Title));
                        cmd.Parameters.Add(new SqlParameter("@year", m.Year));
                        cmd.Parameters.Add(new SqlParameter("@director", m.Director));
                        cmd.Parameters.Add(new SqlParameter("@length", m.Length));
                        cmd.Parameters.Add(new SqlParameter("@rating", m.Rating));
                        cmd.Parameters.Add(new SqlParameter("@seen", m.Seen));
                        cmd.Parameters.Add(new SqlParameter("@genre", m.Genre));
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                foreach (Game m in GameList)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("AddGame", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@title", m.Title));
                        cmd.Parameters.Add(new SqlParameter("@year", m.Year));
                        cmd.Parameters.Add(new SqlParameter("@developer", m.Developer));
                        cmd.Parameters.Add(new SqlParameter("@platform", m.Platform));
                        cmd.Parameters.Add(new SqlParameter("@score", m.Score));
                        cmd.Parameters.Add(new SqlParameter("@played", m.Played));
                        cmd.Parameters.Add(new SqlParameter("@genre", m.Genre));
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                listBoxAdded.ClearSelected();
                listBoxAdded.Items.Clear();
                con.Close();
                this.Close();
            }
            
            
        }

        // Movie Events

        private void BtnMovieAdd_Click(object sender, EventArgs e)
        {
            Add("Movies");
        }

        private void BtnMovieClear_Click(object sender, EventArgs e)
        {
            ClearFields(MovieFields, "Movie");
        }

        private void BtnGameAdd_Click(object sender, EventArgs e)
        {
            Add("Games");
        }

        private void BtnGameClear_Click(object sender, EventArgs e)
        {
            ClearFields(GameFields, "Game");
        }

        private void ListBoxAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAdded.SelectedItem != null)
                {
                    string selectedName = listBoxAdded.SelectedItem.ToString();
                    switch (selectedName[0])
                    {
                        case 'M':
                            tabControlInput.SelectedTab = tabMovieInput;
                            var selectedMovie = MovieList.FirstOrDefault(m => m.Title == selectedName[3..]);
                            txtMovieTitle.Text = selectedMovie.Title;
                            txtMovieDirector.Text = selectedMovie.Director;
                            txtMovieYear.Text = selectedMovie.Year.ToString();
                            txtMovieLength.Text = selectedMovie.Length.ToString();
                            txtMovieRating.Text = selectedMovie.Rating.ToString();
                            txtMovieGenre.Text = selectedMovie.Genre;
                            if (selectedMovie.Seen == 1)
                            {
                                chkMovieSeen.Checked = true;
                            }
                            else
                            {
                                chkMovieSeen.Checked = false;
                            }
                            break;
                        case 'G':
                            tabControlInput.SelectedTab = tabGameInput;
                            var selectedGame = GameList.FirstOrDefault(g => g.Title == selectedName[3..]);
                            txtGameTitle.Text = selectedGame.Title;
                            txtGameDeveloper.Text = selectedGame.Developer;
                            txtGameYear.Text = selectedGame.Year.ToString();
                            txtGamePlatform.Text = selectedGame.Platform;
                            txtGameScore.Text = selectedGame.Score.ToString();
                            txtGameGenre.Text = selectedGame.Genre;
                            if (selectedGame.Played == 1)
                            {
                                chkGamePlayed.Checked = true;
                            }
                            else
                            {
                                chkGamePlayed.Checked = false;
                            }
                            break;
                    }

                }
                }
                catch (Exception err) { }

            }
        }
    }

