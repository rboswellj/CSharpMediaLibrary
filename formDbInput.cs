using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaDB
{
    public partial class FormDbInput : Form
    {
        public FormDbInput()
        {
            InitializeComponent();
        }

        List<Movie> movieList = new List<Movie>();
        private bool validMovie = false;

        private void BtnMovieSubmit_Click(object sender, EventArgs e)
        {
            if (validMovie)
            {
                int seen;
                if (chkMovieSeen.Checked)
                {
                    seen = 1;
                } else
                {
                    seen = 0;
                }
                movieList.Add(new Movie(txtMovieTitle.Text, Convert.ToInt32(txtMovieYear.Text), txtMovieDirector.Text,
                    txtMovieLength.Text, Convert.ToInt32(txtMovieRating.Text), seen, txtMovieGenre.Text));
            }
        }
    }
}
