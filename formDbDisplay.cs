using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MediaDB;

namespace MovieDB
{
    public partial class FormDbDisplay : Form
    {
        public FormDbDisplay()
        {
            InitializeComponent();
            GetAllMovies();
        }
        public static string localPath = "C:\\Users\\Robert\\OneDrive\\Documents\\School\\cSharp2\\MediaDB";
        public static string relative = "[DataDirectory]";

        BindingSource binder = new BindingSource();
        public static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            localPath + "\\media.mdf;" + 
            "Integrated Security = True; Connect Timeout = 30";



        private void SearchMovie()
        {
            // Search by title
            string searchStr = String.Empty;
            string searchCat = cmbMovieSearch.Text;

            if (txtMovieSearch.Text != String.Empty)
            {
                searchStr = txtMovieSearch.Text;
                string procedure = String.Empty;
                string param = String.Empty;
                try
                {
                    // Switch statement reads from combo box.
                    // Dictates which column will be searched and which params will be sent
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    switch (searchCat)
                    {
                        case "Title":
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
                            procedure = "GetMovieByTitle";
                            param = "@title";
                            break;
                    }

                    SqlCommand cmd = new SqlCommand(procedure, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter(param, $"%{searchStr}%"));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    gridMovies.DataSource = binder;
                    binder.DataSource = dataTable;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Search is empty. Please enter a title");
            }
        }

        private void SearchGame()
        {
            // Search by title
            string searchStr = String.Empty;
            string searchCat = cmbGameSearch.Text;

            if (txtMovieSearch.Text != String.Empty)
            {
                searchStr = txtGameSearch.Text;
                string procedure = String.Empty;
                string param = String.Empty;
                try
                {
                    // Switch statement reads from combo box.
                    // Dictates which column will be searched and which params will be sent
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    switch (searchCat)
                    {
                        case "Title":
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

                    SqlCommand cmd = new SqlCommand(procedure, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter(param, $"%{searchStr}%"));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    gridGames.DataSource = binder;
                    binder.DataSource = dataTable;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Search is empty. Please enter a title");
            }
        }

        private void GetAll(string cat)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("getAll" + cat, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            binder.DataSource = dataTable;
            switch (cat)
            {
                case "Movie":
                    gridMovies.DataSource = binder;
                    break;
                case "Game":
                    gridGames.DataSource = binder;
                    break;
            }
            
            con.Close();
        }


        private void BtnEnterNew_Click(object sender, EventArgs e)
        {
            FormDbInput newInput = new FormDbInput();
            newInput.Show();
        }


        private void BtnMovieSearch_Click(object sender, EventArgs e)
        {
            SearchMovie();
        }

        private void BtnMovieGetAll_Click(object sender, EventArgs e)
        {
            GetAll("Movies");
        }
    }
}
