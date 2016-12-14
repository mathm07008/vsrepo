using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ExcelAddIn1
{
    public partial class Ribbon1
    {
        SqlConnection c = new SqlConnection();
        MySqlConnection con;
        DataGridView fixturesGrid;
        excelTraderForm mainForm = new excelTraderForm();
        int fixCode;
        int runner;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            con = c.getConnection();
            con.Open();
            mainForm.button1.Click += new System.EventHandler(this.set_Click);
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            showFixturesGrid();
        }

        private void showFixturesGrid()
        {
            
            fixturesGrid = mainForm.dataGridView1;

            string c1 = @"SELECT A.FixCode as Code, A.SportName as Sport, A.CompetitionName as Competition, 
                    A.HomeTeamName as HomeTeam, A.AwayTeamName as AwayTeam, A.StartsTime 
                    FROM vOddsPivoted AS A 
                    INNER JOIN Competitions as B on A.Competition=B.Code 
                    INNER JOIN Sports as C on A.Sport=C.Code 
                    WHERE A.StartsTime >= now() and B.IsSelected=1 and C.IsSelected=1 and A.Bookmaker=1 
                    ORDER BY A.StartsTime ASC";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(c1, con);
            DataTable DT = new DataTable();
            mySqlDataAdapter.Fill(DT);
            DataTable tempDT = new DataTable();
            tempDT = DT.DefaultView.ToTable(true, "Code", "Sport", "Competition", "HomeTeam", "AwayTeam", "StartsTime");
            fixturesGrid.DataSource = tempDT;
            fixturesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(fixturesGrid_SelectionChanged);
            fixturesGrid.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
            mainForm.Show();
           
        }

        private void fixturesGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in fixturesGrid.SelectedRows)
            {
                int cd = Int32.Parse(row.Cells[0].Value.ToString());
                fixCode = cd;
                
            }
        } 

        private int setSelectedRunner()
        {
            int run = 0;  
            //var buttons = mainForm.Controls.OfType<RadioButton>()                           .FirstOrDefault(n => n.Checked);
            if (mainForm.homeRadio.Checked)
            {
                run = 1;
            }
            if (mainForm.awayRadio.Checked)
            {
                run = 2;
            }
            if (mainForm.drawRadio.Checked)
            {
                run = 3;
            }
            runner = run;
            return run;
        }

        private int selectOddCode(int runner)
        {            
            int oc=0;
            string selectQuery = @"SELECT Code FROM vOdds WHERE FixCode=@fixCode AND Runner=@runner AND Bookmaker=1 AND Type=1";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            cmd.Parameters.Add("@fixCode", MySqlDbType.Int32);
            cmd.Parameters["@fixCode"].Value = fixCode;
            cmd.Parameters.Add("@runner", MySqlDbType.Int32);
            cmd.Parameters["@runner"].Value = runner;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())                
            {
                oc = Int32.Parse(reader[0].ToString());
            }
            reader.Close();
            return oc;
        }

        
        private void set_Click(object sender, EventArgs e)
        {
            int oc = selectOddCode(setSelectedRunner());            
            mainForm.oddCodeTb.Text = oc.ToString();
        }
    }
}
