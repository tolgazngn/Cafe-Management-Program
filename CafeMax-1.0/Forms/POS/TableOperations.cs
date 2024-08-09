using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.Business.Service.concretes;
using CafeMax.Business.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMax
{
    public partial class TableOperations : Form
    {
        List<Table> tables = new List<Table>();

        List<Table> fullTables = new List<Table>();

        List<Table> emptyTables = new List<Table>();

        public TableOperations()
        {
            InitializeComponent();
        }

        private void TableOperations_Load(object sender, EventArgs e)
        {
            GetAllTables();
            GetTableNames();
        }

        private void GetAllTables()
        {
            tableDataGridView.Rows.Clear();

            TableService tableService = new TableService();

            tables = tableService.GetAll();

            foreach (Table table in tables)
            {
                string status;
                if (table.Status) { status = "Dolu"; }
                else { status = "Boş"; }

                tableDataGridView.Rows.Add(table.Name, status);
            }
        }

        private void enterTablePictureBox_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();

            if (fullTableComboBox.Text != "" && emptyTableComboBox.Text != "")
            {
                if (accountService.TransferDesk(fullTableComboBox.Text, emptyTableComboBox.Text))
                {
                    Helper.ShowMessage("İşlem başarılı.", true);
                    GetAllTables();
                    GetTableNames();
                }
                else { Helper.ShowMessage("İşlem başarısız.", false); }
            }
            else { Helper.ShowMessage("İlgili masaları seçin.", false); }
        }

        private void GetTableNames()
        {
            TableService tableService = new TableService();

            fullTables = tableService.GetFulls();

            foreach (Table table in fullTables)
            {
                fullTableComboBox.Items.Add(table.Name);
            }

            emptyTables = tableService.GetEmpties();

            foreach (Table table in emptyTables)
            {
                emptyTableComboBox.Items.Add(table.Name);
            }


        }
    }
}
