namespace ExamControl3
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.pictureBoxProducts = new System.Windows.Forms.PictureBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblManuf = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSortCmb = new System.Windows.Forms.Label();
            this.lblSupCmb = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(26, 99);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(775, 222);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.lblNewPrice);
            this.panelProduct.Controls.Add(this.lblOldPrice);
            this.panelProduct.Controls.Add(this.pictureBoxProducts);
            this.panelProduct.Controls.Add(this.lblDiscount);
            this.panelProduct.Controls.Add(this.lblQty);
            this.panelProduct.Controls.Add(this.lblUnit);
            this.panelProduct.Controls.Add(this.lblPrice);
            this.panelProduct.Controls.Add(this.lblManuf);
            this.panelProduct.Controls.Add(this.lblSupplier);
            this.panelProduct.Controls.Add(this.lblDescription);
            this.panelProduct.Controls.Add(this.lblTitle);
            this.panelProduct.Location = new System.Drawing.Point(26, 339);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(910, 210);
            this.panelProduct.TabIndex = 1;
            // 
            // pictureBoxProducts
            // 
            this.pictureBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProducts.Location = new System.Drawing.Point(26, 12);
            this.pictureBoxProducts.Name = "pictureBoxProducts";
            this.pictureBoxProducts.Size = new System.Drawing.Size(208, 180);
            this.pictureBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducts.TabIndex = 8;
            this.pictureBoxProducts.TabStop = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(743, 12);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(148, 180);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "label8";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(280, 179);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(35, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "label7";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(280, 155);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(35, 13);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "label6";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(280, 127);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "label5";
            // 
            // lblManuf
            // 
            this.lblManuf.AutoSize = true;
            this.lblManuf.Location = new System.Drawing.Point(280, 98);
            this.lblManuf.Name = "lblManuf";
            this.lblManuf.Size = new System.Drawing.Size(35, 13);
            this.lblManuf.TabIndex = 3;
            this.lblManuf.Text = "label4";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(280, 69);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(35, 13);
            this.lblSupplier.TabIndex = 2;
            this.lblSupplier.Text = "label3";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(280, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label2";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(280, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(860, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(860, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(860, 223);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(860, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "Количество по возрастанию",
            "Количество по убыванию"});
            this.cmbSort.Location = new System.Drawing.Point(26, 51);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(210, 21);
            this.cmbSort.TabIndex = 6;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(275, 50);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(202, 21);
            this.cmbSupplier.TabIndex = 7;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(508, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSortCmb
            // 
            this.lblSortCmb.AutoSize = true;
            this.lblSortCmb.Location = new System.Drawing.Point(26, 32);
            this.lblSortCmb.Name = "lblSortCmb";
            this.lblSortCmb.Size = new System.Drawing.Size(67, 13);
            this.lblSortCmb.TabIndex = 9;
            this.lblSortCmb.Text = "Сортировка";
            // 
            // lblSupCmb
            // 
            this.lblSupCmb.AutoSize = true;
            this.lblSupCmb.Location = new System.Drawing.Point(275, 31);
            this.lblSupCmb.Name = "lblSupCmb";
            this.lblSupCmb.Size = new System.Drawing.Size(65, 13);
            this.lblSupCmb.TabIndex = 10;
            this.lblSupCmb.Text = "Поставщик";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(508, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(39, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Поиск";
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(744, 13);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(34, 13);
            this.lblFio.TabIndex = 12;
            this.lblFio.Text = "ФИО";
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.Location = new System.Drawing.Point(333, 127);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(25, 13);
            this.lblOldPrice.TabIndex = 9;
            this.lblOldPrice.Text = "000";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(414, 127);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(25, 13);
            this.lblNewPrice.TabIndex = 10;
            this.lblNewPrice.Text = "000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblSupCmb);
            this.Controls.Add(this.lblSortCmb);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.dgvProducts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.PictureBox pictureBoxProducts;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblManuf;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSortCmb;
        private System.Windows.Forms.Label lblSupCmb;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Label lblOldPrice;
    }
}