namespace Coursework
{
    partial class fOrder
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
            this.rtbOrder = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbOrder
            // 
            this.rtbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOrder.Location = new System.Drawing.Point(0, 0);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.ReadOnly = true;
            this.rtbOrder.Size = new System.Drawing.Size(419, 450);
            this.rtbOrder.TabIndex = 0;
            this.rtbOrder.Text = "";
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.rtbOrder);
            this.Name = "fOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOrder;
    }
}