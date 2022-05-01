using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public static string LocalPath = "C:\\Users\\Robert\\OneDrive\\Documents\\School\\cSharp2\\MediaDB";
        //public static string Relative = "[DataDirectory]";

        public static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            LocalPath + "\\media.mdf;" +
            "Integrated Security = True; Connect Timeout = 30";

        List<Movie> movieList = new List<Movie>();
        List<Game> gameList = new List<Game>();
        public string[] movieFields = { "Title", "Year", "Director", "Length", "Rating", "Genre" };

        // Creates new instances of category classes and adds to a list, rather than push
        // individual additions directly to the db. This feels cleaner
        // Because you only make one DB call for the whole input operation
        // Adds new objects into a list box so they can be inspected before commiting
        private void PopulateListBox(List<Movie> list)
        {
            foreach (Movie m in list)
            {
                listBoxAdded.Items.Add(m.Title);
            }
        }

        private void PopulateListBox(List<Game> list)
        {
            foreach (Game g in list)
            {
                listBoxAdded.Items.Add(g.Title);
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

                try
                {
                    movieList.Add(new Movie(txtMovieTitle.Text, Convert.ToInt32(txtMovieYear.Text), txtMovieDirector.Text,
                        txtMovieLength.Text, Convert.ToInt32(txtMovieRating.Text), seen, txtMovieGenre.Text));
                    listBoxAdded.ClearSelected();
                    listBoxAdded.Items.Clear();
                    PopulateListBox(movieList);
                    ClearFields(movieFields, "Movie");

                }
                catch (ValidationException ve)
                {
                    //MessageBox.Show(ve.Message);
                    MessageBox.Show("Invalid Entries. Please double check fields");
                }
                catch (Exception err)
                {
                    //MessageBox.Show(err.Message);
                    MessageBox.Show("Invalid Entries. Please double check fields");
                }

                break;

            }

        }


        private void BtnMovieClear_Click(object sender, EventArgs e)
        {
            ClearFields(movieFields, "Movie");
        }

        private void BtnEntryCommit_Click(object sender, EventArgs e)
        {
            foreach (Movie m in movieList)
            {
                try
                {
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
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
                    MessageBox.Show("Updated:");

                    con.Close();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            foreach (Game m in gameList)
            {
                try
                {
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
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
                    MessageBox.Show("Updated:");

                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void BtnMovieAdd_Click(object sender, EventArgs e)
        {
            Add("Movies");
        }
    }
}
