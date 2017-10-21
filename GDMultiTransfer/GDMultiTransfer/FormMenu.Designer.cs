namespace GDMultiTransfer
{
    partial class FormMenu
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddTransfer = new System.Windows.Forms.Button();
            this.buttonUpdateTransfer = new System.Windows.Forms.Button();
            this.buttonRemoveTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAddTransfer
            // 
            this.buttonAddTransfer.Location = new System.Drawing.Point(238, 12);
            this.buttonAddTransfer.Name = "buttonAddTransfer";
            this.buttonAddTransfer.Size = new System.Drawing.Size(22, 23);
            this.buttonAddTransfer.TabIndex = 1;
            this.buttonAddTransfer.Text = "+";
            this.buttonAddTransfer.UseVisualStyleBackColor = true;
            this.buttonAddTransfer.Click += new System.EventHandler(this.buttonAddTransfer_Click);
            // 
            // buttonUpdateTransfer
            // 
            this.buttonUpdateTransfer.Location = new System.Drawing.Point(12, 12);
            this.buttonUpdateTransfer.Name = "buttonUpdateTransfer";
            this.buttonUpdateTransfer.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTransfer.TabIndex = 2;
            this.buttonUpdateTransfer.Text = "Update";
            this.buttonUpdateTransfer.UseVisualStyleBackColor = true;
            this.buttonUpdateTransfer.Click += new System.EventHandler(this.buttonUpdateTransfer_Click);
            // 
            // buttonRemoveTransfer
            // 
            this.buttonRemoveTransfer.Location = new System.Drawing.Point(266, 11);
            this.buttonRemoveTransfer.Name = "buttonRemoveTransfer";
            this.buttonRemoveTransfer.Size = new System.Drawing.Size(22, 23);
            this.buttonRemoveTransfer.TabIndex = 3;
            this.buttonRemoveTransfer.Text = "-";
            this.buttonRemoveTransfer.UseVisualStyleBackColor = true;
            this.buttonRemoveTransfer.Click += new System.EventHandler(this.buttonRemoveTransfer_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 45);
            this.Controls.Add(this.buttonRemoveTransfer);
            this.Controls.Add(this.buttonUpdateTransfer);
            this.Controls.Add(this.buttonAddTransfer);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAddTransfer;
        private System.Windows.Forms.Button buttonUpdateTransfer;
        private System.Windows.Forms.Button buttonRemoveTransfer;
    }
}