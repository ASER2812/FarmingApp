namespace WindowsFormsApp1
{
    partial class FarmingDashboard
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
            this.BTN_SETOPT = new System.Windows.Forms.Button();
            this.OPT_BOX = new System.Windows.Forms.ComboBox();
            this.MSG_LBL = new System.Windows.Forms.Label();
            this.SETCLR_BTN = new System.Windows.Forms.Button();
            this.CLR_BOX = new System.Windows.Forms.ComboBox();
            this.MSG_BOX = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DLT_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_SETOPT
            // 
            this.BTN_SETOPT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SETOPT.Location = new System.Drawing.Point(274, 392);
            this.BTN_SETOPT.Name = "BTN_SETOPT";
            this.BTN_SETOPT.Size = new System.Drawing.Size(130, 32);
            this.BTN_SETOPT.TabIndex = 2;
            this.BTN_SETOPT.Text = "Set";
            this.BTN_SETOPT.UseVisualStyleBackColor = true;
            this.BTN_SETOPT.Click += new System.EventHandler(this.button1_Click);
            // 
            // OPT_BOX
            // 
            this.OPT_BOX.FormattingEnabled = true;
            this.OPT_BOX.Items.AddRange(new object[] {
            "Option 1",
            "Option 2"});
            this.OPT_BOX.Location = new System.Drawing.Point(274, 358);
            this.OPT_BOX.Name = "OPT_BOX";
            this.OPT_BOX.Size = new System.Drawing.Size(276, 28);
            this.OPT_BOX.TabIndex = 3;
            this.OPT_BOX.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MSG_LBL
            // 
            this.MSG_LBL.AutoSize = true;
            this.MSG_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSG_LBL.Location = new System.Drawing.Point(270, 48);
            this.MSG_LBL.Name = "MSG_LBL";
            this.MSG_LBL.Size = new System.Drawing.Size(103, 25);
            this.MSG_LBL.TabIndex = 5;
            this.MSG_LBL.Text = "Messages";
            this.MSG_LBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // SETCLR_BTN
            // 
            this.SETCLR_BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SETCLR_BTN.Location = new System.Drawing.Point(274, 12);
            this.SETCLR_BTN.Name = "SETCLR_BTN";
            this.SETCLR_BTN.Size = new System.Drawing.Size(108, 32);
            this.SETCLR_BTN.TabIndex = 6;
            this.SETCLR_BTN.Text = "Set Color";
            this.SETCLR_BTN.UseVisualStyleBackColor = true;
            this.SETCLR_BTN.Click += new System.EventHandler(this.SETCLR_BTN_Click);
            // 
            // CLR_BOX
            // 
            this.CLR_BOX.FormattingEnabled = true;
            this.CLR_BOX.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Green",
            "Blue"});
            this.CLR_BOX.Location = new System.Drawing.Point(388, 12);
            this.CLR_BOX.Name = "CLR_BOX";
            this.CLR_BOX.Size = new System.Drawing.Size(162, 28);
            this.CLR_BOX.TabIndex = 7;
            this.CLR_BOX.SelectedIndexChanged += new System.EventHandler(this.CLR_BOX_SelectedIndexChanged);
            // 
            // MSG_BOX
            // 
            this.MSG_BOX.AcceptsTab = true;
            this.MSG_BOX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MSG_BOX.Location = new System.Drawing.Point(274, 75);
            this.MSG_BOX.Name = "MSG_BOX";
            this.MSG_BOX.ReadOnly = true;
            this.MSG_BOX.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MSG_BOX.Size = new System.Drawing.Size(276, 276);
            this.MSG_BOX.TabIndex = 9;
            this.MSG_BOX.Text = "";
            this.MSG_BOX.TextChanged += new System.EventHandler(this.MSG_BOX_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 386);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // DLT_BTN
            // 
            this.DLT_BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLT_BTN.Location = new System.Drawing.Point(420, 392);
            this.DLT_BTN.Name = "DLT_BTN";
            this.DLT_BTN.Size = new System.Drawing.Size(130, 32);
            this.DLT_BTN.TabIndex = 11;
            this.DLT_BTN.Text = "Delete";
            this.DLT_BTN.UseVisualStyleBackColor = true;
            this.DLT_BTN.Click += new System.EventHandler(this.DLT_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Farm Items";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FarmingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DLT_BTN);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MSG_BOX);
            this.Controls.Add(this.CLR_BOX);
            this.Controls.Add(this.SETCLR_BTN);
            this.Controls.Add(this.MSG_LBL);
            this.Controls.Add(this.OPT_BOX);
            this.Controls.Add(this.BTN_SETOPT);
            this.Name = "FarmingDashboard";
            this.Text = "Farming App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_SETOPT;
        private System.Windows.Forms.ComboBox OPT_BOX;
        private System.Windows.Forms.Label MSG_LBL;
        private System.Windows.Forms.Button SETCLR_BTN;
        private System.Windows.Forms.ComboBox CLR_BOX;
        private System.Windows.Forms.RichTextBox MSG_BOX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DLT_BTN;
        private System.Windows.Forms.Label label1;
    }
}

