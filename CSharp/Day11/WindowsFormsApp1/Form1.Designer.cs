namespace WindowsFormsApp1
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtData.Location = new System.Drawing.Point(316, 113);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(357, 20);
            this.txtData.TabIndex = 0;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(162, 74);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(275, 189);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(275, 238);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(124, 317);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

