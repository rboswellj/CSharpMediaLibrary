using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediaDB
{
    public partial class FormDbUpdateMovie : Form
    {
        public FormDbUpdateMovie()
        {
            InitializeComponent();
            FillFields();
        }

        Movie m = FormDbDisplay.selectedMovie;
        public static string ConString = Properties.Settings.Default.mDB;


        private void FillFields()
        {
            txtMovieTitle.Text = m.Title;
            txtMovieDirector.Text = m.Director;
            txtMovieLength.Text = m.Length.ToString();
            txtMovieYear.Text = m.Year.ToString();
            txtMovieRating.Text = m.Rating.ToString();
            txtMovieGenre.Text = m.Genre;
            if (m.Seen == 1)
            {
                chkMovieSeen.Checked = true;
            }
            else
            {
                chkMovieSeen.Checked = false;
            }
        }

        private void BtnMovieUpdate_Click(object sender, EventArgs e)
        {
            // Attempt to update Movie object to check validation
            try
            {
                m.Title = txtMovieTitle.Text;
                m.Director = txtMovieDirector.Text;
                m.Length = TimeSpan.Parse(txtMovieLength.Text);
                m.Year = Convert.ToInt32(txtMovieYear.Text);
                m.Rating = Convert.ToInt32(txtMovieRating.Text);
                m.Genre = txtMovieGenre.Text;
                m.Seen = chkMovieSeen.Checked ? 1 : 0;
            }
            catch
            {
                MessageBox.Show(FormDbInput.MsgInvalid);
            }
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateMovie", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", FormDbDisplay.selectedMovieID));
                cmd.Parameters.Add(new SqlParameter("@title", m.Title));
                cmd.Parameters.Add(new SqlParameter("@year", m.Year));
                cmd.Parameters.Add(new SqlParameter("@director", m.Director));
                cmd.Parameters.Add(new SqlParameter("@length", m.Length));
                cmd.Parameters.Add(new SqlParameter("@rating", m.Rating));
                cmd.Parameters.Add(new SqlParameter("@seen", m.Seen));
                cmd.Parameters.Add(new SqlParameter("@genre", m.Genre));
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void BtnMovieDelete_Click(object sender, EventArgs e)
        {
            var confirmed = MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmed == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(FormDbInput.ConString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DeleteMovie", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", FormDbDisplay.selectedMovieID));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                
            }
        }
    }
}
