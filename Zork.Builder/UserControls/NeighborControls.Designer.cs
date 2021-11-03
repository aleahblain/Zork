
namespace Zork.Builder.UserControls
{
    partial class NeighborControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NeighborsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Test!";
            // 
            // NeighborsComboBox
            // 
            this.NeighborsComboBox.FormattingEnabled = true;
            this.NeighborsComboBox.Location = new System.Drawing.Point(3, 29);
            this.NeighborsComboBox.Name = "NeighborsComboBox";
            this.NeighborsComboBox.Size = new System.Drawing.Size(236, 21);
            this.NeighborsComboBox.TabIndex = 1;
            this.NeighborsComboBox.SelectedIndexChanged += new System.EventHandler(this.NeighborsComboBox_SelectedIndexChanged);
            // 
            // NeighborControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeighborsComboBox);
            this.Controls.Add(this.textBox1);
            this.Name = "NeighborControls";
            this.Size = new System.Drawing.Size(243, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox NeighborsComboBox;
    }
}
