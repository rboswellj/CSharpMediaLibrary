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

namespace MediaDB
{
    public partial class FormDbDisplay : Form
    {
        public FormDbDisplay()
        {
            InitializeComponent();
            GetAll("Movies");
        }

        public static string LocalPath = "C:\\Users\\Robert\\OneDrive\\Documents\\School\\cSharp2\\MediaDB";
        //public static string Relative = "[DataDirectory]";

        BindingSource binder = new BindingSource();
        public static string ConString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            LocalPath + "\\media.mdf;" + 
            "Integrated Security = True; Connect Timeout = 30";

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
                        gridMovies.DataSource = binder;
                        break;
                    case "Games":
                        gridGames.DataSource = binder;
                        break;
                }
                binder.DataSource = dataTable;
                con.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAll(string cat)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("getAll" + cat, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            binder.DataSource = dataTable;
            switch (cat)
            {
                case "Movies":
                    gridMovies.DataSource = binder;
                    break;
                case "Games":
                    gridGames.DataSource = binder;
                    break;
            }
            
            con.Close();
        }

  
        private void BtnEnterNew_Click(object sender, EventArgs e)
        {
            // Opens Input window
            FormDbInput newInput = new FormDbInput();
            newInput.Show();
        }

        

        private void BtnMovieSearch_Click(object sender, EventArgs e)
        {
            Search("Movies");
        }

        private void BtnMovieGetAll_Click(object sender, EventArgs e)
        {
            GetAll("Movies");
        }


        private void BtnGameSearch_Click(object sender, EventArgs e)
        {
            Search("Games");
        }
    }
}
