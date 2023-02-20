namespace Caster
{
    partial class MapDesigner
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
            this.PNL_TOP = new System.Windows.Forms.Panel();
            this.CHK_BOX = new System.Windows.Forms.CheckBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.PNL_TOKEN = new System.Windows.Forms.Panel();
            this.PCT_PICKER = new System.Windows.Forms.PictureBox();
            this.TXT_B = new System.Windows.Forms.TextBox();
            this.TXT_R = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_G = new System.Windows.Forms.TextBox();
            this.TXT_TOKEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.BTN_OPEN = new System.Windows.Forms.Button();
            this.PNL_TOP.SuspendLayout();
            this.PNL_TOKEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_PICKER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_TOP
            // 
            this.PNL_TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_TOP.Controls.Add(this.BTN_OPEN);
            this.PNL_TOP.Controls.Add(this.CHK_BOX);
            this.PNL_TOP.Controls.Add(this.BTN_SAVE);
            this.PNL_TOP.Controls.Add(this.PNL_TOKEN);
            this.PNL_TOP.Controls.Add(this.label1);
            this.PNL_TOP.Controls.Add(this.LBL_STATUS);
            this.PNL_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_TOP.ForeColor = System.Drawing.Color.Silver;
            this.PNL_TOP.Location = new System.Drawing.Point(0, 0);
            this.PNL_TOP.Name = "PNL_TOP";
            this.PNL_TOP.Size = new System.Drawing.Size(1225, 82);
            this.PNL_TOP.TabIndex = 1;
            // 
            // CHK_BOX
            // 
            this.CHK_BOX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHK_BOX.Appearance = System.Windows.Forms.Appearance.Button;
            this.CHK_BOX.AutoSize = true;
            this.CHK_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CHK_BOX.FlatAppearance.BorderSize = 0;
            this.CHK_BOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHK_BOX.Location = new System.Drawing.Point(800, 28);
            this.CHK_BOX.Name = "CHK_BOX";
            this.CHK_BOX.Size = new System.Drawing.Size(61, 23);
            this.CHK_BOX.TabIndex = 13;
            this.CHK_BOX.Text = "ERASER";
            this.CHK_BOX.UseVisualStyleBackColor = false;
            this.CHK_BOX.CheckStateChanged += new System.EventHandler(this.CHK_BOX_CheckStateChanged);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BTN_SAVE.FlatAppearance.BorderSize = 0;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Location = new System.Drawing.Point(134, 44);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(111, 27);
            this.BTN_SAVE.TabIndex = 12;
            this.BTN_SAVE.Text = "SAVE";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // PNL_TOKEN
            // 
            this.PNL_TOKEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_TOKEN.Controls.Add(this.PCT_PICKER);
            this.PNL_TOKEN.Controls.Add(this.TXT_B);
            this.PNL_TOKEN.Controls.Add(this.TXT_R);
            this.PNL_TOKEN.Controls.Add(this.label5);
            this.PNL_TOKEN.Controls.Add(this.TXT_G);
            this.PNL_TOKEN.Controls.Add(this.TXT_TOKEN);
            this.PNL_TOKEN.Controls.Add(this.label2);
            this.PNL_TOKEN.Controls.Add(this.button1);
            this.PNL_TOKEN.Controls.Add(this.label3);
            this.PNL_TOKEN.Controls.Add(this.label4);
            this.PNL_TOKEN.Location = new System.Drawing.Point(880, 3);
            this.PNL_TOKEN.Name = "PNL_TOKEN";
            this.PNL_TOKEN.Size = new System.Drawing.Size(333, 78);
            this.PNL_TOKEN.TabIndex = 11;
            // 
            // PCT_PICKER
            // 
            this.PCT_PICKER.BackColor = System.Drawing.Color.Cyan;
            this.PCT_PICKER.Location = new System.Drawing.Point(149, 12);
            this.PCT_PICKER.Name = "PCT_PICKER";
            this.PCT_PICKER.Size = new System.Drawing.Size(46, 27);
            this.PCT_PICKER.TabIndex = 2;
            this.PCT_PICKER.TabStop = false;
            // 
            // TXT_B
            // 
            this.TXT_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TXT_B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_B.ForeColor = System.Drawing.Color.Silver;
            this.TXT_B.Location = new System.Drawing.Point(92, 54);
            this.TXT_B.Name = "TXT_B";
            this.TXT_B.Size = new System.Drawing.Size(47, 19);
            this.TXT_B.TabIndex = 5;
            this.TXT_B.Text = "255";
            this.TXT_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_R
            // 
            this.TXT_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TXT_R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_R.ForeColor = System.Drawing.Color.Silver;
            this.TXT_R.Location = new System.Drawing.Point(92, 3);
            this.TXT_R.Name = "TXT_R";
            this.TXT_R.Size = new System.Drawing.Size(47, 19);
            this.TXT_R.TabIndex = 3;
            this.TXT_R.Text = "0";
            this.TXT_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "TOKEN";
            // 
            // TXT_G
            // 
            this.TXT_G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TXT_G.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_G.ForeColor = System.Drawing.Color.Silver;
            this.TXT_G.Location = new System.Drawing.Point(92, 29);
            this.TXT_G.Name = "TXT_G";
            this.TXT_G.Size = new System.Drawing.Size(47, 19);
            this.TXT_G.TabIndex = 4;
            this.TXT_G.Text = "255";
            this.TXT_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_TOKEN
            // 
            this.TXT_TOKEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TXT_TOKEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_TOKEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TOKEN.ForeColor = System.Drawing.Color.Silver;
            this.TXT_TOKEN.Location = new System.Drawing.Point(201, 46);
            this.TXT_TOKEN.Name = "TXT_TOKEN";
            this.TXT_TOKEN.Size = new System.Drawing.Size(106, 22);
            this.TXT_TOKEN.TabIndex = 9;
            this.TXT_TOKEN.Text = "@";
            this.TXT_TOKEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "RED";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(201, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "COLOR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "GREEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "BLUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "coordenates: ";
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.ForeColor = System.Drawing.Color.Silver;
            this.LBL_STATUS.Location = new System.Drawing.Point(169, 16);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(91, 20);
            this.LBL_STATUS.TabIndex = 0;
            this.LBL_STATUS.Text = "WELCOME";
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(13, 87);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1200, 600);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // BTN_OPEN
            // 
            this.BTN_OPEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BTN_OPEN.FlatAppearance.BorderSize = 0;
            this.BTN_OPEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OPEN.Location = new System.Drawing.Point(17, 44);
            this.BTN_OPEN.Name = "BTN_OPEN";
            this.BTN_OPEN.Size = new System.Drawing.Size(111, 27);
            this.BTN_OPEN.TabIndex = 14;
            this.BTN_OPEN.Text = "OPEN";
            this.BTN_OPEN.UseVisualStyleBackColor = false;
            this.BTN_OPEN.Click += new System.EventHandler(this.BTN_OPEN_Click);
            // 
            // MapDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1225, 693);
            this.Controls.Add(this.PCT_CANVAS);
            this.Controls.Add(this.PNL_TOP);
            this.Name = "MapDesigner";
            this.Text = "MapDesigner";
            this.PNL_TOP.ResumeLayout(false);
            this.PNL_TOP.PerformLayout();
            this.PNL_TOKEN.ResumeLayout(false);
            this.PNL_TOKEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_PICKER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_TOP;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PCT_PICKER;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_G;
        private System.Windows.Forms.TextBox TXT_R;
        private System.Windows.Forms.TextBox TXT_B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_TOKEN;
        private System.Windows.Forms.Panel PNL_TOKEN;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.CheckBox CHK_BOX;
        private System.Windows.Forms.Button BTN_OPEN;
    }
}