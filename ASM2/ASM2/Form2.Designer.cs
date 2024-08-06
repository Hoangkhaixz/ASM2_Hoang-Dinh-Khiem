namespace ASM2
{
    partial class Form2
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
            this.lbwater = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtused = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnprin = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtdscre = new System.Windows.Forms.TextBox();
            this.lbdescr = new System.Windows.Forms.Label();
            this.lbvnd = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbused = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblast = new System.Windows.Forms.Label();
            this.lbthis = new System.Windows.Forms.Label();
            this.cbbtype = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtthis = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbnum = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lvcustomer = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbwater
            // 
            this.lbwater.AutoSize = true;
            this.lbwater.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbwater.Location = new System.Drawing.Point(682, 14);
            this.lbwater.Name = "lbwater";
            this.lbwater.Size = new System.Drawing.Size(220, 52);
            this.lbwater.TabIndex = 0;
            this.lbwater.Text = "Water Bill";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtused);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnprin);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtdscre);
            this.groupBox1.Controls.Add(this.lbdescr);
            this.groupBox1.Controls.Add(this.lbvnd);
            this.groupBox1.Controls.Add(this.lbtotal);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.lbused);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblast);
            this.groupBox1.Controls.Add(this.lbthis);
            this.groupBox1.Controls.Add(this.cbbtype);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.txtlast);
            this.groupBox1.Controls.Add(this.txtthis);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lbnum);
            this.groupBox1.Controls.Add(this.lbtype);
            this.groupBox1.Controls.Add(this.lbphone);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Location = new System.Drawing.Point(72, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1455, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtused
            // 
            this.txtused.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtused.Location = new System.Drawing.Point(671, 165);
            this.txtused.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtused.Name = "txtused";
            this.txtused.Size = new System.Drawing.Size(92, 26);
            this.txtused.TabIndex = 25;
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnedit.Location = new System.Drawing.Point(421, 316);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(106, 34);
            this.btnedit.TabIndex = 24;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreset.Location = new System.Drawing.Point(657, 316);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(106, 34);
            this.btnreset.TabIndex = 23;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.Location = new System.Drawing.Point(908, 316);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 34);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnprin
            // 
            this.btnprin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnprin.Location = new System.Drawing.Point(1149, 316);
            this.btnprin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprin.Name = "btnprin";
            this.btnprin.Size = new System.Drawing.Size(108, 34);
            this.btnprin.TabIndex = 21;
            this.btnprin.Text = "Print bill";
            this.btnprin.UseVisualStyleBackColor = true;
            this.btnprin.Click += new System.EventHandler(this.btnprin_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Location = new System.Drawing.Point(179, 316);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 34);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtdscre
            // 
            this.txtdscre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdscre.Location = new System.Drawing.Point(1097, 67);
            this.txtdscre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdscre.Multiline = true;
            this.txtdscre.Name = "txtdscre";
            this.txtdscre.Size = new System.Drawing.Size(273, 201);
            this.txtdscre.TabIndex = 19;
            // 
            // lbdescr
            // 
            this.lbdescr.AutoSize = true;
            this.lbdescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdescr.Location = new System.Drawing.Point(1171, 19);
            this.lbdescr.Name = "lbdescr";
            this.lbdescr.Size = new System.Drawing.Size(104, 24);
            this.lbdescr.TabIndex = 18;
            this.lbdescr.Text = "Description";
            // 
            // lbvnd
            // 
            this.lbvnd.AutoSize = true;
            this.lbvnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbvnd.Location = new System.Drawing.Point(796, 249);
            this.lbvnd.Name = "lbvnd";
            this.lbvnd.Size = new System.Drawing.Size(50, 24);
            this.lbvnd.TabIndex = 17;
            this.lbvnd.Text = "VND";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtotal.Location = new System.Drawing.Point(615, 209);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(234, 24);
            this.lbtotal.TabIndex = 16;
            this.lbtotal.Text = "Total price(rental included)";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttotal.Location = new System.Drawing.Point(636, 244);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(156, 28);
            this.txttotal.TabIndex = 15;
            this.txttotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // lbused
            // 
            this.lbused.AutoSize = true;
            this.lbused.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbused.Location = new System.Drawing.Point(768, 166);
            this.lbused.Name = "lbused";
            this.lbused.Size = new System.Drawing.Size(36, 24);
            this.lbused.TabIndex = 14;
            this.lbused.Text = "m3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(623, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount of water used";
            // 
            // lblast
            // 
            this.lblast.AutoSize = true;
            this.lblast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblast.Location = new System.Drawing.Point(569, 19);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(101, 24);
            this.lblast.TabIndex = 11;
            this.lblast.Text = "Last month";
            // 
            // lbthis
            // 
            this.lbthis.AutoSize = true;
            this.lbthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthis.Location = new System.Drawing.Point(782, 19);
            this.lbthis.Name = "lbthis";
            this.lbthis.Size = new System.Drawing.Size(104, 24);
            this.lbthis.TabIndex = 10;
            this.lbthis.Text = "This month";
            // 
            // cbbtype
            // 
            this.cbbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbtype.FormattingEnabled = true;
            this.cbbtype.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.cbbtype.Location = new System.Drawing.Point(220, 168);
            this.cbbtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtype.Name = "cbbtype";
            this.cbbtype.Size = new System.Drawing.Size(179, 30);
            this.cbbtype.TabIndex = 9;
            this.cbbtype.SelectedIndexChanged += new System.EventHandler(this.cbbtype_SelectedIndexChanged_1);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(220, 92);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(179, 22);
            this.txtphone.TabIndex = 8;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(220, 246);
            this.txtnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(179, 22);
            this.txtnum.TabIndex = 7;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // txtlast
            // 
            this.txtlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtlast.Location = new System.Drawing.Point(573, 67);
            this.txtlast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(103, 28);
            this.txtlast.TabIndex = 6;
            this.txtlast.TextChanged += new System.EventHandler(this.txtlast_TextChanged);
            // 
            // txtthis
            // 
            this.txtthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthis.Location = new System.Drawing.Point(787, 67);
            this.txtthis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtthis.Name = "txtthis";
            this.txtthis.Size = new System.Drawing.Size(102, 28);
            this.txtthis.TabIndex = 5;
            this.txtthis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(220, 19);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 22);
            this.txtname.TabIndex = 4;
            // 
            // lbnum
            // 
            this.lbnum.AutoSize = true;
            this.lbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnum.Location = new System.Drawing.Point(18, 246);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(163, 24);
            this.lbnum.TabIndex = 3;
            this.lbnum.Text = "Number of people";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtype.Location = new System.Drawing.Point(18, 166);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(131, 24);
            this.lbtype.TabIndex = 2;
            this.lbtype.Text = "Customer type";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbphone.Location = new System.Drawing.Point(18, 92);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(66, 24);
            this.lbphone.TabIndex = 1;
            this.lbphone.Text = "Phone";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbname.Location = new System.Drawing.Point(18, 18);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(61, 24);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Name";
            // 
            // lvcustomer
            // 
            this.lvcustomer.HideSelection = false;
            this.lvcustomer.Location = new System.Drawing.Point(117, 485);
            this.lvcustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvcustomer.Name = "lvcustomer";
            this.lvcustomer.Size = new System.Drawing.Size(1456, 345);
            this.lvcustomer.TabIndex = 0;
            this.lvcustomer.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 838);
            this.Controls.Add(this.lvcustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbwater);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbwater;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.Label lbthis;
        private System.Windows.Forms.ComboBox cbbtype;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtthis;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbused;
        private System.Windows.Forms.Label lbvnd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtdscre;
        private System.Windows.Forms.Label lbdescr;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnprin;
        private System.Windows.Forms.ListView lvcustomer;
        private System.Windows.Forms.TextBox txtused;
    }
}