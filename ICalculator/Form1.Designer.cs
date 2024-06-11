namespace ICalculator
{
    partial class BadCalculator
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
            txtTitle = new TextBox();
            btnHistory = new Button();
            btnclearAll = new Button();
            btnClearRecent = new Button();
            btnDeleteDigit = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSubtract = new Button();
            btn0 = new Button();
            btnAdd = new Button();
            btnPeriod = new Button();
            btnEquals = new Button();
            txtViewer = new TextBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(23, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(230, 23);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Calculator Title Goes Here";
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(23, 86);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(53, 35);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnclearAll
            // 
            btnclearAll.Location = new Point(82, 86);
            btnclearAll.Name = "btnclearAll";
            btnclearAll.Size = new Size(53, 35);
            btnclearAll.TabIndex = 2;
            btnclearAll.Text = "C";
            btnclearAll.UseVisualStyleBackColor = true;
            btnclearAll.Click += btnclearAll_Click;
            // 
            // btnClearRecent
            // 
            btnClearRecent.Location = new Point(141, 86);
            btnClearRecent.Name = "btnClearRecent";
            btnClearRecent.Size = new Size(53, 35);
            btnClearRecent.TabIndex = 3;
            btnClearRecent.Text = "CE";
            btnClearRecent.UseVisualStyleBackColor = true;
            btnClearRecent.Click += btnClearRecent_Click;
            // 
            // btnDeleteDigit
            // 
            btnDeleteDigit.Location = new Point(141, 250);
            btnDeleteDigit.Name = "btnDeleteDigit";
            btnDeleteDigit.Size = new Size(53, 35);
            btnDeleteDigit.TabIndex = 4;
            btnDeleteDigit.Text = "DEL";
            btnDeleteDigit.UseVisualStyleBackColor = true;
            btnDeleteDigit.Click += btnDeleteDigit_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(23, 127);
            btn7.Name = "btn7";
            btn7.Size = new Size(53, 35);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(82, 127);
            btn8.Name = "btn8";
            btn8.Size = new Size(53, 35);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(141, 127);
            btn9.Name = "btn9";
            btn9.Size = new Size(53, 35);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(200, 209);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(53, 35);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(23, 168);
            btn4.Name = "btn4";
            btn4.Size = new Size(53, 35);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(82, 168);
            btn5.Name = "btn5";
            btn5.Size = new Size(53, 35);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(141, 168);
            btn6.Name = "btn6";
            btn6.Size = new Size(53, 35);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(200, 168);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(53, 35);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(23, 209);
            btn1.Name = "btn1";
            btn1.Size = new Size(53, 35);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(82, 209);
            btn2.Name = "btn2";
            btn2.Size = new Size(53, 35);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(141, 209);
            btn3.Name = "btn3";
            btn3.Size = new Size(53, 35);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(200, 127);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(53, 35);
            btnSubtract.TabIndex = 16;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(23, 250);
            btn0.Name = "btn0";
            btn0.Size = new Size(53, 35);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(200, 86);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 35);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPeriod
            // 
            btnPeriod.Location = new Point(82, 250);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(53, 35);
            btnPeriod.TabIndex = 19;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = true;
            btnPeriod.Click += btnPeriod_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(200, 250);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(53, 35);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // txtViewer
            // 
            txtViewer.Location = new Point(23, 41);
            txtViewer.Multiline = true;
            txtViewer.Name = "txtViewer";
            txtViewer.Size = new Size(230, 39);
            txtViewer.TabIndex = 21;
            txtViewer.TextAlign = HorizontalAlignment.Right;
            // 
            // BadCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 301);
            Controls.Add(txtViewer);
            Controls.Add(btnEquals);
            Controls.Add(btnPeriod);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDeleteDigit);
            Controls.Add(btnClearRecent);
            Controls.Add(btnclearAll);
            Controls.Add(btnHistory);
            Controls.Add(txtTitle);
            Name = "BadCalculator";
            Text = "BadCalculator";
            Load += BadCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Button btnHistory;
        private Button btnclearAll;
        private Button btnClearRecent;
        private Button btnDeleteDigit;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSubtract;
        private Button btn0;
        private Button btnAdd;
        private Button btnPeriod;
        private Button btnEquals;
        private TextBox txtViewer;
    }
}
