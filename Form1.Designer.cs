namespace DES
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.open = new FontAwesome.Sharp.IconButton();
            this.ptext = new System.Windows.Forms.RichTextBox();
            this.pbinarytext = new System.Windows.Forms.RichTextBox();
            this.randomkey = new FontAwesome.Sharp.IconButton();
            this.keytext = new System.Windows.Forms.RichTextBox();
            this.Encrypt = new FontAwesome.Sharp.IconButton();
            this.Decrypt = new FontAwesome.Sharp.IconButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbinarytext = new System.Windows.Forms.RichTextBox();
            this.dnlowdresult = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progresslabel = new System.Windows.Forms.Label();
            this.cancelProgressbtn = new FontAwesome.Sharp.IconButton();
            this.blockNumlabel = new System.Windows.Forms.Label();
            this.keyHextext = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.MidnightBlue;
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.open.ForeColor = System.Drawing.Color.GhostWhite;
            this.open.IconChar = FontAwesome.Sharp.IconChar.File;
            this.open.IconColor = System.Drawing.Color.GhostWhite;
            this.open.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.open.Location = new System.Drawing.Point(12, 94);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(134, 101);
            this.open.TabIndex = 0;
            this.open.Text = "Open File";
            this.open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // ptext
            // 
            this.ptext.BackColor = System.Drawing.Color.DarkBlue;
            this.ptext.ForeColor = System.Drawing.Color.White;
            this.ptext.Location = new System.Drawing.Point(299, 12);
            this.ptext.Name = "ptext";
            this.ptext.Size = new System.Drawing.Size(1055, 117);
            this.ptext.TabIndex = 1;
            this.ptext.Text = "";
            // 
            // pbinarytext
            // 
            this.pbinarytext.BackColor = System.Drawing.Color.DarkBlue;
            this.pbinarytext.ForeColor = System.Drawing.Color.White;
            this.pbinarytext.Location = new System.Drawing.Point(299, 135);
            this.pbinarytext.Name = "pbinarytext";
            this.pbinarytext.Size = new System.Drawing.Size(1055, 117);
            this.pbinarytext.TabIndex = 2;
            this.pbinarytext.Text = "";
            // 
            // randomkey
            // 
            this.randomkey.BackColor = System.Drawing.Color.MidnightBlue;
            this.randomkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomkey.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.randomkey.ForeColor = System.Drawing.Color.Gold;
            this.randomkey.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.randomkey.IconColor = System.Drawing.Color.Gold;
            this.randomkey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.randomkey.Location = new System.Drawing.Point(12, 350);
            this.randomkey.Name = "randomkey";
            this.randomkey.Size = new System.Drawing.Size(283, 52);
            this.randomkey.TabIndex = 3;
            this.randomkey.Text = "Generate random key";
            this.randomkey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.randomkey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.randomkey.UseVisualStyleBackColor = false;
            this.randomkey.Click += new System.EventHandler(this.randomkey_Click);
            // 
            // keytext
            // 
            this.keytext.BackColor = System.Drawing.Color.Khaki;
            this.keytext.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keytext.ForeColor = System.Drawing.Color.Black;
            this.keytext.Location = new System.Drawing.Point(299, 350);
            this.keytext.Name = "keytext";
            this.keytext.Size = new System.Drawing.Size(887, 52);
            this.keytext.TabIndex = 4;
            this.keytext.Text = "";
            this.keytext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keytext_KeyPress);
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt.FlatAppearance.BorderSize = 2;
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Encrypt.ForeColor = System.Drawing.Color.Lime;
            this.Encrypt.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.Encrypt.IconColor = System.Drawing.Color.Lime;
            this.Encrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Encrypt.IconSize = 40;
            this.Encrypt.Location = new System.Drawing.Point(531, 408);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(172, 44);
            this.Encrypt.TabIndex = 6;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Encrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt.FlatAppearance.BorderSize = 2;
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.Color.Red;
            this.Decrypt.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.Decrypt.IconColor = System.Drawing.Color.Red;
            this.Decrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Decrypt.IconSize = 40;
            this.Decrypt.Location = new System.Drawing.Point(739, 408);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(172, 44);
            this.Decrypt.TabIndex = 7;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Decrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(299, 458);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1055, 14);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // cbinarytext
            // 
            this.cbinarytext.BackColor = System.Drawing.Color.DarkBlue;
            this.cbinarytext.ForeColor = System.Drawing.Color.White;
            this.cbinarytext.Location = new System.Drawing.Point(299, 511);
            this.cbinarytext.Name = "cbinarytext";
            this.cbinarytext.Size = new System.Drawing.Size(1055, 222);
            this.cbinarytext.TabIndex = 11;
            this.cbinarytext.Text = "";
            // 
            // dnlowdresult
            // 
            this.dnlowdresult.BackColor = System.Drawing.Color.MidnightBlue;
            this.dnlowdresult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dnlowdresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dnlowdresult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dnlowdresult.ForeColor = System.Drawing.Color.GhostWhite;
            this.dnlowdresult.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.dnlowdresult.IconColor = System.Drawing.Color.GhostWhite;
            this.dnlowdresult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dnlowdresult.Location = new System.Drawing.Point(12, 575);
            this.dnlowdresult.Name = "dnlowdresult";
            this.dnlowdresult.Size = new System.Drawing.Size(134, 101);
            this.dnlowdresult.TabIndex = 9;
            this.dnlowdresult.Text = "Download the result";
            this.dnlowdresult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dnlowdresult.UseVisualStyleBackColor = false;
            this.dnlowdresult.Click += new System.EventHandler(this.dnlowdresult_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Plain-text preview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Binary preview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Binary preview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(713, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "/";
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresslabel.ForeColor = System.Drawing.Color.White;
            this.progresslabel.Location = new System.Drawing.Point(174, 451);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(80, 21);
            this.progresslabel.TabIndex = 17;
            this.progresslabel.Text = "Progress:";
            // 
            // cancelProgressbtn
            // 
            this.cancelProgressbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.cancelProgressbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelProgressbtn.FlatAppearance.BorderSize = 2;
            this.cancelProgressbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelProgressbtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelProgressbtn.ForeColor = System.Drawing.Color.Red;
            this.cancelProgressbtn.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.cancelProgressbtn.IconColor = System.Drawing.Color.Red;
            this.cancelProgressbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelProgressbtn.IconSize = 26;
            this.cancelProgressbtn.Location = new System.Drawing.Point(12, 446);
            this.cancelProgressbtn.Name = "cancelProgressbtn";
            this.cancelProgressbtn.Size = new System.Drawing.Size(144, 32);
            this.cancelProgressbtn.TabIndex = 18;
            this.cancelProgressbtn.Text = "Cancel progress";
            this.cancelProgressbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelProgressbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelProgressbtn.UseVisualStyleBackColor = false;
            this.cancelProgressbtn.Click += new System.EventHandler(this.cancelProgressbtn_Click);
            // 
            // blockNumlabel
            // 
            this.blockNumlabel.AutoSize = true;
            this.blockNumlabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockNumlabel.ForeColor = System.Drawing.Color.White;
            this.blockNumlabel.Location = new System.Drawing.Point(578, 475);
            this.blockNumlabel.Name = "blockNumlabel";
            this.blockNumlabel.Size = new System.Drawing.Size(195, 21);
            this.blockNumlabel.TabIndex = 19;
            this.blockNumlabel.Text = "Processing block Number";
            // 
            // keyHextext
            // 
            this.keyHextext.BackColor = System.Drawing.Color.Khaki;
            this.keyHextext.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyHextext.ForeColor = System.Drawing.Color.Black;
            this.keyHextext.Location = new System.Drawing.Point(299, 280);
            this.keyHextext.Name = "keyHextext";
            this.keyHextext.Size = new System.Drawing.Size(887, 52);
            this.keyHextext.TabIndex = 20;
            this.keyHextext.Text = "";
            this.keyHextext.TextChanged += new System.EventHandler(this.keyHextext_TextChanged);
            this.keyHextext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyHextext_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(66, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Write the key in hexadecimal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(1209, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hexadecimal key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(1209, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Binary key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1366, 742);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyHextext);
            this.Controls.Add(this.blockNumlabel);
            this.Controls.Add(this.cancelProgressbtn);
            this.Controls.Add(this.progresslabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbinarytext);
            this.Controls.Add(this.dnlowdresult);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.keytext);
            this.Controls.Add(this.randomkey);
            this.Controls.Add(this.pbinarytext);
            this.Controls.Add(this.ptext);
            this.Controls.Add(this.open);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Encryption Standards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FontAwesome.Sharp.IconButton open;
        private System.Windows.Forms.RichTextBox ptext;
        private System.Windows.Forms.RichTextBox pbinarytext;
        private FontAwesome.Sharp.IconButton randomkey;
        private System.Windows.Forms.RichTextBox keytext;
        private FontAwesome.Sharp.IconButton Encrypt;
        private FontAwesome.Sharp.IconButton Decrypt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox cbinarytext;
        private FontAwesome.Sharp.IconButton dnlowdresult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label progresslabel;
        private FontAwesome.Sharp.IconButton cancelProgressbtn;
        private System.Windows.Forms.Label blockNumlabel;
        private System.Windows.Forms.RichTextBox keyHextext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

