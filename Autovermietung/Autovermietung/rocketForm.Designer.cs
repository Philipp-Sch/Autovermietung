namespace Autovermietung
{
    partial class RocketForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RocketForm));
            this.rocketTitlePanel = new System.Windows.Forms.Panel();
            this.rocketTitleLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rocketTitlePanel
            // 
            this.rocketTitlePanel.Location = new System.Drawing.Point(48, 12);
            this.rocketTitlePanel.Name = "rocketTitlePanel";
            this.rocketTitlePanel.Size = new System.Drawing.Size(380, 231);
            this.rocketTitlePanel.TabIndex = 0;
            this.rocketTitlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rocketTitlePanelPaint);
            // 
            // rocketTitleLabel
            // 
            this.rocketTitleLabel.AutoSize = true;
            this.rocketTitleLabel.Location = new System.Drawing.Point(140, 246);
            this.rocketTitleLabel.Name = "rocketTitleLabel";
            this.rocketTitleLabel.Size = new System.Drawing.Size(149, 13);
            this.rocketTitleLabel.TabIndex = 1;
            this.rocketTitleLabel.Text = "Team Rocket Autovermietung";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(143, 262);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Anmelden";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(143, 298);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 30);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Registrieren";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 334);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.rocketTitleLabel);
            this.Controls.Add(this.rocketTitlePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RocketForm";
            this.Text = "Rocketvermietung";
            this.Load += new System.EventHandler(this.rocketFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rocketTitlePanel;
        private System.Windows.Forms.Label rocketTitleLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;

    }
}

