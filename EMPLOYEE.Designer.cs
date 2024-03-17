namespace DeMacilalaHS
{
    partial class EMPLOYEE
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btmINSERT = new System.Windows.Forms.Button();
            this.btmUPDATE = new System.Windows.Forms.Button();
            this.btmDELETE = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.txtCONTACT = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbPOSITION = new System.Windows.Forms.ComboBox();
            this.cbGENDER = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGE EMPLOYEE";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(881, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "DASHBOARD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "POSITION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DATE OF BIRTH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CONTACT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "DATE OF HIRE";
            // 
            // btmINSERT
            // 
            this.btmINSERT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmINSERT.Location = new System.Drawing.Point(26, 329);
            this.btmINSERT.Name = "btmINSERT";
            this.btmINSERT.Size = new System.Drawing.Size(101, 30);
            this.btmINSERT.TabIndex = 9;
            this.btmINSERT.Text = "INSERT";
            this.btmINSERT.UseVisualStyleBackColor = true;
            this.btmINSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // btmUPDATE
            // 
            this.btmUPDATE.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmUPDATE.Location = new System.Drawing.Point(142, 330);
            this.btmUPDATE.Name = "btmUPDATE";
            this.btmUPDATE.Size = new System.Drawing.Size(108, 30);
            this.btmUPDATE.TabIndex = 10;
            this.btmUPDATE.Text = "UPDATE";
            this.btmUPDATE.UseVisualStyleBackColor = true;
            this.btmUPDATE.Click += new System.EventHandler(this.btmUPDATE_Click);
            // 
            // btmDELETE
            // 
            this.btmDELETE.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDELETE.Location = new System.Drawing.Point(263, 330);
            this.btmDELETE.Name = "btmDELETE";
            this.btmDELETE.Size = new System.Drawing.Size(101, 30);
            this.btmDELETE.TabIndex = 11;
            this.btmDELETE.Text = "DELETE";
            this.btmDELETE.UseVisualStyleBackColor = true;
            this.btmDELETE.Click += new System.EventHandler(this.btmDELETE_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 123);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(131, 20);
            this.txtID.TabIndex = 12;
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(152, 123);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(212, 20);
            this.txtNAME.TabIndex = 13;
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Location = new System.Drawing.Point(152, 173);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(212, 20);
            this.txtADDRESS.TabIndex = 13;
            // 
            // txtCONTACT
            // 
            this.txtCONTACT.Location = new System.Drawing.Point(16, 290);
            this.txtCONTACT.Name = "txtCONTACT";
            this.txtCONTACT.Size = new System.Drawing.Size(128, 20);
            this.txtCONTACT.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(149, 288);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // cbPOSITION
            // 
            this.cbPOSITION.FormattingEnabled = true;
            this.cbPOSITION.Items.AddRange(new object[] {
            "Manager",
            "Secretary",
            "Cashier",
            "Staff",
            "Delivery"});
            this.cbPOSITION.Location = new System.Drawing.Point(13, 235);
            this.cbPOSITION.Name = "cbPOSITION";
            this.cbPOSITION.Size = new System.Drawing.Size(113, 21);
            this.cbPOSITION.TabIndex = 18;
            // 
            // cbGENDER
            // 
            this.cbGENDER.FormattingEnabled = true;
            this.cbGENDER.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGENDER.Location = new System.Drawing.Point(13, 173);
            this.cbGENDER.Name = "cbGENDER";
            this.cbGENDER.Size = new System.Drawing.Size(113, 21);
            this.cbGENDER.TabIndex = 19;
            // 
            // EMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.cbGENDER);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPOSITION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCONTACT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmDELETE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btmUPDATE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btmINSERT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "EMPLOYEE";
            this.Text = "MANAGE EMPLOYEE";
            this.Load += new System.EventHandler(this.EMPLOYEE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btmINSERT;
        private System.Windows.Forms.Button btmUPDATE;
        private System.Windows.Forms.Button btmDELETE;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.TextBox txtCONTACT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbPOSITION;
        private System.Windows.Forms.ComboBox cbGENDER;
    }
}