namespace Assignment2_Hotels
{
    partial class FormHotel
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
            this.lbxHotels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHotelInfo = new System.Windows.Forms.GroupBox();
            this.tbxRanking = new System.Windows.Forms.TextBox();
            this.clbxServices = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clbxRoomType = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tlpRanking = new System.Windows.Forms.TableLayoutPanel();
            this.lblRank = new System.Windows.Forms.Label();
            this.tbxHotelPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpMngrDob = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxMngrEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxMngrPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMngrFullname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNewHotel = new System.Windows.Forms.Button();
            this.btnRmvHotel = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.menuFormHotel = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbHotelInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuFormHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxHotels
            // 
            this.lbxHotels.FormattingEnabled = true;
            this.lbxHotels.Location = new System.Drawing.Point(13, 47);
            this.lbxHotels.Name = "lbxHotels";
            this.lbxHotels.Size = new System.Drawing.Size(221, 498);
            this.lbxHotels.TabIndex = 0;
            this.lbxHotels.SelectedIndexChanged += new System.EventHandler(this.lbxHotels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL HOTELS";
            // 
            // gbHotelInfo
            // 
            this.gbHotelInfo.Controls.Add(this.tbxRanking);
            this.gbHotelInfo.Controls.Add(this.clbxServices);
            this.gbHotelInfo.Controls.Add(this.label7);
            this.gbHotelInfo.Controls.Add(this.clbxRoomType);
            this.gbHotelInfo.Controls.Add(this.label11);
            this.gbHotelInfo.Controls.Add(this.tlpRanking);
            this.gbHotelInfo.Controls.Add(this.lblRank);
            this.gbHotelInfo.Controls.Add(this.tbxHotelPhone);
            this.gbHotelInfo.Controls.Add(this.label2);
            this.gbHotelInfo.Controls.Add(this.label12);
            this.gbHotelInfo.Controls.Add(this.tbxAddress);
            this.gbHotelInfo.Controls.Add(this.label6);
            this.gbHotelInfo.Controls.Add(this.tbxPostalCode);
            this.gbHotelInfo.Controls.Add(this.label5);
            this.gbHotelInfo.Controls.Add(this.tbxCity);
            this.gbHotelInfo.Controls.Add(this.label4);
            this.gbHotelInfo.Controls.Add(this.tbxCountry);
            this.gbHotelInfo.Controls.Add(this.tbxName);
            this.gbHotelInfo.Controls.Add(this.label3);
            this.gbHotelInfo.Location = new System.Drawing.Point(254, 41);
            this.gbHotelInfo.Name = "gbHotelInfo";
            this.gbHotelInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbHotelInfo.Size = new System.Drawing.Size(318, 356);
            this.gbHotelInfo.TabIndex = 3;
            this.gbHotelInfo.TabStop = false;
            this.gbHotelInfo.Text = "Hotel Details";
            // 
            // tbxRanking
            // 
            this.tbxRanking.Location = new System.Drawing.Point(101, 315);
            this.tbxRanking.Name = "tbxRanking";
            this.tbxRanking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxRanking.Size = new System.Drawing.Size(65, 20);
            this.tbxRanking.TabIndex = 12;
            this.tbxRanking.Visible = false;
            // 
            // clbxServices
            // 
            this.clbxServices.Enabled = false;
            this.clbxServices.FormattingEnabled = true;
            this.clbxServices.Items.AddRange(new object[] {
            "Bar",
            "Gym",
            "Laundry",
            "Parking",
            "Sauna",
            "Wifi"});
            this.clbxServices.Location = new System.Drawing.Point(142, 202);
            this.clbxServices.Name = "clbxServices";
            this.clbxServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbxServices.Size = new System.Drawing.Size(109, 94);
            this.clbxServices.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Services";
            // 
            // clbxRoomType
            // 
            this.clbxRoomType.Enabled = false;
            this.clbxRoomType.FormattingEnabled = true;
            this.clbxRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Family"});
            this.clbxRoomType.Location = new System.Drawing.Point(10, 201);
            this.clbxRoomType.Name = "clbxRoomType";
            this.clbxRoomType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbxRoomType.Size = new System.Drawing.Size(104, 64);
            this.clbxRoomType.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Room Types";
            // 
            // tlpRanking
            // 
            this.tlpRanking.BackColor = System.Drawing.Color.White;
            this.tlpRanking.ColumnCount = 5;
            this.tlpRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRanking.Location = new System.Drawing.Point(87, 302);
            this.tlpRanking.Name = "tlpRanking";
            this.tlpRanking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpRanking.RowCount = 1;
            this.tlpRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpRanking.Size = new System.Drawing.Size(225, 41);
            this.tlpRanking.TabIndex = 20;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(6, 318);
            this.lblRank.Name = "lblRank";
            this.lblRank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRank.Size = new System.Drawing.Size(47, 13);
            this.lblRank.TabIndex = 13;
            this.lblRank.Text = "Ranking";
            // 
            // tbxHotelPhone
            // 
            this.tbxHotelPhone.Enabled = false;
            this.tbxHotelPhone.Location = new System.Drawing.Point(87, 154);
            this.tbxHotelPhone.Name = "tbxHotelPhone";
            this.tbxHotelPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxHotelPhone.Size = new System.Drawing.Size(225, 20);
            this.tbxHotelPhone.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telephone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Enabled = false;
            this.tbxAddress.Location = new System.Drawing.Point(87, 127);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxAddress.Size = new System.Drawing.Size(225, 20);
            this.tbxAddress.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Postal Code";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Enabled = false;
            this.tbxPostalCode.Location = new System.Drawing.Point(87, 101);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxPostalCode.Size = new System.Drawing.Size(225, 20);
            this.tbxPostalCode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "City";
            // 
            // tbxCity
            // 
            this.tbxCity.Enabled = false;
            this.tbxCity.Location = new System.Drawing.Point(87, 75);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxCity.Size = new System.Drawing.Size(225, 20);
            this.tbxCity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Enabled = false;
            this.tbxCountry.Location = new System.Drawing.Point(87, 49);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxCountry.Size = new System.Drawing.Size(225, 20);
            this.tbxCountry.TabIndex = 5;
            // 
            // tbxName
            // 
            this.tbxName.Enabled = false;
            this.tbxName.Location = new System.Drawing.Point(87, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxName.Size = new System.Drawing.Size(225, 20);
            this.tbxName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpMngrDob);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbxMngrEmail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbxMngrPhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxMngrFullname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(254, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(318, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Manager";
            // 
            // dtpMngrDob
            // 
            this.dtpMngrDob.Enabled = false;
            this.dtpMngrDob.Location = new System.Drawing.Point(87, 103);
            this.dtpMngrDob.Name = "dtpMngrDob";
            this.dtpMngrDob.Size = new System.Drawing.Size(139, 20);
            this.dtpMngrDob.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Date of Birth";
            // 
            // tbxMngrEmail
            // 
            this.tbxMngrEmail.Enabled = false;
            this.tbxMngrEmail.Location = new System.Drawing.Point(87, 77);
            this.tbxMngrEmail.Name = "tbxMngrEmail";
            this.tbxMngrEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxMngrEmail.Size = new System.Drawing.Size(225, 20);
            this.tbxMngrEmail.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Email Address";
            // 
            // tbxMngrPhone
            // 
            this.tbxMngrPhone.Enabled = false;
            this.tbxMngrPhone.Location = new System.Drawing.Point(87, 51);
            this.tbxMngrPhone.Name = "tbxMngrPhone";
            this.tbxMngrPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxMngrPhone.Size = new System.Drawing.Size(225, 20);
            this.tbxMngrPhone.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mobile Phone";
            // 
            // tbxMngrFullname
            // 
            this.tbxMngrFullname.Enabled = false;
            this.tbxMngrFullname.Location = new System.Drawing.Point(87, 25);
            this.tbxMngrFullname.Name = "tbxMngrFullname";
            this.tbxMngrFullname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxMngrFullname.Size = new System.Drawing.Size(225, 20);
            this.tbxMngrFullname.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Full Name";
            // 
            // btnNewHotel
            // 
            this.btnNewHotel.Location = new System.Drawing.Point(12, 551);
            this.btnNewHotel.Name = "btnNewHotel";
            this.btnNewHotel.Size = new System.Drawing.Size(90, 30);
            this.btnNewHotel.TabIndex = 1;
            this.btnNewHotel.Text = "Add New Hotel";
            this.btnNewHotel.UseVisualStyleBackColor = true;
            this.btnNewHotel.Click += new System.EventHandler(this.btnNewHotel_Click);
            // 
            // btnRmvHotel
            // 
            this.btnRmvHotel.Location = new System.Drawing.Point(144, 551);
            this.btnRmvHotel.Name = "btnRmvHotel";
            this.btnRmvHotel.Size = new System.Drawing.Size(90, 30);
            this.btnRmvHotel.TabIndex = 2;
            this.btnRmvHotel.Text = "Remove Hotel";
            this.btnRmvHotel.UseVisualStyleBackColor = true;
            this.btnRmvHotel.Click += new System.EventHandler(this.btnRmvHotel_Click);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(481, 551);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(90, 30);
            this.btnEditDetails.TabIndex = 18;
            this.btnEditDetails.Text = "Edit Details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // menuFormHotel
            // 
            this.menuFormHotel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuFormHotel.Location = new System.Drawing.Point(0, 0);
            this.menuFormHotel.Name = "menuFormHotel";
            this.menuFormHotel.Size = new System.Drawing.Size(584, 24);
            this.menuFormHotel.TabIndex = 5;
            this.menuFormHotel.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.programInfoToolStripMenuItem.Text = "Program info";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.programInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(482, 552);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(88, 29);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 591);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.btnRmvHotel);
            this.Controls.Add(this.btnNewHotel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHotelInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxHotels);
            this.Controls.Add(this.menuFormHotel);
            this.MainMenuStrip = this.menuFormHotel;
            this.Name = "FormHotel";
            this.Text = "Hotels";
            this.Load += new System.EventHandler(this.FormHotel_Load);
            this.gbHotelInfo.ResumeLayout(false);
            this.gbHotelInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuFormHotel.ResumeLayout(false);
            this.menuFormHotel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbxHotels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHotelInfo;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnNewHotel;
        private System.Windows.Forms.Button btnRmvHotel;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.MenuStrip menuFormHotel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxHotelPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMngrPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMngrFullname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxMngrEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tlpRanking;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.CheckedListBox clbxServices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbxRoomType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxRanking;
        private System.Windows.Forms.DateTimePicker dtpMngrDob;
    }
}

