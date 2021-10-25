
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.ToolStripMenuItem MainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator FileSeparatorMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.RoomsGroupBox = new System.Windows.Forms.GroupBox();
            this.RoomsDeleteButton = new System.Windows.Forms.Button();
            this.RoomsAddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            MainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            FileSeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            this.RoomsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            MainMenuStrip});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
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
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(6, 19);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(188, 355);
            this.roomsListBox.TabIndex = 0;
            this.roomsListBox.ValueMember = "Description";
            // 
            // RoomsGroupBox
            // 
            this.RoomsGroupBox.Controls.Add(this.RoomsDeleteButton);
            this.RoomsGroupBox.Controls.Add(this.RoomsAddButton);
            this.RoomsGroupBox.Controls.Add(this.roomsListBox);
            this.RoomsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.RoomsGroupBox.Name = "RoomsGroupBox";
            this.RoomsGroupBox.Size = new System.Drawing.Size(200, 411);
            this.RoomsGroupBox.TabIndex = 1;
            this.RoomsGroupBox.TabStop = false;
            this.RoomsGroupBox.Text = "Rooms";
            // 
            // RoomsDeleteButton
            // 
            this.RoomsDeleteButton.Location = new System.Drawing.Point(119, 382);
            this.RoomsDeleteButton.Name = "RoomsDeleteButton";
            this.RoomsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RoomsDeleteButton.TabIndex = 2;
            this.RoomsDeleteButton.Text = "&Delete";
            this.RoomsDeleteButton.UseVisualStyleBackColor = true;
            this.RoomsDeleteButton.Click += new System.EventHandler(this.RoomsDeleteButton_Click);
            // 
            // RoomsAddButton
            // 
            this.RoomsAddButton.Enabled = false;
            this.RoomsAddButton.Location = new System.Drawing.Point(38, 382);
            this.RoomsAddButton.Name = "RoomsAddButton";
            this.RoomsAddButton.Size = new System.Drawing.Size(75, 23);
            this.RoomsAddButton.TabIndex = 1;
            this.RoomsAddButton.Text = "&Add";
            this.RoomsAddButton.UseVisualStyleBackColor = true;
            this.RoomsAddButton.Click += new System.EventHandler(this.RoomsAddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomDescriptionTextBox);
            this.groupBox1.Controls.Add(this.roomDescriptionLabel);
            this.groupBox1.Controls.Add(this.roomNameTextBox);
            this.groupBox1.Controls.Add(this.roomNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(227, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 411);
            this.groupBox1.TabIndex = 2;
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
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.WorldViewModel);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomsGroupBox);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ZorkBuilder";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.RoomsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.GroupBox RoomsGroupBox;
        private System.Windows.Forms.Button RoomsDeleteButton;
        private System.Windows.Forms.Button RoomsAddButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
    }
}

