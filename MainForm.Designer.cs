
namespace Coursework_WIN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainP = new System.Windows.Forms.Panel();
            this.LoadB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.ProdPriceTB = new System.Windows.Forms.TextBox();
            this.DelProdB = new System.Windows.Forms.Button();
            this.AddProdB = new System.Windows.Forms.Button();
            this.ProdL = new System.Windows.Forms.Label();
            this.DepL = new System.Windows.Forms.Label();
            this.DepTB = new System.Windows.Forms.TextBox();
            this.DelDepB = new System.Windows.Forms.Button();
            this.ProdTB = new System.Windows.Forms.TextBox();
            this.AddDepB = new System.Windows.Forms.Button();
            this.ProdTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepTable = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.DepMessageL = new System.Windows.Forms.Label();
            this.ProdMessageL = new System.Windows.Forms.Label();
            this.MainP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainP
            // 
            this.MainP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.MainP.Controls.Add(this.ProdMessageL);
            this.MainP.Controls.Add(this.DepMessageL);
            this.MainP.Controls.Add(this.LoadB);
            this.MainP.Controls.Add(this.SaveB);
            this.MainP.Controls.Add(this.ProdPriceTB);
            this.MainP.Controls.Add(this.DelProdB);
            this.MainP.Controls.Add(this.AddProdB);
            this.MainP.Controls.Add(this.ProdL);
            this.MainP.Controls.Add(this.DepL);
            this.MainP.Controls.Add(this.DepTB);
            this.MainP.Controls.Add(this.DelDepB);
            this.MainP.Controls.Add(this.ProdTB);
            this.MainP.Controls.Add(this.AddDepB);
            this.MainP.Controls.Add(this.ProdTable);
            this.MainP.Controls.Add(this.DepTable);
            this.MainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainP.ForeColor = System.Drawing.Color.White;
            this.MainP.Location = new System.Drawing.Point(0, 0);
            this.MainP.Margin = new System.Windows.Forms.Padding(2);
            this.MainP.Name = "MainP";
            this.MainP.Size = new System.Drawing.Size(1124, 657);
            this.MainP.TabIndex = 1;
            // 
            // LoadB
            // 
            this.LoadB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.LoadB.FlatAppearance.BorderSize = 0;
            this.LoadB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadB.Location = new System.Drawing.Point(12, 12);
            this.LoadB.Name = "LoadB";
            this.LoadB.Size = new System.Drawing.Size(54, 27);
            this.LoadB.TabIndex = 12;
            this.LoadB.Text = "Load";
            this.LoadB.UseVisualStyleBackColor = false;
            this.LoadB.Click += new System.EventHandler(this.LoadB_Click);
            // 
            // SaveB
            // 
            this.SaveB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.SaveB.FlatAppearance.BorderSize = 0;
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveB.Location = new System.Drawing.Point(72, 12);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(55, 27);
            this.SaveB.TabIndex = 11;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = false;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // ProdPriceTB
            // 
            this.ProdPriceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.ProdPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdPriceTB.ForeColor = System.Drawing.Color.White;
            this.ProdPriceTB.Location = new System.Drawing.Point(960, 492);
            this.ProdPriceTB.Name = "ProdPriceTB";
            this.ProdPriceTB.Size = new System.Drawing.Size(110, 35);
            this.ProdPriceTB.TabIndex = 10;
            this.ProdPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProdPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdPriceTB_KeyPress);
            // 
            // DelProdB
            // 
            this.DelProdB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.DelProdB.FlatAppearance.BorderSize = 0;
            this.DelProdB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelProdB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelProdB.Location = new System.Drawing.Point(917, 565);
            this.DelProdB.Name = "DelProdB";
            this.DelProdB.Size = new System.Drawing.Size(153, 39);
            this.DelProdB.TabIndex = 9;
            this.DelProdB.Text = "Delete";
            this.DelProdB.UseVisualStyleBackColor = false;
            this.DelProdB.Click += new System.EventHandler(this.DelProdB_Click);
            // 
            // AddProdB
            // 
            this.AddProdB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.AddProdB.FlatAppearance.BorderSize = 0;
            this.AddProdB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProdB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProdB.Location = new System.Drawing.Point(628, 565);
            this.AddProdB.Name = "AddProdB";
            this.AddProdB.Size = new System.Drawing.Size(153, 39);
            this.AddProdB.TabIndex = 8;
            this.AddProdB.Text = "Add";
            this.AddProdB.UseVisualStyleBackColor = false;
            this.AddProdB.Click += new System.EventHandler(this.AddProdB_Click);
            // 
            // ProdL
            // 
            this.ProdL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdL.Location = new System.Drawing.Point(622, 64);
            this.ProdL.Name = "ProdL";
            this.ProdL.Size = new System.Drawing.Size(442, 39);
            this.ProdL.TabIndex = 7;
            this.ProdL.Text = "Products";
            this.ProdL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepL
            // 
            this.DepL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepL.Location = new System.Drawing.Point(43, 64);
            this.DepL.Name = "DepL";
            this.DepL.Size = new System.Drawing.Size(529, 39);
            this.DepL.TabIndex = 6;
            this.DepL.Text = "Departments";
            this.DepL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepTB
            // 
            this.DepTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.DepTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepTB.ForeColor = System.Drawing.Color.White;
            this.DepTB.Location = new System.Drawing.Point(103, 492);
            this.DepTB.Name = "DepTB";
            this.DepTB.Size = new System.Drawing.Size(364, 35);
            this.DepTB.TabIndex = 5;
            this.DepTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DelDepB
            // 
            this.DelDepB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.DelDepB.FlatAppearance.BorderSize = 0;
            this.DelDepB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelDepB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelDepB.Location = new System.Drawing.Point(314, 565);
            this.DelDepB.Name = "DelDepB";
            this.DelDepB.Size = new System.Drawing.Size(153, 39);
            this.DelDepB.TabIndex = 4;
            this.DelDepB.Text = "Delete";
            this.DelDepB.UseVisualStyleBackColor = false;
            this.DelDepB.Click += new System.EventHandler(this.DelDepB_Click);
            // 
            // ProdTB
            // 
            this.ProdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.ProdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdTB.ForeColor = System.Drawing.Color.White;
            this.ProdTB.Location = new System.Drawing.Point(628, 492);
            this.ProdTB.Name = "ProdTB";
            this.ProdTB.Size = new System.Drawing.Size(326, 35);
            this.ProdTB.TabIndex = 3;
            this.ProdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddDepB
            // 
            this.AddDepB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.AddDepB.FlatAppearance.BorderSize = 0;
            this.AddDepB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDepB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepB.Location = new System.Drawing.Point(103, 565);
            this.AddDepB.Name = "AddDepB";
            this.AddDepB.Size = new System.Drawing.Size(153, 39);
            this.AddDepB.TabIndex = 2;
            this.AddDepB.Text = "Add";
            this.AddDepB.UseVisualStyleBackColor = false;
            this.AddDepB.Click += new System.EventHandler(this.AddDepB_Click);
            // 
            // ProdTable
            // 
            this.ProdTable.AllowUserToAddRows = false;
            this.ProdTable.AllowUserToDeleteRows = false;
            this.ProdTable.AllowUserToOrderColumns = true;
            this.ProdTable.AllowUserToResizeColumns = false;
            this.ProdTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.ProdTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ProdTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdTable.ColumnHeadersHeight = 35;
            this.ProdTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProdName,
            this.ProdPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdTable.EnableHeadersVisualStyles = false;
            this.ProdTable.Location = new System.Drawing.Point(628, 105);
            this.ProdTable.Margin = new System.Windows.Forms.Padding(2);
            this.ProdTable.Name = "ProdTable";
            this.ProdTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdTable.RowHeadersVisible = false;
            this.ProdTable.RowHeadersWidth = 51;
            this.ProdTable.RowTemplate.Height = 24;
            this.ProdTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProdTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdTable.Size = new System.Drawing.Size(442, 327);
            this.ProdTable.TabIndex = 1;
            this.ProdTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 32.08556F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // ProdName
            // 
            this.ProdName.FillWeight = 133.9572F;
            this.ProdName.HeaderText = "Product ";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 250;
            // 
            // ProdPrice
            // 
            this.ProdPrice.FillWeight = 133.9572F;
            this.ProdPrice.HeaderText = "Price";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.ReadOnly = true;
            this.ProdPrice.Width = 150;
            // 
            // DepTable
            // 
            this.DepTable.AllowUserToAddRows = false;
            this.DepTable.AllowUserToDeleteRows = false;
            this.DepTable.AllowUserToOrderColumns = true;
            this.DepTable.AllowUserToResizeColumns = false;
            this.DepTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            this.DepTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DepTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.DepTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DepTable.ColumnHeadersHeight = 35;
            this.DepTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.DepName,
            this.DepQuant,
            this.DepSum});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(193)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DepTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.DepTable.EnableHeadersVisualStyles = false;
            this.DepTable.Location = new System.Drawing.Point(49, 105);
            this.DepTable.Margin = new System.Windows.Forms.Padding(2);
            this.DepTable.Name = "DepTable";
            this.DepTable.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DepTable.RowHeadersVisible = false;
            this.DepTable.RowHeadersWidth = 51;
            this.DepTable.RowTemplate.Height = 24;
            this.DepTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DepTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepTable.Size = new System.Drawing.Size(523, 327);
            this.DepTable.TabIndex = 0;
            this.DepTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepTable_CellClick);
            // 
            // Num
            // 
            this.Num.FillWeight = 23.81889F;
            this.Num.HeaderText = "№";
            this.Num.MaxInputLength = 3;
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 40;
            // 
            // DepName
            // 
            this.DepName.FillWeight = 118.5511F;
            this.DepName.HeaderText = "Department name";
            this.DepName.MinimumWidth = 6;
            this.DepName.Name = "DepName";
            this.DepName.ReadOnly = true;
            this.DepName.Width = 230;
            // 
            // DepQuant
            // 
            this.DepQuant.FillWeight = 57.37074F;
            this.DepQuant.HeaderText = "Number";
            this.DepQuant.MinimumWidth = 6;
            this.DepQuant.Name = "DepQuant";
            this.DepQuant.ReadOnly = true;
            // 
            // DepSum
            // 
            this.DepSum.FillWeight = 86.08587F;
            this.DepSum.HeaderText = "Total value";
            this.DepSum.MinimumWidth = 6;
            this.DepSum.Name = "DepSum";
            this.DepSum.ReadOnly = true;
            this.DepSum.Width = 150;
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "txt";
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "\"Text files(*.txt)|*.txt\"";
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "txt";
            this.sfd.Filter = "\"Text files(*.txt)|*.txt|All files(*.*)|*.*\"";
            // 
            // DepMessageL
            // 
            this.DepMessageL.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepMessageL.Location = new System.Drawing.Point(101, 447);
            this.DepMessageL.Name = "DepMessageL";
            this.DepMessageL.Size = new System.Drawing.Size(366, 31);
            this.DepMessageL.TabIndex = 13;
            // 
            // ProdMessageL
            // 
            this.ProdMessageL.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdMessageL.Location = new System.Drawing.Point(628, 447);
            this.ProdMessageL.Name = "ProdMessageL";
            this.ProdMessageL.Size = new System.Drawing.Size(442, 31);
            this.ProdMessageL.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 657);
            this.Controls.Add(this.MainP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermarket";
            this.MainP.ResumeLayout(false);
            this.MainP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainP;
        private System.Windows.Forms.DataGridView DepTable;
        private System.Windows.Forms.DataGridView ProdTable;
        private System.Windows.Forms.Button AddDepB;
        private System.Windows.Forms.TextBox ProdTB;
        private System.Windows.Forms.Button DelDepB;
        private System.Windows.Forms.Label ProdL;
        private System.Windows.Forms.Label DepL;
        private System.Windows.Forms.TextBox DepTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepSum;
        private System.Windows.Forms.TextBox ProdPriceTB;
        private System.Windows.Forms.Button DelProdB;
        private System.Windows.Forms.Button AddProdB;
        private System.Windows.Forms.Button LoadB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label ProdMessageL;
        private System.Windows.Forms.Label DepMessageL;
    }
}