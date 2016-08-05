namespace ConstraintSatisfactionProblemSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbr1 = new System.Windows.Forms.Label();
            this.lbr2 = new System.Windows.Forms.Label();
            this.lbr3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGiveValues = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lb_diag = new System.Windows.Forms.Label();
            this.lbc1 = new System.Windows.Forms.Label();
            this.lbc2 = new System.Windows.Forms.Label();
            this.lbc3 = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.rb32 = new System.Windows.Forms.RadioButton();
            this.rb31 = new System.Windows.Forms.RadioButton();
            this.rb33 = new System.Windows.Forms.RadioButton();
            this.rb21 = new System.Windows.Forms.RadioButton();
            this.rb22 = new System.Windows.Forms.RadioButton();
            this.rb23 = new System.Windows.Forms.RadioButton();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb13 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tablePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbr1
            // 
            this.lbr1.AutoSize = true;
            this.lbr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbr1.ForeColor = System.Drawing.Color.Blue;
            this.lbr1.Location = new System.Drawing.Point(316, 19);
            this.lbr1.Name = "lbr1";
            this.lbr1.Size = new System.Drawing.Size(36, 39);
            this.lbr1.TabIndex = 3;
            this.lbr1.Text = "0";
            // 
            // lbr2
            // 
            this.lbr2.AutoSize = true;
            this.lbr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbr2.ForeColor = System.Drawing.Color.Blue;
            this.lbr2.Location = new System.Drawing.Point(316, 86);
            this.lbr2.Name = "lbr2";
            this.lbr2.Size = new System.Drawing.Size(36, 39);
            this.lbr2.TabIndex = 7;
            this.lbr2.Text = "0";
            // 
            // lbr3
            // 
            this.lbr3.AutoSize = true;
            this.lbr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbr3.ForeColor = System.Drawing.Color.Blue;
            this.lbr3.Location = new System.Drawing.Point(316, 152);
            this.lbr3.Name = "lbr3";
            this.lbr3.Size = new System.Drawing.Size(36, 39);
            this.lbr3.TabIndex = 11;
            this.lbr3.Text = "0";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(159, 483);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(54, 20);
            this.txtValue.TabIndex = 14;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Row and Col :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 485);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 19);
            this.label15.TabIndex = 17;
            this.label15.Text = "Value :";
            // 
            // btnGiveValues
            // 
            this.btnGiveValues.Location = new System.Drawing.Point(271, 423);
            this.btnGiveValues.Name = "btnGiveValues";
            this.btnGiveValues.Size = new System.Drawing.Size(160, 32);
            this.btnGiveValues.TabIndex = 18;
            this.btnGiveValues.Text = "Give Values";
            this.btnGiveValues.UseVisualStyleBackColor = true;
            this.btnGiveValues.Click += new System.EventHandler(this.btnGiveValues_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(271, 462);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(160, 42);
            this.btnOutput.TabIndex = 19;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lb_diag
            // 
            this.lb_diag.AutoSize = true;
            this.lb_diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diag.ForeColor = System.Drawing.Color.Crimson;
            this.lb_diag.Location = new System.Drawing.Point(316, 232);
            this.lb_diag.Name = "lb_diag";
            this.lb_diag.Size = new System.Drawing.Size(36, 39);
            this.lb_diag.TabIndex = 20;
            this.lb_diag.Text = "0";
            // 
            // lbc1
            // 
            this.lbc1.AutoSize = true;
            this.lbc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbc1.ForeColor = System.Drawing.Color.Blue;
            this.lbc1.Location = new System.Drawing.Point(27, 232);
            this.lbc1.Name = "lbc1";
            this.lbc1.Size = new System.Drawing.Size(36, 39);
            this.lbc1.TabIndex = 21;
            this.lbc1.Text = "0";
            // 
            // lbc2
            // 
            this.lbc2.AutoSize = true;
            this.lbc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbc2.ForeColor = System.Drawing.Color.Blue;
            this.lbc2.Location = new System.Drawing.Point(133, 232);
            this.lbc2.Name = "lbc2";
            this.lbc2.Size = new System.Drawing.Size(36, 39);
            this.lbc2.TabIndex = 22;
            this.lbc2.Text = "0";
            // 
            // lbc3
            // 
            this.lbc3.AutoSize = true;
            this.lbc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbc3.ForeColor = System.Drawing.Color.Blue;
            this.lbc3.Location = new System.Drawing.Point(232, 232);
            this.lbc3.Name = "lbc3";
            this.lbc3.Size = new System.Drawing.Size(36, 39);
            this.lbc3.TabIndex = 23;
            this.lbc3.Text = "0";
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tablePanel.BackgroundImage")));
            this.tablePanel.Controls.Add(this.lbc3);
            this.tablePanel.Controls.Add(this.lb_diag);
            this.tablePanel.Controls.Add(this.lbr1);
            this.tablePanel.Controls.Add(this.lbc2);
            this.tablePanel.Controls.Add(this.lbr2);
            this.tablePanel.Controls.Add(this.lbc1);
            this.tablePanel.Controls.Add(this.lbr3);
            this.tablePanel.Location = new System.Drawing.Point(53, 62);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(378, 298);
            this.tablePanel.TabIndex = 24;
            // 
            // rb32
            // 
            this.rb32.AutoSize = true;
            this.rb32.BackColor = System.Drawing.Color.Transparent;
            this.rb32.Location = new System.Drawing.Point(179, 461);
            this.rb32.Name = "rb32";
            this.rb32.Size = new System.Drawing.Size(14, 13);
            this.rb32.TabIndex = 25;
            this.rb32.TabStop = true;
            this.rb32.UseVisualStyleBackColor = false;
            this.rb32.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb31
            // 
            this.rb31.AutoSize = true;
            this.rb31.BackColor = System.Drawing.Color.Transparent;
            this.rb31.Location = new System.Drawing.Point(159, 461);
            this.rb31.Name = "rb31";
            this.rb31.Size = new System.Drawing.Size(14, 13);
            this.rb31.TabIndex = 26;
            this.rb31.TabStop = true;
            this.rb31.UseVisualStyleBackColor = false;
            this.rb31.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb33
            // 
            this.rb33.AutoSize = true;
            this.rb33.BackColor = System.Drawing.Color.Transparent;
            this.rb33.Location = new System.Drawing.Point(199, 461);
            this.rb33.Name = "rb33";
            this.rb33.Size = new System.Drawing.Size(14, 13);
            this.rb33.TabIndex = 27;
            this.rb33.TabStop = true;
            this.rb33.UseVisualStyleBackColor = false;
            this.rb33.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb21
            // 
            this.rb21.AutoSize = true;
            this.rb21.BackColor = System.Drawing.Color.Transparent;
            this.rb21.Location = new System.Drawing.Point(159, 442);
            this.rb21.Name = "rb21";
            this.rb21.Size = new System.Drawing.Size(14, 13);
            this.rb21.TabIndex = 28;
            this.rb21.TabStop = true;
            this.rb21.UseVisualStyleBackColor = false;
            this.rb21.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb22
            // 
            this.rb22.AutoSize = true;
            this.rb22.BackColor = System.Drawing.Color.Transparent;
            this.rb22.Location = new System.Drawing.Point(179, 442);
            this.rb22.Name = "rb22";
            this.rb22.Size = new System.Drawing.Size(14, 13);
            this.rb22.TabIndex = 29;
            this.rb22.TabStop = true;
            this.rb22.UseVisualStyleBackColor = false;
            this.rb22.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb23
            // 
            this.rb23.AutoSize = true;
            this.rb23.BackColor = System.Drawing.Color.Transparent;
            this.rb23.Location = new System.Drawing.Point(199, 442);
            this.rb23.Name = "rb23";
            this.rb23.Size = new System.Drawing.Size(14, 13);
            this.rb23.TabIndex = 30;
            this.rb23.TabStop = true;
            this.rb23.UseVisualStyleBackColor = false;
            this.rb23.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb11
            // 
            this.rb11.AutoSize = true;
            this.rb11.BackColor = System.Drawing.Color.Transparent;
            this.rb11.Location = new System.Drawing.Point(159, 423);
            this.rb11.Name = "rb11";
            this.rb11.Size = new System.Drawing.Size(14, 13);
            this.rb11.TabIndex = 31;
            this.rb11.TabStop = true;
            this.rb11.UseVisualStyleBackColor = false;
            this.rb11.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.BackColor = System.Drawing.Color.Transparent;
            this.rb12.Location = new System.Drawing.Point(179, 423);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(14, 13);
            this.rb12.TabIndex = 32;
            this.rb12.TabStop = true;
            this.rb12.UseVisualStyleBackColor = false;
            this.rb12.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // rb13
            // 
            this.rb13.AutoSize = true;
            this.rb13.BackColor = System.Drawing.Color.Transparent;
            this.rb13.Location = new System.Drawing.Point(199, 423);
            this.rb13.Name = "rb13";
            this.rb13.Size = new System.Drawing.Size(14, 13);
            this.rb13.TabIndex = 33;
            this.rb13.TabStop = true;
            this.rb13.UseVisualStyleBackColor = false;
            this.rb13.CheckedChanged += new System.EventHandler(this.allChkBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Constraint Satisfaction Problem Solver";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(228, 423);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 30);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(226, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 47);
            this.panel1.TabIndex = 36;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(16, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 36);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "0000";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Total Possible Solutions:";
            // 
            // tbSol
            // 
            this.tbSol.Location = new System.Drawing.Point(451, 84);
            this.tbSol.Multiline = true;
            this.tbSol.Name = "tbSol";
            this.tbSol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSol.Size = new System.Drawing.Size(151, 276);
            this.tbSol.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "All Possible Solutions:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb13);
            this.Controls.Add(this.rb12);
            this.Controls.Add(this.rb11);
            this.Controls.Add(this.rb23);
            this.Controls.Add(this.rb22);
            this.Controls.Add(this.rb21);
            this.Controls.Add(this.rb33);
            this.Controls.Add(this.rb31);
            this.Controls.Add(this.rb32);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnGiveValues);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constraint Satisfaction Problem Solver";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbr1;
        private System.Windows.Forms.Label lbr2;
        private System.Windows.Forms.Label lbr3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnGiveValues;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lb_diag;
        private System.Windows.Forms.Label lbc1;
        private System.Windows.Forms.Label lbc2;
        private System.Windows.Forms.Label lbc3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.RadioButton rb32;
        private System.Windows.Forms.RadioButton rb31;
        private System.Windows.Forms.RadioButton rb33;
        private System.Windows.Forms.RadioButton rb21;
        private System.Windows.Forms.RadioButton rb22;
        private System.Windows.Forms.RadioButton rb23;
        private System.Windows.Forms.RadioButton rb11;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSol;
        private System.Windows.Forms.Label label3;
    }
}

