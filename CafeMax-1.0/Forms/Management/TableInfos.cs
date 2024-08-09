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

namespace CafeMax.Forms.Management
{
    public partial class TableInfos : Form
    {
        public TableInfos()
        {
            InitializeComponent();
        }

        private void TableInfos_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                TableService tableService = new TableService();

                if (tableService.CheckTableNameAvailability(nameTextBox.Text))
                {
                    if (tableService.AddTable(nameTextBox.Text))
                    {
                        Helper.ShowMessage($"'{nameTextBox.Text}' başarıyla eklendi.", true);
                        RefreshTable();
                        nameTextBox.Text = "";
                    }
                    else { Helper.ShowMessage("Masa eklenemedi.", false); }
                }
                else { Helper.ShowMessage("Bu masa zaten mecvut.", false); }
            }
            else { Helper.ShowMessage("Boş alan olmamalıdır.", false); }
        }

        private void RefreshTable()
        {
            tableDataGridView.Rows.Clear();

            TableService tableService = new TableService();

            List<Table> tables = tableService.GetAll();

            foreach (Table table in tables)
            {
                string status;
                if (table.Status) { status = "Dolu"; }
                else { status = "Boş"; }

                tableDataGridView.Rows.Add(table.Name, status, table.Reserved);
            }
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = tableDataGridView.SelectedCells[0].RowIndex;

            int columnOfInterest = 0;

            object cellValue = tableDataGridView.Rows[selectedRow].Cells[columnOfInterest].Value;

            selectedTableNameTextBox.Text = cellValue.ToString();
        }

        private void enter2_Click(object sender, EventArgs e)
        {
            if (selectedTableNameTextBox.Text != "")
            {
                TableService tableService = new TableService();

                if (tableService.IsRowDeletable(selectedTableNameTextBox.Text))
                {
                    DialogResult result = Helper.ShowMessage($"{selectedTableNameTextBox.Text} kaydını silmek istiyor musunuz?");
                    if (result == DialogResult.Yes)
                    {
                        if (tableService.DeleteTable(selectedTableNameTextBox.Text))
                        {
                            Helper.ShowMessage($"{selectedTableNameTextBox.Text} silindi.", true);
                            RefreshTable();
                            nameTextBox.Text = "";
                        }
                        else { Helper.ShowMessage("İşlem başarısız.", false); }
                    }
                    else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                    else { Helper.ShowMessage("İşlem iptal edildi.", true); }
                }
                else { Helper.ShowMessage("Masa meşgul olduğundan silinemez.", false); }
            }
            else { Helper.ShowMessage("Masa seçiniz.", false); }
        }
    }
}
