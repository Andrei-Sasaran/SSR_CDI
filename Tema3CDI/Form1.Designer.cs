namespace Tema3CDI
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
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_CodeUniv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.Location = new System.Drawing.Point(50, 60);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(234, 290);
            this.listBox_Univ.TabIndex = 0;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listBox_Univ_SelectedIndexChanged);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.Location = new System.Drawing.Point(348, 43);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(204, 134);
            this.listBox_Fac.TabIndex = 1;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(348, 213);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.ReadOnly = true;
            this.textBox_City.Size = new System.Drawing.Size(189, 20);
            this.textBox_City.TabIndex = 2;
            // 
            // textBox_CodeUniv
            // 
            this.textBox_CodeUniv.Location = new System.Drawing.Point(348, 278);
            this.textBox_CodeUniv.Name = "textBox_CodeUniv";
            this.textBox_CodeUniv.ReadOnly = true;
            this.textBox_CodeUniv.Size = new System.Drawing.Size(189, 20);
            this.textBox_CodeUniv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Universities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Faculties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "University Code ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddEntry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CodeUniv);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.listBox_Fac);
            this.Controls.Add(this.listBox_Univ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_CodeUniv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

