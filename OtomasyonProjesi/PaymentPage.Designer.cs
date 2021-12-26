
namespace OtomasyonProjesi
{
    partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblCurrentTotalPayment = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cbxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.gbxPaymentMethod = new System.Windows.Forms.GroupBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblCurrentCargoPrice = new System.Windows.Forms.Label();
            this.lblCargoPrice = new System.Windows.Forms.Label();
            this.lblCurrentTotalCargoWeight = new System.Windows.Forms.Label();
            this.lblTotalCargoWeight = new System.Windows.Forms.Label();
            this.txtPayment3 = new System.Windows.Forms.TextBox();
            this.txtPayment2 = new System.Windows.Forms.TextBox();
            this.txtPayment1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.pbxLogoPayment = new System.Windows.Forms.PictureBox();
            this.pbxCustomer = new System.Windows.Forms.PictureBox();
            this.lblTotalPaymentCurrency = new System.Windows.Forms.Label();
            this.gbxPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.lblCustomer.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Snow;
            this.lblCustomer.Location = new System.Drawing.Point(299, 11);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(80, 16);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "KullanıcıAdı";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPayment.ForeColor = System.Drawing.Color.White;
            this.lblTotalPayment.Location = new System.Drawing.Point(113, 359);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(122, 15);
            this.lblTotalPayment.TabIndex = 8;
            this.lblTotalPayment.Text = "ÖDENECEK TUTAR:";
            // 
            // lblCurrentTotalPayment
            // 
            this.lblCurrentTotalPayment.AutoSize = true;
            this.lblCurrentTotalPayment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentTotalPayment.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTotalPayment.Location = new System.Drawing.Point(231, 359);
            this.lblCurrentTotalPayment.Name = "lblCurrentTotalPayment";
            this.lblCurrentTotalPayment.Size = new System.Drawing.Size(35, 15);
            this.lblCurrentTotalPayment.TabIndex = 9;
            this.lblCurrentTotalPayment.Text = "$$$$";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.lblPaymentMethod.Location = new System.Drawing.Point(12, 137);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(139, 15);
            this.lblPaymentMethod.TabIndex = 10;
            this.lblPaymentMethod.Text = "ÖDEME YÖNTEMLERİ:";
            // 
            // cbxPaymentMethod
            // 
            this.cbxPaymentMethod.BackColor = System.Drawing.Color.White;
            this.cbxPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPaymentMethod.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxPaymentMethod.FormattingEnabled = true;
            this.cbxPaymentMethod.Items.AddRange(new object[] {
            "KAPIDA ÖDEME",
            "KREDİ KARTI İLE ÖDEME",
            "ÇEK İLE ÖDEME"});
            this.cbxPaymentMethod.Location = new System.Drawing.Point(204, 134);
            this.cbxPaymentMethod.Name = "cbxPaymentMethod";
            this.cbxPaymentMethod.Size = new System.Drawing.Size(185, 23);
            this.cbxPaymentMethod.TabIndex = 11;
            this.cbxPaymentMethod.Text = "--ÖDEME YÖNTEMİ SEÇİNİZ--";
            this.cbxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 17;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(314, 355);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "ÖDE";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxPaymentMethod
            // 
            this.gbxPaymentMethod.BackColor = System.Drawing.Color.Firebrick;
            this.gbxPaymentMethod.Controls.Add(this.lblCurrency);
            this.gbxPaymentMethod.Controls.Add(this.lblKilo);
            this.gbxPaymentMethod.Controls.Add(this.lblCurrentCargoPrice);
            this.gbxPaymentMethod.Controls.Add(this.lblCargoPrice);
            this.gbxPaymentMethod.Controls.Add(this.lblCurrentTotalCargoWeight);
            this.gbxPaymentMethod.Controls.Add(this.lblTotalCargoWeight);
            this.gbxPaymentMethod.Controls.Add(this.txtPayment3);
            this.gbxPaymentMethod.Controls.Add(this.txtPayment2);
            this.gbxPaymentMethod.Controls.Add(this.txtPayment1);
            this.gbxPaymentMethod.Controls.Add(this.label10);
            this.gbxPaymentMethod.Controls.Add(this.label9);
            this.gbxPaymentMethod.Controls.Add(this.label7);
            this.gbxPaymentMethod.Location = new System.Drawing.Point(12, 171);
            this.gbxPaymentMethod.Name = "gbxPaymentMethod";
            this.gbxPaymentMethod.Size = new System.Drawing.Size(377, 178);
            this.gbxPaymentMethod.TabIndex = 20;
            this.gbxPaymentMethod.TabStop = false;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrency.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Location = new System.Drawing.Point(296, 148);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(23, 15);
            this.lblCurrency.TabIndex = 14;
            this.lblCurrency.Text = "TL";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKilo.ForeColor = System.Drawing.Color.White;
            this.lblKilo.Location = new System.Drawing.Point(296, 133);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(25, 15);
            this.lblKilo.TabIndex = 13;
            this.lblKilo.Text = "KG";
            // 
            // lblCurrentCargoPrice
            // 
            this.lblCurrentCargoPrice.AutoSize = true;
            this.lblCurrentCargoPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentCargoPrice.ForeColor = System.Drawing.Color.White;
            this.lblCurrentCargoPrice.Location = new System.Drawing.Point(263, 148);
            this.lblCurrentCargoPrice.Name = "lblCurrentCargoPrice";
            this.lblCurrentCargoPrice.Size = new System.Drawing.Size(35, 15);
            this.lblCurrentCargoPrice.TabIndex = 12;
            this.lblCurrentCargoPrice.Text = "$$$$";
            // 
            // lblCargoPrice
            // 
            this.lblCargoPrice.AutoSize = true;
            this.lblCargoPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCargoPrice.ForeColor = System.Drawing.Color.White;
            this.lblCargoPrice.Location = new System.Drawing.Point(189, 148);
            this.lblCargoPrice.Name = "lblCargoPrice";
            this.lblCargoPrice.Size = new System.Drawing.Size(82, 15);
            this.lblCargoPrice.TabIndex = 11;
            this.lblCargoPrice.Text = "Kargo Ücreti:";
            // 
            // lblCurrentTotalCargoWeight
            // 
            this.lblCurrentTotalCargoWeight.AutoSize = true;
            this.lblCurrentTotalCargoWeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentTotalCargoWeight.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTotalCargoWeight.Location = new System.Drawing.Point(263, 133);
            this.lblCurrentTotalCargoWeight.Name = "lblCurrentTotalCargoWeight";
            this.lblCurrentTotalCargoWeight.Size = new System.Drawing.Size(35, 15);
            this.lblCurrentTotalCargoWeight.TabIndex = 10;
            this.lblCurrentTotalCargoWeight.Text = "$$$$";
            // 
            // lblTotalCargoWeight
            // 
            this.lblTotalCargoWeight.AutoSize = true;
            this.lblTotalCargoWeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCargoWeight.ForeColor = System.Drawing.Color.White;
            this.lblTotalCargoWeight.Location = new System.Drawing.Point(137, 133);
            this.lblTotalCargoWeight.Name = "lblTotalCargoWeight";
            this.lblTotalCargoWeight.Size = new System.Drawing.Size(134, 15);
            this.lblTotalCargoWeight.TabIndex = 9;
            this.lblTotalCargoWeight.Text = "Toplam Kargo Ağırlığı:";
            // 
            // txtPayment3
            // 
            this.txtPayment3.Location = new System.Drawing.Point(222, 80);
            this.txtPayment3.Name = "txtPayment3";
            this.txtPayment3.Size = new System.Drawing.Size(100, 20);
            this.txtPayment3.TabIndex = 7;
            this.txtPayment3.Visible = false;
            // 
            // txtPayment2
            // 
            this.txtPayment2.Location = new System.Drawing.Point(221, 54);
            this.txtPayment2.Name = "txtPayment2";
            this.txtPayment2.Size = new System.Drawing.Size(100, 20);
            this.txtPayment2.TabIndex = 6;
            this.txtPayment2.Visible = false;
            // 
            // txtPayment1
            // 
            this.txtPayment1.Location = new System.Drawing.Point(221, 28);
            this.txtPayment1.Name = "txtPayment1";
            this.txtPayment1.Size = new System.Drawing.Size(100, 20);
            this.txtPayment1.TabIndex = 5;
            this.txtPayment1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(51, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 4;
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 3;
            this.label9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 2;
            this.label7.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(12, 75);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(152, 15);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "GÖNDERİLECEK ADRES:";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.rtxtAddress.Location = new System.Drawing.Point(204, 75);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(185, 53);
            this.rtxtAddress.TabIndex = 22;
            this.rtxtAddress.Text = "";
            // 
            // pbxLogoPayment
            // 
            this.pbxLogoPayment.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoPayment.Image")));
            this.pbxLogoPayment.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxLogoPayment.InitialImage")));
            this.pbxLogoPayment.Location = new System.Drawing.Point(-3, -19);
            this.pbxLogoPayment.Name = "pbxLogoPayment";
            this.pbxLogoPayment.Size = new System.Drawing.Size(187, 147);
            this.pbxLogoPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoPayment.TabIndex = 23;
            this.pbxLogoPayment.TabStop = false;
            // 
            // pbxCustomer
            // 
            this.pbxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.pbxCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbxCustomer.Image")));
            this.pbxCustomer.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxCustomer.InitialImage")));
            this.pbxCustomer.Location = new System.Drawing.Point(372, 9);
            this.pbxCustomer.Name = "pbxCustomer";
            this.pbxCustomer.Size = new System.Drawing.Size(17, 18);
            this.pbxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCustomer.TabIndex = 24;
            this.pbxCustomer.TabStop = false;
            // 
            // lblTotalPaymentCurrency
            // 
            this.lblTotalPaymentCurrency.AutoSize = true;
            this.lblTotalPaymentCurrency.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPaymentCurrency.ForeColor = System.Drawing.Color.White;
            this.lblTotalPaymentCurrency.Location = new System.Drawing.Point(287, 359);
            this.lblTotalPaymentCurrency.Name = "lblTotalPaymentCurrency";
            this.lblTotalPaymentCurrency.Size = new System.Drawing.Size(23, 15);
            this.lblTotalPaymentCurrency.TabIndex = 25;
            this.lblTotalPaymentCurrency.Text = "TL";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(401, 390);
            this.Controls.Add(this.lblTotalPaymentCurrency);
            this.Controls.Add(this.pbxCustomer);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.gbxPaymentMethod);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblCurrentTotalPayment);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.pbxLogoPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentPage";
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.payment_Load);
            this.gbxPaymentMethod.ResumeLayout(false);
            this.gbxPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblCurrentTotalPayment;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cbxPaymentMethod;
        private System.Windows.Forms.GroupBox gbxPaymentMethod;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.PictureBox pbxLogoPayment;
        private System.Windows.Forms.PictureBox pbxCustomer;
        private System.Windows.Forms.TextBox txtPayment3;
        private System.Windows.Forms.TextBox txtPayment2;
        private System.Windows.Forms.TextBox txtPayment1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalCargoWeight;
        private System.Windows.Forms.Label lblCurrentCargoPrice;
        private System.Windows.Forms.Label lblCargoPrice;
        private System.Windows.Forms.Label lblCurrentTotalCargoWeight;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblTotalPaymentCurrency;
    }
}