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
        /// <param name="disposing">True, wenn verwaltete Ressourcen gel�scht werden sollen; andernfalls False.</param>
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
        /// Erforderliche Methode f�r die Designerunterst�tzung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor ge�ndert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.AusleihButton = new System.Windows.Forms.Button();
            this.gangschaltartTextBox = new System.Windows.Forms.TextBox();
            this.CarListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gangschaltartLabel = new System.Windows.Forms.Label();
            this.markeTextBox = new System.Windows.Forms.TextBox();
            this.leistungTextBox = new System.Windows.Forms.TextBox();
            this.treibstoffTextBox = new System.Windows.Forms.TextBox();
            this.sitzpl�tzeTextBox = new System.Windows.Forms.TextBox();
            this.stadtTextBox = new System.Windows.Forms.TextBox();
            this.postleitzahlTextBox = new System.Windows.Forms.TextBox();
            this.anh�ngekuppelTextBox = new System.Windows.Forms.TextBox();
            this.kofferraumgr��eTextBox = new System.Windows.Forms.TextBox();
            this.stra�eTextBox = new System.Windows.Forms.TextBox();
            this.klasseTextBox = new System.Windows.Forms.TextBox();
            this.leistunglabel = new System.Windows.Forms.Label();
            this.treibstoffLabel = new System.Windows.Forms.Label();
            this.markeLabel = new System.Windows.Forms.Label();
            this.stadtLabel = new System.Windows.Forms.Label();
            this.sitzpl�tzeLabel = new System.Windows.Forms.Label();
            this.postleitzahlLabel = new System.Windows.Forms.Label();
            this.anh�ngekuppelLabel = new System.Windows.Forms.Label();
            this.klasseLabel = new System.Windows.Forms.Label();
            this.Kofferraumgr��eLabel = new System.Windows.Forms.Label();
            this.stra�eLabel = new System.Windows.Forms.Label();
            this.hinzuf�genButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AusleihButton
            // 
            this.AusleihButton.Location = new System.Drawing.Point(469, 323);
            this.AusleihButton.Name = "AusleihButton";
            this.AusleihButton.Size = new System.Drawing.Size(142, 28);
            this.AusleihButton.TabIndex = 0;
            this.AusleihButton.Text = "Ausleihen";
            this.AusleihButton.UseVisualStyleBackColor = true;
            this.AusleihButton.Click += new System.EventHandler(this.AusleihButton_Click);
            // 
            // gangschaltartTextBox
            // 
            this.gangschaltartTextBox.Location = new System.Drawing.Point(297, 23);
            this.gangschaltartTextBox.Name = "gangschaltartTextBox";
            this.gangschaltartTextBox.Size = new System.Drawing.Size(97, 20);
            this.gangschaltartTextBox.TabIndex = 1;
            // 
            // CarListBox
            // 
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.Location = new System.Drawing.Point(12, 24);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.Size = new System.Drawing.Size(120, 290);
            this.CarListBox.TabIndex = 2;
            this.CarListBox.SelectedIndexChanged += new System.EventHandler(this.CarListBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(154, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(94, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(151, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // gangschaltartLabel
            // 
            this.gangschaltartLabel.AutoSize = true;
            this.gangschaltartLabel.Location = new System.Drawing.Point(294, 7);
            this.gangschaltartLabel.Name = "gangschaltartLabel";
            this.gangschaltartLabel.Size = new System.Drawing.Size(73, 13);
            this.gangschaltartLabel.TabIndex = 5;
            this.gangschaltartLabel.Text = "Gangschaltart";
            // 
            // markeTextBox
            // 
            this.markeTextBox.Location = new System.Drawing.Point(154, 65);
            this.markeTextBox.Name = "markeTextBox";
            this.markeTextBox.Size = new System.Drawing.Size(94, 20);
            this.markeTextBox.TabIndex = 6;
            // 
            // leistungTextBox
            // 
            this.leistungTextBox.Location = new System.Drawing.Point(154, 116);
            this.leistungTextBox.Name = "leistungTextBox";
            this.leistungTextBox.Size = new System.Drawing.Size(94, 20);
            this.leistungTextBox.TabIndex = 7;
            // 
            // treibstoffTextBox
            // 
            this.treibstoffTextBox.Location = new System.Drawing.Point(297, 65);
            this.treibstoffTextBox.Name = "treibstoffTextBox";
            this.treibstoffTextBox.Size = new System.Drawing.Size(97, 20);
            this.treibstoffTextBox.TabIndex = 8;
            // 
            // sitzpl�tzeTextBox
            // 
            this.sitzpl�tzeTextBox.Location = new System.Drawing.Point(154, 170);
            this.sitzpl�tzeTextBox.Name = "sitzpl�tzeTextBox";
            this.sitzpl�tzeTextBox.Size = new System.Drawing.Size(94, 20);
            this.sitzpl�tzeTextBox.TabIndex = 9;
            // 
            // stadtTextBox
            // 
            this.stadtTextBox.Location = new System.Drawing.Point(296, 218);
            this.stadtTextBox.Name = "stadtTextBox";
            this.stadtTextBox.Size = new System.Drawing.Size(97, 20);
            this.stadtTextBox.TabIndex = 10;
            // 
            // postleitzahlTextBox
            // 
            this.postleitzahlTextBox.Location = new System.Drawing.Point(296, 170);
            this.postleitzahlTextBox.Name = "postleitzahlTextBox";
            this.postleitzahlTextBox.Size = new System.Drawing.Size(97, 20);
            this.postleitzahlTextBox.TabIndex = 11;
            // 
            // anh�ngekuppelTextBox
            // 
            this.anh�ngekuppelTextBox.Location = new System.Drawing.Point(297, 116);
            this.anh�ngekuppelTextBox.Name = "anh�ngekuppelTextBox";
            this.anh�ngekuppelTextBox.Size = new System.Drawing.Size(97, 20);
            this.anh�ngekuppelTextBox.TabIndex = 12;
            // 
            // kofferraumgr��eTextBox
            // 
            this.kofferraumgr��eTextBox.Location = new System.Drawing.Point(154, 218);
            this.kofferraumgr��eTextBox.Name = "kofferraumgr��eTextBox";
            this.kofferraumgr��eTextBox.Size = new System.Drawing.Size(94, 20);
            this.kofferraumgr��eTextBox.TabIndex = 14;
            // 
            // stra�eTextBox
            // 
            this.stra�eTextBox.Location = new System.Drawing.Point(297, 272);
            this.stra�eTextBox.Name = "stra�eTextBox";
            this.stra�eTextBox.Size = new System.Drawing.Size(97, 20);
            this.stra�eTextBox.TabIndex = 15;
            // 
            // klasseTextBox
            // 
            this.klasseTextBox.Location = new System.Drawing.Point(154, 272);
            this.klasseTextBox.Name = "klasseTextBox";
            this.klasseTextBox.Size = new System.Drawing.Size(94, 20);
            this.klasseTextBox.TabIndex = 16;
            // 
            // leistunglabel
            // 
            this.leistunglabel.AutoSize = true;
            this.leistunglabel.Location = new System.Drawing.Point(151, 100);
            this.leistunglabel.Name = "leistunglabel";
            this.leistunglabel.Size = new System.Drawing.Size(47, 13);
            this.leistunglabel.TabIndex = 17;
            this.leistunglabel.Text = "Leistung";
            // 
            // treibstoffLabel
            // 
            this.treibstoffLabel.AutoSize = true;
            this.treibstoffLabel.Location = new System.Drawing.Point(294, 49);
            this.treibstoffLabel.Name = "treibstoffLabel";
            this.treibstoffLabel.Size = new System.Drawing.Size(51, 13);
            this.treibstoffLabel.TabIndex = 18;
            this.treibstoffLabel.Text = "Treibstoff";
            // 
            // markeLabel
            // 
            this.markeLabel.AutoSize = true;
            this.markeLabel.Location = new System.Drawing.Point(151, 49);
            this.markeLabel.Name = "markeLabel";
            this.markeLabel.Size = new System.Drawing.Size(37, 13);
            this.markeLabel.TabIndex = 19;
            this.markeLabel.Text = "Marke";
            // 
            // stadtLabel
            // 
            this.stadtLabel.AutoSize = true;
            this.stadtLabel.Location = new System.Drawing.Point(294, 202);
            this.stadtLabel.Name = "stadtLabel";
            this.stadtLabel.Size = new System.Drawing.Size(32, 13);
            this.stadtLabel.TabIndex = 20;
            this.stadtLabel.Text = "Stadt";
            // 
            // sitzpl�tzeLabel
            // 
            this.sitzpl�tzeLabel.AutoSize = true;
            this.sitzpl�tzeLabel.Location = new System.Drawing.Point(151, 154);
            this.sitzpl�tzeLabel.Name = "sitzpl�tzeLabel";
            this.sitzpl�tzeLabel.Size = new System.Drawing.Size(52, 13);
            this.sitzpl�tzeLabel.TabIndex = 21;
            this.sitzpl�tzeLabel.Text = "Sitzpl�tze";
            // 
            // postleitzahlLabel
            // 
            this.postleitzahlLabel.AutoSize = true;
            this.postleitzahlLabel.Location = new System.Drawing.Point(294, 154);
            this.postleitzahlLabel.Name = "postleitzahlLabel";
            this.postleitzahlLabel.Size = new System.Drawing.Size(60, 13);
            this.postleitzahlLabel.TabIndex = 22;
            this.postleitzahlLabel.Text = "Postleitzahl";
            // 
            // anh�ngekuppelLabel
            // 
            this.anh�ngekuppelLabel.AutoSize = true;
            this.anh�ngekuppelLabel.Location = new System.Drawing.Point(294, 100);
            this.anh�ngekuppelLabel.Name = "anh�ngekuppelLabel";
            this.anh�ngekuppelLabel.Size = new System.Drawing.Size(82, 13);
            this.anh�ngekuppelLabel.TabIndex = 23;
            this.anh�ngekuppelLabel.Text = "Anh�ngekuppel";
            // 
            // klasseLabel
            // 
            this.klasseLabel.AutoSize = true;
            this.klasseLabel.Location = new System.Drawing.Point(151, 256);
            this.klasseLabel.Name = "klasseLabel";
            this.klasseLabel.Size = new System.Drawing.Size(38, 13);
            this.klasseLabel.TabIndex = 24;
            this.klasseLabel.Text = "Klasse";
            // 
            // Kofferraumgr��eLabel
            // 
            this.Kofferraumgr��eLabel.AutoSize = true;
            this.Kofferraumgr��eLabel.Location = new System.Drawing.Point(151, 202);
            this.Kofferraumgr��eLabel.Name = "Kofferraumgr��eLabel";
            this.Kofferraumgr��eLabel.Size = new System.Drawing.Size(85, 13);
            this.Kofferraumgr��eLabel.TabIndex = 25;
            this.Kofferraumgr��eLabel.Text = "Kofferraumgr��e";
            // 
            // stra�eLabel
            // 
            this.stra�eLabel.AutoSize = true;
            this.stra�eLabel.Location = new System.Drawing.Point(294, 256);
            this.stra�eLabel.Name = "stra�eLabel";
            this.stra�eLabel.Size = new System.Drawing.Size(38, 13);
            this.stra�eLabel.TabIndex = 26;
            this.stra�eLabel.Text = "Stra�e";
            // 
            // hinzuf�genButton
            // 
            this.hinzuf�genButton.Location = new System.Drawing.Point(12, 321);
            this.hinzuf�genButton.Name = "hinzuf�genButton";
            this.hinzuf�genButton.Size = new System.Drawing.Size(382, 28);
            this.hinzuf�genButton.TabIndex = 27;
            this.hinzuf�genButton.Text = "Hinzuf�gen";
            this.hinzuf�genButton.UseVisualStyleBackColor = true;
            this.hinzuf�genButton.Click += new System.EventHandler(this.Hinzuf�genButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 22);
            this.refreshButton.TabIndex = 28;
            this.refreshButton.Text = "Aktualisieren";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(469, 23);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(142, 20);
            this.usernameTextBox.TabIndex = 29;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(466, 7);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 31;
            this.usernameLabel.Text = "Username";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(466, 49);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(45, 13);
            this.startTimeLabel.TabIndex = 32;
            this.startTimeLabel.Text = "Startzeit";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(469, 65);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(142, 20);
            this.startTimeTextBox.TabIndex = 33;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(411, 100);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 35;
            this.dateTimePicker2.Visible = false;
            // 
            // RocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.hinzuf�genButton);
            this.Controls.Add(this.stra�eLabel);
            this.Controls.Add(this.Kofferraumgr��eLabel);
            this.Controls.Add(this.klasseLabel);
            this.Controls.Add(this.anh�ngekuppelLabel);
            this.Controls.Add(this.postleitzahlLabel);
            this.Controls.Add(this.sitzpl�tzeLabel);
            this.Controls.Add(this.stadtLabel);
            this.Controls.Add(this.markeLabel);
            this.Controls.Add(this.treibstoffLabel);
            this.Controls.Add(this.leistunglabel);
            this.Controls.Add(this.klasseTextBox);
            this.Controls.Add(this.stra�eTextBox);
            this.Controls.Add(this.kofferraumgr��eTextBox);
            this.Controls.Add(this.anh�ngekuppelTextBox);
            this.Controls.Add(this.postleitzahlTextBox);
            this.Controls.Add(this.stadtTextBox);
            this.Controls.Add(this.sitzpl�tzeTextBox);
            this.Controls.Add(this.treibstoffTextBox);
            this.Controls.Add(this.leistungTextBox);
            this.Controls.Add(this.markeTextBox);
            this.Controls.Add(this.gangschaltartLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.CarListBox);
            this.Controls.Add(this.gangschaltartTextBox);
            this.Controls.Add(this.AusleihButton);
            this.Name = "RocketForm";
            this.Text = "RocketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AusleihButton;
        private System.Windows.Forms.TextBox gangschaltartTextBox;
        private System.Windows.Forms.ListBox CarListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gangschaltartLabel;
        private System.Windows.Forms.TextBox markeTextBox;
        private System.Windows.Forms.TextBox leistungTextBox;
        private System.Windows.Forms.TextBox treibstoffTextBox;
        private System.Windows.Forms.TextBox sitzpl�tzeTextBox;
        private System.Windows.Forms.TextBox stadtTextBox;
        private System.Windows.Forms.TextBox postleitzahlTextBox;
        private System.Windows.Forms.TextBox anh�ngekuppelTextBox;
        private System.Windows.Forms.TextBox kofferraumgr��eTextBox;
        private System.Windows.Forms.TextBox stra�eTextBox;
        private System.Windows.Forms.TextBox klasseTextBox;
        private System.Windows.Forms.Label leistunglabel;
        private System.Windows.Forms.Label treibstoffLabel;
        private System.Windows.Forms.Label markeLabel;
        private System.Windows.Forms.Label stadtLabel;
        private System.Windows.Forms.Label sitzpl�tzeLabel;
        private System.Windows.Forms.Label postleitzahlLabel;
        private System.Windows.Forms.Label anh�ngekuppelLabel;
        private System.Windows.Forms.Label klasseLabel;
        private System.Windows.Forms.Label Kofferraumgr��eLabel;
        private System.Windows.Forms.Label stra�eLabel;
        private System.Windows.Forms.Button hinzuf�genButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

