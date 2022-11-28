namespace Calculatrice2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatriceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Result = new System.Windows.Forms.TextBox();
            this.but9 = new System.Windows.Forms.Button();
            this.buT10 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but11 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but12 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.chiffre = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.but14 = new System.Windows.Forms.Button();
            this.but13 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.pnlprincipale = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlprincipale.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatriceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // calculatriceToolStripMenuItem
            // 
            this.calculatriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatriceToolStripMenuItem1});
            this.calculatriceToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatriceToolStripMenuItem.Name = "calculatriceToolStripMenuItem";
            this.calculatriceToolStripMenuItem.Size = new System.Drawing.Size(46, 30);
            this.calculatriceToolStripMenuItem.Text = "...";
            // 
            // calculatriceToolStripMenuItem1
            // 
            this.calculatriceToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatriceToolStripMenuItem1.Name = "calculatriceToolStripMenuItem1";
            this.calculatriceToolStripMenuItem1.Size = new System.Drawing.Size(234, 34);
            this.calculatriceToolStripMenuItem1.Text = "Calculatrice ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(63, 36);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(382, 45);
            this.Result.TabIndex = 4;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // but9
            // 
            this.but9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.Location = new System.Drawing.Point(276, 95);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(75, 46);
            this.but9.TabIndex = 0;
            this.but9.Text = "+";
            this.but9.UseVisualStyleBackColor = false;
            this.but9.Click += new System.EventHandler(this.BTN12);
            // 
            // buT10
            // 
            this.buT10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buT10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buT10.Location = new System.Drawing.Point(276, 147);
            this.buT10.Name = "buT10";
            this.buT10.Size = new System.Drawing.Size(75, 47);
            this.buT10.TabIndex = 1;
            this.buT10.Text = "×";
            this.buT10.UseVisualStyleBackColor = false;
            this.buT10.Click += new System.EventHandler(this.BTN16);
            // 
            // but8
            // 
            this.but8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.Location = new System.Drawing.Point(276, 49);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(75, 40);
            this.but8.TabIndex = 2;
            this.but8.Text = "div";
            this.but8.UseVisualStyleBackColor = false;
            this.but8.Click += new System.EventHandler(this.BTN8);
            // 
            // but11
            // 
            this.but11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but11.Location = new System.Drawing.Point(276, 200);
            this.but11.Name = "but11";
            this.but11.Size = new System.Drawing.Size(75, 51);
            this.but11.TabIndex = 3;
            this.but11.Text = "-";
            this.but11.UseVisualStyleBackColor = false;
            this.but11.Click += new System.EventHandler(this.BTN21);
            // 
            // but4
            // 
            this.but4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.Location = new System.Drawing.Point(276, 3);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(75, 40);
            this.but4.TabIndex = 4;
            this.but4.Text = "<<==";
            this.but4.UseVisualStyleBackColor = false;
            this.but4.Click += new System.EventHandler(this.BTN4);
            // 
            // but12
            // 
            this.but12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.but12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but12.Location = new System.Drawing.Point(276, 254);
            this.but12.Name = "but12";
            this.but12.Size = new System.Drawing.Size(75, 47);
            this.but12.TabIndex = 5;
            this.but12.Text = "=";
            this.but12.UseVisualStyleBackColor = false;
            this.but12.Click += new System.EventHandler(this.BTN22);
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Location = new System.Drawing.Point(33, 3);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 40);
            this.but1.TabIndex = 6;
            this.but1.Text = "%";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.BTN1);
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(114, 3);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 40);
            this.but2.TabIndex = 7;
            this.but2.Text = "CE";
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.BTN2);
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Location = new System.Drawing.Point(195, 3);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 40);
            this.but3.TabIndex = 8;
            this.but3.Text = "C";
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.BTN3);
            // 
            // but7
            // 
            this.but7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.Location = new System.Drawing.Point(195, 49);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(75, 40);
            this.but7.TabIndex = 9;
            this.but7.Text = "√ ";
            this.but7.UseVisualStyleBackColor = false;
            this.but7.Click += new System.EventHandler(this.BTN7);
            // 
            // but6
            // 
            this.but6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.Location = new System.Drawing.Point(114, 49);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(75, 40);
            this.but6.TabIndex = 10;
            this.but6.Text = "x²";
            this.but6.UseVisualStyleBackColor = false;
            this.but6.Click += new System.EventHandler(this.BTN6);
            // 
            // but5
            // 
            this.but5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.Location = new System.Drawing.Point(33, 49);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(75, 40);
            this.but5.TabIndex = 11;
            this.but5.Text = "1/x";
            this.but5.UseVisualStyleBackColor = false;
            this.but5.Click += new System.EventHandler(this.BTN5);
            // 
            // chiffre
            // 
            this.chiffre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.chiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiffre.Location = new System.Drawing.Point(33, 95);
            this.chiffre.Name = "chiffre";
            this.chiffre.Size = new System.Drawing.Size(75, 40);
            this.chiffre.TabIndex = 12;
            this.chiffre.Text = "1";
            this.chiffre.UseVisualStyleBackColor = false;
            this.chiffre.Click += new System.EventHandler(this.BTN9);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(114, 95);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 40);
            this.num1.TabIndex = 13;
            this.num1.Text = "2";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.BTN10);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(195, 95);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 40);
            this.num2.TabIndex = 14;
            this.num2.Text = "3";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.BTN11);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(33, 141);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 50);
            this.num3.TabIndex = 15;
            this.num3.Text = "4";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.BTN13);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(114, 141);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 50);
            this.num4.TabIndex = 16;
            this.num4.Text = "5";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.BTN14);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(195, 141);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 50);
            this.num5.TabIndex = 17;
            this.num5.Text = "6";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.BTN15);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(33, 197);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 51);
            this.num6.TabIndex = 18;
            this.num6.Text = "7";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.BTN17);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(114, 197);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 51);
            this.num7.TabIndex = 19;
            this.num7.Text = "8";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.BTN18);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(195, 197);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 51);
            this.num8.TabIndex = 20;
            this.num8.Text = "9";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.BTN19);
            // 
            // but14
            // 
            this.but14.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but14.Location = new System.Drawing.Point(33, 254);
            this.but14.Name = "but14";
            this.but14.Size = new System.Drawing.Size(75, 47);
            this.but14.TabIndex = 21;
            this.but14.Text = "+/-";
            this.but14.UseVisualStyleBackColor = false;
            this.but14.Click += new System.EventHandler(this.BTN25);
            // 
            // but13
            // 
            this.but13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.but13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but13.Location = new System.Drawing.Point(114, 254);
            this.but13.Name = "but13";
            this.but13.Size = new System.Drawing.Size(75, 47);
            this.but13.TabIndex = 22;
            this.but13.Text = ",";
            this.but13.UseVisualStyleBackColor = false;
            this.but13.Click += new System.EventHandler(this.BTN24);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(195, 254);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 47);
            this.num9.TabIndex = 23;
            this.num9.Text = "0";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.BTN20);
            // 
            // pnlprincipale
            // 
            this.pnlprincipale.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlprincipale.Controls.Add(this.num9);
            this.pnlprincipale.Controls.Add(this.but13);
            this.pnlprincipale.Controls.Add(this.but14);
            this.pnlprincipale.Controls.Add(this.num8);
            this.pnlprincipale.Controls.Add(this.num7);
            this.pnlprincipale.Controls.Add(this.num6);
            this.pnlprincipale.Controls.Add(this.num5);
            this.pnlprincipale.Controls.Add(this.num4);
            this.pnlprincipale.Controls.Add(this.num3);
            this.pnlprincipale.Controls.Add(this.num2);
            this.pnlprincipale.Controls.Add(this.num1);
            this.pnlprincipale.Controls.Add(this.chiffre);
            this.pnlprincipale.Controls.Add(this.but5);
            this.pnlprincipale.Controls.Add(this.but6);
            this.pnlprincipale.Controls.Add(this.but7);
            this.pnlprincipale.Controls.Add(this.but3);
            this.pnlprincipale.Controls.Add(this.but2);
            this.pnlprincipale.Controls.Add(this.but1);
            this.pnlprincipale.Controls.Add(this.but12);
            this.pnlprincipale.Controls.Add(this.but4);
            this.pnlprincipale.Controls.Add(this.but11);
            this.pnlprincipale.Controls.Add(this.but8);
            this.pnlprincipale.Controls.Add(this.buT10);
            this.pnlprincipale.Controls.Add(this.but9);
            this.pnlprincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlprincipale.Location = new System.Drawing.Point(63, 87);
            this.pnlprincipale.Name = "pnlprincipale";
            this.pnlprincipale.Size = new System.Drawing.Size(382, 320);
            this.pnlprincipale.TabIndex = 3;
            this.pnlprincipale.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(456, 393);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.pnlprincipale);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "calcule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlprincipale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatriceToolStripMenuItem1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button buT10;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but11;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but12;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button chiffre;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button but14;
        private System.Windows.Forms.Button but13;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Panel pnlprincipale;
    }
}

