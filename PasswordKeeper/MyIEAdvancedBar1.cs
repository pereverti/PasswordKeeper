﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IE = Interop.SHDocVw;
using AddinExpress.IE;
using System.Collections.Generic;
using BrightIdeasSoftware;
using System.Linq;

namespace PasswordKeeper
{
    /// <summary>
    /// Add-in Express for Internet Explorer Bar
    /// </summary>
    [ComVisible(true), Guid("1C8F1522-72CB-4979-A166-A432F0698384")]
    public class MyIEAdvancedBar1 : ADXIEAdvancedBar
    {
        public MyIEAdvancedBar1()
        {
            InitializeComponent();
        }
        private Panel pnlLogin;
        private LinkLabel lnkRegister;
        private TextBox txtDisplayName;
        private Label lblDisplayName;
        private Button btnLoginAction;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private Panel pnlPasswords;
        private Button btnNewPassword;
        private Button btnLogout;
        private Label lblConnectedUserFriendlyName;
        private Label lblConnectedUser;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Button btnSettings;
        private Button btnUserUpdateCancel;
        private Button btnDeleteUser;
        private Button btnAutoTypeTop;
        private Button btnAutoTypeBottom;
        private ContextMenuStrip ctxMenuCopy;
        private ToolStripMenuItem toolStripCopyUser;
        private ToolStripMenuItem toolStripCopyPassword;
        private ToolStripMenuItem copyURLToolStripMenuItem;
        internal FastDataListView olvPasswords;
        private OLVColumn colDisplayName;
        private OLVColumn colUserName;
        private OLVColumn colPasswordUnreadable;
        private OLVColumn colUrl;
        private Button btnShowPassword;
        private ToolTip ttAutoTypeTop;
        private ToolTip ttAutoTypeBottom;
        private ToolStripMenuItem toolStripEditPassword;
        private ToolTip ttAddEntry;
        private Label lblSelectedEntry;
        private ProgressBar pgbClearClipboard;
        private Timer timerClearClipboard;

