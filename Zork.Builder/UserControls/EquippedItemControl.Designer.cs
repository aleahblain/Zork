
namespace Zork.Builder.UserControls
{
    partial class EquippedItemControl
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
<<<<<<< HEAD:Zork.Builder/UserControls/EquippedItemControl.Designer.cs
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
=======
            this.NeighborTestBox = new System.Windows.Forms.TextBox();
            this.NeighborsComboBox = new System.Windows.Forms.ComboBox();
>>>>>>> UI:Zork.Builder/UserControls/NeighborControls.Designer.cs
            this.SuspendLayout();
            // 
            // NeighborTestBox
            // 
<<<<<<< HEAD:Zork.Builder/UserControls/EquippedItemControl.Designer.cs
            this.textBox1.Location = new System.Drawing.Point(4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Test!";
=======
            this.NeighborTestBox.Location = new System.Drawing.Point(4, 3);
            this.NeighborTestBox.Name = "NeighborTestBox";
            this.NeighborTestBox.ReadOnly = true;
            this.NeighborTestBox.Size = new System.Drawing.Size(236, 20);
            this.NeighborTestBox.TabIndex = 0;
            this.NeighborTestBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
>>>>>>> UI:Zork.Builder/UserControls/NeighborControls.Designer.cs
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // EquippedItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD:Zork.Builder/UserControls/EquippedItemControl.Designer.cs
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "EquippedItemControl";
            this.Size = new System.Drawing.Size(243, 55);
=======
            this.Controls.Add(this.NeighborsComboBox);
            this.Controls.Add(this.NeighborTestBox);
            this.Name = "NeighborControls";
            this.Size = new System.Drawing.Size(237, 55);
>>>>>>> UI:Zork.Builder/UserControls/NeighborControls.Designer.cs
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD:Zork.Builder/UserControls/EquippedItemControl.Designer.cs
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
=======
        private System.Windows.Forms.TextBox NeighborTestBox;
        private System.Windows.Forms.ComboBox NeighborsComboBox;
>>>>>>> UI:Zork.Builder/UserControls/NeighborControls.Designer.cs
    }
}
