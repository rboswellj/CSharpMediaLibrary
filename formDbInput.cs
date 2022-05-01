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

        public static string localPath = "C:\\Users\\Robert\\OneDrive\\Documents\\School\\cSharp2\\MediaDB";
        public static string relative = "[DataDirectory]";

        BindingSource binder = new BindingSource();
        public static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            localPath + "\\media.mdf;" +
            "Integrated Security = True; Connect Timeout = 30";

        List<Movie> movieList = new List<Movie>();
        public string[] movieFields = { "Title", "Year", "Director", "Length", "Rating", "Genre" };

        private void PopulateListBox(List<Movie> list)
        {
            foreach (Movie m in list)
            {
                listBoxAdded.Items.Add(m.title);
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


        private void BtnMovieSubmit_Click(object sender, EventArgs e)
        {
            
            int seen;
            if (chkMovieSeen.Checked)
            {
                seen = 1;
            } else
            {
                seen = 0;
            }
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
            catch(Exception err)
            {
                //MessageBox.Show(err.Message);
                MessageBox.Show("Invalid Entries. Please double check fields");
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
                    cmd.Parameters.Add(new SqlParameter("@title", m.title));
                    cmd.Parameters.Add(new SqlParameter("@year", m.year));
                    cmd.Parameters.Add(new SqlParameter("@director", m.director));
                    cmd.Parameters.Add(new SqlParameter("@length", m.length));
                    cmd.Parameters.Add(new SqlParameter("@rating", m.tomato_rating));
                    cmd.Parameters.Add(new SqlParameter("@seen", m.seen));
                    cmd.Parameters.Add(new SqlParameter("@genre", m.genre));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated:");

                    con.Close();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
