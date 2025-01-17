﻿namespace GlassInspectionSystem.Forms
{
    partial class FormBrokenSettings
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
            if (disposing && ( components != null ))
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInSidePixelFromEdge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutSidePixelFromEdge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTwoDerivativeValue = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvgCnt = new System.Windows.Forms.TextBox();
            this.txtBrokenValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.txtThreshold1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreshold2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 349);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(3, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(521, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtThreshold2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtThreshold1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtInSidePixelFromEdge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOutSidePixelFromEdge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTwoDerivativeValue);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAvgCnt);
            this.panel1.Controls.Add(this.txtBrokenValue);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 223);
            this.panel1.TabIndex = 1;
            // 
            // txtInSidePixelFromEdge
            // 
            this.txtInSidePixelFromEdge.Location = new System.Drawing.Point(227, 38);
            this.txtInSidePixelFromEdge.Name = "txtInSidePixelFromEdge";
            this.txtInSidePixelFromEdge.Size = new System.Drawing.Size(68, 21);
            this.txtInSidePixelFromEdge.TabIndex = 140;
            this.txtInSidePixelFromEdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInSidePixelFromEdge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(301, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 142;
            this.label4.Text = "pixel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(9, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 23);
            this.label5.TabIndex = 141;
            this.label5.Text = "Crop InSide Pixel From Edge";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutSidePixelFromEdge
            // 
            this.txtOutSidePixelFromEdge.Location = new System.Drawing.Point(227, 11);
            this.txtOutSidePixelFromEdge.Name = "txtOutSidePixelFromEdge";
            this.txtOutSidePixelFromEdge.Size = new System.Drawing.Size(68, 21);
            this.txtOutSidePixelFromEdge.TabIndex = 137;
            this.txtOutSidePixelFromEdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutSidePixelFromEdge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(301, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 139;
            this.label2.Text = "pixel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 138;
            this.label3.Text = "Crop OutSide Pixel From Edge";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTwoDerivativeValue
            // 
            this.txtTwoDerivativeValue.Location = new System.Drawing.Point(402, 73);
            this.txtTwoDerivativeValue.Name = "txtTwoDerivativeValue";
            this.txtTwoDerivativeValue.Size = new System.Drawing.Size(68, 21);
            this.txtTwoDerivativeValue.TabIndex = 134;
            this.txtTwoDerivativeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTwoDerivativeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label37.Location = new System.Drawing.Point(254, 72);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(139, 23);
            this.label37.TabIndex = 132;
            this.label37.Text = "TwoDerivativeValue";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(202, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 23);
            this.label8.TabIndex = 131;
            this.label8.Text = "pixel";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(9, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 130;
            this.label9.Text = "Average Count";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAvgCnt
            // 
            this.txtAvgCnt.Location = new System.Drawing.Point(128, 106);
            this.txtAvgCnt.Name = "txtAvgCnt";
            this.txtAvgCnt.Size = new System.Drawing.Size(68, 21);
            this.txtAvgCnt.TabIndex = 129;
            this.txtAvgCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAvgCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtAvgCnt.Leave += new System.EventHandler(this.txtAvgCnt_Leave);
            // 
            // txtBrokenValue
            // 
            this.txtBrokenValue.Location = new System.Drawing.Point(128, 73);
            this.txtBrokenValue.Name = "txtBrokenValue";
            this.txtBrokenValue.Size = new System.Drawing.Size(68, 21);
            this.txtBrokenValue.TabIndex = 126;
            this.txtBrokenValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrokenValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(202, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 23);
            this.label14.TabIndex = 128;
            this.label14.Text = "pixel";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(9, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 23);
            this.label17.TabIndex = 127;
            this.label17.Text = "Broken Value";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 24);
            this.panel2.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(521, 24);
            this.lblText.TabIndex = 126;
            this.lblText.Text = "Broken Param Settings";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblRight);
            this.panel3.Controls.Add(this.lblBottom);
            this.panel3.Controls.Add(this.lblTop);
            this.panel3.Controls.Add(this.lblLeft);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 34);
            this.panel3.TabIndex = 3;
            // 
            // lblRight
            // 
            this.lblRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRight.Location = new System.Drawing.Point(76, 6);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(64, 23);
            this.lblRight.TabIndex = 142;
            this.lblRight.Text = "Right";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRight.Click += new System.EventHandler(this.lblBroken_Click);
            // 
            // lblBottom
            // 
            this.lblBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBottom.Location = new System.Drawing.Point(216, 6);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(64, 23);
            this.lblBottom.TabIndex = 141;
            this.lblBottom.Text = "Bottom";
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBottom.Click += new System.EventHandler(this.lblBroken_Click);
            // 
            // lblTop
            // 
            this.lblTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTop.Location = new System.Drawing.Point(146, 6);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(64, 23);
            this.lblTop.TabIndex = 140;
            this.lblTop.Text = "Top";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.Click += new System.EventHandler(this.lblBroken_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLeft.Location = new System.Drawing.Point(6, 6);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(64, 23);
            this.lblLeft.TabIndex = 139;
            this.lblLeft.Text = "Left";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeft.Click += new System.EventHandler(this.lblBroken_Click);
            // 
            // txtThreshold1
            // 
            this.txtThreshold1.Location = new System.Drawing.Point(128, 145);
            this.txtThreshold1.Name = "txtThreshold1";
            this.txtThreshold1.Size = new System.Drawing.Size(68, 21);
            this.txtThreshold1.TabIndex = 143;
            this.txtThreshold1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 144;
            this.label1.Text = "Threshold1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThreshold2
            // 
            this.txtThreshold2.Location = new System.Drawing.Point(128, 185);
            this.txtThreshold2.Name = "txtThreshold2";
            this.txtThreshold2.Size = new System.Drawing.Size(68, 21);
            this.txtThreshold2.TabIndex = 145;
            this.txtThreshold2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(9, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 146;
            this.label6.Text = "Threshold2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormBrokenSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormBrokenSettings";
            this.Text = "FormBrokenSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBrokenSettings_FormClosed);
            this.Load += new System.EventHandler(this.FormBrokenSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTwoDerivativeValue;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvgCnt;
        private System.Windows.Forms.TextBox txtBrokenValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.TextBox txtInSidePixelFromEdge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutSidePixelFromEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThreshold2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThreshold1;
        private System.Windows.Forms.Label label1;
    }
}