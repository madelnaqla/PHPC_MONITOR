namespace Time_Attendance
{
    partial class FrmNowIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNowIN));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.glassButton1 = new EnhancedGlassButton.GlassButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.BtnPrintPreview = new EnhancedGlassButton.GlassButton();
            this.btnExit = new EnhancedGlassButton.GlassButton();
            this.grpMain = new Infragistics.Win.Misc.UltraGroupBox();
            this.rbut_find_abs = new System.Windows.Forms.RadioButton();
            this.rbut_find_att = new System.Windows.Forms.RadioButton();
            this.rbut_find_out = new System.Windows.Forms.RadioButton();
            this.rbut_find_in = new System.Windows.Forms.RadioButton();
            this.clb_location = new System.Windows.Forms.CheckedListBox();
            this.clb_company = new System.Windows.Forms.CheckedListBox();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.clbDep = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.depBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeAttendanceDataSet = new Time_Attendance.TimeAttendanceDataSet();
            this.depTableAdapter = new Time_Attendance.TimeAttendanceDataSetTableAdapters.DepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeAttendanceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox1.Controls.Add(this.glassButton1);
            this.ultraGroupBox1.Controls.Add(this.radioButton4);
            this.ultraGroupBox1.Controls.Add(this.label5);
            this.ultraGroupBox1.Controls.Add(this.radioButton1);
            this.ultraGroupBox1.Controls.Add(this.radioButton2);
            this.ultraGroupBox1.Controls.Add(this.radioButton3);
            this.ultraGroupBox1.Controls.Add(this.BtnPrintPreview);
            this.ultraGroupBox1.Controls.Add(this.btnExit);
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 409);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1016, 43);
            this.ultraGroupBox1.TabIndex = 27;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // glassButton1
            // 
            this.glassButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.glassButton1.AnimateGlow = true;
            this.glassButton1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.glassButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.glassButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.glassButton1.GlowColor = System.Drawing.Color.AliceBlue;
            this.glassButton1.Image = ((System.Drawing.Image)(resources.GetObject("glassButton1.Image")));
            this.glassButton1.InnerBorderColor = System.Drawing.Color.LightSkyBlue;
            this.glassButton1.Location = new System.Drawing.Point(775, 10);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(116, 24);
            this.glassButton1.TabIndex = 114;
            this.glassButton1.Text = "print summary";
            this.glassButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glassButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.glassButton1.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton4.Location = new System.Drawing.Point(565, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 17);
            this.radioButton4.TabIndex = 51;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Dep";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(328, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Sort By";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(400, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 50;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(460, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Card";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(512, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 49;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Date";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // BtnPrintPreview
            // 
            this.BtnPrintPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPrintPreview.AnimateGlow = true;
            this.BtnPrintPreview.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnPrintPreview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnPrintPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnPrintPreview.GlowColor = System.Drawing.Color.AliceBlue;
            this.BtnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintPreview.Image")));
            this.BtnPrintPreview.InnerBorderColor = System.Drawing.Color.LightSkyBlue;
            this.BtnPrintPreview.Location = new System.Drawing.Point(619, 10);
            this.BtnPrintPreview.Name = "BtnPrintPreview";
            this.BtnPrintPreview.Size = new System.Drawing.Size(72, 24);
            this.BtnPrintPreview.TabIndex = 17;
            this.BtnPrintPreview.Text = "print";
            this.BtnPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPrintPreview.Click += new System.EventHandler(this.BtnPrintPreview_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.AnimateGlow = true;
            this.btnExit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.GlowColor = System.Drawing.Color.AliceBlue;
            this.btnExit.InnerBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.Location = new System.Drawing.Point(697, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 24);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Close";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.rbut_find_abs);
            this.grpMain.Controls.Add(this.rbut_find_att);
            this.grpMain.Controls.Add(this.rbut_find_out);
            this.grpMain.Controls.Add(this.rbut_find_in);
            this.grpMain.Controls.Add(this.clb_location);
            this.grpMain.Controls.Add(this.clb_company);
            this.grpMain.Controls.Add(this.ch1);
            this.grpMain.Controls.Add(this.clbDep);
            this.grpMain.Controls.Add(this.label7);
            this.grpMain.Controls.Add(this.label8);
            this.grpMain.Controls.Add(this.btnFind);
            this.grpMain.Location = new System.Drawing.Point(3, 4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(1009, 135);
            this.grpMain.TabIndex = 24;
            this.grpMain.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // rbut_find_abs
            // 
            this.rbut_find_abs.AutoSize = true;
            this.rbut_find_abs.BackColor = System.Drawing.Color.Transparent;
            this.rbut_find_abs.Location = new System.Drawing.Point(841, 93);
            this.rbut_find_abs.Name = "rbut_find_abs";
            this.rbut_find_abs.Size = new System.Drawing.Size(66, 17);
            this.rbut_find_abs.TabIndex = 122;
            this.rbut_find_abs.Text = "Absence";
            this.rbut_find_abs.UseVisualStyleBackColor = false;
            // 
            // rbut_find_att
            // 
            this.rbut_find_att.AutoSize = true;
            this.rbut_find_att.BackColor = System.Drawing.Color.Transparent;
            this.rbut_find_att.Location = new System.Drawing.Point(841, 67);
            this.rbut_find_att.Name = "rbut_find_att";
            this.rbut_find_att.Size = new System.Drawing.Size(81, 17);
            this.rbut_find_att.TabIndex = 121;
            this.rbut_find_att.Text = "Attendance";
            this.rbut_find_att.UseVisualStyleBackColor = false;
            // 
            // rbut_find_out
            // 
            this.rbut_find_out.AutoSize = true;
            this.rbut_find_out.BackColor = System.Drawing.Color.Transparent;
            this.rbut_find_out.Location = new System.Drawing.Point(841, 42);
            this.rbut_find_out.Name = "rbut_find_out";
            this.rbut_find_out.Size = new System.Drawing.Size(66, 17);
            this.rbut_find_out.TabIndex = 120;
            this.rbut_find_out.Text = "Find Out";
            this.rbut_find_out.UseVisualStyleBackColor = false;
            // 
            // rbut_find_in
            // 
            this.rbut_find_in.AutoSize = true;
            this.rbut_find_in.BackColor = System.Drawing.Color.Transparent;
            this.rbut_find_in.Checked = true;
            this.rbut_find_in.Location = new System.Drawing.Point(841, 19);
            this.rbut_find_in.Name = "rbut_find_in";
            this.rbut_find_in.Size = new System.Drawing.Size(58, 17);
            this.rbut_find_in.TabIndex = 119;
            this.rbut_find_in.TabStop = true;
            this.rbut_find_in.Text = "Find In";
            this.rbut_find_in.UseVisualStyleBackColor = false;
            // 
            // clb_location
            // 
            this.clb_location.CheckOnClick = true;
            this.clb_location.FormattingEnabled = true;
            this.clb_location.Items.AddRange(new object[] {
            "Cairo",
            "Port Said"});
            this.clb_location.Location = new System.Drawing.Point(336, 17);
            this.clb_location.Name = "clb_location";
            this.clb_location.ScrollAlwaysVisible = true;
            this.clb_location.Size = new System.Drawing.Size(166, 79);
            this.clb_location.Sorted = true;
            this.clb_location.TabIndex = 115;
            this.clb_location.ThreeDCheckBoxes = true;
            // 
            // clb_company
            // 
            this.clb_company.CheckOnClick = true;
            this.clb_company.FormattingEnabled = true;
            this.clb_company.Items.AddRange(new object[] {
            "BP",
            "EPSCO",
            "IBS",
            "Other..",
            "PhPC"});
            this.clb_company.Location = new System.Drawing.Point(76, 17);
            this.clb_company.Name = "clb_company";
            this.clb_company.ScrollAlwaysVisible = true;
            this.clb_company.Size = new System.Drawing.Size(166, 79);
            this.clb_company.Sorted = true;
            this.clb_company.TabIndex = 114;
            this.clb_company.ThreeDCheckBoxes = true;
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.BackColor = System.Drawing.Color.Transparent;
            this.ch1.Location = new System.Drawing.Point(515, 20);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(15, 14);
            this.ch1.TabIndex = 113;
            this.ch1.UseVisualStyleBackColor = false;
            this.ch1.CheckedChanged += new System.EventHandler(this.ch1_CheckedChanged);
            // 
            // clbDep
            // 
            this.clbDep.CheckOnClick = true;
            this.clbDep.FormattingEnabled = true;
            this.clbDep.Location = new System.Drawing.Point(537, 17);
            this.clbDep.Name = "clbDep";
            this.clbDep.ScrollAlwaysVisible = true;
            this.clbDep.Size = new System.Drawing.Size(287, 79);
            this.clbDep.Sorted = true;
            this.clbDep.TabIndex = 112;
            this.clbDep.ThreeDCheckBoxes = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Company : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(266, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 107;
            this.label8.Text = "Location : ";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(534, 106);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 97;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.White;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            this.ultraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            this.ultraGrid1.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.Name = "Arial";
            appearance3.FontData.SizeInPoints = 10F;
            appearance3.ForeColor = System.Drawing.Color.White;
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance4.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance4.BackColor2 = System.Drawing.Color.White;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassTop50;
            appearance4.BackHatchStyle = Infragistics.Win.BackHatchStyle.ForwardDiagonal;
            this.ultraGrid1.DisplayLayout.Override.RowAlternateAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid1.DisplayLayout.Override.SelectedRowAppearance = appearance6;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.Location = new System.Drawing.Point(3, 145);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(1009, 259);
            this.ultraGrid1.TabIndex = 10;
            // 
            // depBindingSource
            // 
            this.depBindingSource.DataMember = "Dep";
            this.depBindingSource.DataSource = this.timeAttendanceDataSet;
            // 
            // timeAttendanceDataSet
            // 
            this.timeAttendanceDataSet.DataSetName = "TimeAttendanceDataSet";
            this.timeAttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depTableAdapter
            // 
            this.depTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNowIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1016, 452);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.ultraGrid1);
            this.Name = "FrmNowIN";
            this.Text = "Now In";
            this.Load += new System.EventHandler(this.FrmEmpTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeAttendanceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox grpMain;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private EnhancedGlassButton.GlassButton btnExit;
        private EnhancedGlassButton.GlassButton BtnPrintPreview;
        private TimeAttendanceDataSet timeAttendanceDataSet;
        private System.Windows.Forms.BindingSource depBindingSource;
        private Time_Attendance.TimeAttendanceDataSetTableAdapters.DepTableAdapter depTableAdapter;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnFind;
        private EnhancedGlassButton.GlassButton glassButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckedListBox clbDep;
        private System.Windows.Forms.CheckedListBox clb_company;
        private System.Windows.Forms.CheckedListBox clb_location;
        private System.Windows.Forms.RadioButton rbut_find_abs;
        private System.Windows.Forms.RadioButton rbut_find_att;
        private System.Windows.Forms.RadioButton rbut_find_out;
        private System.Windows.Forms.RadioButton rbut_find_in;
    }
}