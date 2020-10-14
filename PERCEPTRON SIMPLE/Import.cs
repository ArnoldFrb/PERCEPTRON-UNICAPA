using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace PERCEPTRON_SIMPLE
{
    class Import
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dataTable;

        public void ImportExcel(DataGridView dataGridView, String hojaExcel)
        {
            String ruta = "";

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files |*.xlsx";
                openFileDialog.Title = "Seleccione Archivo Excel";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog.FileName.Equals("") == false)
                    {
                        ruta = openFileDialog.FileName;
                    }
                }

                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                dataAdapter = new OleDbDataAdapter("select * from [" + hojaExcel + "$]", connection);
                dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
