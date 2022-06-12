namespace ClientRPS.Forms {
    partial class FrmDialogBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDialogBox));
            this.pnlMoveForm = new System.Windows.Forms.Panel();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.pnlCredits = new System.Windows.Forms.Panel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDialogText = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.pnlMoveForm.SuspendLayout();
            this.pnlCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMoveForm
            // 
            this.pnlMoveForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMoveForm.Controls.Add(this.lblTitleText);
            this.pnlMoveForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMoveForm.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveForm.Name = "pnlMoveForm";
            this.pnlMoveForm.Size = new System.Drawing.Size(400, 29);
            this.pnlMoveForm.TabIndex = 20;
            // 
            // lblTitleText
            // 
            this.lblTitleText.Location = new System.Drawing.Point(3, 1);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(396, 27);
            this.lblTitleText.TabIndex = 1;
            this.lblTitleText.Text = "Diyalog Başlığı";
            this.lblTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitleText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lblTitleText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lblTitleText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pnlCredits
            // 
            this.pnlCredits.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlCredits.Controls.Add(this.lblCredits);
            this.pnlCredits.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlCredits.Location = new System.Drawing.Point(0, 271);
            this.pnlCredits.Name = "pnlCredits";
            this.pnlCredits.Size = new System.Drawing.Size(400, 29);
            this.pnlCredits.TabIndex = 21;
            // 
            // lblCredits
            // 
            this.lblCredits.Location = new System.Drawing.Point(3, 1);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(396, 27);
            this.lblCredits.TabIndex = 1;
            this.lblCredits.Text = "Taş Kağıt Makas Client";
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(16, 227);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(181, 38);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.TabStop = false;
            this.btnAccept.Text = "KABUL EDEN BUTON";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecline.ForeColor = System.Drawing.Color.White;
            this.btnDecline.Location = new System.Drawing.Point(203, 227);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(181, 38);
            this.btnDecline.TabIndex = 23;
            this.btnDecline.TabStop = false;
            this.btnDecline.Text = "REDDEDEN BUTON";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 300);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(390, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 300);
            this.panel2.TabIndex = 23;
            // 
            // lblDialogText
            // 
            this.lblDialogText.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDialogText.ForeColor = System.Drawing.Color.White;
            this.lblDialogText.Location = new System.Drawing.Point(16, 32);
            this.lblDialogText.Name = "lblDialogText";
            this.lblDialogText.Size = new System.Drawing.Size(368, 160);
            this.lblDialogText.TabIndex = 21;
            this.lblDialogText.Text = "Diyalog İçeriği";
            this.lblDialogText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtInput
            // 
            this.TxtInput.BackColor = System.Drawing.Color.MidnightBlue;
            this.TxtInput.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtInput.ForeColor = System.Drawing.Color.White;
            this.TxtInput.Location = new System.Drawing.Point(16, 189);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(368, 32);
            this.TxtInput.TabIndex = 24;
            this.TxtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtInput.Visible = false;
            // 
            // FrmDialogBox
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(196)))));
            this.CancelButton = this.btnDecline;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pnlCredits);
            this.Controls.Add(this.lblDialogText);
            this.Controls.Add(this.pnlMoveForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDialogBox";
            this.pnlMoveForm.ResumeLayout(false);
            this.pnlCredits.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMoveForm;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Panel pnlCredits;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDialogText;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox TxtInput;
    }
}