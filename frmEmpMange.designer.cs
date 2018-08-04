namespace Time_Attendance
{
    partial class frmEmpMange
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpMange));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btncancel = new EnhancedGlassButton.GlassButton();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpNav = new Infragistics.Win.Misc.UltraGroupBox();
            this.butt_stop = new System.Windows.Forms.Button();
            this.butt_start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.GrdEmployees = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grpMain = new Infragistics.Win.Misc.UltraGroupBox();
            this.LBL_IN = new System.Windows.Forms.Label();
            this.LBL_IN_OUT = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNav)).BeginInit();
            this.grpNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.Btncancel);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 688);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1274, 62);
            this.ultraGroupBox1.TabIndex = 1;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btncancel
            // 
            this.Btncancel.AnimateGlow = true;
            this.Btncancel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btncancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btncancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btncancel.GlowColor = System.Drawing.Color.AliceBlue;
            this.Btncancel.Image = ((System.Drawing.Image)(resources.GetObject("Btncancel.Image")));
            this.Btncancel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btncancel.InnerBorderColor = System.Drawing.Color.LightSkyBlue;
            this.Btncancel.Location = new System.Drawing.Point(570, 15);
            this.Btncancel.Name = "Btncancel";
            this.Btncancel.Size = new System.Drawing.Size(123, 28);
            this.Btncancel.TabIndex = 23;
            this.Btncancel.Text = "Print";
            this.Btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btncancel.Click += new System.EventHandler(this.Btncancel_Click);
            // 
            // err1
            // 
            this.err1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.err1.ContainerControl = this;
            // 
            // grpNav
            // 
            this.grpNav.Controls.Add(this.butt_stop);
            this.grpNav.Controls.Add(this.butt_start);
            this.grpNav.Controls.Add(this.textBox1);
            this.grpNav.Controls.Add(this.radioButtonOut);
            this.grpNav.Controls.Add(this.radioButtonIn);
            this.grpNav.Controls.Add(this.comboBox1);
            this.grpNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpNav.Location = new System.Drawing.Point(0, 0);
            this.grpNav.Name = "grpNav";
            this.grpNav.Size = new System.Drawing.Size(1274, 52);
            this.grpNav.TabIndex = 2;
            this.grpNav.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // butt_stop
            // 
            this.butt_stop.Location = new System.Drawing.Point(311, 18);
            this.butt_stop.Name = "butt_stop";
            this.butt_stop.Size = new System.Drawing.Size(75, 23);
            this.butt_stop.TabIndex = 5;
            this.butt_stop.Text = "Stop";
            this.butt_stop.UseVisualStyleBackColor = true;
            this.butt_stop.Click += new System.EventHandler(this.butt_stop_Click);
            // 
            // butt_start
            // 
            this.butt_start.Location = new System.Drawing.Point(392, 18);
            this.butt_start.Name = "butt_start";
            this.butt_start.Size = new System.Drawing.Size(75, 23);
            this.butt_start.TabIndex = 4;
            this.butt_start.Text = "Start";
            this.butt_start.UseVisualStyleBackColor = true;
            this.butt_start.Click += new System.EventHandler(this.butt_start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "10";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOut.Location = new System.Drawing.Point(116, 21);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(43, 17);
            this.radioButtonOut.TabIndex = 2;
            this.radioButtonOut.Text = "Out";
            this.radioButtonOut.UseVisualStyleBackColor = false;
            this.radioButtonOut.CheckedChanged += new System.EventHandler(this.radioButtonOut_CheckedChanged);
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonIn.Checked = true;
            this.radioButtonIn.Location = new System.Drawing.Point(52, 21);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(35, 17);
            this.radioButtonIn.TabIndex = 1;
            this.radioButtonIn.TabStop = true;
            this.radioButtonIn.Text = "In";
            this.radioButtonIn.UseVisualStyleBackColor = false;
            this.radioButtonIn.CheckedChanged += new System.EventHandler(this.radioButtonIn_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Cairo Old Building",
            "Cairo New Building"});
            this.comboBox1.Location = new System.Drawing.Point(490, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.GrdEmployees);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraGroupBox2.Location = new System.Drawing.Point(0, 52);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(633, 636);
            this.ultraGroupBox2.TabIndex = 4;
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // GrdEmployees
            // 
            this.GrdEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.White;
            this.GrdEmployees.DisplayLayout.Appearance = appearance1;
            this.GrdEmployees.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            this.GrdEmployees.DisplayLayout.GroupByBox.Hidden = true;
            this.GrdEmployees.DisplayLayout.MaxColScrollRegions = 1;
            this.GrdEmployees.DisplayLayout.MaxRowScrollRegions = 1;
            this.GrdEmployees.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.GrdEmployees.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.GrdEmployees.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.GrdEmployees.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.GrdEmployees.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.GrdEmployees.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.GrdEmployees.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Hidden;
            this.GrdEmployees.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden;
            this.GrdEmployees.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.Name = "Arial";
            appearance3.FontData.SizeInPoints = 10F;
            appearance3.ForeColor = System.Drawing.Color.White;
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.GrdEmployees.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.GrdEmployees.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance4.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance4.BackColor2 = System.Drawing.Color.White;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassTop20;
            appearance4.BackHatchStyle = Infragistics.Win.BackHatchStyle.ForwardDiagonal;
            this.GrdEmployees.DisplayLayout.Override.RowAlternateAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.GrdEmployees.DisplayLayout.Override.RowSelectorAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.GrdEmployees.DisplayLayout.Override.SelectedRowAppearance = appearance6;
            this.GrdEmployees.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.GrdEmployees.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.GrdEmployees.Location = new System.Drawing.Point(6, 3);
            this.GrdEmployees.Name = "GrdEmployees";
            this.GrdEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdEmployees.Size = new System.Drawing.Size(621, 627);
            this.GrdEmployees.TabIndex = 12;
            this.GrdEmployees.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.GrdEmployees_InitializeLayout);
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Controls.Add(this.grpMain);
            this.ultraGroupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.ultraGroupBox3.Location = new System.Drawing.Point(578, 52);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(696, 636);
            this.ultraGroupBox3.TabIndex = 3;
            this.ultraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // grpMain
            // 
            appearance7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            appearance7.BackColor2 = System.Drawing.SystemColors.InactiveCaptionText;
            appearance7.BackColorDisabled = System.Drawing.SystemColors.InactiveCaptionText;
            appearance7.BackColorDisabled2 = System.Drawing.SystemColors.InactiveCaptionText;
            this.grpMain.Appearance = appearance7;
            this.grpMain.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Header3D;
            this.grpMain.Controls.Add(this.LBL_IN);
            this.grpMain.Controls.Add(this.LBL_IN_OUT);
            this.grpMain.Controls.Add(this.txt_department);
            this.grpMain.Controls.Add(this.pictureBox1);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Controls.Add(this.txtemployeename);
            this.grpMain.Controls.Add(this.txtCardNo);
            this.grpMain.Controls.Add(this.label8);
            this.grpMain.Controls.Add(this.label11);
            this.grpMain.Controls.Add(this.label12);
            this.grpMain.Controls.Add(this.txtJob);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpMain.Location = new System.Drawing.Point(3, 3);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(690, 630);
            this.grpMain.TabIndex = 1;
            // 
            // LBL_IN
            // 
            this.LBL_IN.AutoSize = true;
            this.LBL_IN.BackColor = System.Drawing.Color.Transparent;
            this.LBL_IN.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IN.Location = new System.Drawing.Point(122, 113);
            this.LBL_IN.Name = "LBL_IN";
            this.LBL_IN.Size = new System.Drawing.Size(57, 42);
            this.LBL_IN.TabIndex = 97;
            this.LBL_IN.Text = "In";
            // 
            // LBL_IN_OUT
            // 
            this.LBL_IN_OUT.AutoSize = true;
            this.LBL_IN_OUT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IN_OUT.Location = new System.Drawing.Point(250, 268);
            this.LBL_IN_OUT.Name = "LBL_IN_OUT";
            this.LBL_IN_OUT.Size = new System.Drawing.Size(75, 25);
            this.LBL_IN_OUT.TabIndex = 96;
            this.LBL_IN_OUT.Text = "label2";
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(257, 456);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(344, 30);
            this.txt_department.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(312, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(116, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 93;
            this.label1.Text = "Department";
            // 
            // txtemployeename
            // 
            this.txtemployeename.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeename.Location = new System.Drawing.Point(257, 360);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(344, 30);
            this.txtemployeename.TabIndex = 12;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.Location = new System.Drawing.Point(257, 314);
            this.txtCardNo.MaxLength = 9;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(344, 30);
            this.txtCardNo.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(195, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 89;
            this.label8.Text = "Job";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(97, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "Card Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(75, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Employee Name";
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(257, 410);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(344, 30);
            this.txtJob.TabIndex = 86;
            // 
            // frmEmpMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1274, 750);
            this.ControlBox = false;
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox3);
            this.Controls.Add(this.grpNav);
            this.Controls.Add(this.ultraGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpMange";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.frmEmpMange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNav)).EndInit();
            this.grpNav.ResumeLayout(false);
            this.grpNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.ErrorProvider err1;
        private Infragistics.Win.Misc.UltraGroupBox grpNav;
        private System.Windows.Forms.Timer timer1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.Misc.UltraGroupBox grpMain;
        private System.Windows.Forms.Label LBL_IN;
        private System.Windows.Forms.Label LBL_IN_OUT;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemployeename;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtJob;
        private Infragistics.Win.UltraWinGrid.UltraGrid GrdEmployees;
        private System.Windows.Forms.ComboBox comboBox1;
        private EnhancedGlassButton.GlassButton Btncancel;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butt_stop;
        private System.Windows.Forms.Button butt_start;
    }
}