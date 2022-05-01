﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaDB;
using System.Data.SqlClient;

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

        private void FillFields()
        {
            txtMovieTitle.Text = m.Title;
            txtMovieDirector.Text = m.Director;
            txtMovieLength.Text = m.Length.ToString();
            txtMovieYear.Text = m.Year.ToString();
            txtMovieRating.Text = m.Rating.ToString();
            txtMovieGenre.Text = m.Genre.ToString();
            if(m.Seen == 1)
            {
                chkMovieSeen.Checked = true;
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
            SqlConnection con = new SqlConnection(FormDbInput.ConString);
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

            MessageBox.Show(FormDbInput.MsgCommit);
        }
    }
}