        #region Component Designer generated code

        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblListPasswords;
            System.Windows.Forms.Label lblTitle;
            System.Windows.Forms.Label lblLogin;
            System.Windows.Forms.Label lblPassword;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyIEAdvancedBar1));
            this.lblConnectedUserFriendlyName = new System.Windows.Forms.Label();
            this.lblConnectedUser = new System.Windows.Forms.Label();
            this.ctxMenuCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripCopyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.copyURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUserUpdateCancel = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.btnLoginAction = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pnlPasswords = new System.Windows.Forms.Panel();
            this.pgbClearClipboard = new System.Windows.Forms.ProgressBar();
            this.lblSelectedEntry = new System.Windows.Forms.Label();
            this.olvPasswords = new BrightIdeasSoftware.FastDataListView();
            this.colDisplayName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colUserName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPasswordUnreadable = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colUrl = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAutoTypeBottom = new System.Windows.Forms.Button();
            this.btnAutoTypeTop = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.ttAutoTypeTop = new System.Windows.Forms.ToolTip(this.components);
            this.ttAutoTypeBottom = new System.Windows.Forms.ToolTip(this.components);
            this.ttAddEntry = new System.Windows.Forms.ToolTip(this.components);
            this.timerClearClipboard = new System.Windows.Forms.Timer(this.components);
            lblListPasswords = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblLogin = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuCopy.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlPasswords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListPasswords
            // 
            lblListPasswords.AutoSize = true;
            lblListPasswords.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblListPasswords.Location = new System.Drawing.Point(4, 116);
            lblListPasswords.Name = "lblListPasswords";
            lblListPasswords.Size = new System.Drawing.Size(63, 15);
            lblListPasswords.TabIndex = 14;
            lblListPasswords.Text = "Entries List";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(35, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(218, 37);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Password Keeper";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new System.Drawing.Point(3, 10);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(36, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(3, 39);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // lblConnectedUserFriendlyName
            // 
            this.lblConnectedUserFriendlyName.AutoSize = true;
            this.lblConnectedUserFriendlyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedUserFriendlyName.Location = new System.Drawing.Point(3, 15);
            this.lblConnectedUserFriendlyName.Name = "lblConnectedUserFriendlyName";
            this.lblConnectedUserFriendlyName.Size = new System.Drawing.Size(160, 21);
            this.lblConnectedUserFriendlyName.TabIndex = 15;
            this.lblConnectedUserFriendlyName.Text = "User Friendly Name";
            // 
            // lblConnectedUser
            // 
            this.lblConnectedUser.AutoSize = true;
            this.lblConnectedUser.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedUser.Location = new System.Drawing.Point(4, 36);
            this.lblConnectedUser.Name = "lblConnectedUser";
            this.lblConnectedUser.Size = new System.Drawing.Size(55, 12);
            this.lblConnectedUser.TabIndex = 16;
            this.lblConnectedUser.Text = "User Name";
            // 
            // ctxMenuCopy
            // 
            this.ctxMenuCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCopyUser,
            this.toolStripCopyPassword,
            this.copyURLToolStripMenuItem,
            toolStripSeparator,
            this.toolStripEditPassword});
            this.ctxMenuCopy.Name = "ctxMenuCopy";
            this.ctxMenuCopy.Size = new System.Drawing.Size(156, 98);
            this.ctxMenuCopy.Text = "Clipboard Copy";
            // 
            // toolStripCopyUser
            // 
            this.toolStripCopyUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopyUser.Image")));
            this.toolStripCopyUser.Name = "toolStripCopyUser";
            this.toolStripCopyUser.Size = new System.Drawing.Size(155, 22);
            this.toolStripCopyUser.Text = "Copy User";
            this.toolStripCopyUser.Click += new System.EventHandler(this.toolStripCopyUser_Click);
            // 
            // toolStripCopyPassword
            // 
            this.toolStripCopyPassword.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopyPassword.Image")));
            this.toolStripCopyPassword.Name = "toolStripCopyPassword";
            this.toolStripCopyPassword.Size = new System.Drawing.Size(155, 22);
            this.toolStripCopyPassword.Text = "Copy Password";
            this.toolStripCopyPassword.Click += new System.EventHandler(this.toolStripCopyPassword_Click);
            // 
            // copyURLToolStripMenuItem
            // 
            this.copyURLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyURLToolStripMenuItem.Image")));
            this.copyURLToolStripMenuItem.Name = "copyURLToolStripMenuItem";
            this.copyURLToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyURLToolStripMenuItem.Text = "Copy URL";
            this.copyURLToolStripMenuItem.Click += new System.EventHandler(this.copyURLToolStripMenuItem_Click);
            // 
            // toolStripEditPassword
            // 
            this.toolStripEditPassword.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditPassword.Image")));
            this.toolStripEditPassword.Name = "toolStripEditPassword";
            this.toolStripEditPassword.Size = new System.Drawing.Size(155, 22);
            this.toolStripEditPassword.Text = "Edit Entry";
            this.toolStripEditPassword.Click += new System.EventHandler(this.toolStripEditPassword_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.Controls.Add(this.btnShowPassword);
            this.pnlLogin.Controls.Add(this.btnDeleteUser);
            this.pnlLogin.Controls.Add(this.btnUserUpdateCancel);
            this.pnlLogin.Controls.Add(this.txtConfirmPassword);
            this.pnlLogin.Controls.Add(this.lblConfirmPassword);
            this.pnlLogin.Controls.Add(this.lnkRegister);
            this.pnlLogin.Controls.Add(this.txtDisplayName);
            this.pnlLogin.Controls.Add(this.lblDisplayName);
            this.pnlLogin.Controls.Add(this.btnLoginAction);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(lblPassword);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Controls.Add(lblLogin);
            this.pnlLogin.Location = new System.Drawing.Point(0, 40);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(303, 191);
            this.pnlLogin.TabIndex = 16;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPassword.Location = new System.Drawing.Point(245, 36);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(45, 23);
            this.btnShowPassword.TabIndex = 4;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.Text = "●●●";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(4, 160);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Visible = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUserUpdateCancel
            // 
            this.btnUserUpdateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserUpdateCancel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserUpdateCancel.Location = new System.Drawing.Point(128, 160);
            this.btnUserUpdateCancel.Name = "btnUserUpdateCancel";
            this.btnUserUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUserUpdateCancel.TabIndex = 12;
            this.btnUserUpdateCancel.Text = "Cancel";
            this.btnUserUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUserUpdateCancel.Visible = false;
            this.btnUserUpdateCancel.Click += new System.EventHandler(this.btnUserUpdateCancel_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(113, 65);
            this.txtConfirmPassword.MaxLength = 255;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(126, 23);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 68);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(104, 15);
            this.lblConfirmPassword.TabIndex = 11;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.Visible = false;
            // 
            // lnkRegister
            // 
            this.lnkRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Location = new System.Drawing.Point(3, 165);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(49, 15);
            this.lnkRegister.TabIndex = 11;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayName.Location = new System.Drawing.Point(113, 94);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(177, 23);
            this.txtDisplayName.TabIndex = 7;
            this.txtDisplayName.Visible = false;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(3, 97);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(80, 15);
            this.lblDisplayName.TabIndex = 10;
            this.lblDisplayName.Text = "Display Name";
            this.lblDisplayName.Visible = false;
            // 
            // btnLoginAction
            // 
            this.btnLoginAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginAction.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAction.Location = new System.Drawing.Point(209, 160);
            this.btnLoginAction.Name = "btnLoginAction";
            this.btnLoginAction.Size = new System.Drawing.Size(75, 23);
            this.btnLoginAction.TabIndex = 9;
            this.btnLoginAction.Text = "Connect";
            this.btnLoginAction.UseVisualStyleBackColor = true;
            this.btnLoginAction.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(113, 36);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(126, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(113, 7);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(177, 23);
            this.txtLogin.TabIndex = 1;
            // 
            // pnlPasswords
            // 
            this.pnlPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPasswords.Controls.Add(this.pgbClearClipboard);
            this.pnlPasswords.Controls.Add(this.lblSelectedEntry);
            this.pnlPasswords.Controls.Add(this.olvPasswords);
            this.pnlPasswords.Controls.Add(this.btnAutoTypeBottom);
            this.pnlPasswords.Controls.Add(this.btnAutoTypeTop);
            this.pnlPasswords.Controls.Add(this.btnSettings);
            this.pnlPasswords.Controls.Add(this.btnLogout);
            this.pnlPasswords.Controls.Add(this.btnNewPassword);
            this.pnlPasswords.Controls.Add(this.lblConnectedUser);
            this.pnlPasswords.Controls.Add(this.lblConnectedUserFriendlyName);
            this.pnlPasswords.Controls.Add(lblListPasswords);
            this.pnlPasswords.Location = new System.Drawing.Point(0, 40);
            this.pnlPasswords.Name = "pnlPasswords";
            this.pnlPasswords.Size = new System.Drawing.Size(303, 617);
            this.pnlPasswords.TabIndex = 18;
            this.pnlPasswords.Visible = false;
            // 
            // pgbClearClipboard
            // 
            this.pgbClearClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbClearClipboard.Location = new System.Drawing.Point(3, 598);
            this.pgbClearClipboard.Maximum = 150;
            this.pgbClearClipboard.Name = "pgbClearClipboard";
            this.pgbClearClipboard.Size = new System.Drawing.Size(268, 10);
            this.pgbClearClipboard.Step = -1;
            this.pgbClearClipboard.TabIndex = 30;
            this.pgbClearClipboard.Value = 150;
            this.pgbClearClipboard.Visible = false;
            // 
            // lblSelectedEntry
            // 
            this.lblSelectedEntry.AutoSize = true;
            this.lblSelectedEntry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedEntry.Location = new System.Drawing.Point(3, 76);
            this.lblSelectedEntry.Name = "lblSelectedEntry";
            this.lblSelectedEntry.Size = new System.Drawing.Size(193, 21);
            this.lblSelectedEntry.TabIndex = 29;
            this.lblSelectedEntry.Text = "Password Display Name";
            // 
            // olvPasswords
            // 
            this.olvPasswords.AllColumns.Add(this.colDisplayName);
            this.olvPasswords.AllColumns.Add(this.colUserName);
            this.olvPasswords.AllColumns.Add(this.colPasswordUnreadable);
            this.olvPasswords.AllColumns.Add(this.colUrl);
            this.olvPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvPasswords.CellEditUseWholeCell = false;
            this.olvPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDisplayName,
            this.colUserName,
            this.colPasswordUnreadable,
            this.colUrl});
            this.olvPasswords.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPasswords.DataSource = null;
            this.olvPasswords.FullRowSelect = true;
            this.olvPasswords.GridLines = true;
            this.olvPasswords.Location = new System.Drawing.Point(4, 134);
            this.olvPasswords.MultiSelect = false;
            this.olvPasswords.Name = "olvPasswords";
            this.olvPasswords.SelectAllOnControlA = false;
            this.olvPasswords.ShowGroups = false;
            this.olvPasswords.Size = new System.Drawing.Size(296, 451);
            this.olvPasswords.TabIndex = 28;
            this.olvPasswords.UseAlternatingBackColors = true;
            this.olvPasswords.UseCompatibleStateImageBehavior = false;
            this.olvPasswords.View = System.Windows.Forms.View.Details;
            this.olvPasswords.VirtualMode = true;
            this.olvPasswords.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvPasswords_CellClick);
            this.olvPasswords.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.olvPasswords_CellRightClick);
            this.olvPasswords.DoubleClick += new System.EventHandler(this.olvPasswords_DoubleClick);
            // 
            // colDisplayName
            // 
            this.colDisplayName.AspectName = "DisplayName";
            this.colDisplayName.IsEditable = false;
            this.colDisplayName.Text = "Title";
            this.colDisplayName.Width = 90;
            // 
            // colUserName
            // 
            this.colUserName.AspectName = "Login";
            this.colUserName.IsEditable = false;
            this.colUserName.Text = "User Name";
            this.colUserName.Width = 90;
            // 
            // colPasswordUnreadable
            // 
            this.colPasswordUnreadable.AspectName = "PasswordBullets";
            this.colPasswordUnreadable.AspectToStringFormat = "";
            this.colPasswordUnreadable.IsEditable = false;
            this.colPasswordUnreadable.Sortable = false;
            this.colPasswordUnreadable.Text = "Password";
            this.colPasswordUnreadable.Width = 70;
            // 
            // colUrl
            // 
            this.colUrl.AspectName = "Url";
            this.colUrl.IsEditable = false;
            this.colUrl.Text = "Url";
            this.colUrl.Width = 150;
            // 
            // btnAutoTypeBottom
            // 
            this.btnAutoTypeBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoTypeBottom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoTypeBottom.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoTypeBottom.Image")));
            this.btnAutoTypeBottom.Location = new System.Drawing.Point(277, 591);
            this.btnAutoTypeBottom.Name = "btnAutoTypeBottom";
            this.btnAutoTypeBottom.Size = new System.Drawing.Size(23, 23);
            this.btnAutoTypeBottom.TabIndex = 27;
            this.btnAutoTypeBottom.UseVisualStyleBackColor = true;
            this.btnAutoTypeBottom.Click += new System.EventHandler(this.btnAutoType_Click);
            // 
            // btnAutoTypeTop
            // 
            this.btnAutoTypeTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoTypeTop.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoTypeTop.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoTypeTop.Image")));
            this.btnAutoTypeTop.Location = new System.Drawing.Point(277, 108);
            this.btnAutoTypeTop.Name = "btnAutoTypeTop";
            this.btnAutoTypeTop.Size = new System.Drawing.Size(23, 23);
            this.btnAutoTypeTop.TabIndex = 26;
            this.btnAutoTypeTop.UseVisualStyleBackColor = true;
            this.btnAutoTypeTop.Click += new System.EventHandler(this.btnAutoType_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(196, 13);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 23);
            this.btnSettings.TabIndex = 25;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(225, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPassword.Image")));
            this.btnNewPassword.Location = new System.Drawing.Point(248, 108);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(23, 23);
            this.btnNewPassword.TabIndex = 24;
            this.btnNewPassword.UseVisualStyleBackColor = true;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // ttAutoTypeTop
            // 
            this.ttAutoTypeTop.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ttAutoTypeBottom
            // 
            this.ttAutoTypeBottom.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ttAddEntry
            // 
            this.ttAddEntry.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timerClearClipboard
            // 
            this.timerClearClipboard.Tick += new System.EventHandler(this.timerClearClipboard_Tick);
            // 
            // MyIEAdvancedBar1
            // 
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlPasswords);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MyIEAdvancedBar1";
            this.Size = new System.Drawing.Size(303, 660);
            this.Load += new System.EventHandler(this.MyIEAdvancedBar1_Load);
            this.ctxMenuCopy.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlPasswords.ResumeLayout(false);
            this.pnlPasswords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region ADX automatic code

        // Required by Add-in Express - do not modify
        // the methods within this region

        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }

        #endregion

        public IE.WebBrowser IEApp
        {
            get
            {
                return (Module.IEObj as IE.WebBrowser);
            }
        }

        public mshtml.HTMLDocument HTMLDocument
        {
            get
            {
                return (Module.HTMLDocumentObj as mshtml.HTMLDocument);
            }
        }

        #region Variables

        private UserModel CurrentUser;

        private enum TypeLogin
        {
            Connect,
            Register,
            Update
        }

        private enum TypePanel
        {
            Login,
            Passwords
        }

        private enum TypeOfElement
        {
            Login,
            Password,
            Title,
            URL,
            Unknow
        }

        private string SelectedItemCellText;
        private TypeOfElement SelectedElement;

        #endregion

        #region Events

        private void MyIEAdvancedBar1_Load(object sender, EventArgs e)
        {
            // Synchronisation
            BarItem.ApplyChangesForAllTabs = true;

            // Get connection
            ConnectionModel currentConnection = new ConnectionModel
            {
                MachineMacAddress = Tools.GetMacAddress(),
                MachineName = Environment.MachineName,
                MachineUserName = Environment.UserName,
                ConnectionDate = DateTime.Now
            };
            ConnectionController connController = new ConnectionController(string.Concat(currentConnection.MachineUserName, currentConnection.MachineName));
            
            connController.SwipeOldConnections();

            int? lastUserId = connController.GetConnectionTempUserId(currentConnection);

            if (lastUserId != null)
            {
                currentConnection.UserId = Convert.ToInt32(lastUserId);

                UserController controlUser = new UserController();

                CurrentUser = controlUser.GetUser(currentConnection.UserId);

                InitPanelPasswords();
                LoadPasswordsList();

                TogglePanelsLoginPasswords(TypePanel.Passwords);
            }
        }

        /// <summary>
        /// Click on the register link
        /// </summary>
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkRegister.Text.Equals(Tools.LblLinkButtonRegister)) // Registration
            {
                ToggleLoginPanelControls(TypeLogin.Register);
            }
            else if (lnkRegister.Text.Equals(Tools.LblLinkButtonCancel)) // Cancel registration
            {
                ToggleLoginPanelControls(TypeLogin.Connect);

                // Clean textboxes
                Clean();
            }
        }

        /// <summary>
        /// Click event of the button connection
        /// </summary>
        /// <remarks>This button is also used to save a new user (registration mode) or update an existing user (edition mode once connected)</remarks>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool connectActionDone = false;

            switch (btnLoginAction.Text)
            {
                case Tools.lblButtonConnect:
                    if (CheckCredentials())
                    {
                        InitPanelPasswords();
                        LoadPasswordsList();

                        TogglePanelsLoginPasswords(TypePanel.Passwords);

                        connectActionDone = true;
                    }

                    break;
                case Tools.LblButtonRegister:
                    // Back to connection mode if registration succeeds
                    if (RegisterNewUser())
                        ToggleLoginPanelControls(TypeLogin.Connect);

                    break;
                case Tools.lblButtonUpdate:
                    if (UpdateUser())
                    {
                        TogglePanelsLoginPasswords(TypePanel.Passwords);
                        InitPanelPasswords();

                        connectActionDone = true;
                    }

                    break;
            }

            // Log connection in bdd
            if (connectActionDone)
            {
                SetCurrentConnection();
            }
        }

        /// <summary>
        /// Create a new password entry
        /// </summary>
        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Cancel;

            SetCurrentConnection();

            using (frmPasswordManagement newPassword = new frmPasswordManagement(Tools.PasswordAction.Create, CurrentUser.Id, CurrentUser.Login))
            {
                result = newPassword.ShowDialog();
            }

            if (result == DialogResult.OK)
                LoadPasswordsList();
        }

        /// <summary>
        /// Quit current session
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Clean();
            ClearSelectedPassword();
            CleanCurrentConnection();

            TogglePanelsLoginPasswords(TypePanel.Login);
            ToggleLoginPanelControls(TypeLogin.Connect);
        }

        /// <summary>
        /// Edit current user
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            TogglePanelsLoginPasswords(TypePanel.Login);
            ToggleLoginPanelControls(TypeLogin.Update);

            FillUserControls();
        }

        /// <summary>
        /// Cancel user update
        /// </summary>
        private void btnUserUpdateCancel_Click(object sender, EventArgs e)
        {
            TogglePanelsLoginPasswords(TypePanel.Passwords);
        }

        /// <summary>
        /// Delete current user
        /// </summary>
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Concat("Are you sure you want to delete the user \"", CurrentUser.DisplayName, "\""), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new UserController().Delete(CurrentUser.Id);

                Clean();
                CleanCurrentConnection();

                TogglePanelsLoginPasswords(TypePanel.Login);
                ToggleLoginPanelControls(TypeLogin.Connect);
            }
        }

        /// <summary>
        /// Copy selected entry login in clipboard
        /// </summary>
        private void toolStripCopyUser_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((PasswordModel)olvPasswords.FocusedObject).Login);

            WriteIeStatusBar("User copied in clipboard");

            // Start countdown timer
            ClearClipboardCountDown();
        }

        /// <summary>
        /// Copy selected entry password in clipboard
        /// </summary>
        private void toolStripCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((PasswordModel)olvPasswords.FocusedObject).Password);

            WriteIeStatusBar("Password copied in clipboard");

            // Start countdown timer
            ClearClipboardCountDown();
        }

        /// <summary>
        /// Copy selected entry url in clipboard
        /// </summary>
        private void copyURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((PasswordModel)olvPasswords.FocusedObject).Url);

            WriteIeStatusBar("URL copied in clipboard");

            // Start countdown timer
            ClearClipboardCountDown();
        }

        /// <summary>
        /// Edit the selected entry
        /// </summary>
        private void toolStripEditPassword_Click(object sender, EventArgs e)
        {
            SetCurrentConnection();

            ShowPasswordForm((PasswordModel)olvPasswords.FocusedObject);
        }

        /// <summary>
        /// Click on auto-type buttons
        /// </summary>
        private void btnAutoType_Click(object sender, EventArgs e)
        {
            SetCurrentConnection();

            if (olvPasswords.FocusedItem == null)
                return;

            PasswordModel currentPassword = ((PasswordModel)olvPasswords.FocusedObject);
            List<CustomFieldModel> customFilelds = new CustomFieldController().GetCustomFields(currentPassword.Id);

            bool loginFilled = false;
            bool passwordfilled = false;

            string customLogin = customFilelds.Count > 0
                ? customFilelds.FirstOrDefault(cField => cField.Type == Tools.TypeField.Login) != null
                    ? customFilelds.FirstOrDefault(cField => cField.Type == Tools.TypeField.Login).WebControlId
                    : string.Empty
                : string.Empty;

            string customPassword = customFilelds.Count > 0
                ? customFilelds.FirstOrDefault(cField => cField.Type == Tools.TypeField.Password) != null
                    ? customFilelds.FirstOrDefault(cField => cField.Type == Tools.TypeField.Password).WebControlId
                    : string.Empty
                : string.Empty;

            mshtml.IHTMLElementCollection inputCollection = HTMLDocument.getElementsByTagName("input");

            // First Pass : custom fields
            foreach (mshtml.IHTMLElement element in inputCollection)
            {
                // Exit if login and password are already filled
                if (passwordfilled && loginFilled)
                    break;

                // Only read existing and visible elements
                if (element.id != null && !element.getAttribute("type").ToString().Equals("hidden"))
                {
                    if (!loginFilled && element.id.Equals(customLogin))
                    {
                        element.setAttribute("style", "background-color:Lime !important");
                        element.setAttribute("value", currentPassword.Login);

                        loginFilled = true;
                    }
                    else if (!passwordfilled && element.id.Equals(customPassword))
                    {
                        element.setAttribute("style", "background-color:Lime !important");
                        element.setAttribute("value", currentPassword.Password);

                        passwordfilled = true;
                    }
                }
            }

            // Second pass : generic dictionary
            foreach (mshtml.IHTMLElement element in inputCollection)
            {
                // Exit if login and password are already filled
                if (passwordfilled && loginFilled)
                    break;

                // Only read existing and visible elements
                if (element.id != null && !element.getAttribute("type").ToString().Equals("hidden"))
                {
                    if (!loginFilled && Tools.IsLogin(element.id))
                    {
                        element.setAttribute("style", "background-color:Lime !important");
                        element.setAttribute("value", currentPassword.Login);

                        loginFilled = true;
                    }
                    else if (!passwordfilled && Tools.IsPassword(element.id))
                    {
                        element.setAttribute("style", "background-color:Lime !important");
                        element.setAttribute("value", currentPassword.Password);

                        passwordfilled = true;
                    }
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar.Equals('\0') ? '●' : '\0';
            txtConfirmPassword.PasswordChar = txtPassword.PasswordChar;
        }

        /// <summary>
        /// Password list double click
        /// </summary>
        private void olvPasswords_DoubleClick(object sender, EventArgs e)
        {
            const string statusEnd = "copied in clipboard";

            SetCurrentConnection();

            switch (SelectedElement)
            {
                case TypeOfElement.Login:
                    WriteIeStatusBar(string.Concat("Login ", statusEnd));

                    // Copy in clipboard
                    Clipboard.SetText(SelectedItemCellText);

                    // Start countdown timer
                    ClearClipboardCountDown();

                    break;
                case TypeOfElement.Password:
                    WriteIeStatusBar(string.Concat("Password ", statusEnd));

                    // Copy in clipboard
                    Clipboard.SetText(SelectedItemCellText);

                    // Start countdown timer
                    ClearClipboardCountDown();

                    break;
                case TypeOfElement.Title:
                    // Edit current entry
                    ShowPasswordForm((PasswordModel)((FastDataListView)sender).FocusedObject);

                    break;
                case TypeOfElement.URL:
                    // Open URL in new tab
                    OpenUrlInNewTab(((PasswordModel)((FastDataListView)sender).FocusedObject).Url);

                    break;
                case TypeOfElement.Unknow:
                    WriteIeStatusBar(string.Concat("Element ", statusEnd));

                    // Copy in clipboard
                    Clipboard.SetText(SelectedItemCellText);

                    // Start countdown timer
                    ClearClipboardCountDown();

                    break;
            }
        }

        /// <summary>
        /// Passwords list cell click, get the value and/or the kind of the cell
        /// </summary>
        private void olvPasswords_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            // Set selected entry label and variables
            SetSelectedPassword(((PasswordModel)e.ListView.FocusedObject).Id, ((PasswordModel)e.ListView.FocusedObject).DisplayName);

            // Save the value of the clicked cell
            switch (e.Column.Index)
            {
                case 0: // Title column
                    SelectedElement = TypeOfElement.Title;

                    break;
                case 1: // Login column
                    SelectedElement = TypeOfElement.Login;
                    SelectedItemCellText = e.SubItem.Text;

                    break;
                case 2: // Password column
                    SelectedElement = TypeOfElement.Password;

                    // Get the real password bacause e.SubItem.Text shows the unreadable password (bullets)
                    SelectedItemCellText = ((PasswordModel)e.ListView.FocusedObject).Password;

                    break;
                case 3:
                    SelectedElement = TypeOfElement.URL;

                    break;
                default: // Other columns, to be copied as it
                    SelectedElement = TypeOfElement.Unknow;

                    SelectedItemCellText = e.SubItem.Text;

                    break;
            }
        }

        private void olvPasswords_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            SetSelectedPassword(((PasswordModel)olvPasswords.FocusedObject).Id, ((PasswordModel)olvPasswords.FocusedObject).DisplayName);

            ctxMenuCopy.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nothing will be happen if the form is not in connection mode
            if (!btnLoginAction.Text.Equals(Tools.lblButtonConnect))
                return;

            // Enter key is pressed
            if (e.KeyChar.Equals('\r'))
                btnConnect_Click(sender, null);
        }

        /// <summary>
        /// Decrease countdown progressbar for each timer interval
        /// </summary>
        private void timerClearClipboard_Tick(object sender, EventArgs e)
        {
            pgbClearClipboard.PerformStep();

            // COuntdown is over
            if (pgbClearClipboard.Value == 0)
            {
                timerClearClipboard.Stop();

                // Clear clipboard
                Clipboard.Clear();

                WriteIeStatusBar("Clipboard cleared !");

                pgbClearClipboard.Visible = false;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clean controls and objects
        /// </summary>
        private void Clean()
        {
            CurrentUser = null;

            txtLogin.Text = string.Empty;
            txtDisplayName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        /// <summary>
        /// Show countdown progressbar and start timer
        /// </summary>
        private void ClearClipboardCountDown()
        {
            pgbClearClipboard.Value = 150;
            pgbClearClipboard.Visible = true;

            timerClearClipboard.Start();
        }

        /// <summary>
        /// Fill user texbox with user values
        /// </summary>
        private void FillUserControls()
        {
            txtLogin.Text = CurrentUser.Login;
            txtDisplayName.Text = CurrentUser.DisplayName;
            txtPassword.Text = CurrentUser.Password;
            txtConfirmPassword.Text = CurrentUser.Password;
        }

        /// <summary>
        /// Initialize panel controls
        /// </summary>
        private void InitPanelPasswords()
        {
            lblConnectedUser.Text = CurrentUser.Login;
            lblConnectedUserFriendlyName.Text = CurrentUser.DisplayName;

            ClearSelectedPassword();

            ttAutoTypeTop.SetToolTip(btnAutoTypeTop, "Auto complete fields");
            ttAutoTypeBottom.SetToolTip(btnAutoTypeBottom, "Auto complete fields");
            ttAddEntry.SetToolTip(btnNewPassword, "Add entry");
        }

        private void LoadPasswordsList()
        {
            olvPasswords.SetObjects(new PasswordController(CurrentUser.Login).GetList(CurrentUser.Id));
        }

        /// <summary>
        /// Manage the behaviour of the connection panel
        /// </summary>
        /// <param name="mode">Connection mode (registration or connection)</param>
        private void ToggleLoginPanelControls(TypeLogin mode)
        {
            switch (mode)
            {
                case TypeLogin.Register:
                    lblDisplayName.Visible = true;
                    lblConfirmPassword.Visible = true;

                    txtLogin.Enabled = true;
                    txtDisplayName.Visible = true;
                    txtConfirmPassword.Visible = true;

                    btnLoginAction.Text = Tools.LblButtonRegister;
                    btnUserUpdateCancel.Visible = false;
                    btnDeleteUser.Visible = false;

                    lnkRegister.Visible = true;
                    lnkRegister.Text = Tools.LblLinkButtonCancel;

                    break;
                case TypeLogin.Connect:
                    lblDisplayName.Visible = false;
                    lblConfirmPassword.Visible = false;

                    txtLogin.Enabled = true;
                    txtDisplayName.Visible = false;
                    txtConfirmPassword.Visible = false;

                    btnLoginAction.Text = Tools.lblButtonConnect;
                    btnUserUpdateCancel.Visible = false;
                    btnDeleteUser.Visible = false;

                    lnkRegister.Visible = true;
                    lnkRegister.Text = Tools.LblLinkButtonRegister;

                    break;
                case TypeLogin.Update:
                    lblDisplayName.Visible = true;
                    lblConfirmPassword.Visible = true;

                    txtLogin.Enabled = false;
                    txtDisplayName.Visible = true;
                    txtConfirmPassword.Visible = true;

                    btnLoginAction.Text = Tools.lblButtonUpdate;
                    btnUserUpdateCancel.Visible = true;
                    btnDeleteUser.Visible = true;

                    lnkRegister.Visible = false;

                    break;
            }
        }

        /// <summary>
        /// Management of the different panels
        /// </summary>
        /// <param name="kindOfPanel">Type of panel shown</param>
        private void TogglePanelsLoginPasswords(TypePanel kindOfPanel)
        {
            switch (kindOfPanel)
            {
                case TypePanel.Login:
                    pnlLogin.Visible = true;
                    pnlPasswords.Visible = false;

                    break;
                case TypePanel.Passwords:
                    pnlLogin.Visible = false;
                    pnlPasswords.Visible = true;

                    break;
            }
        }

        /// <summary>
        /// Store the current connection in database
        /// </summary>
        private void SetCurrentConnection()
        {
            ConnectionModel currentConnection = new ConnectionModel
            {
                UserId = CurrentUser.Id,
                MachineMacAddress = Tools.GetMacAddress(),
                MachineName = Environment.MachineName,
                MachineUserName = Environment.UserName,
                ConnectionDate = DateTime.Now
            };

            new ConnectionController(string.Concat(currentConnection.MachineUserName, currentConnection.MachineName)).Set(currentConnection);
        }

        /// <summary>
        /// Clean the current connection in database
        /// </summary>
        private void CleanCurrentConnection()
        {
            ConnectionModel currentConnection = new ConnectionModel
            {
                MachineMacAddress = Tools.GetMacAddress(),
                MachineName = Environment.MachineName,
                MachineUserName = Environment.UserName,
                ConnectionDate = DateTime.Now
            };

            new ConnectionController(string.Concat(currentConnection.MachineUserName, currentConnection.MachineName)).DeleteConnection(currentConnection);
        }

        /// <summary>
        /// Check the credentials and get the user connected
        /// </summary>
        /// <returns>true if the credentials are ok, false otherwise</returns>
        private bool CheckCredentials()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("All fields are required !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            UserController controlUser = new UserController();

            CurrentUser = controlUser.GetUser(txtLogin.Text.Trim(), txtPassword.Text);

            if (CurrentUser == null)
            {
                MessageBox.Show("User not found or incorrect credentials !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Chack if the user fields are filled
        /// </summary>
        /// <returns>true if all fields are filled, false otherwise</returns>
        private bool CheckUserFieldsEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text) || string.IsNullOrWhiteSpace(txtDisplayName.Text))
            {
                MessageBox.Show("All fields are required !", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <returns>true if the registration is done correctly, false otherwise</returns>
        private bool RegisterNewUser()
        {
            // Control all fields are correctly filled
            if (!CheckUserFieldsEmpty())
                return false;

            string userLogin = txtLogin.Text.Trim();

            // Check email format
            if (!Tools.IsValidEmail(userLogin))
            {
                MessageBox.Show("Email is not valid !", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }

            // Check passwords
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Passwords are different !", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }

            // Check if the user already exists
            if (new PasswordKeeper.UserController().GetUserCount(userLogin) > 0)
            {
                MessageBox.Show("This email is already used, please choose another one !", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }

            CurrentUser = new UserModel()
            {
                Login = userLogin,
                Password = txtPassword.Text.Trim(),
                DisplayName = txtDisplayName.Text.Trim(),
                IsActive = true,
                CreationDate = DateTime.Now
            };

            new UserController().Create(CurrentUser);

            MessageBox.Show(string.Concat(CurrentUser.DisplayName, " sucessfully created."), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        /// <summary>
        /// Update current user
        /// </summary>
        /// <returns>true if the update is done correctly, false otherwise</returns>
        private bool UpdateUser()
        {
            // Control all fields are correctly filled
            if (!CheckUserFieldsEmpty())
                return false;

            CurrentUser.Password = txtPassword.Text.Trim();
            CurrentUser.DisplayName = txtDisplayName.Text.Trim();

            new UserController().Update(CurrentUser);

            MessageBox.Show(string.Concat(CurrentUser.DisplayName, " sucessfully updated."), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        /// <summary>
        /// Call the new/update password form
        /// </summary>
        /// <param name="password">Password object</param>
        private void ShowPasswordForm(PasswordModel password)
        {
            DialogResult result = DialogResult.Cancel;

            using (frmPasswordManagement updatedPassword = new frmPasswordManagement(Tools.PasswordAction.Edit, CurrentUser.Id, CurrentUser.Login, password))
            {
                result = updatedPassword.ShowDialog();
            }

            if (result == DialogResult.OK)
                LoadPasswordsList();
        }

        /// <summary>
        /// Open an URL in a new IE tab
        /// </summary>
        /// <param name="url">URL to open</param>
        private void OpenUrlInNewTab(string url)
        {
            object flag = 0x0800;
            object targetFrameName = "_self";

            IEApp.Navigate(url, ref flag, ref targetFrameName);
        }

        /// <summary>
        /// Show the IE status bar and write some text
        /// </summary>
        /// <param name="status">Text to write</param>
        private void WriteIeStatusBar(string status)
        {
            IEApp.StatusBar = true;
            IEApp.StatusText = status;
        }

        /// <summary>
        /// Clear selected password label and variables
        /// </summary>
        private void ClearSelectedPassword()
        {
            lblSelectedEntry.Text = string.Empty;

            Tools.IdCurrentPassword = null;
        }

        /// <summary>
        /// Set selected password label and variables
        /// </summary>
        /// <param name="currentPasswordId">Password id</param>
        /// <param name="currentPasswordDisplayName">Password display name</param>
        private void SetSelectedPassword(int currentPasswordId, string currentPasswordDisplayName)
        {
            lblSelectedEntry.Text = string.Concat("Selected Entry : ", currentPasswordDisplayName);

            Tools.IdCurrentPassword = currentPasswordId;
        }

        #endregion

    }
}