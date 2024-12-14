namespace proyecto_3
{
    partial class FormEje1
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
            txtTamArr = new TextBox();
            lblPregunta = new Label();
            btnGen3 = new Button();
            lblResp1 = new Label();
            lblResp2 = new Label();
            lblResp3 = new Label();
            lblResp4 = new Label();
            lblResp5 = new Label();
            lblResp6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTamArr
            // 
            txtTamArr.Location = new Point(456, 195);
            txtTamArr.Name = "txtTamArr";
            txtTamArr.Size = new Size(299, 23);
            txtTamArr.TabIndex = 0;
            txtTamArr.TextChanged += txtTamArr_TextChanged;
            txtTamArr.KeyPress += txtTamArr_KeyPress_1;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(454, 121);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(38, 15);
            lblPregunta.TabIndex = 1;
            lblPregunta.Text = "label1";
            // 
            // btnGen3
            // 
            btnGen3.Location = new Point(449, 249);
            btnGen3.Name = "btnGen3";
            btnGen3.Size = new Size(185, 55);
            btnGen3.TabIndex = 2;
            btnGen3.Text = "button1";
            btnGen3.UseVisualStyleBackColor = true;
            btnGen3.Click += button1_Click;
            // 
            // lblResp1
            // 
            lblResp1.AutoSize = true;
            lblResp1.Location = new Point(201, 369);
            lblResp1.Name = "lblResp1";
            lblResp1.Size = new Size(38, 15);
            lblResp1.TabIndex = 3;
            lblResp1.Text = "label1";
            // 
            // lblResp2
            // 
            lblResp2.AutoSize = true;
            lblResp2.Location = new Point(201, 406);
            lblResp2.Name = "lblResp2";
            lblResp2.Size = new Size(38, 15);
            lblResp2.TabIndex = 4;
            lblResp2.Text = "label2";
            // 
            // lblResp3
            // 
            lblResp3.AutoSize = true;
            lblResp3.Location = new Point(201, 445);
            lblResp3.Name = "lblResp3";
            lblResp3.Size = new Size(38, 15);
            lblResp3.TabIndex = 5;
            lblResp3.Text = "label3";
            // 
            // lblResp4
            // 
            lblResp4.AutoSize = true;
            lblResp4.Location = new Point(201, 480);
            lblResp4.Name = "lblResp4";
            lblResp4.Size = new Size(38, 15);
            lblResp4.TabIndex = 6;
            lblResp4.Text = "label4";
            // 
            // lblResp5
            // 
            lblResp5.AutoSize = true;
            lblResp5.Location = new Point(201, 516);
            lblResp5.Name = "lblResp5";
            lblResp5.Size = new Size(38, 15);
            lblResp5.TabIndex = 7;
            lblResp5.Text = "label5";
            // 
            // lblResp6
            // 
            lblResp6.AutoSize = true;
            lblResp6.Location = new Point(201, 552);
            lblResp6.Name = "lblResp6";
            lblResp6.Size = new Size(38, 15);
            lblResp6.TabIndex = 8;
            lblResp6.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(1239, 761);
            button1.Name = "button1";
            button1.Size = new Size(107, 30);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormEje1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 880);
            Controls.Add(button1);
            Controls.Add(lblResp6);
            Controls.Add(lblResp5);
            Controls.Add(lblResp4);
            Controls.Add(lblResp3);
            Controls.Add(lblResp2);
            Controls.Add(lblResp1);
            Controls.Add(btnGen3);
            Controls.Add(lblPregunta);
            Controls.Add(txtTamArr);
            Name = "FormEje1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTamArr;
        private Label lblPregunta;
        private Button btnGen3;
        private Label lblResp1;
        private Label lblResp2;
        private Label lblResp3;
        private Label lblResp4;
        private Label lblResp5;
        private Label lblResp6;
        private Button button1;
    }
}
