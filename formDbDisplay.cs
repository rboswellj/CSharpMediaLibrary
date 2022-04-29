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

namespace MovieDB
{
    public partial class formDbDisplay : Form
    {
        public formDbDisplay()
        {
            InitializeComponent();
            
        }
        public static string localPath = "C:\\Users\\Robert\\OneDrive\\Documents\\School\\cSharp2\\MovieDB";
        public static string relative = "[DataDirectory]";

        BindingSource binder = new BindingSource();
        public static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            localPath + "\\media.mdf;" + 
            "Integrated Security = True; Connect Timeout = 30";


        

        private void SearchSql()
        {
            // Search by title
            string searchStr = String.Empty;
            string searchCat = cmbSearch.Text;

            if (txtSearch.Text != String.Empty)
            {
                // If search box is empty will attempt to parse to int. If not int message invalid
                searchStr = txtSearch.Text;
                string procedure = String.Empty;
                string param = String.Empty;
                try
                {
                    // Query DB for student ID entered in search
                    //TODO: Add response message when no match found
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

        private void GetAllMovies()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("getAllMovies", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            binder.DataSource = dataTable;
            gridMovies.DataSource = binder;
            con.Close();
        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            GetAllMovies();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchSql();
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchSql();
            }
        }

    }
}
