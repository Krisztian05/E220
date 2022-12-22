namespace CsevegesGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kezdemenyezo = new System.Windows.Forms.Label();
            this.cmbx_kezdemenyezo = new System.Windows.Forms.ComboBox();
            this.cmbx_fogado = new System.Windows.Forms.ComboBox();
            this.lbl_fogado = new System.Windows.Forms.Label();
            this.lstb_csevegesek = new System.Windows.Forms.ListBox();
            this.lbl_csevegesek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_kezdemenyezo
            // 
            this.lbl_kezdemenyezo.AutoSize = true;
            this.lbl_kezdemenyezo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kezdemenyezo.Location = new System.Drawing.Point(23, 32);
            this.lbl_kezdemenyezo.Name = "lbl_kezdemenyezo";
            this.lbl_kezdemenyezo.Size = new System.Drawing.Size(86, 15);
            this.lbl_kezdemenyezo.TabIndex = 0;
            this.lbl_kezdemenyezo.Text = "Kezdeményező";
            // 
            // cmbx_kezdemenyezo
            // 
            this.cmbx_kezdemenyezo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_kezdemenyezo.FormattingEnabled = true;
            this.cmbx_kezdemenyezo.Location = new System.Drawing.Point(132, 32);
            this.cmbx_kezdemenyezo.Name = "cmbx_kezdemenyezo";
            this.cmbx_kezdemenyezo.Size = new System.Drawing.Size(174, 23);
            this.cmbx_kezdemenyezo.Sorted = true;
            this.cmbx_kezdemenyezo.TabIndex = 1;
            this.cmbx_kezdemenyezo.SelectedIndexChanged += new System.EventHandler(this.cmbx_SelectedIndexChanged);
            // 
            // cmbx_fogado
            // 
            this.cmbx_fogado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_fogado.FormattingEnabled = true;
            this.cmbx_fogado.Location = new System.Drawing.Point(132, 61);
            this.cmbx_fogado.Name = "cmbx_fogado";
            this.cmbx_fogado.Size = new System.Drawing.Size(174, 23);
            this.cmbx_fogado.Sorted = true;
            this.cmbx_fogado.TabIndex = 2;
            this.cmbx_fogado.SelectedIndexChanged += new System.EventHandler(this.cmbx_SelectedIndexChanged);
            // 
            // lbl_fogado
            // 
            this.lbl_fogado.AutoSize = true;
            this.lbl_fogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fogado.Location = new System.Drawing.Point(23, 61);
            this.lbl_fogado.Name = "lbl_fogado";
            this.lbl_fogado.Size = new System.Drawing.Size(96, 15);
            this.lbl_fogado.TabIndex = 3;
            this.lbl_fogado.Text = "Fogadó (partner)";
            // 
            // lstb_csevegesek
            // 
            this.lstb_csevegesek.FormattingEnabled = true;
            this.lstb_csevegesek.ItemHeight = 15;
            this.lstb_csevegesek.Location = new System.Drawing.Point(23, 127);
            this.lstb_csevegesek.Name = "lstb_csevegesek";
            this.lstb_csevegesek.Size = new System.Drawing.Size(283, 289);
            this.lstb_csevegesek.TabIndex = 4;
            // 
            // lbl_csevegesek
            // 
            this.lbl_csevegesek.AutoSize = true;
            this.lbl_csevegesek.Location = new System.Drawing.Point(23, 109);
            this.lbl_csevegesek.Name = "lbl_csevegesek";
            this.lbl_csevegesek.Size = new System.Drawing.Size(68, 15);
            this.lbl_csevegesek.TabIndex = 5;
            this.lbl_csevegesek.Text = "Csevegések";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 430);
            this.Controls.Add(this.lbl_csevegesek);
            this.Controls.Add(this.lstb_csevegesek);
            this.Controls.Add(this.lbl_fogado);
            this.Controls.Add(this.cmbx_fogado);
            this.Controls.Add(this.cmbx_kezdemenyezo);
            this.Controls.Add(this.lbl_kezdemenyezo);
            this.Name = "Form1";
            this.Text = "Csevegés GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_kezdemenyezo;
        private ComboBox cmbx_kezdemenyezo;
        private ComboBox cmbx_fogado;
        private Label lbl_fogado;
        private ListBox lstb_csevegesek;
        private Label lbl_csevegesek;
    }
}