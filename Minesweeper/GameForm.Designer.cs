namespace Minesweeper
{
    partial class GameForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MinesLeftLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(9, 62);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(380, 380);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeLabel.Location = new System.Drawing.Point(12, 18);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeLabel.Size = new System.Drawing.Size(70, 30);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "label1";
            // 
            // MinesLeftLabel
            // 
            this.MinesLeftLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.MinesLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MinesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinesLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinesLeftLabel.Location = new System.Drawing.Point(319, 18);
            this.MinesLeftLabel.Name = "MinesLeftLabel";
            this.MinesLeftLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinesLeftLabel.Size = new System.Drawing.Size(70, 30);
            this.MinesLeftLabel.TabIndex = 2;
            this.MinesLeftLabel.Text = "label1";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(176, 14);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(46, 40);
            this.StartButton.TabIndex = 3;
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 454);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MinesLeftLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label MinesLeftLabel;
        private System.Windows.Forms.Button StartButton;
    }
}

