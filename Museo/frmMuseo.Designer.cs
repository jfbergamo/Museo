namespace Museo
{
    partial class frmMuseo
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
            this.pnlInfoFile = new System.Windows.Forms.Panel();
            this.btnInfoFile = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.fldInfoFile = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.azioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.pnlGestione = new System.Windows.Forms.Panel();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.grpElimina = new System.Windows.Forms.GroupBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtModifica = new System.Windows.Forms.TextBox();
            this.tltScegliID = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlInfoFile.SuspendLayout();
            this.fldInfoFile.SuspendLayout();
            this.menu.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            this.pnlGestione.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfoFile
            // 
            this.pnlInfoFile.Controls.Add(this.fldInfoFile);
            this.pnlInfoFile.Controls.Add(this.btnInfoFile);
            this.pnlInfoFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoFile.Location = new System.Drawing.Point(600, 24);
            this.pnlInfoFile.Name = "pnlInfoFile";
            this.pnlInfoFile.Size = new System.Drawing.Size(200, 426);
            this.pnlInfoFile.TabIndex = 0;
            // 
            // btnInfoFile
            // 
            this.btnInfoFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoFile.Location = new System.Drawing.Point(0, 0);
            this.btnInfoFile.Name = "btnInfoFile";
            this.btnInfoFile.Size = new System.Drawing.Size(200, 119);
            this.btnInfoFile.TabIndex = 0;
            this.btnInfoFile.Text = "Mostra info File";
            this.btnInfoFile.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(277, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // fldInfoFile
            // 
            this.fldInfoFile.AutoScroll = true;
            this.fldInfoFile.BackColor = System.Drawing.SystemColors.ControlText;
            this.fldInfoFile.Controls.Add(this.lblInfo);
            this.fldInfoFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldInfoFile.Location = new System.Drawing.Point(0, 119);
            this.fldInfoFile.Name = "fldInfoFile";
            this.fldInfoFile.Size = new System.Drawing.Size(200, 307);
            this.fldInfoFile.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azioniToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // azioniToolStripMenuItem
            // 
            this.azioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esciToolStripMenuItem});
            this.azioniToolStripMenuItem.Name = "azioniToolStripMenuItem";
            this.azioniToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.azioniToolStripMenuItem.Text = "Azioni";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // pnlCentro
            // 
            this.pnlCentro.Controls.Add(this.btnModifica);
            this.pnlCentro.Controls.Add(this.txtModifica);
            this.pnlCentro.Controls.Add(this.textBox1);
            this.pnlCentro.Controls.Add(this.pnlGestione);
            this.pnlCentro.Controls.Add(this.grpModifica);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 24);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(600, 426);
            this.pnlCentro.TabIndex = 2;
            // 
            // pnlGestione
            // 
            this.pnlGestione.Controls.Add(this.grpElimina);
            this.pnlGestione.Controls.Add(this.btnAggiungi);
            this.pnlGestione.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestione.Location = new System.Drawing.Point(0, 0);
            this.pnlGestione.Name = "pnlGestione";
            this.pnlGestione.Size = new System.Drawing.Size(600, 100);
            this.pnlGestione.TabIndex = 0;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAggiungi.Location = new System.Drawing.Point(0, 0);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(172, 100);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // grpModifica
            // 
            this.grpModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModifica.Location = new System.Drawing.Point(226, 230);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(200, 100);
            this.grpModifica.TabIndex = 1;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica opera";
            // 
            // grpElimina
            // 
            this.grpElimina.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElimina.Location = new System.Drawing.Point(441, 0);
            this.grpElimina.Name = "grpElimina";
            this.grpElimina.Size = new System.Drawing.Size(159, 100);
            this.grpElimina.TabIndex = 2;
            this.grpElimina.TabStop = false;
            this.grpElimina.Text = "Rimuovi opera";
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(481, 202);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 0;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // txtModifica
            // 
            this.txtModifica.Location = new System.Drawing.Point(82, 348);
            this.txtModifica.Name = "txtModifica";
            this.txtModifica.Size = new System.Drawing.Size(236, 20);
            this.txtModifica.TabIndex = 1;
            this.tltScegliID.SetToolTip(this.txtModifica, "Inserisci l\'ID dell\'opera");
            // 
            // tltScegliID
            // 
            this.tltScegliID.ToolTipTitle = "Scegli l\'ID dell\'opera";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 2;
            this.tltScegliID.SetToolTip(this.textBox1, "Inserisci l\'ID dell\'opera");
            // 
            // frmMuseo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.pnlInfoFile);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMuseo";
            this.Text = "Museo delle Fontane in Piazza";
            this.pnlInfoFile.ResumeLayout(false);
            this.fldInfoFile.ResumeLayout(false);
            this.fldInfoFile.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            this.pnlGestione.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfoFile;
        private System.Windows.Forms.Button btnInfoFile;
        private System.Windows.Forms.Panel fldInfoFile;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem azioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Panel pnlGestione;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.GroupBox grpElimina;
        private System.Windows.Forms.TextBox txtModifica;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.ToolTip tltScegliID;
        private System.Windows.Forms.TextBox textBox1;
    }
}

