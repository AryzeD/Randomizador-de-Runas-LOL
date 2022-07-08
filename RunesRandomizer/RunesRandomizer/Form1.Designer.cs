namespace RunesRandomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPath = new System.Windows.Forms.Label();
            this.lblKeystone = new System.Windows.Forms.Label();
            this.lblSlot1 = new System.Windows.Forms.Label();
            this.lblSlot2 = new System.Windows.Forms.Label();
            this.lblSlot3 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPath.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPath.Location = new System.Drawing.Point(25, 401);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(108, 28);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "MainRune";
            // 
            // lblKeystone
            // 
            this.lblKeystone.AutoSize = true;
            this.lblKeystone.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblKeystone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeystone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKeystone.Location = new System.Drawing.Point(222, 410);
            this.lblKeystone.Name = "lblKeystone";
            this.lblKeystone.Size = new System.Drawing.Size(73, 21);
            this.lblKeystone.TabIndex = 1;
            this.lblKeystone.Text = "Keystone";
            // 
            // lblSlot1
            // 
            this.lblSlot1.AutoSize = true;
            this.lblSlot1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSlot1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSlot1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSlot1.Location = new System.Drawing.Point(444, 408);
            this.lblSlot1.Name = "lblSlot1";
            this.lblSlot1.Size = new System.Drawing.Size(46, 21);
            this.lblSlot1.TabIndex = 4;
            this.lblSlot1.Text = "Slot1";
            // 
            // lblSlot2
            // 
            this.lblSlot2.AutoSize = true;
            this.lblSlot2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSlot2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSlot2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSlot2.Location = new System.Drawing.Point(659, 410);
            this.lblSlot2.Name = "lblSlot2";
            this.lblSlot2.Size = new System.Drawing.Size(46, 21);
            this.lblSlot2.TabIndex = 7;
            this.lblSlot2.Text = "Slot2";
            // 
            // lblSlot3
            // 
            this.lblSlot3.AutoSize = true;
            this.lblSlot3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSlot3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSlot3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSlot3.Location = new System.Drawing.Point(854, 410);
            this.lblSlot3.Name = "lblSlot3";
            this.lblSlot3.Size = new System.Drawing.Size(46, 21);
            this.lblSlot3.TabIndex = 10;
            this.lblSlot3.Text = "Slot3";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandom.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRandom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRandom.Location = new System.Drawing.Point(9, 8);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(158, 71);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Randomizar";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(996, 451);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblSlot3);
            this.Controls.Add(this.lblSlot2);
            this.Controls.Add(this.lblSlot1);
            this.Controls.Add(this.lblKeystone);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Randomizador de Runas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPath;
        private Label lblKeystone;
        private Label lblSlot1;
        private Label lblSlot2;
        private Label lblSlot3;
        private Button btnRandom;
    }
}