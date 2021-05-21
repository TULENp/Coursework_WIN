using System;
using System.ComponentModel;
using System.Windows.Forms;
using Coursework_Console;
using System.IO;
using System.Collections.Generic;

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
                this.dep = null;
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
                if (this.prod != null)
                {
                    if (dep.AddByIndex(dep.Search(prod), ProdTB.Text, Convert.ToDouble(ProdPriceTB.Text)))
                    {
                        ProdRefresh(dep);
                        this.prod = null;
                    }
                    else ProdMessageL.Text = "Department is full";
                }
                else
                if (dep.Add(ProdTB.Text, Convert.ToDouble(ProdPriceTB.Text)))
                {
                    ProdRefresh(dep);
                }
                else ProdMessageL.Text = "Department is full";
                ProdTB.Text = "";
                ProdPriceTB.Text = "";
            }
            else ProdMessageL.Text = "Select department";
        }
        private void DelProdB_Click(object sender, EventArgs e)
        {
            if (sup.Quantity != 0)
            {
                DelProd(dep);
                this.prod = null;
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
        private void LoadB_Click(object sender, EventArgs e)
        {
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    using (StreamReader streamReader = new StreamReader(ofd.FileName))
            //    {
            //        //string sfile = streamReader.ReadToEnd();
            //        while (!streamReader.EndOfStream)
            //        {
            //            string line = streamReader.ReadLine();
            //            for (int i = 0; i < Convert.ToInt32(line); i++)
            //            {
            //                string name = streamReader.ReadLine();

            //            }

            //        }
            //    }
            //}
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(sfd.FileName))
                {
                    Department temp = sup.First;
                    while (temp != null)
                    {
                        streamWriter.WriteLine(temp.Name);
                        for (int i = 0; i < temp.Quantity; i++)
                        {
                            streamWriter.WriteLine(temp.Arr[i].Name + "   " + temp.Arr[i].Price);
                        }
                        temp = temp.Next;
                    }
                }
            }

        }
        private void DepTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = DepTable.CurrentRow.Cells[1].Value.ToString();
            dep = sup.Search(row);

            ProdRefresh(dep);
            ProdMessageL.Text = "";
            ProdTB.Text = "";
            ProdPriceTB.Text = "";
        }
        private void ProdTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProd(dep);
        }
        private void SelectProd(Department dep)
        {
            prod = ProdTable.CurrentRow.Cells[1].Value.ToString();
        }
        private void ProdPriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }
    }
}
