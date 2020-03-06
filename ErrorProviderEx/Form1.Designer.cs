namespace ErrorProviderEx
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNumber1 = new System.Windows.Forms.TextBox();
            this.tbxNumber2 = new System.Windows.Forms.TextBox();
            this.tbxMultlip = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.errTbxNumber1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTbxNumber2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTbxMultlip = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errTbxNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTbxNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTbxMultlip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Multlip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // tbxNumber1
            // 
            this.tbxNumber1.Location = new System.Drawing.Point(119, 18);
            this.tbxNumber1.Name = "tbxNumber1";
            this.tbxNumber1.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber1.TabIndex = 4;
            // 
            // tbxNumber2
            // 
            this.tbxNumber2.Location = new System.Drawing.Point(119, 51);
            this.tbxNumber2.Name = "tbxNumber2";
            this.tbxNumber2.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber2.TabIndex = 5;
            // 
            // tbxMultlip
            // 
            this.tbxMultlip.Location = new System.Drawing.Point(119, 90);
            this.tbxMultlip.Name = "tbxMultlip";
            this.tbxMultlip.Size = new System.Drawing.Size(100, 20);
            this.tbxMultlip.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(133, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // errTbxNumber1
            // 
            this.errTbxNumber1.ContainerControl = this;
            // 
            // errTbxNumber2
            // 
            this.errTbxNumber2.ContainerControl = this;
            // 
            // errTbxMultlip
            // 
            this.errTbxMultlip.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 163);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxMultlip);
            this.Controls.Add(this.tbxNumber2);
            this.Controls.Add(this.tbxNumber1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errTbxNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTbxNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTbxMultlip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNumber1;
        private System.Windows.Forms.TextBox tbxNumber2;
        private System.Windows.Forms.TextBox tbxMultlip;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ErrorProvider errTbxNumber1;
        private System.Windows.Forms.ErrorProvider errTbxNumber2;
        private System.Windows.Forms.ErrorProvider errTbxMultlip;
    }
}

