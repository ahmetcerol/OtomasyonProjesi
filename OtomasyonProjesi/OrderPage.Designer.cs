
namespace OtomasyonProjesi
{
    partial class OrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPage));
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblCurrentOrderTotal = new System.Windows.Forms.Label();
            this.lblResetOrder = new System.Windows.Forms.Button();
            this.lblAcceptOrder = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pbxCustomer = new System.Windows.Forms.PictureBox();
            this.pbxOrderLogo = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblCurrentTax = new System.Windows.Forms.Label();
            this.lblCurrentTotal = new System.Windows.Forms.Label();
            this.lblCurrency3 = new System.Windows.Forms.Label();
            this.lblCurrency1 = new System.Windows.Forms.Label();
            this.lblCurrency2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOrders
            // 
            this.dgwOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.Location = new System.Drawing.Point(12, 54);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.Size = new System.Drawing.Size(317, 198);
            this.dgwOrders.TabIndex = 0;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.White;
            this.lblOrderTotal.Location = new System.Drawing.Point(175, 294);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(80, 15);
            this.lblOrderTotal.TabIndex = 1;
            this.lblOrderTotal.Text = "Toplam Fiyat:";
            // 
            // lblCurrentOrderTotal
            // 
            this.lblCurrentOrderTotal.AutoSize = true;
            this.lblCurrentOrderTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentOrderTotal.ForeColor = System.Drawing.Color.White;
            this.lblCurrentOrderTotal.Location = new System.Drawing.Point(252, 294);
            this.lblCurrentOrderTotal.Name = "lblCurrentOrderTotal";
            this.lblCurrentOrderTotal.Size = new System.Drawing.Size(28, 15);
            this.lblCurrentOrderTotal.TabIndex = 2;
            this.lblCurrentOrderTotal.Text = "$$$";
            // 
            // lblResetOrder
            // 
            this.lblResetOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.lblResetOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResetOrder.ForeColor = System.Drawing.Color.White;
            this.lblResetOrder.Location = new System.Drawing.Point(13, 312);
            this.lblResetOrder.Name = "lblResetOrder";
            this.lblResetOrder.Size = new System.Drawing.Size(112, 23);
            this.lblResetOrder.TabIndex = 3;
            this.lblResetOrder.Text = "Sepeti Sıfırla";
            this.lblResetOrder.UseVisualStyleBackColor = false;
            this.lblResetOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAcceptOrder
            // 
            this.lblAcceptOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.lblAcceptOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcceptOrder.ForeColor = System.Drawing.Color.White;
            this.lblAcceptOrder.Location = new System.Drawing.Point(201, 312);
            this.lblAcceptOrder.Name = "lblAcceptOrder";
            this.lblAcceptOrder.Size = new System.Drawing.Size(120, 23);
            this.lblAcceptOrder.TabIndex = 4;
            this.lblAcceptOrder.Text = "Sepeti Onayla";
            this.lblAcceptOrder.UseVisualStyleBackColor = false;
            this.lblAcceptOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.lblCustomer.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(234, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(77, 16);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "kullanıcıadı";
            // 
            // pbxCustomer
            // 
            this.pbxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.pbxCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbxCustomer.Image")));
            this.pbxCustomer.Location = new System.Drawing.Point(307, 7);
            this.pbxCustomer.Name = "pbxCustomer";
            this.pbxCustomer.Size = new System.Drawing.Size(17, 18);
            this.pbxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCustomer.TabIndex = 6;
            this.pbxCustomer.TabStop = false;
            // 
            // pbxOrderLogo
            // 
            this.pbxOrderLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxOrderLogo.Image")));
            this.pbxOrderLogo.Location = new System.Drawing.Point(12, -19);
            this.pbxOrderLogo.Name = "pbxOrderLogo";
            this.pbxOrderLogo.Size = new System.Drawing.Size(100, 96);
            this.pbxOrderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOrderLogo.TabIndex = 7;
            this.pbxOrderLogo.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(172, 264);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Toplam Tutar:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTax.ForeColor = System.Drawing.Color.White;
            this.lblTax.Location = new System.Drawing.Point(218, 279);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(37, 15);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "KDV:";
            // 
            // lblCurrentTax
            // 
            this.lblCurrentTax.AutoSize = true;
            this.lblCurrentTax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentTax.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTax.Location = new System.Drawing.Point(252, 279);
            this.lblCurrentTax.Name = "lblCurrentTax";
            this.lblCurrentTax.Size = new System.Drawing.Size(28, 15);
            this.lblCurrentTax.TabIndex = 12;
            this.lblCurrentTax.Text = "$$$";
            // 
            // lblCurrentTotal
            // 
            this.lblCurrentTotal.AutoSize = true;
            this.lblCurrentTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentTotal.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTotal.Location = new System.Drawing.Point(252, 264);
            this.lblCurrentTotal.Name = "lblCurrentTotal";
            this.lblCurrentTotal.Size = new System.Drawing.Size(28, 15);
            this.lblCurrentTotal.TabIndex = 13;
            this.lblCurrentTotal.Text = "$$$";
            // 
            // lblCurrency3
            // 
            this.lblCurrency3.AutoSize = true;
            this.lblCurrency3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrency3.ForeColor = System.Drawing.Color.White;
            this.lblCurrency3.Location = new System.Drawing.Point(301, 294);
            this.lblCurrency3.Name = "lblCurrency3";
            this.lblCurrency3.Size = new System.Drawing.Size(23, 15);
            this.lblCurrency3.TabIndex = 15;
            this.lblCurrency3.Text = "TL";
            // 
            // lblCurrency1
            // 
            this.lblCurrency1.AutoSize = true;
            this.lblCurrency1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrency1.ForeColor = System.Drawing.Color.White;
            this.lblCurrency1.Location = new System.Drawing.Point(301, 264);
            this.lblCurrency1.Name = "lblCurrency1";
            this.lblCurrency1.Size = new System.Drawing.Size(23, 15);
            this.lblCurrency1.TabIndex = 16;
            this.lblCurrency1.Text = "TL";
            // 
            // lblCurrency2
            // 
            this.lblCurrency2.AutoSize = true;
            this.lblCurrency2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrency2.ForeColor = System.Drawing.Color.White;
            this.lblCurrency2.Location = new System.Drawing.Point(301, 279);
            this.lblCurrency2.Name = "lblCurrency2";
            this.lblCurrency2.Size = new System.Drawing.Size(23, 15);
            this.lblCurrency2.TabIndex = 17;
            this.lblCurrency2.Text = "TL";
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(342, 356);
            this.Controls.Add(this.lblCurrency2);
            this.Controls.Add(this.lblCurrency1);
            this.Controls.Add(this.lblCurrency3);
            this.Controls.Add(this.lblCurrentTotal);
            this.Controls.Add(this.lblCurrentTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pbxCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblAcceptOrder);
            this.Controls.Add(this.lblResetOrder);
            this.Controls.Add(this.lblCurrentOrderTotal);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.dgwOrders);
            this.Controls.Add(this.pbxOrderLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderPage";
            this.Text = "Sepetim";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrders;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblCurrentOrderTotal;
        private System.Windows.Forms.Button lblResetOrder;
        private System.Windows.Forms.Button lblAcceptOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox pbxCustomer;
        private System.Windows.Forms.PictureBox pbxOrderLogo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblCurrentTax;
        private System.Windows.Forms.Label lblCurrentTotal;
        private System.Windows.Forms.Label lblCurrency3;
        private System.Windows.Forms.Label lblCurrency1;
        private System.Windows.Forms.Label lblCurrency2;
    }
}