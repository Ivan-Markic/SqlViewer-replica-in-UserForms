using SqlViewer.Dal;
using SqlViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer
{
    public partial class SqlManagerForm : Form
    {
        public SqlManagerForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init() => LoadDatabases();

        private void LoadDatabases() => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());


        private void SqlManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            lbTables.DataSource = (CbDatabases.SelectedItem as Database).Tables;
            lbViews.DataSource = (CbDatabases.SelectedItem as Database).Views;
            lbProcedures.DataSource = (CbDatabases.SelectedItem as Database).Procedures;
        }

        private void Clear()
        {
            lbTableColumns.DataSource = null;
            lbViewColumns.DataSource = null;
            lbProceduresParameters.DataSource = null;
        }

        private void scQuery_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SplitContainer splitContainer = sender as SplitContainer;
            Panel panel = splitContainer.Panel1;
            tbQuery.Width = panel.Width - 5;
            tbQuery.Height = panel.Height;

            panel = splitContainer.Panel2;

            tcResultMessage.Width = panel.Width - 5;
            tcResultMessage.Height = panel.Height - 5;
        }

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e) => lbTableColumns.DataSource = (lbTables.SelectedItem as DBEntity).Columns;

        private void lbViews_SelectedIndexChanged(object sender, EventArgs e) => lbViewColumns.DataSource = (lbViews.SelectedItem as DBEntity).Columns;

        private void lbProcedured_SelectedIndexChanged(object sender, EventArgs e) => lbProceduresParameters.DataSource = (lbProcedures.SelectedItem as Procedure).Parameters;

        private void tbQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt
                && e.KeyCode == Keys.X
                && tbQuery.Text.Length != 0)
            {
                ConfiguringQuery();
            }
        }

        private void ConfiguringQuery()
        {
            IsQueryFieldReady(false);

            //Pocetak mjerenja
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            StringBuilder query = GetQuery();
            StringBuilder message = new StringBuilder("");

            try
            {
                tpResult.Controls.Clear();

                if (query.ToString().ToLower().Contains("select"))
                {
                    

                    DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(query.ToString());

                    int tableHeight = tpResult.Height / ds.Tables.Count - 3;
                    int tableWidth = tpResult.Width - 5;

                    foreach (DataTable table in ds.Tables)
                    {
                        message.Append($"({table.Rows.Count} rows affected) \n");
                        DataGridView dgvResults = new DataGridView();
                        dgvResults.Location = new Point(dgvResults.Location.X, tableHeight * ds.Tables.IndexOf(table));
                        dgvResults.Height = tableHeight;
                        dgvResults.Width = tableWidth;
                        dgvResults.AllowUserToAddRows = false;
                        dgvResults.AllowUserToDeleteRows = false;
                        dgvResults.DataSource = table;
                        tpResult.Controls.Add(dgvResults);
                    }
                    tcResultMessage.SelectedTab = tcResultMessage.TabPages[0];
                }

                else
                {
                    //U repositoryu napraviti novu metodu koja ce raditi sa DataReaderom
                    int numberOfRows = RepositoryFactory.GetRepository().ExecuteQuery(query.ToString());
                    message.Append($"({numberOfRows} rows affected) \n \n");
                    tcResultMessage.SelectedTab = tcResultMessage.TabPages[1];
                }

                lblMessages.ForeColor = tbQuery.ForeColor;
            }
            catch (Exception e)
            {
                lblMessages.ForeColor = Color.Red;
                tcResultMessage.SelectedTab = tcResultMessage.TabPages[1];
                message.Append($"{e.Message} \n \n");
            }
            stopwatch.Stop();

            message.Append($"Completion time: {DateTime.Now.ToLocalTime()} \n \n");
            message.Append($"Time elapsed: {stopwatch.ElapsedMilliseconds}ms");

            lblMessages.Text = message.ToString();

            IsQueryFieldReady(true);
        }

        private void IsQueryFieldReady(bool enabled)
        {
            btnStartQuery.Enabled = enabled;
            tbQuery.Enabled = enabled;
        }

        private StringBuilder GetQuery()
        {
            StringBuilder query = new StringBuilder($"Use {CbDatabases.SelectedItem}");

            if (tbQuery.SelectedText.Length != 0)
            {
                //Saljemo samo oznaceno
                query.Append($"\n {tbQuery.SelectedText}");
            }
            else
            {
                //Saljemo cijeli text
                query.Append($"\n {tbQuery.Text}");
            }

            return query;
        }

        private void btnStartQuery_Click(object sender, EventArgs e)
        {
            if (tbQuery.Text.Length != 0)
            {
                ConfiguringQuery();
            }

        }

        private void tpResult_SizeChanged(object sender, EventArgs e)
        {
            if (tpResult.Controls.Count!=0)
            {
                int tableHeight = tpResult.Height / tpResult.Controls.Count;

                foreach (DataGridView dgvTable in tpResult.Controls)
                {
                    dgvTable.Location = new Point(dgvTable.Location.X, tableHeight * tpResult.Controls.IndexOf(dgvTable));
                    dgvTable.Height = tableHeight;
                } 
            }
        }
    }
}
