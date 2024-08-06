namespace ASM2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbenvi = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbused = new System.Windows.Forms.Label();
            this.lbthis = new System.Windows.Forms.Label();
            this.lblast = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbvat = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.txtenvi = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtused = new System.Windows.Forms.TextBox();
            this.txtthis = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(219, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water Bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbname.Location = new System.Drawing.Point(16, 145);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(162, 25);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name customer";
            // 
            // lbenvi
            // 
            this.lbenvi.AutoSize = true;
            this.lbenvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbenvi.Location = new System.Drawing.Point(19, 580);
            this.lbenvi.Name = "lbenvi";
            this.lbenvi.Size = new System.Drawing.Size(220, 25);
            this.lbenvi.TabIndex = 2;
            this.lbenvi.Text = "Enviroment tax (10%)";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbprice.Location = new System.Drawing.Point(19, 531);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(128, 25);
            this.lbprice.TabIndex = 3;
            this.lbprice.Text = "Price (VND)";
            // 
            // lbused
            // 
            this.lbused.AutoSize = true;
            this.lbused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbused.Location = new System.Drawing.Point(19, 466);
            this.lbused.Name = "lbused";
            this.lbused.Size = new System.Drawing.Size(202, 25);
            this.lbused.TabIndex = 4;
            this.lbused.Text = "Amout of used (m3)";
            // 
            // lbthis
            // 
            this.lbthis.AutoSize = true;
            this.lbthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthis.Location = new System.Drawing.Point(19, 408);
            this.lbthis.Name = "lbthis";
            this.lbthis.Size = new System.Drawing.Size(226, 25);
            this.lbthis.TabIndex = 5;
            this.lbthis.Text = "Water this month (m3)";
            // 
            // lblast
            // 
            this.lblast.AutoSize = true;
            this.lblast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblast.Location = new System.Drawing.Point(19, 346);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(226, 25);
            this.lblast.TabIndex = 6;
            this.lblast.Text = "Water last month (m3)";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtype.Location = new System.Drawing.Point(19, 254);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(160, 25);
            this.lbtype.TabIndex = 7;
            this.lbtype.Text = "Customer Type";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbphone.Location = new System.Drawing.Point(16, 201);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(74, 25);
            this.lbphone.TabIndex = 8;
            this.lbphone.Text = "Phone";
            // 
            // lbvat
            // 
            this.lbvat.AutoSize = true;
            this.lbvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbvat.Location = new System.Drawing.Point(19, 631);
            this.lbvat.Name = "lbvat";
            this.lbvat.Size = new System.Drawing.Size(121, 25);
            this.lbvat.TabIndex = 9;
            this.lbvat.Text = "VAT (10%)";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtotal.Location = new System.Drawing.Point(16, 710);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(61, 25);
            this.lbtotal.TabIndex = 10;
            this.lbtotal.Text = "Total";
            this.lbtotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(-1, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(692, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(692, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(-2, 673);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(692, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.txtvat);
            this.groupBox1.Controls.Add(this.txtenvi);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtused);
            this.groupBox1.Controls.Add(this.txtthis);
            this.groupBox1.Controls.Add(this.txtlast);
            this.groupBox1.Controls.Add(this.txttype);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbtotal);
            this.groupBox1.Controls.Add(this.lbvat);
            this.groupBox1.Controls.Add(this.lbphone);
            this.groupBox1.Controls.Add(this.lbtype);
            this.groupBox1.Controls.Add(this.lblast);
            this.groupBox1.Controls.Add(this.lbthis);
            this.groupBox1.Controls.Add(this.lbused);
            this.groupBox1.Controls.Add(this.lbprice);
            this.groupBox1.Controls.Add(this.lbenvi);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(544, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(689, 778);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttotal.Location = new System.Drawing.Point(408, 706);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(176, 30);
            this.txttotal.TabIndex = 23;
            // 
            // txtvat
            // 
            this.txtvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtvat.Location = new System.Drawing.Point(408, 626);
            this.txtvat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(176, 30);
            this.txtvat.TabIndex = 22;
            // 
            // txtenvi
            // 
            this.txtenvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtenvi.Location = new System.Drawing.Point(408, 575);
            this.txtenvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtenvi.Name = "txtenvi";
            this.txtenvi.Size = new System.Drawing.Size(176, 30);
            this.txtenvi.TabIndex = 21;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtprice.Location = new System.Drawing.Point(408, 526);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(176, 30);
            this.txtprice.TabIndex = 20;
            // 
            // txtused
            // 
            this.txtused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtused.Location = new System.Drawing.Point(408, 462);
            this.txtused.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtused.Name = "txtused";
            this.txtused.Size = new System.Drawing.Size(176, 30);
            this.txtused.TabIndex = 19;
            // 
            // txtthis
            // 
            this.txtthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthis.Location = new System.Drawing.Point(408, 403);
            this.txtthis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtthis.Name = "txtthis";
            this.txtthis.Size = new System.Drawing.Size(176, 30);
            this.txtthis.TabIndex = 18;
            // 
            // txtlast
            // 
            this.txtlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtlast.Location = new System.Drawing.Point(408, 342);
            this.txtlast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(176, 30);
            this.txtlast.TabIndex = 17;
            this.txtlast.TextChanged += new System.EventHandler(this.txtlast_TextChanged);
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttype.Location = new System.Drawing.Point(408, 250);
            this.txttype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(176, 30);
            this.txttype.TabIndex = 16;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtphone.Location = new System.Drawing.Point(408, 196);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(176, 30);
            this.txtphone.TabIndex = 15;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(408, 140);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(176, 30);
            this.txtname.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbenvi;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbused;
        private System.Windows.Forms.Label lbthis;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbvat;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.TextBox txtenvi;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtused;
        private System.Windows.Forms.TextBox txtthis;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txttype;
    }
}