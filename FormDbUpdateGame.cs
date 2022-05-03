﻿using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediaDB
{
    public partial class FormDbUpdateGame : Form
    {
        public FormDbUpdateGame()
        {
            InitializeComponent();
            FillFields();
        }

        Game g = FormDbDisplay.selectedGame;
        public bool deleteConfirm = false;
        public static string ConString = Properties.Settings.Default.mDB;


        private void FillFields()
        {
            txtGameTitle.Text = g.Title;
            txtGameDeveloper.Text = g.Developer;
            txtGamePlatform.Text = g.Platform;
            txtGameYear.Text = g.Year.ToString();
            txtGameScore.Text = g.Score.ToString();
            txtGameGenre.Text = g.Genre;
            if (g.Played == 1)
            {
                chkGamePlayed.Checked = true;
            }
            else
            {
                chkGamePlayed.Checked = false;
            }
        }
        private void BtnGameUpdate_Click(object sender, EventArgs e)
        {
            // Attempt to update Game object to check validation
            try
            {
                g.Title = txtGameTitle.Text;
                g.Developer = txtGameDeveloper.Text;
                g.Platform = txtGamePlatform.Text;
                g.Year = Convert.ToInt32(txtGameYear.Text);
                g.Score = Convert.ToInt32(txtGameScore.Text);
                g.Genre = txtGameGenre.Text;
                g.Played = chkGamePlayed.Checked ? 1 : 0;
            }
            catch
            {
                MessageBox.Show(FormDbInput.MsgInvalid);
            }
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateGame", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", FormDbDisplay.selectedGameID));
                cmd.Parameters.Add(new SqlParameter("@title", g.Title));
                cmd.Parameters.Add(new SqlParameter("@year", g.Year));
                cmd.Parameters.Add(new SqlParameter("@developer", g.Developer));
                cmd.Parameters.Add(new SqlParameter("@platform", g.Platform));
                cmd.Parameters.Add(new SqlParameter("@score", g.Score));
                cmd.Parameters.Add(new SqlParameter("@played", g.Played));
                cmd.Parameters.Add(new SqlParameter("@genre", g.Genre));
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnGameDelete_Click(object sender, EventArgs e)
        {
            var confirmed = MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmed == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(FormDbInput.ConString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DeleteGame", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", FormDbDisplay.selectedGameID));
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
