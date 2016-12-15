using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Timers;

namespace ExcelAddIn1
{
    public partial class Ribbon1
    {
        SqlConnection c = new SqlConnection();
        MySqlConnection con;
        DataGridView fixturesGrid;
        excelTraderForm mainForm = new excelTraderForm();
        int oddCode;        
        Microsoft.Office.Interop.Excel.Workbook objBook;        
        Microsoft.Office.Interop.Excel._Worksheet workSheet;
        System.Timers.Timer aTimer = new System.Timers.Timer();

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            con = c.getConnection();
            con.Open();
            mainForm.button1.Click += new System.EventHandler(this.set_Click);
            mainForm.StartButton.Click += new System.EventHandler(this.start_Click);
            mainForm.StopButton.Click += new System.EventHandler(this.stop_Click);
            mainForm.StopButton.Enabled = false;
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 7000;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            showFixturesGrid();
        }

        private void showFixturesGrid()
        {
            
            fixturesGrid = mainForm.dataGridView1;

            string c1 = @"SELECT 
                Code, HomeTeamName as HomeTeam, AwayTeamName as AwayTeam, TypeName as Type, RunnerType as Runner, BackPrice, StartsTime
                FROM vOdds
                WHERE StartsTime > now() AND StartsTime< (now() + INTERVAL 3 Day) AND Bookmaker = 1
                ORDER BY StartsTime ASC;";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(c1, con);
            System.Data.DataTable DT = new System.Data.DataTable();
            mySqlDataAdapter.Fill(DT);
            System.Data.DataTable tempDT = new System.Data.DataTable();
            tempDT = DT.DefaultView.ToTable(true, "Code", "HomeTeam", "AwayTeam", "Type", "Runner", "BackPrice", "StartsTime");
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
                oddCode = cd;                
            }
        } 

        
        private double getBackPrice(int oddCode)
        {            
            double oc = 0;
            string selectQuery = @"SELECT BackPrice FROM vOdds WHERE Code=@oddCode";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            cmd.Parameters.Add("@oddCode", MySqlDbType.Int32);
            cmd.Parameters["@oddCode"].Value = oddCode;            
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())                
            {
                oc = reader.GetDouble(0);
            }
            reader.Close();
            return oc;
        }

        private double getHistogram(int oddCode)
        {
            double oc = 0;
            string selectQuery = @"SELECT Histogramm FROM vMacd 
                WHERE OddCode=@oddCode 
                AND InsertDate=(SELECT max(InsertDate) FROM vMacd where OddCode=@oddCode) ";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            cmd.Parameters.Add("@oddCode", MySqlDbType.Int32);
            cmd.Parameters["@oddCode"].Value = oddCode;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    oc = reader.GetDouble(0);
                } else
                {
                    oc = -100000;
                }                                
            }
            reader.Close();
            return oc;
        }

        private void setExcelCell(string col, int row, object value)
        {
            objBook = (Workbook)Globals.ThisAddIn.Application.ActiveWorkbook;
            workSheet = (Worksheet)objBook.ActiveSheet;
            workSheet.Cells[row, col] = value;            
        }
        private void set_Click(object sender, EventArgs e)
        {
             setExcelValues();

        }

        private void setExcelValues()
        {
            if ((!string.IsNullOrWhiteSpace(mainForm.oddlColTb.Text)) && (!string.IsNullOrWhiteSpace(mainForm.oddRowTb.Text))
                  && (!string.IsNullOrWhiteSpace(mainForm.histColTb.Text)) && (!string.IsNullOrWhiteSpace(mainForm.histRowTb.Text)))
            {
                string a1 = mainForm.oddlColTb.Text;
                string b1 = mainForm.histColTb.Text;
                int a2 = Int32.Parse(mainForm.oddRowTb.Text);
                int b2 = Int32.Parse(mainForm.histRowTb.Text);
                setExcelCell(a1, a2, getBackPrice(oddCode));
                setExcelCell(b1, b2, getHistogram(oddCode));
            }
            else
            {
                MessageBox.Show("Fill cell properties malaka");
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = true;
            mainForm.StartButton.Enabled = false;
            mainForm.StopButton.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
            mainForm.StartButton.Enabled = true;
            mainForm.StopButton.Enabled = false;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            setExcelValues();
        }
    }
}
