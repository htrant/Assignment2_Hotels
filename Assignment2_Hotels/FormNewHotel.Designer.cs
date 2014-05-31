namespace Assignment2_Hotels
{
    partial class FormNewHotel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbxServices = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clbxRoomType = new System.Windows.Forms.CheckedListBox();
            this.tbxHotelPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxRanking = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpMngrDob = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxMngrEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxMngrPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxMngrFullname = new System.Windows.Forms.TextBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.lblMgrName = new System.Windows.Forms.Label();
            this.lblMgrPhone = new System.Windows.Forms.Label();
            this.lblMgrEmail = new System.Windows.Forms.Label();
            this.lblMgrDoB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW HOTEL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRanking);
            this.groupBox1.Controls.Add(this.lblTelephone);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPostalCode);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblHotelName);
            this.groupBox1.Controls.Add(this.clbxServices);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.clbxRoomType);
            this.groupBox1.Controls.Add(this.tbxHotelPhone);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbxRanking);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxCity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxPostalCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxCountry);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Details";
            // 
            // clbxServices
            // 
            this.clbxServices.FormattingEnabled = true;
            this.clbxServices.Items.AddRange(new object[] {
            "Bar",
            "Gym",
            "Laundry",
            "Parking",
            "Sauna",
            "Wifi"});
            this.clbxServices.Location = new System.Drawing.Point(141, 227);
            this.clbxServices.Name = "clbxServices";
            this.clbxServices.Size = new System.Drawing.Size(109, 94);
            this.clbxServices.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Services";
            // 
            // clbxRoomType
            // 
            this.clbxRoomType.FormattingEnabled = true;
            this.clbxRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Family"});
            this.clbxRoomType.Location = new System.Drawing.Point(9, 226);
            this.clbxRoomType.Name = "clbxRoomType";
            this.clbxRoomType.Size = new System.Drawing.Size(104, 64);
            this.clbxRoomType.TabIndex = 8;
            // 
            // tbxHotelPhone
            // 
            this.tbxHotelPhone.Location = new System.Drawing.Point(121, 153);
            this.tbxHotelPhone.Name = "tbxHotelPhone";
            this.tbxHotelPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxHotelPhone.Size = new System.Drawing.Size(225, 20);
            this.tbxHotelPhone.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Telephone";
            // 
            // tbxRanking
            // 
            this.tbxRanking.Location = new System.Drawing.Point(121, 179);
            this.tbxRanking.Name = "tbxRanking";
            this.tbxRanking.Size = new System.Drawing.Size(65, 20);
            this.tbxRanking.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ranking (0-5)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Room Types";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(121, 127);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxAddress.Size = new System.Drawing.Size(225, 20);
            this.tbxAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(121, 75);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxCity.Size = new System.Drawing.Size(225, 20);
            this.tbxCity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Postal Code";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(121, 101);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxPostalCode.Size = new System.Drawing.Size(225, 20);
            this.tbxPostalCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Country";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(121, 49);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxCountry.Size = new System.Drawing.Size(225, 20);
            this.tbxCountry.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hotel Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(121, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxName.Size = new System.Drawing.Size(225, 20);
            this.tbxName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 520);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(211, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMgrDoB);
            this.groupBox2.Controls.Add(this.lblMgrEmail);
            this.groupBox2.Controls.Add(this.lblMgrPhone);
            this.groupBox2.Controls.Add(this.lblMgrName);
            this.groupBox2.Controls.Add(this.dtpMngrDob);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbxMngrEmail);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbxMngrPhone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxMngrFullname);
            this.groupBox2.Location = new System.Drawing.Point(12, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotel Manager";
            // 
            // dtpMngrDob
            // 
            this.dtpMngrDob.Location = new System.Drawing.Point(121, 101);
            this.dtpMngrDob.Name = "dtpMngrDob";
            this.dtpMngrDob.Size = new System.Drawing.Size(139, 20);
            this.dtpMngrDob.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Date of Birth";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Email Address";
            // 
            // tbxMngrEmail
            // 
            this.tbxMngrEmail.Location = new System.Drawing.Point(121, 74);
            this.tbxMngrEmail.Name = "tbxMngrEmail";
            this.tbxMngrEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxMngrEmail.Size = new System.Drawing.Size(225, 20);
            this.tbxMngrEmail.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mobile Phone";
            // 
            // tbxMngrPhone
            // 
            this.tbxMngrPhone.Location = new System.Drawing.Point(121, 48);
            this.tbxMngrPhone.Name = "tbxMngrPhone";
            this.tbxMngrPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxMngrPhone.Size = new System.Drawing.Size(225, 20);
            this.tbxMngrPhone.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Full Name";
            // 
            // tbxMngrFullname
            // 
            this.tbxMngrFullname.Location = new System.Drawing.Point(121, 22);
            this.tbxMngrFullname.Name = "tbxMngrFullname";
            this.tbxMngrFullname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxMngrFullname.Size = new System.Drawing.Size(225, 20);
            this.tbxMngrFullname.TabIndex = 10;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.BackColor = System.Drawing.SystemColors.Control;
            this.lblHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.ForeColor = System.Drawing.Color.Red;
            this.lblHotelName.Location = new System.Drawing.Point(104, 26);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(15, 20);
            this.lblHotelName.TabIndex = 42;
            this.lblHotelName.Text = "*";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.SystemColors.Control;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Red;
            this.lblCountry.Location = new System.Drawing.Point(104, 52);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(15, 20);
            this.lblCountry.TabIndex = 43;
            this.lblCountry.Text = "*";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.SystemColors.Control;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Red;
            this.lblCity.Location = new System.Drawing.Point(104, 78);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(15, 20);
            this.lblCity.TabIndex = 44;
            this.lblCity.Text = "*";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.ForeColor = System.Drawing.Color.Red;
            this.lblPostalCode.Location = new System.Drawing.Point(104, 104);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(15, 20);
            this.lblPostalCode.TabIndex = 45;
            this.lblPostalCode.Text = "*";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Red;
            this.lblAddress.Location = new System.Drawing.Point(104, 130);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(15, 20);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "*";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.Color.Red;
            this.lblTelephone.Location = new System.Drawing.Point(104, 156);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(15, 20);
            this.lblTelephone.TabIndex = 47;
            this.lblTelephone.Text = "*";
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.BackColor = System.Drawing.SystemColors.Control;
            this.lblRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.ForeColor = System.Drawing.Color.Red;
            this.lblRanking.Location = new System.Drawing.Point(104, 182);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(15, 20);
            this.lblRanking.TabIndex = 48;
            this.lblRanking.Text = "*";
            // 
            // lblMgrName
            // 
            this.lblMgrName.AutoSize = true;
            this.lblMgrName.BackColor = System.Drawing.SystemColors.Control;
            this.lblMgrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgrName.ForeColor = System.Drawing.Color.Red;
            this.lblMgrName.Location = new System.Drawing.Point(104, 25);
            this.lblMgrName.Name = "lblMgrName";
            this.lblMgrName.Size = new System.Drawing.Size(15, 20);
            this.lblMgrName.TabIndex = 49;
            this.lblMgrName.Text = "*";
            // 
            // lblMgrPhone
            // 
            this.lblMgrPhone.AutoSize = true;
            this.lblMgrPhone.BackColor = System.Drawing.SystemColors.Control;
            this.lblMgrPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgrPhone.ForeColor = System.Drawing.Color.Red;
            this.lblMgrPhone.Location = new System.Drawing.Point(104, 51);
            this.lblMgrPhone.Name = "lblMgrPhone";
            this.lblMgrPhone.Size = new System.Drawing.Size(15, 20);
            this.lblMgrPhone.TabIndex = 50;
            this.lblMgrPhone.Text = "*";
            // 
            // lblMgrEmail
            // 
            this.lblMgrEmail.AutoSize = true;
            this.lblMgrEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblMgrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgrEmail.ForeColor = System.Drawing.Color.Red;
            this.lblMgrEmail.Location = new System.Drawing.Point(104, 77);
            this.lblMgrEmail.Name = "lblMgrEmail";
            this.lblMgrEmail.Size = new System.Drawing.Size(15, 20);
            this.lblMgrEmail.TabIndex = 51;
            this.lblMgrEmail.Text = "*";
            // 
            // lblMgrDoB
            // 
            this.lblMgrDoB.AutoSize = true;
            this.lblMgrDoB.BackColor = System.Drawing.SystemColors.Control;
            this.lblMgrDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgrDoB.ForeColor = System.Drawing.Color.Red;
            this.lblMgrDoB.Location = new System.Drawing.Point(104, 102);
            this.lblMgrDoB.Name = "lblMgrDoB";
            this.lblMgrDoB.Size = new System.Drawing.Size(15, 20);
            this.lblMgrDoB.TabIndex = 52;
            this.lblMgrDoB.Text = "*";
            // 
            // FormNewHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormNewHotel";
            this.Text = "New Hotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRanking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxMngrEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxMngrPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxMngrFullname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpMngrDob;
        private System.Windows.Forms.TextBox tbxHotelPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox clbxServices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox clbxRoomType;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblMgrEmail;
        private System.Windows.Forms.Label lblMgrPhone;
        private System.Windows.Forms.Label lblMgrName;
        private System.Windows.Forms.Label lblMgrDoB;
    }
}