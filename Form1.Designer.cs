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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.chiffre = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN12);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(276, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "×";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BTN16);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(276, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "supp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BTN8);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(276, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BTN19);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(276, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "<<==";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BTN4);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(276, 254);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 47);
            this.button6.TabIndex = 5;
            this.button6.Text = "=";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BTN21);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(33, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "%";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BTN1);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(114, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "CE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BTN2);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(195, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "C";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BTN3);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(195, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "√ ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BTN7);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(114, 49);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 40);
            this.button11.TabIndex = 10;
            this.button11.Text = "x²";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BTN6);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(33, 49);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 40);
            this.button12.TabIndex = 11;
            this.button12.Text = "1/x";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.BTN5);
            // 
            // chiffre
            // 
            this.chiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiffre.Location = new System.Drawing.Point(33, 95);
            this.chiffre.Name = "chiffre";
            this.chiffre.Size = new System.Drawing.Size(75, 40);
            this.chiffre.TabIndex = 12;
            this.chiffre.Text = "1";
            this.chiffre.UseVisualStyleBackColor = true;
            this.chiffre.Click += new System.EventHandler(this.BTN9);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(114, 95);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 40);
            this.num1.TabIndex = 13;
            this.num1.Text = "2";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.BTN10);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(195, 95);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 40);
            this.num2.TabIndex = 14;
            this.num2.Text = "3";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.BTN11);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(33, 141);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 50);
            this.num3.TabIndex = 15;
            this.num3.Text = "4";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.BTN13);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(114, 141);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 50);
            this.num4.TabIndex = 16;
            this.num4.Text = "5";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.BTN14);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(195, 141);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 50);
            this.num5.TabIndex = 17;
            this.num5.Text = "6";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.BTN15);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(33, 197);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 51);
            this.num6.TabIndex = 18;
            this.num6.Text = "7";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.BTN17);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(114, 197);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 51);
            this.num7.TabIndex = 19;
            this.num7.Text = "8";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.BTN18);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(195, 197);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 51);
            this.num8.TabIndex = 20;
            this.num8.Text = "9";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.BTN19);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(33, 254);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 47);
            this.button22.TabIndex = 21;
            this.button22.Text = "+/-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.BTN19);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(114, 254);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 47);
            this.button23.TabIndex = 22;
            this.button23.Text = ",";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.BTN20);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(195, 254);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 47);
            this.num9.TabIndex = 23;
            this.num9.Text = "0";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.BTN20);
            // 
            // pnlprincipale
            // 
            this.pnlprincipale.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlprincipale.Controls.Add(this.num9);
            this.pnlprincipale.Controls.Add(this.button23);
            this.pnlprincipale.Controls.Add(this.button22);
            this.pnlprincipale.Controls.Add(this.num8);
            this.pnlprincipale.Controls.Add(this.num7);
            this.pnlprincipale.Controls.Add(this.num6);
            this.pnlprincipale.Controls.Add(this.num5);
            this.pnlprincipale.Controls.Add(this.num4);
            this.pnlprincipale.Controls.Add(this.num3);
            this.pnlprincipale.Controls.Add(this.num2);
            this.pnlprincipale.Controls.Add(this.num1);
            this.pnlprincipale.Controls.Add(this.chiffre);
            this.pnlprincipale.Controls.Add(this.button12);
            this.pnlprincipale.Controls.Add(this.button11);
            this.pnlprincipale.Controls.Add(this.button10);
            this.pnlprincipale.Controls.Add(this.button9);
            this.pnlprincipale.Controls.Add(this.button8);
            this.pnlprincipale.Controls.Add(this.button7);
            this.pnlprincipale.Controls.Add(this.button6);
            this.pnlprincipale.Controls.Add(this.button5);
            this.pnlprincipale.Controls.Add(this.button4);
            this.pnlprincipale.Controls.Add(this.button3);
            this.pnlprincipale.Controls.Add(this.button2);
            this.pnlprincipale.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button chiffre;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Panel pnlprincipale;
    }
}

