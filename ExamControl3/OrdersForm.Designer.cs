namespace ExamControl3
{
    partial class OrdersForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(861, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(861, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(861, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(25, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Артикул заказа";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(25, 65);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(80, 13);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Статус заказа";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(25, 107);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(115, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Адрес пункта выдачи";
            // 
            // lblDiscount
            // 
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(596, 11);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(148, 180);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Дата доставки";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.label1);
            this.panelProduct.Controls.Add(this.lblDiscount);
            this.panelProduct.Controls.Add(this.lblQty);
            this.panelProduct.Controls.Add(this.lblUnit);
            this.panelProduct.Controls.Add(this.lblTitle);
            this.panelProduct.Location = new System.Drawing.Point(38, 116);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(788, 199);
            this.panelProduct.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата заказа";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 374);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelProduct);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label label1;
    }
}