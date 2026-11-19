namespace HomesSalesTrackingApplication
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGuide = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtSalesinitial = new System.Windows.Forms.TextBox();
            this.txtAmountOfSale = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(303, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOMES SALES TRACKING";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Location = new System.Drawing.Point(282, 54);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(213, 16);
            this.lblGuide.TabIndex = 1;
            this.lblGuide.Text = "D - Danielle, E - Edward, F - Fatima";
            this.lblGuide.Click += new System.EventHandler(this.lblGuide_Click);
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(85, 89);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(124, 16);
            this.lblInitial.TabIndex = 2;
            this.lblInitial.Text = "Sales Person Initial:";
            this.lblInitial.Click += new System.EventHandler(this.lblInitial_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(85, 157);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(107, 16);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount of Sales:";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(88, 302);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(350, 120);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // txtSalesinitial
            // 
            this.txtSalesinitial.Location = new System.Drawing.Point(88, 108);
            this.txtSalesinitial.Name = "txtSalesinitial";
            this.txtSalesinitial.Size = new System.Drawing.Size(189, 22);
            this.txtSalesinitial.TabIndex = 5;
            this.txtSalesinitial.TextChanged += new System.EventHandler(this.txtSalesinitial_TextChanged);
            // 
            // txtAmountOfSale
            // 
            this.txtAmountOfSale.Location = new System.Drawing.Point(88, 176);
            this.txtAmountOfSale.Name = "txtAmountOfSale";
            this.txtAmountOfSale.Size = new System.Drawing.Size(189, 22);
            this.txtAmountOfSale.TabIndex = 6;
            this.txtAmountOfSale.TextChanged += new System.EventHandler(this.txtAmountOfSale_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(88, 232);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 34);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(266, 232);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 34);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAmountOfSale);
            this.Controls.Add(this.txtSalesinitial);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtSalesinitial;
        private System.Windows.Forms.TextBox txtAmountOfSale;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
    }
}

