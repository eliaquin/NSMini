namespace nsMini2
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecibidas = new System.Windows.Forms.TextBox();
            this.txtContestadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContestadasD20Seg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAbandonadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAbandonadasD20Seg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNS_Actual = new System.Windows.Forms.Label();
            this.lbFocus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrescarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recibidas";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txtRecibidas
            // 
            this.txtRecibidas.HideSelection = false;
            this.txtRecibidas.Location = new System.Drawing.Point(14, 49);
            this.txtRecibidas.Name = "txtRecibidas";
            this.txtRecibidas.ReadOnly = true;
            this.txtRecibidas.Size = new System.Drawing.Size(144, 20);
            this.txtRecibidas.TabIndex = 1;
            // 
            // txtContestadas
            // 
            this.txtContestadas.Location = new System.Drawing.Point(14, 105);
            this.txtContestadas.Name = "txtContestadas";
            this.txtContestadas.ReadOnly = true;
            this.txtContestadas.Size = new System.Drawing.Size(144, 20);
            this.txtContestadas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contestadas";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtContestadasD20Seg
            // 
            this.txtContestadasD20Seg.Location = new System.Drawing.Point(14, 162);
            this.txtContestadasD20Seg.Name = "txtContestadasD20Seg";
            this.txtContestadasD20Seg.ReadOnly = true;
            this.txtContestadasD20Seg.Size = new System.Drawing.Size(144, 20);
            this.txtContestadasD20Seg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contestadas D. 20 Seg.";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txtAbandonadas
            // 
            this.txtAbandonadas.Location = new System.Drawing.Point(177, 105);
            this.txtAbandonadas.Name = "txtAbandonadas";
            this.txtAbandonadas.ReadOnly = true;
            this.txtAbandonadas.Size = new System.Drawing.Size(144, 20);
            this.txtAbandonadas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Abandonadas";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // txtAbandonadasD20Seg
            // 
            this.txtAbandonadasD20Seg.Location = new System.Drawing.Point(177, 162);
            this.txtAbandonadasD20Seg.Name = "txtAbandonadasD20Seg";
            this.txtAbandonadasD20Seg.ReadOnly = true;
            this.txtAbandonadasD20Seg.Size = new System.Drawing.Size(144, 20);
            this.txtAbandonadasD20Seg.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Abandonadas D. 20 Seg.";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // lbNS_Actual
            // 
            this.lbNS_Actual.AutoSize = true;
            this.lbNS_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNS_Actual.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNS_Actual.Location = new System.Drawing.Point(228, 30);
            this.lbNS_Actual.Name = "lbNS_Actual";
            this.lbNS_Actual.Size = new System.Drawing.Size(79, 29);
            this.lbNS_Actual.TabIndex = 10;
            this.lbNS_Actual.Text = "NS %";
            // 
            // lbFocus
            // 
            this.lbFocus.AutoSize = true;
            this.lbFocus.Location = new System.Drawing.Point(134, 13);
            this.lbFocus.Name = "lbFocus";
            this.lbFocus.Size = new System.Drawing.Size(0, 13);
            this.lbFocus.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrescarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // refrescarToolStripMenuItem
            // 
            this.refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            this.refrescarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.refrescarToolStripMenuItem.Text = "Refrescar";
            this.refrescarToolStripMenuItem.Click += new System.EventHandler(this.refrescarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 204);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbFocus);
            this.Controls.Add(this.lbNS_Actual);
            this.Controls.Add(this.txtAbandonadasD20Seg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAbandonadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContestadasD20Seg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContestadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecibidas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Nivel de Servicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecibidas;
        private System.Windows.Forms.TextBox txtContestadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContestadasD20Seg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAbandonadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAbandonadasD20Seg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNS_Actual;
        private System.Windows.Forms.Label lbFocus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refrescarToolStripMenuItem;
    }
}

