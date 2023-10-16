using Microsoft.Reporting.WinForms;
using QuanLy.doanDataSet1TableAdapters;
using QuanLy.DTO;
using QuanLy.ReportWater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class WaterReport : Form
    {
        

        public WaterReport()
        {
            InitializeComponent();
        }

        private void WaterReport_Load(object sender, EventArgs e)
        {
          
            
            this.rptWater.RefreshReport();
        }

        private void rptWater_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTaoReport_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.doanConnectionString;
            SqlCommand command = new SqlCommand();
            command.CommandText = "USP_GetListBillByDateByReprot1";

            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.Parameters.Add(new SqlParameter("@dateCheckin" , dtpkCheckOut));
            command.Parameters.Add(new SqlParameter(" @dateCheckout", dtpkCheckOut));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);

            rptWater.ProcessingMode = ProcessingMode.Local;
            rptWater.LocalReport.ReportPath = "./Report/waterReport.rdlc";

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];


                rptWater.LocalReport.DataSources.Clear();

                rptWater.LocalReport.DataSources.Add(rds);

                rptWater.RefreshReport();

            }   
        }

    }
}
