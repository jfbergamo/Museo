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
            this.fldInfoFile = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnInfoFile = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.azioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtModifica = new System.Windows.Forms.TextBox();
            this.pnlGestione = new System.Windows.Forms.Panel();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.grpElimina = new System.Windows.Forms.GroupBox();
            this.txtElimina = new System.Windows.Forms.TextBox();
            this.tltScegliID = new System.Windows.Forms.ToolTip(this.components);
            this.btnElimina = new System.Windows.Forms.Button();
            this.pnlCentro2 = new System.Windows.Forms.Panel();
            this.pnlFiltri = new System.Windows.Forms.Panel();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfoFile.SuspendLayout();
            this.fldInfoFile.SuspendLayout();
            this.menu.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            this.pnlGestione.SuspendLayout();
            this.grpModifica.SuspendLayout();
            this.grpElimina.SuspendLayout();
            this.pnlCentro2.SuspendLayout();
            this.pnlFiltri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
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
            // fldInfoFile
            // 
            this.fldInfoFile.AutoScroll = true;
            this.fldInfoFile.BackColor = System.Drawing.SystemColors.ControlText;
            this.fldInfoFile.Controls.Add(this.lblInfo);
            this.fldInfoFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldInfoFile.Location = new System.Drawing.Point(0, 74);
            this.fldInfoFile.Name = "fldInfoFile";
            this.fldInfoFile.Size = new System.Drawing.Size(200, 352);
            this.fldInfoFile.TabIndex = 1;
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
            // btnInfoFile
            // 
            this.btnInfoFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoFile.Location = new System.Drawing.Point(0, 0);
            this.btnInfoFile.Name = "btnInfoFile";
            this.btnInfoFile.Size = new System.Drawing.Size(200, 74);
            this.btnInfoFile.TabIndex = 0;
            this.btnInfoFile.Text = "Mostra info File";
            this.btnInfoFile.UseVisualStyleBackColor = true;
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
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // pnlCentro
            // 
            this.pnlCentro.Controls.Add(this.pnlCentro2);
            this.pnlCentro.Controls.Add(this.pnlGestione);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 24);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(600, 426);
            this.pnlCentro.TabIndex = 2;
            // 
            // btnModifica
            // 
            this.btnModifica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(3, 19);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(223, 55);
            this.btnModifica.TabIndex = 0;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // txtModifica
            // 
            this.txtModifica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtModifica.Location = new System.Drawing.Point(3, 74);
            this.txtModifica.Name = "txtModifica";
            this.txtModifica.Size = new System.Drawing.Size(223, 23);
            this.txtModifica.TabIndex = 1;
            this.tltScegliID.SetToolTip(this.txtModifica, "Inserisci l\'ID dell\'opera");
            // 
            // pnlGestione
            // 
            this.pnlGestione.Controls.Add(this.grpModifica);
            this.pnlGestione.Controls.Add(this.btnAggiungi);
            this.pnlGestione.Controls.Add(this.grpElimina);
            this.pnlGestione.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestione.Location = new System.Drawing.Point(0, 0);
            this.pnlGestione.Name = "pnlGestione";
            this.pnlGestione.Size = new System.Drawing.Size(600, 100);
            this.pnlGestione.TabIndex = 0;
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.btnModifica);
            this.grpModifica.Controls.Add(this.txtModifica);
            this.grpModifica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModifica.Location = new System.Drawing.Point(165, 0);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(229, 100);
            this.grpModifica.TabIndex = 1;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica opera";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAggiungi.Location = new System.Drawing.Point(0, 0);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(165, 100);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // grpElimina
            // 
            this.grpElimina.Controls.Add(this.btnElimina);
            this.grpElimina.Controls.Add(this.txtElimina);
            this.grpElimina.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElimina.Location = new System.Drawing.Point(394, 0);
            this.grpElimina.Name = "grpElimina";
            this.grpElimina.Size = new System.Drawing.Size(206, 100);
            this.grpElimina.TabIndex = 2;
            this.grpElimina.TabStop = false;
            this.grpElimina.Text = "Rimuovi opera";
            // 
            // txtElimina
            // 
            this.txtElimina.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtElimina.Location = new System.Drawing.Point(3, 19);
            this.txtElimina.Name = "txtElimina";
            this.txtElimina.Size = new System.Drawing.Size(200, 23);
            this.txtElimina.TabIndex = 2;
            this.tltScegliID.SetToolTip(this.txtElimina, "Inserisci l\'ID dell\'opera");
            // 
            // tltScegliID
            // 
            this.tltScegliID.ToolTipTitle = "Scegli l\'ID dell\'opera";
            // 
            // btnElimina
            // 
            this.btnElimina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(3, 42);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(200, 55);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // pnlCentro2
            // 
            this.pnlCentro2.Controls.Add(this.grdData);
            this.pnlCentro2.Controls.Add(this.pnlFiltri);
            this.pnlCentro2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro2.Location = new System.Drawing.Point(0, 100);
            this.pnlCentro2.Name = "pnlCentro2";
            this.pnlCentro2.Size = new System.Drawing.Size(600, 326);
            this.pnlCentro2.TabIndex = 1;
            // 
            // pnlFiltri
            // 
            this.pnlFiltri.Controls.Add(this.btnCerca);
            this.pnlFiltri.Controls.Add(this.btnVisualizza);
            this.pnlFiltri.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltri.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltri.Name = "pnlFiltri";
            this.pnlFiltri.Size = new System.Drawing.Size(600, 70);
            this.pnlFiltri.TabIndex = 0;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVisualizza.Location = new System.Drawing.Point(0, 0);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(293, 70);
            this.btnVisualizza.TabIndex = 0;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // btnCerca
            // 
            this.btnCerca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerca.Location = new System.Drawing.Point(293, 0);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(307, 70);
            this.btnCerca.TabIndex = 1;
            this.btnCerca.Text = "Cesca per autore";
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.A,
            this.Column4});
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(0, 70);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(600, 256);
            this.grdData.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Autore";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Titolo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // A
            // 
            this.A.HeaderText = "Anno";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmMuseo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Museo.Properties.Resources.museo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.pnlGestione.ResumeLayout(false);
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            this.grpElimina.ResumeLayout(false);
            this.grpElimina.PerformLayout();
            this.pnlCentro2.ResumeLayout(false);
            this.pnlFiltri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
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
        private System.Windows.Forms.TextBox txtElimina;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Panel pnlCentro2;
        private System.Windows.Forms.Panel pnlFiltri;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

