namespace Template_Maker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbBCC = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.cbTemplates = new System.Windows.Forms.ComboBox();
            this.btnCreateEdit = new System.Windows.Forms.Button();
            this.lblTemplates = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblBCC = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.frm1MenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorLight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorDark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNewTempName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.frm1MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFrom
            // 
            this.tbFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFrom.Location = new System.Drawing.Point(112, 79);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(653, 27);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrom_KeyPress);
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTo.Location = new System.Drawing.Point(112, 112);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(653, 27);
            this.tbTo.TabIndex = 4;
            this.tbTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTo_KeyPress);
            // 
            // tbCC
            // 
            this.tbCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCC.Location = new System.Drawing.Point(112, 145);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(653, 27);
            this.tbCC.TabIndex = 5;
            this.tbCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCC_KeyPress);
            // 
            // tbBCC
            // 
            this.tbBCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBCC.Location = new System.Drawing.Point(112, 178);
            this.tbBCC.Name = "tbBCC";
            this.tbBCC.Size = new System.Drawing.Size(653, 27);
            this.tbBCC.TabIndex = 6;
            this.tbBCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBCC_KeyPress);
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubject.Location = new System.Drawing.Point(112, 211);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(653, 27);
            this.tbSubject.TabIndex = 7;
            this.tbSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSubject_KeyPress);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(112, 244);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(653, 120);
            this.tbMessage.TabIndex = 8;
            // 
            // cbTemplates
            // 
            this.cbTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemplates.FormattingEnabled = true;
            this.cbTemplates.Items.AddRange(new object[] {
            "[Create New Template]"});
            this.cbTemplates.Location = new System.Drawing.Point(112, 46);
            this.cbTemplates.Name = "cbTemplates";
            this.cbTemplates.Size = new System.Drawing.Size(247, 27);
            this.cbTemplates.TabIndex = 1;
            this.cbTemplates.SelectedValueChanged += new System.EventHandler(this.cbTemplates_SelectedValueChanged);
            // 
            // btnCreateEdit
            // 
            this.btnCreateEdit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEdit.Location = new System.Drawing.Point(112, 390);
            this.btnCreateEdit.Name = "btnCreateEdit";
            this.btnCreateEdit.Size = new System.Drawing.Size(175, 74);
            this.btnCreateEdit.TabIndex = 10;
            this.btnCreateEdit.Text = "Create Template";
            this.btnCreateEdit.UseVisualStyleBackColor = true;
            this.btnCreateEdit.Click += new System.EventHandler(this.btnCreateEdit_Click);
            this.btnCreateEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCreateEdit_KeyPress);
            // 
            // lblTemplates
            // 
            this.lblTemplates.AutoSize = true;
            this.lblTemplates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplates.Location = new System.Drawing.Point(24, 49);
            this.lblTemplates.Name = "lblTemplates";
            this.lblTemplates.Size = new System.Drawing.Size(80, 19);
            this.lblTemplates.TabIndex = 25;
            this.lblTemplates.Text = "Templates:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(51, 82);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(45, 19);
            this.lblFrom.TabIndex = 24;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(68, 115);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 19);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "To:";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(65, 148);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(31, 19);
            this.lblCC.TabIndex = 12;
            this.lblCC.Text = "CC:";
            // 
            // lblBCC
            // 
            this.lblBCC.AutoSize = true;
            this.lblBCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCC.Location = new System.Drawing.Point(56, 181);
            this.lblBCC.Name = "lblBCC";
            this.lblBCC.Size = new System.Drawing.Size(40, 19);
            this.lblBCC.TabIndex = 13;
            this.lblBCC.Text = "BCC:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(36, 214);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(60, 19);
            this.lblSubject.TabIndex = 14;
            this.lblSubject.Text = "Subject:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(24, 247);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(72, 19);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Message:";
            // 
            // frm1MenuStrip
            // 
            this.frm1MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuConfig,
            this.menuHelp});
            this.frm1MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frm1MenuStrip.Name = "frm1MenuStrip";
            this.frm1MenuStrip.Size = new System.Drawing.Size(890, 24);
            this.frm1MenuStrip.TabIndex = 17;
            this.frm1MenuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColor});
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(93, 20);
            this.menuConfig.Text = "Configuration";
            // 
            // menuColor
            // 
            this.menuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColorLight,
            this.menuColorDark});
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(152, 22);
            this.menuColor.Text = "Color Theme";
            // 
            // menuColorLight
            // 
            this.menuColorLight.Checked = true;
            this.menuColorLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuColorLight.Name = "menuColorLight";
            this.menuColorLight.Size = new System.Drawing.Size(152, 22);
            this.menuColorLight.Text = "Light";
            this.menuColorLight.Click += new System.EventHandler(this.menuColorLight_Click);
            // 
            // menuColorDark
            // 
            this.menuColorDark.Enabled = false;
            this.menuColorDark.Name = "menuColorDark";
            this.menuColorDark.Size = new System.Drawing.Size(152, 22);
            this.menuColorDark.Text = "Dark";
            this.menuColorDark.Click += new System.EventHandler(this.menuColorDark_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(152, 22);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // tbNewTempName
            // 
            this.tbNewTempName.Enabled = false;
            this.tbNewTempName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewTempName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbNewTempName.Location = new System.Drawing.Point(365, 46);
            this.tbNewTempName.Name = "tbNewTempName";
            this.tbNewTempName.Size = new System.Drawing.Size(400, 27);
            this.tbNewTempName.TabIndex = 2;
            this.tbNewTempName.Enter += new System.EventHandler(this.tbNewTempName_Enter);
            this.tbNewTempName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewTempName_KeyPress);
            this.tbNewTempName.Leave += new System.EventHandler(this.tbNewTempName_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(25, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(14, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(590, 390);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(175, 74);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove Template";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRemove_KeyPress);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(351, 390);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(175, 74);
            this.btnPreview.TabIndex = 26;
            this.btnPreview.Text = "Preview Template";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 489);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNewTempName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblBCC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTemplates);
            this.Controls.Add(this.btnCreateEdit);
            this.Controls.Add(this.cbTemplates);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbBCC);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.frm1MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.frm1MenuStrip;
            this.Name = "Form1";
            this.Text = "Template Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.frm1MenuStrip.ResumeLayout(false);
            this.frm1MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbBCC;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ComboBox cbTemplates;
        private System.Windows.Forms.Button btnCreateEdit;
        private System.Windows.Forms.Label lblTemplates;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblBCC;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MenuStrip frm1MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.TextBox tbNewTempName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.ToolStripMenuItem menuColorLight;
        private System.Windows.Forms.ToolStripMenuItem menuColorDark;
    }
}

