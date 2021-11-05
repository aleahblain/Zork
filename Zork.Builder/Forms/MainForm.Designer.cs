
namespace Zork.Builder
{
    partial class MainForm
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
            System.Windows.Forms.ToolStripMenuItem MainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator FileSeparatorMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.MenuStrip menuStrip1;
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.RoomsGroupBox = new System.Windows.Forms.GroupBox();
            this.RoomsDeleteButton = new System.Windows.Forms.Button();
            this.RoomsAddButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ItemsNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemsName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ItemsDeleteButton = new System.Windows.Forms.Button();
            this.ItemsAddButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            MainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            FileSeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RoomsGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            FileSeparatorMenuItem,
            exitToolStripMenuItem});
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new System.Drawing.Size(37, 20);
            MainMenuStrip.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            // 
            // FileSeparatorMenuItem
            // 
            FileSeparatorMenuItem.Name = "FileSeparatorMenuItem";
            FileSeparatorMenuItem.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            MainMenuStrip});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(797, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 471);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.RoomsGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomDescriptionTextBox);
            this.groupBox1.Controls.Add(this.roomDescriptionLabel);
            this.groupBox1.Controls.Add(this.roomNameTextBox);
            this.groupBox1.Controls.Add(this.roomNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(210, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 433);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(10, 92);
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(309, 20);
            this.roomDescriptionTextBox.TabIndex = 3;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(7, 76);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.roomDescriptionLabel.TabIndex = 2;
            this.roomDescriptionLabel.Text = "&Description";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(10, 36);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(309, 20);
            this.roomNameTextBox.TabIndex = 1;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(7, 19);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(35, 13);
            this.roomNameLabel.TabIndex = 0;
            this.roomNameLabel.Text = "&Name";
            // 
            // RoomsGroupBox
            // 
            this.RoomsGroupBox.Controls.Add(this.RoomsDeleteButton);
            this.RoomsGroupBox.Controls.Add(this.RoomsAddButton);
            this.RoomsGroupBox.Controls.Add(this.roomsListBox);
            this.RoomsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.RoomsGroupBox.Name = "RoomsGroupBox";
            this.RoomsGroupBox.Size = new System.Drawing.Size(201, 433);
            this.RoomsGroupBox.TabIndex = 3;
            this.RoomsGroupBox.TabStop = false;
            this.RoomsGroupBox.Text = "Rooms";
            // 
            // RoomsDeleteButton
            // 
            this.RoomsDeleteButton.Location = new System.Drawing.Point(120, 394);
            this.RoomsDeleteButton.Name = "RoomsDeleteButton";
            this.RoomsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RoomsDeleteButton.TabIndex = 2;
            this.RoomsDeleteButton.Text = "&Delete";
            this.RoomsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // RoomsAddButton
            // 
            this.RoomsAddButton.Enabled = false;
            this.RoomsAddButton.Location = new System.Drawing.Point(39, 394);
            this.RoomsAddButton.Name = "RoomsAddButton";
            this.RoomsAddButton.Size = new System.Drawing.Size(75, 23);
            this.RoomsAddButton.TabIndex = 1;
            this.RoomsAddButton.Text = "&Add";
            this.RoomsAddButton.UseVisualStyleBackColor = true;
            // 
            // roomsListBox
            // 
            this.roomsListBox.DisplayMember = "Description";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(7, 19);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(188, 355);
            this.roomsListBox.TabIndex = 0;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ItemsNameTextBox);
            this.groupBox2.Controls.Add(this.ItemsName);
            this.groupBox2.Location = new System.Drawing.Point(211, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 433);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // ItemsNameTextBox
            // 
            this.ItemsNameTextBox.Location = new System.Drawing.Point(10, 36);
            this.ItemsNameTextBox.Name = "ItemsNameTextBox";
            this.ItemsNameTextBox.Size = new System.Drawing.Size(309, 20);
            this.ItemsNameTextBox.TabIndex = 1;
            // 
            // ItemsName
            // 
            this.ItemsName.AutoSize = true;
            this.ItemsName.Location = new System.Drawing.Point(7, 19);
            this.ItemsName.Name = "ItemsName";
            this.ItemsName.Size = new System.Drawing.Size(35, 13);
            this.ItemsName.TabIndex = 0;
            this.ItemsName.Text = "&Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ItemsDeleteButton);
            this.groupBox3.Controls.Add(this.ItemsAddButton);
            this.groupBox3.Controls.Add(this.ItemsListBox);
            this.groupBox3.Location = new System.Drawing.Point(4, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 433);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // ItemsDeleteButton
            // 
            this.ItemsDeleteButton.Location = new System.Drawing.Point(120, 394);
            this.ItemsDeleteButton.Name = "ItemsDeleteButton";
            this.ItemsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ItemsDeleteButton.TabIndex = 2;
            this.ItemsDeleteButton.Text = "&Delete";
            this.ItemsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ItemsAddButton
            // 
            this.ItemsAddButton.Enabled = false;
            this.ItemsAddButton.Location = new System.Drawing.Point(39, 394);
            this.ItemsAddButton.Name = "ItemsAddButton";
            this.ItemsAddButton.Size = new System.Drawing.Size(75, 23);
            this.ItemsAddButton.TabIndex = 1;
            this.ItemsAddButton.Text = "&Add";
            this.ItemsAddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.DisplayMember = "Description";
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(7, 19);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(188, 355);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.ValueMember = "Description";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ZorkBuilder";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RoomsGroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.GroupBox RoomsGroupBox;
        private System.Windows.Forms.Button RoomsDeleteButton;
        private System.Windows.Forms.Button RoomsAddButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ItemsNameTextBox;
        private System.Windows.Forms.Label ItemsName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ItemsDeleteButton;
        private System.Windows.Forms.Button ItemsAddButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

