using System;
using System.ComponentModel;
using System.Windows.Forms;
using Coursework_Console;
using System.IO;

namespace Coursework_WIN
{
    public partial class MainForm : Form
    {
        Supermarket sup = new Supermarket("Supermarket");
        Department dep;
        string prod;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {


        }
        private void DepRefresh()
        {
            DepTable.Rows.Clear();
            int i = 0;
            Department temp = sup.First;
            while (temp != null)
            {
                DepTable.Rows.Add(++i, temp.Name, temp.Quantity, temp.Sum());
                temp = temp.Next;
            }
        }
        private void ProdRefresh(Department dep)
        {
            ProdTable.Rows.Clear();
            for (int i = 0; i < dep.Quantity; i++)
            {
                ProdTable.Rows.Add(i + 1, dep.Arr[i].Name, dep.Arr[i].Price);
            }
        }

        private void AddDepB_Click(object sender, EventArgs e)
        {
            if (DepTB.Text == "")
            {
                DepMessageL.Text = "Input data";
            }
            else
            {
                sup.AddDepartment(DepTB.Text);
                DepRefresh();
                DepMessageL.Text = "";
            }
            DepTB.Text = "";
            ProdMessageL.Text = "";
        }

        private void DelDepB_Click(object sender, EventArgs e)
        {
            if (sup.DelDepartment())
            {
                DepRefresh();
                ProdTable.Rows.Clear();
            }
        }

        private void AddProdB_Click(object sender, EventArgs e)
        {
            if (sup.Quantity != 0)
            {
                AddProd(dep);
                DepRefresh();
            }
            else ProdMessageL.Text = "Add at least one department ";


        }
        private void AddProd(Department dep)
        {
            DepMessageL.Text = "";

            if (ProdTB.Text == "" || ProdPriceTB.Text == "")
            {
                ProdMessageL.Text = "Input data";
            }
            else if (this.dep != null)
            {
                if (dep.Add(ProdTB.Text, Convert.ToDouble(ProdPriceTB.Text)))
                {
                    ProdRefresh(dep);
                    ProdMessageL.Text = "";
                    ProdTB.Text = "";
                    ProdPriceTB.Text = "";
                }
                else ProdMessageL.Text = "Department is full";
            }
            else ProdMessageL.Text = "Select department";
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void LoadB_Click(object sender, EventArgs e)
        {
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    using (StreamReader streamReader = new StreamReader(ofd.FileName))
            //    {
            //        for (int i = 0; i < DepTable.ColumnCount; i++)
            //            for (int j = 0; j < DepTable.RowCount; j++)
            //    }
            //}
        }

        private void SaveB_Click(object sender, EventArgs e) // add save for all tablets 
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(sfd.FileName))
                {
                    for (int j = 0; j < DepTable.RowCount; j++)
                        for (int i = 0; i < DepTable.ColumnCount; i++)
                        {
                            streamWriter.WriteLine(DepTable[j, i].Value);
                            //int index = DepTable.NewRowIndex;// ? getting index 

                        }
                }
            }

        }

        private void ProdPriceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdPriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void DepTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = DepTable.CurrentRow.Cells[1].Value.ToString();
            dep = sup.Search(row);

            ProdRefresh(dep);
        }

        private void DelProdB_Click(object sender, EventArgs e)
        {
            if (sup.Quantity != 0)
            {
                DelProd(dep);
            }
            
        }
        private void DelProd(Department dep)
        {
            if (dep.DelProduct(prod))
            {
                ProdRefresh(dep);
                DepRefresh();
            }
        }

        private void ProdTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProd(dep);
        }
        private void SelectProd(Department dep)
        {
            prod = ProdTable.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
