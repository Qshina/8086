namespace _8086
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
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XCHG_btn = new System.Windows.Forms.Button();
            this.MOV_btn = new System.Windows.Forms.Button();
            this.moVwind1 = new _8086.MOVwind();
            this.xchGwid1 = new _8086.XCHGwid();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(5000, 200);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.XCHG_btn);
            this.panel1.Controls.Add(this.MOV_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 423);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // XCHG_btn
            // 
            this.XCHG_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.XCHG_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.XCHG_btn.FlatAppearance.BorderSize = 3;
            this.XCHG_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.XCHG_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XCHG_btn.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XCHG_btn.Location = new System.Drawing.Point(0, 213);
            this.XCHG_btn.Name = "XCHG_btn";
            this.XCHG_btn.Size = new System.Drawing.Size(100, 210);
            this.XCHG_btn.TabIndex = 0;
            this.XCHG_btn.Text = "XCHG";
            this.XCHG_btn.UseVisualStyleBackColor = false;
            this.XCHG_btn.Click += new System.EventHandler(this.XCHG_btn_Click);
            // 
            // MOV_btn
            // 
            this.MOV_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MOV_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.MOV_btn.FlatAppearance.BorderSize = 3;
            this.MOV_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MOV_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.MOV_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MOV_btn.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MOV_btn.Location = new System.Drawing.Point(0, 0);
            this.MOV_btn.Name = "MOV_btn";
            this.MOV_btn.Size = new System.Drawing.Size(100, 210);
            this.MOV_btn.TabIndex = 0;
            this.MOV_btn.Text = "MOV";
            this.MOV_btn.UseVisualStyleBackColor = false;
            this.MOV_btn.Click += new System.EventHandler(this.MOV_Click);
            // 
            // moVwind1
            // 
            this.moVwind1.BackColor = System.Drawing.Color.Teal;
            this.moVwind1.Location = new System.Drawing.Point(106, 0);
            this.moVwind1.Name = "moVwind1";
            this.moVwind1.Size = new System.Drawing.Size(530, 423);
            this.moVwind1.TabIndex = 15;
            this.moVwind1.Load += new System.EventHandler(this.moVwind1_Load);
            // 
            // xchGwid1
            // 
            this.xchGwid1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.xchGwid1.BackColor = System.Drawing.SystemColors.Control;
            this.xchGwid1.Location = new System.Drawing.Point(106, 0);
            this.xchGwid1.Name = "xchGwid1";
            this.xchGwid1.Size = new System.Drawing.Size(530, 423);
            this.xchGwid1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xchGwid1);
            this.Controls.Add(this.moVwind1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "8086 MOV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Button XCHG_btn;
        private Button MOV_btn;
        private MOVwind moVwind1;
        private XCHGwid xchGwid1;
    }
}