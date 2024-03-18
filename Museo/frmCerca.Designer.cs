namespace Museo
{
    partial class frmCerca
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
            this.btnConferma = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTooltip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConferma
            // 
            this.btnConferma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConferma.Location = new System.Drawing.Point(0, 94);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(246, 23);
            this.btnConferma.TabIndex = 0;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNome.Location = new System.Drawing.Point(0, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblTooltip
            // 
            this.lblTooltip.BackColor = System.Drawing.Color.Transparent;
            this.lblTooltip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTooltip.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTooltip.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTooltip.Location = new System.Drawing.Point(0, 51);
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(246, 23);
            this.lblTooltip.TabIndex = 2;
            this.lblTooltip.Text = "Scrivi il nome:";
            this.lblTooltip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Museo.Properties.Resources.quadretto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(246, 117);
            this.Controls.Add(this.lblTooltip);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnConferma);
            this.Name = "frmCerca";
            this.Text = "frmCerca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTooltip;
    }
}