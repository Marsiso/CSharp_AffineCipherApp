
using System;

namespace AffineCipherApp
{
    partial class BasicView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicView));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.subPanelTables = new System.Windows.Forms.Panel();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.listViewSubstitution = new System.Windows.Forms.ListView();
            this.listViewFilter = new System.Windows.Forms.ListView();
            this.btnSubstitution = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.subPanelOpt = new System.Windows.Forms.Panel();
            this.btnOptSave = new System.Windows.Forms.Button();
            this.tblLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelVarA = new System.Windows.Forms.Label();
            this.labelVarB = new System.Windows.Forms.Label();
            this.labelVarM = new System.Windows.Forms.Label();
            this.txtBoxVarA = new System.Windows.Forms.TextBox();
            this.txtBoxVarB = new System.Windows.Forms.TextBox();
            this.txtBoxVarM = new System.Windows.Forms.TextBox();
            this.checkBoxExtAplhabet = new System.Windows.Forms.CheckBox();
            this.checkBoxStdAplhabet = new System.Windows.Forms.CheckBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picUtbLogo = new System.Windows.Forms.PictureBox();
            this.tblRight = new System.Windows.Forms.TableLayoutPanel();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.txtBoxIn = new System.Windows.Forms.TextBox();
            this.txtBoxOut = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            this.subPanelTables.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.subPanelOpt.SuspendLayout();
            this.tblLayoutPanelLeft.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtbLogo)).BeginInit();
            this.tblRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLeft.Controls.Add(this.subPanelTables);
            this.panelLeft.Controls.Add(this.btnTables);
            this.panelLeft.Controls.Add(this.labelAuthor);
            this.panelLeft.Controls.Add(this.subPanelOpt);
            this.panelLeft.Controls.Add(this.btnOptions);
            this.panelLeft.Controls.Add(this.btnDecrypt);
            this.panelLeft.Controls.Add(this.btnEncrypt);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(291, 944);
            this.panelLeft.TabIndex = 0;
            // 
            // subPanelTables
            // 
            this.subPanelTables.AutoScroll = true;
            this.subPanelTables.AutoSize = true;
            this.subPanelTables.BackColor = System.Drawing.Color.SeaShell;
            this.subPanelTables.Controls.Add(this.tblLeft);
            this.subPanelTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelTables.Location = new System.Drawing.Point(0, 646);
            this.subPanelTables.Name = "subPanelTables";
            this.subPanelTables.Size = new System.Drawing.Size(265, 540);
            this.subPanelTables.TabIndex = 0;
            this.subPanelTables.Visible = false;
            // 
            // tblLeft
            // 
            this.tblLeft.AutoSize = true;
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLeft.Controls.Add(this.btnFilter, 0, 2);
            this.tblLeft.Controls.Add(this.listViewSubstitution, 0, 1);
            this.tblLeft.Controls.Add(this.listViewFilter, 0, 3);
            this.tblLeft.Controls.Add(this.btnSubstitution, 0, 0);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLeft.Location = new System.Drawing.Point(0, 0);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 4;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLeft.Size = new System.Drawing.Size(265, 540);
            this.tblLeft.TabIndex = 0;
            this.tblLeft.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Enabled = false;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(3, 345);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFilter.Size = new System.Drawing.Size(288, 42);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Visible = false;
            // 
            // listViewSubstitution
            // 
            this.listViewSubstitution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSubstitution.FullRowSelect = true;
            this.listViewSubstitution.GridLines = true;
            this.listViewSubstitution.HideSelection = false;
            this.listViewSubstitution.Location = new System.Drawing.Point(3, 51);
            this.listViewSubstitution.MinimumSize = new System.Drawing.Size(288, 288);
            this.listViewSubstitution.Name = "listViewSubstitution";
            this.listViewSubstitution.Size = new System.Drawing.Size(288, 288);
            this.listViewSubstitution.TabIndex = 2;
            this.listViewSubstitution.UseCompatibleStateImageBehavior = false;
            this.listViewSubstitution.View = System.Windows.Forms.View.Details;
            this.listViewSubstitution.Visible = false;
            // 
            // listViewFilter
            // 
            this.listViewFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFilter.FullRowSelect = true;
            this.listViewFilter.GridLines = true;
            this.listViewFilter.HideSelection = false;
            this.listViewFilter.Location = new System.Drawing.Point(3, 393);
            this.listViewFilter.MinimumSize = new System.Drawing.Size(288, 144);
            this.listViewFilter.Name = "listViewFilter";
            this.listViewFilter.Size = new System.Drawing.Size(288, 144);
            this.listViewFilter.TabIndex = 3;
            this.listViewFilter.UseCompatibleStateImageBehavior = false;
            this.listViewFilter.View = System.Windows.Forms.View.Details;
            this.listViewFilter.Visible = false;
            // 
            // btnSubstitution
            // 
            this.btnSubstitution.BackColor = System.Drawing.Color.Transparent;
            this.btnSubstitution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubstitution.Enabled = false;
            this.btnSubstitution.FlatAppearance.BorderSize = 0;
            this.btnSubstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstitution.Image = ((System.Drawing.Image)(resources.GetObject("btnSubstitution.Image")));
            this.btnSubstitution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubstitution.Location = new System.Drawing.Point(3, 3);
            this.btnSubstitution.Name = "btnSubstitution";
            this.btnSubstitution.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubstitution.Size = new System.Drawing.Size(288, 42);
            this.btnSubstitution.TabIndex = 4;
            this.btnSubstitution.Text = " Substitution";
            this.btnSubstitution.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubstitution.UseVisualStyleBackColor = false;
            this.btnSubstitution.Visible = false;
            // 
            // btnTables
            // 
            this.btnTables.BackColor = System.Drawing.Color.Wheat;
            this.btnTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTables.FlatAppearance.BorderSize = 0;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTables.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTables.ForeColor = System.Drawing.Color.Black;
            this.btnTables.Image = ((System.Drawing.Image)(resources.GetObject("btnTables.Image")));
            this.btnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.Location = new System.Drawing.Point(0, 588);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(265, 58);
            this.btnTables.TabIndex = 5;
            this.btnTables.Text = " Tables";
            this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTables.UseVisualStyleBackColor = false;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAuthor.Location = new System.Drawing.Point(0, 1186);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelAuthor.Size = new System.Drawing.Size(245, 29);
            this.labelAuthor.TabIndex = 7;
            this.labelAuthor.Text = "® Made by Marek Olsak";
            // 
            // subPanelOpt
            // 
            this.subPanelOpt.AutoSize = true;
            this.subPanelOpt.BackColor = System.Drawing.Color.SeaShell;
            this.subPanelOpt.Controls.Add(this.btnOptSave);
            this.subPanelOpt.Controls.Add(this.tblLayoutPanelLeft);
            this.subPanelOpt.Controls.Add(this.checkBoxExtAplhabet);
            this.subPanelOpt.Controls.Add(this.checkBoxStdAplhabet);
            this.subPanelOpt.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelOpt.Location = new System.Drawing.Point(0, 294);
            this.subPanelOpt.Name = "subPanelOpt";
            this.subPanelOpt.Size = new System.Drawing.Size(265, 294);
            this.subPanelOpt.TabIndex = 4;
            this.subPanelOpt.Visible = false;
            // 
            // btnOptSave
            // 
            this.btnOptSave.BackColor = System.Drawing.Color.Transparent;
            this.btnOptSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOptSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptSave.FlatAppearance.BorderSize = 0;
            this.btnOptSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptSave.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptSave.Image = ((System.Drawing.Image)(resources.GetObject("btnOptSave.Image")));
            this.btnOptSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptSave.Location = new System.Drawing.Point(0, 236);
            this.btnOptSave.Name = "btnOptSave";
            this.btnOptSave.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOptSave.Size = new System.Drawing.Size(265, 58);
            this.btnOptSave.TabIndex = 3;
            this.btnOptSave.Text = " Save";
            this.btnOptSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptSave.UseVisualStyleBackColor = false;
            this.btnOptSave.Visible = false;
            this.btnOptSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tblLayoutPanelLeft
            // 
            this.tblLayoutPanelLeft.AutoSize = true;
            this.tblLayoutPanelLeft.BackColor = System.Drawing.Color.Transparent;
            this.tblLayoutPanelLeft.ColumnCount = 2;
            this.tblLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLayoutPanelLeft.Controls.Add(this.labelVarA, 0, 0);
            this.tblLayoutPanelLeft.Controls.Add(this.labelVarB, 0, 1);
            this.tblLayoutPanelLeft.Controls.Add(this.labelVarM, 0, 2);
            this.tblLayoutPanelLeft.Controls.Add(this.txtBoxVarA, 1, 0);
            this.tblLayoutPanelLeft.Controls.Add(this.txtBoxVarB, 1, 1);
            this.tblLayoutPanelLeft.Controls.Add(this.txtBoxVarM, 1, 2);
            this.tblLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayoutPanelLeft.Location = new System.Drawing.Point(0, 56);
            this.tblLayoutPanelLeft.Name = "tblLayoutPanelLeft";
            this.tblLayoutPanelLeft.RowCount = 3;
            this.tblLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelLeft.Size = new System.Drawing.Size(265, 180);
            this.tblLayoutPanelLeft.TabIndex = 2;
            this.tblLayoutPanelLeft.Visible = false;
            // 
            // labelVarA
            // 
            this.labelVarA.BackColor = System.Drawing.Color.Transparent;
            this.labelVarA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVarA.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVarA.Location = new System.Drawing.Point(3, 0);
            this.labelVarA.Name = "labelVarA";
            this.labelVarA.Size = new System.Drawing.Size(60, 59);
            this.labelVarA.TabIndex = 0;
            this.labelVarA.Text = "a:";
            this.labelVarA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVarA.Visible = false;
            // 
            // labelVarB
            // 
            this.labelVarB.BackColor = System.Drawing.Color.Transparent;
            this.labelVarB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVarB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVarB.Location = new System.Drawing.Point(3, 59);
            this.labelVarB.Name = "labelVarB";
            this.labelVarB.Size = new System.Drawing.Size(60, 60);
            this.labelVarB.TabIndex = 1;
            this.labelVarB.Text = "b:";
            this.labelVarB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVarB.Visible = false;
            // 
            // labelVarM
            // 
            this.labelVarM.BackColor = System.Drawing.Color.Transparent;
            this.labelVarM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVarM.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVarM.Location = new System.Drawing.Point(3, 119);
            this.labelVarM.Name = "labelVarM";
            this.labelVarM.Size = new System.Drawing.Size(60, 61);
            this.labelVarM.TabIndex = 2;
            this.labelVarM.Text = "m:";
            this.labelVarM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVarM.Visible = false;
            // 
            // txtBoxVarA
            // 
            this.txtBoxVarA.BackColor = System.Drawing.Color.White;
            this.txtBoxVarA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxVarA.Location = new System.Drawing.Point(69, 3);
            this.txtBoxVarA.MaxLength = 10;
            this.txtBoxVarA.Name = "txtBoxVarA";
            this.txtBoxVarA.Size = new System.Drawing.Size(193, 32);
            this.txtBoxVarA.TabIndex = 3;
            this.txtBoxVarA.Text = "5";
            this.txtBoxVarA.Visible = false;
            this.txtBoxVarA.TextChanged += new System.EventHandler(this.txtBoxVarA_TextChanged);
            // 
            // txtBoxVarB
            // 
            this.txtBoxVarB.BackColor = System.Drawing.Color.White;
            this.txtBoxVarB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxVarB.Location = new System.Drawing.Point(69, 62);
            this.txtBoxVarB.MaxLength = 10;
            this.txtBoxVarB.Name = "txtBoxVarB";
            this.txtBoxVarB.Size = new System.Drawing.Size(193, 32);
            this.txtBoxVarB.TabIndex = 4;
            this.txtBoxVarB.Text = "9";
            this.txtBoxVarB.Visible = false;
            this.txtBoxVarB.TextChanged += new System.EventHandler(this.textBoxVarB_TextChanged);
            // 
            // txtBoxVarM
            // 
            this.txtBoxVarM.BackColor = System.Drawing.Color.SeaShell;
            this.txtBoxVarM.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxVarM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxVarM.Location = new System.Drawing.Point(69, 122);
            this.txtBoxVarM.MaxLength = 10;
            this.txtBoxVarM.Name = "txtBoxVarM";
            this.txtBoxVarM.ReadOnly = true;
            this.txtBoxVarM.Size = new System.Drawing.Size(193, 32);
            this.txtBoxVarM.TabIndex = 5;
            this.txtBoxVarM.Text = "26";
            this.txtBoxVarM.Visible = false;
            // 
            // checkBoxExtAplhabet
            // 
            this.checkBoxExtAplhabet.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExtAplhabet.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxExtAplhabet.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxExtAplhabet.Location = new System.Drawing.Point(0, 28);
            this.checkBoxExtAplhabet.Name = "checkBoxExtAplhabet";
            this.checkBoxExtAplhabet.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBoxExtAplhabet.Size = new System.Drawing.Size(265, 28);
            this.checkBoxExtAplhabet.TabIndex = 1;
            this.checkBoxExtAplhabet.Text = "Extended alphabet (A-Z, 0-9)";
            this.checkBoxExtAplhabet.UseVisualStyleBackColor = false;
            this.checkBoxExtAplhabet.Visible = false;
            this.checkBoxExtAplhabet.CheckedChanged += new System.EventHandler(this.checkBoxStdExtAlphabet_CheckedChanged);
            // 
            // checkBoxStdAplhabet
            // 
            this.checkBoxStdAplhabet.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxStdAplhabet.Checked = true;
            this.checkBoxStdAplhabet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStdAplhabet.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxStdAplhabet.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxStdAplhabet.Location = new System.Drawing.Point(0, 0);
            this.checkBoxStdAplhabet.Name = "checkBoxStdAplhabet";
            this.checkBoxStdAplhabet.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBoxStdAplhabet.Size = new System.Drawing.Size(265, 28);
            this.checkBoxStdAplhabet.TabIndex = 0;
            this.checkBoxStdAplhabet.Text = "Standart alphabet (A-Z)";
            this.checkBoxStdAplhabet.UseVisualStyleBackColor = false;
            this.checkBoxStdAplhabet.Visible = false;
            this.checkBoxStdAplhabet.CheckedChanged += new System.EventHandler(this.checkBoxStdExtAlphabet_CheckedChanged);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Wheat;
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptions.ForeColor = System.Drawing.Color.Black;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.Location = new System.Drawing.Point(0, 236);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(265, 58);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = " Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Wheat;
            this.btnDecrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.Image")));
            this.btnDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.Location = new System.Drawing.Point(0, 178);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(265, 58);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = " Decryption";
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Wheat;
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.Image")));
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.Location = new System.Drawing.Point(0, 120);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(265, 58);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = " Encryption";
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSize = true;
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.picUtbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(265, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // picUtbLogo
            // 
            this.picUtbLogo.BackColor = System.Drawing.Color.OldLace;
            this.picUtbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtbLogo.BackgroundImage")));
            this.picUtbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUtbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picUtbLogo.Location = new System.Drawing.Point(0, 0);
            this.picUtbLogo.Name = "picUtbLogo";
            this.picUtbLogo.Size = new System.Drawing.Size(265, 120);
            this.picUtbLogo.TabIndex = 0;
            this.picUtbLogo.TabStop = false;
            // 
            // tblRight
            // 
            this.tblRight.AutoScroll = true;
            this.tblRight.AutoSize = true;
            this.tblRight.BackColor = System.Drawing.Color.Transparent;
            this.tblRight.ColumnCount = 1;
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRight.Controls.Add(this.labelInput, 0, 0);
            this.tblRight.Controls.Add(this.labelOutput, 0, 2);
            this.tblRight.Controls.Add(this.txtBoxIn, 0, 1);
            this.tblRight.Controls.Add(this.txtBoxOut, 0, 3);
            this.tblRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRight.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblRight.Location = new System.Drawing.Point(291, 0);
            this.tblRight.Name = "tblRight";
            this.tblRight.RowCount = 4;
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRight.Size = new System.Drawing.Size(1367, 944);
            this.tblRight.TabIndex = 1;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.SandyBrown;
            this.labelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInput.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInput.Location = new System.Drawing.Point(3, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(1361, 40);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Open Text";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.BackColor = System.Drawing.Color.SandyBrown;
            this.labelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutput.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.Location = new System.Drawing.Point(3, 472);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(1361, 40);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Cypher";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxIn
            // 
            this.txtBoxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxIn.Location = new System.Drawing.Point(3, 43);
            this.txtBoxIn.Multiline = true;
            this.txtBoxIn.Name = "txtBoxIn";
            this.txtBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxIn.Size = new System.Drawing.Size(1361, 426);
            this.txtBoxIn.TabIndex = 2;
            this.txtBoxIn.TextChanged += new System.EventHandler(this.txtBoxIn_TextChanged);
            // 
            // txtBoxOut
            // 
            this.txtBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxOut.Location = new System.Drawing.Point(3, 515);
            this.txtBoxOut.Multiline = true;
            this.txtBoxOut.Name = "txtBoxOut";
            this.txtBoxOut.ReadOnly = true;
            this.txtBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOut.Size = new System.Drawing.Size(1361, 426);
            this.txtBoxOut.TabIndex = 3;
            // 
            // BasicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1658, 944);
            this.Controls.Add(this.tblRight);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasicView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affine Cipher Application";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.subPanelTables.ResumeLayout(false);
            this.subPanelTables.PerformLayout();
            this.tblLeft.ResumeLayout(false);
            this.subPanelOpt.ResumeLayout(false);
            this.subPanelOpt.PerformLayout();
            this.tblLayoutPanelLeft.ResumeLayout(false);
            this.tblLayoutPanelLeft.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUtbLogo)).EndInit();
            this.tblRight.ResumeLayout(false);
            this.tblRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.PictureBox picUtbLogo;
        private System.Windows.Forms.Panel subPanelOpt;
        private System.Windows.Forms.CheckBox checkBoxStdAplhabet;
        private System.Windows.Forms.CheckBox checkBoxExtAplhabet;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button btnOptSave;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelLeft;
        private System.Windows.Forms.Label labelVarA;
        private System.Windows.Forms.Label labelVarB;
        private System.Windows.Forms.Label labelVarM;
        private System.Windows.Forms.TextBox txtBoxVarA;
        private System.Windows.Forms.TextBox txtBoxVarB;
        private System.Windows.Forms.TextBox txtBoxVarM;
        private System.Windows.Forms.TableLayoutPanel tblRight;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox txtBoxIn;
        private System.Windows.Forms.TextBox txtBoxOut;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Panel subPanelTables;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private System.Windows.Forms.ListView listViewSubstitution;
        private System.Windows.Forms.ListView listViewFilter;
        private System.Windows.Forms.Button btnSubstitution;
        private System.Windows.Forms.Button btnFilter;
    }
}

