
namespace TicTacToe_mini_
{
    partial class TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutbtn);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startToolStripMenuItem.Text = "New Game";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(12, 31);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(107, 102);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.BtnClick);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(257, 31);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(107, 102);
            this.a3.TabIndex = 1;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.BtnClick);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(257, 270);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(107, 102);
            this.c3.TabIndex = 1;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.BtnClick);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(12, 270);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(107, 102);
            this.c1.TabIndex = 1;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.BtnClick);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 150);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(107, 102);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.BtnClick);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(134, 31);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(107, 102);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.BtnClick);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(134, 270);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(107, 102);
            this.c2.TabIndex = 1;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.BtnClick);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(134, 150);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(107, 102);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.BtnClick);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(257, 150);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(107, 102);
            this.b3.TabIndex = 1;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.BtnClick);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 390);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
    }
}

