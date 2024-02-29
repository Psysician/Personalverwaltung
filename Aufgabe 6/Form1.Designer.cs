using System.IO;
using System;
using System.Drawing;

namespace Aufgabe_6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.name = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.data_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PB = new System.Windows.Forms.Button();
            this.delpb = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.name.Location = new System.Drawing.Point(55, 102);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(116, 24);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.street.Location = new System.Drawing.Point(237, 342);
            this.street.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(116, 24);
            this.street.TabIndex = 4;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.mail.Location = new System.Drawing.Point(55, 455);
            this.mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(116, 24);
            this.mail.TabIndex = 5;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.city.Location = new System.Drawing.Point(54, 342);
            this.city.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(116, 24);
            this.city.TabIndex = 3;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.lastname.Location = new System.Drawing.Point(236, 102);
            this.lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(116, 24);
            this.lastname.TabIndex = 1;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nachname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vorname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geburtsdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wohnort:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Straße:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-Mail:";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.btn_save.Location = new System.Drawing.Point(54, 513);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 58);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Datensatz Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 186);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(683, 67);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 504);
            this.listBox1.TabIndex = 15;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // data_name
            // 
            this.data_name.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.data_name.Location = new System.Drawing.Point(237, 455);
            this.data_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_name.Name = "data_name";
            this.data_name.Size = new System.Drawing.Size(116, 24);
            this.data_name.TabIndex = 6;
            this.data_name.TextChanged += new System.EventHandler(this.data_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name Datensatz:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 222);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 24);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PB
            // 
            this.PB.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.PB.Location = new System.Drawing.Point(465, 342);
            this.PB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(147, 35);
            this.PB.TabIndex = 19;
            this.PB.Text = "Profilbild Auswählen";
            this.PB.UseVisualStyleBackColor = true;
            this.PB.Click += new System.EventHandler(this.button1_Click);
            // 
            // delpb
            // 
            this.delpb.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.delpb.Location = new System.Drawing.Point(465, 450);
            this.delpb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delpb.Name = "delpb";
            this.delpb.Size = new System.Drawing.Size(147, 35);
            this.delpb.TabIndex = 20;
            this.delpb.Text = "Profilbild löschen";
            this.delpb.UseVisualStyleBackColor = true;
            this.delpb.Click += new System.EventHandler(this.deletepb);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPG files (*.jpg)|*.jpg| GIF files (*.gif)|*.gif| PNG files (*.png)|*.png| All fi" +
    "les (*.*)|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(461, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Alter: ";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.AgeLabel.Location = new System.Drawing.Point(512, 288);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(0, 20);
            this.AgeLabel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 628);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delpb);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.city);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.street);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox data_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button PB;
        private System.Windows.Forms.Button delpb;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AgeLabel;
    }
}

