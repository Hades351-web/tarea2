namespace proyecto_2
{
    partial class FormEje2
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
            lstNum = new ListBox();
            txtNum = new TextBox();
            btnAdd = new Button();
            lblAdd = new Label();
            lstPar = new ListBox();
            lblPar = new Label();
            lblSuPar = new Label();
            lblSumImp = new Label();
            lblImp = new Label();
            lstImp = new ListBox();
            lstOrde = new ListBox();
            lblOrde = new Label();
            btnDell = new Button();
            btnStart = new Button();
            lblInst = new Label();
            lblSumaPar = new Label();
            lblSumaImp = new Label();
            SuspendLayout();
            // 
            // lstNum
            // 
            lstNum.FormattingEnabled = true;
            lstNum.ItemHeight = 15;
            lstNum.Location = new Point(81, 170);
            lstNum.Name = "lstNum";
            lstNum.Size = new Size(156, 469);
            lstNum.TabIndex = 0;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(81, 103);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(156, 23);
            txtNum.TabIndex = 1;
            txtNum.KeyPress += txtNum_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(259, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 25);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Location = new Point(81, 46);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(38, 15);
            lblAdd.TabIndex = 3;
            lblAdd.Text = "label1";
            // 
            // lstPar
            // 
            lstPar.FormattingEnabled = true;
            lstPar.ItemHeight = 15;
            lstPar.Location = new Point(741, 170);
            lstPar.Name = "lstPar";
            lstPar.Size = new Size(156, 319);
            lstPar.TabIndex = 4;
            // 
            // lblPar
            // 
            lblPar.AutoSize = true;
            lblPar.Location = new Point(741, 105);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(38, 15);
            lblPar.TabIndex = 6;
            lblPar.Text = "label1";
            // 
            // lblSuPar
            // 
            lblSuPar.AutoSize = true;
            lblSuPar.Location = new Point(741, 581);
            lblSuPar.Name = "lblSuPar";
            lblSuPar.Size = new Size(38, 15);
            lblSuPar.TabIndex = 10;
            lblSuPar.Text = "label1";
            // 
            // lblSumImp
            // 
            lblSumImp.AutoSize = true;
            lblSumImp.Location = new Point(961, 581);
            lblSumImp.Name = "lblSumImp";
            lblSumImp.Size = new Size(38, 15);
            lblSumImp.TabIndex = 14;
            lblSumImp.Text = "label1";
            // 
            // lblImp
            // 
            lblImp.AutoSize = true;
            lblImp.Location = new Point(961, 105);
            lblImp.Name = "lblImp";
            lblImp.Size = new Size(38, 15);
            lblImp.TabIndex = 12;
            lblImp.Text = "label1";
            // 
            // lstImp
            // 
            lstImp.FormattingEnabled = true;
            lstImp.ItemHeight = 15;
            lstImp.Location = new Point(961, 170);
            lstImp.Name = "lstImp";
            lstImp.Size = new Size(156, 319);
            lstImp.TabIndex = 11;
            // 
            // lstOrde
            // 
            lstOrde.FormattingEnabled = true;
            lstOrde.ItemHeight = 15;
            lstOrde.Location = new Point(451, 170);
            lstOrde.Name = "lstOrde";
            lstOrde.Size = new Size(156, 469);
            lstOrde.TabIndex = 15;
            // 
            // lblOrde
            // 
            lblOrde.AutoSize = true;
            lblOrde.Location = new Point(451, 113);
            lblOrde.Name = "lblOrde";
            lblOrde.Size = new Size(38, 15);
            lblOrde.TabIndex = 16;
            lblOrde.Text = "label1";
            // 
            // btnDell
            // 
            btnDell.Location = new Point(259, 149);
            btnDell.Name = "btnDell";
            btnDell.Size = new Size(132, 25);
            btnDell.TabIndex = 17;
            btnDell.Text = "button1";
            btnDell.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(259, 321);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(132, 25);
            btnStart.TabIndex = 18;
            btnStart.Text = "button1";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblInst
            // 
            lblInst.AutoSize = true;
            lblInst.Location = new Point(81, 75);
            lblInst.Name = "lblInst";
            lblInst.Size = new Size(38, 15);
            lblInst.TabIndex = 19;
            lblInst.Text = "label1";
            // 
            // lblSumaPar
            // 
            lblSumaPar.AutoSize = true;
            lblSumaPar.Location = new Point(741, 624);
            lblSumaPar.Name = "lblSumaPar";
            lblSumaPar.Size = new Size(38, 15);
            lblSumaPar.TabIndex = 20;
            lblSumaPar.Text = "label1";
            // 
            // lblSumaImp
            // 
            lblSumaImp.AutoSize = true;
            lblSumaImp.Location = new Point(961, 624);
            lblSumaImp.Name = "lblSumaImp";
            lblSumaImp.Size = new Size(38, 15);
            lblSumaImp.TabIndex = 21;
            lblSumaImp.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 877);
            Controls.Add(lblSumaImp);
            Controls.Add(lblSumaPar);
            Controls.Add(lblInst);
            Controls.Add(btnStart);
            Controls.Add(btnDell);
            Controls.Add(lblOrde);
            Controls.Add(lstOrde);
            Controls.Add(lblSumImp);
            Controls.Add(lblImp);
            Controls.Add(lstImp);
            Controls.Add(lblSuPar);
            Controls.Add(lblPar);
            Controls.Add(lstPar);
            Controls.Add(lblAdd);
            Controls.Add(btnAdd);
            Controls.Add(txtNum);
            Controls.Add(lstNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNum;
        private TextBox txtNum;
        private Button btnAdd;
        private Label lblAdd;
        private ListBox lstPar;
        private Label lblPar;
        private Label lblSuPar;
        private Label lblSumImp;
        private Label lblImp;
        private ListBox lstImp;
        private ListBox lstOrde;
        private Label lblOrde;
        private Button btnDell;
        private Button btnStart;
        private Label lblInst;
        private Label lblSumaPar;
        private Label lblSumaImp;
    }
}
