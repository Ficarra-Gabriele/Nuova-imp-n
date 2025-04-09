using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Impiccats
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
            Parols = new Label();
            L01 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            L02 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Facils = new Button();
            medis = new Button();
            difficils = new Button();
            citts = new Button();
            Oggets = new Button();
            Animals = new Button();
            label6 = new Label();
            L07 = new Label();
            Invio = new Button();
            Invio2 = new Button();
            Label8 = new Label();
            Jolly = new Button();
            II = new Label();
            T00 = new Label();
            tentats = new Label();
            Lista = new ListBox();
            SuspendLayout();
            // 
            // Parols
            // 
            Parols.AutoSize = true;
            Parols.BackColor = SystemColors.WindowFrame;
            Parols.Location = new Point(397, 217);
            Parols.MinimumSize = new Size(300, 50);
            Parols.Name = "Parols";
            Parols.Size = new Size(300, 50);
            Parols.TabIndex = 1;
            Parols.Text = "Parola nascosta";
            Parols.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L01
            // 
            L01.Location = new Point(397, 324);
            L01.MinimumSize = new Size(140, 30);
            L01.Name = "L01";
            L01.Size = new Size(140, 30);
            L01.TabIndex = 2;
            L01.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Location = new Point(397, 291);
            label1.MinimumSize = new Size(140, 30);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 3;
            label1.Text = "Inserisci lettera";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(548, 291);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Location = new Point(563, 291);
            label3.MinimumSize = new Size(140, 30);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 5;
            label3.Text = "Inserisci parola";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L02
            // 
            L02.Location = new Point(563, 324);
            L02.MinimumSize = new Size(140, 30);
            L02.Name = "L02";
            L02.Size = new Size(140, 30);
            L02.TabIndex = 6;
            L02.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Location = new Point(795, 217);
            label4.MinimumSize = new Size(140, 30);
            label4.Name = "label4";
            label4.Size = new Size(140, 30);
            label4.TabIndex = 7;
            label4.Text = "Punteggio";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.InfoText;
            label5.Font = new System.Drawing.Font("Ravie", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(94, 111);
            label5.MinimumSize = new Size(900, 50);
            label5.Name = "label5";
            label5.Size = new Size(900, 50);
            label5.TabIndex = 9;
            label5.Text = "Benvenuto nel gioco dell'impiccato";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Facils
            // 
            Facils.Location = new Point(322, 445);
            Facils.MinimumSize = new Size(50, 50);
            Facils.Name = "Facils";
            Facils.Size = new Size(64, 57);
            Facils.TabIndex = 10;
            Facils.Text = "Facile";
            Facils.UseVisualStyleBackColor = true;
            Facils.Click += Facils_Click;
            // 
            // medis
            // 
            medis.Location = new Point(392, 445);
            medis.MinimumSize = new Size(50, 50);
            medis.Name = "medis";
            medis.Size = new Size(64, 57);
            medis.TabIndex = 11;
            medis.Text = "Medio";
            medis.UseVisualStyleBackColor = true;
            medis.Click += medis_Click;
            // 
            // difficils
            // 
            difficils.Location = new Point(462, 445);
            difficils.MinimumSize = new Size(50, 50);
            difficils.Name = "difficils";
            difficils.Size = new Size(64, 57);
            difficils.TabIndex = 12;
            difficils.Text = "Difficile";
            difficils.UseVisualStyleBackColor = true;
            difficils.Click += difficils_Click;
            // 
            // citts
            // 
            citts.Location = new Point(718, 445);
            citts.MinimumSize = new Size(50, 50);
            citts.Name = "citts";
            citts.Size = new Size(64, 57);
            citts.TabIndex = 15;
            citts.Text = "Città";
            citts.UseVisualStyleBackColor = true;
            citts.Click += citts_Click;
            // 
            // Oggets
            // 
            Oggets.Location = new Point(648, 445);
            Oggets.MinimumSize = new Size(50, 50);
            Oggets.Name = "Oggets";
            Oggets.Size = new Size(64, 57);
            Oggets.TabIndex = 14;
            Oggets.Text = "Oggetti";
            Oggets.UseVisualStyleBackColor = true;
            Oggets.Click += Oggets_Click;
            // 
            // Animals
            // 
            Animals.Location = new Point(578, 445);
            Animals.MinimumSize = new Size(50, 50);
            Animals.Name = "Animals";
            Animals.Size = new Size(64, 57);
            Animals.TabIndex = 13;
            Animals.Text = "Animali";
            Animals.UseVisualStyleBackColor = true;
            Animals.Click += Animals_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(301, 417);
            label6.MinimumSize = new Size(500, 25);
            label6.Name = "label6";
            label6.Size = new Size(500, 25);
            label6.TabIndex = 16;
            label6.Text = "Scegli la difficoltà o il tema";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L07
            // 
            L07.AutoSize = true;
            L07.BackColor = SystemColors.Window;
            L07.Location = new Point(856, 257);
            L07.MinimumSize = new Size(22, 23);
            L07.Name = "L07";
            L07.Size = new Size(22, 23);
            L07.TabIndex = 17;
            L07.Text = "0";
            L07.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Invio
            // 
            Invio.Location = new Point(397, 358);
            Invio.MinimumSize = new Size(140, 30);
            Invio.Name = "Invio";
            Invio.Size = new Size(140, 30);
            Invio.TabIndex = 19;
            Invio.Text = "Invio";
            Invio.UseVisualStyleBackColor = true;
            Invio.Click += Invio_Click;
            // 
            // Invio2
            // 
            Invio2.Location = new Point(563, 360);
            Invio2.MinimumSize = new Size(140, 30);
            Invio2.Name = "Invio2";
            Invio2.Size = new Size(140, 30);
            Invio2.TabIndex = 20;
            Invio2.Text = "Invio";
            Invio2.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = SystemColors.ControlDarkDark;
            Label8.Location = new Point(301, 505);
            Label8.MinimumSize = new Size(500, 25);
            Label8.Name = "Label8";
            Label8.Size = new Size(500, 25);
            Label8.TabIndex = 21;
            Label8.Text = "Ora hai a disposizione 2 jolly";
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Jolly
            // 
            Jolly.Location = new Point(524, 533);
            Jolly.MinimumSize = new Size(50, 50);
            Jolly.Name = "Jolly";
            Jolly.Size = new Size(64, 57);
            Jolly.TabIndex = 22;
            Jolly.Text = "Jolly";
            Jolly.UseVisualStyleBackColor = true;
            Jolly.Click += Jolly_Click;
            // 
            // II
            // 
            II.AutoSize = true;
            II.BackColor = SystemColors.Window;
            II.Location = new Point(594, 550);
            II.MinimumSize = new Size(22, 23);
            II.Name = "II";
            II.Size = new Size(22, 23);
            II.TabIndex = 23;
            II.Text = "0";
            II.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // T00
            // 
            T00.AutoSize = true;
            T00.BackColor = SystemColors.Window;
            T00.Location = new Point(856, 331);
            T00.MinimumSize = new Size(22, 23);
            T00.Name = "T00";
            T00.Size = new Size(22, 23);
            T00.TabIndex = 25;
            T00.Text = "0";
            T00.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tentats
            // 
            tentats.AutoSize = true;
            tentats.BackColor = SystemColors.WindowFrame;
            tentats.Location = new Point(795, 291);
            tentats.MinimumSize = new Size(140, 30);
            tentats.Name = "tentats";
            tentats.Size = new Size(140, 30);
            tentats.TabIndex = 24;
            tentats.Text = "Tentativi";
            tentats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lista
            // 
            Lista.BackColor = SystemColors.ScrollBar;
            Lista.BorderStyle = BorderStyle.None;
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 15;
            Lista.Location = new Point(128, 217);
            Lista.MinimumSize = new Size(216, 170);
            Lista.Name = "Lista";
            Lista.Size = new Size(216, 180);
            Lista.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1075, 733);
            Controls.Add(Lista);
            Controls.Add(T00);
            Controls.Add(tentats);
            Controls.Add(II);
            Controls.Add(Jolly);
            Controls.Add(Label8);
            Controls.Add(Invio2);
            Controls.Add(Invio);
            Controls.Add(L07);
            Controls.Add(label6);
            Controls.Add(citts);
            Controls.Add(Oggets);
            Controls.Add(Animals);
            Controls.Add(difficils);
            Controls.Add(medis);
            Controls.Add(Facils);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(L02);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(L01);
            Controls.Add(Parols);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Parols;
        private TextBox L01;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox L02;
        private Label label4;
        private Label label5;
        private Button Facils;
        private Button medis;
        private Button difficils;
        private Button citts;
        private Button Oggets;
        private Button Animals;
        private Label label6;
        private Label L07;
        private Button Invio;
        private Button Invio2;
        private Label Label8;
        private Button Jolly;
        private Label II;
        private Label T00;
        private Label tentats;
        private ListBox Lista;
    }
}
