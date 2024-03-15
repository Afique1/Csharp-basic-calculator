namespace SimpleCalculatorGUI
{
    partial class Calculator
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.pnlCalculaltorAll = new System.Windows.Forms.Panel();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.pnlCalculatorButtons = new System.Windows.Forms.Panel();
            this.btnNameId = new System.Windows.Forms.Button();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnSummation = new System.Windows.Forms.Button();
            this.pnlNumbers = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnNu0 = new System.Windows.Forms.Button();
            this.btnNu9 = new System.Windows.Forms.Button();
            this.btnNu8 = new System.Windows.Forms.Button();
            this.btnNu7 = new System.Windows.Forms.Button();
            this.btnNu6 = new System.Windows.Forms.Button();
            this.btnNu5 = new System.Windows.Forms.Button();
            this.btnNu4 = new System.Windows.Forms.Button();
            this.btnNu3 = new System.Windows.Forms.Button();
            this.btnNu2 = new System.Windows.Forms.Button();
            this.btnNu1 = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlCalculaltorAll.SuspendLayout();
            this.pnlCalculatorButtons.SuspendLayout();
            this.pnlAnswer.SuspendLayout();
            this.pnlOperation.SuspendLayout();
            this.pnlNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.listBoxHistory);
            this.pnlMain.Controls.Add(this.pnlCalculaltorAll);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(521, 430);
            this.pnlMain.TabIndex = 1;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.BackColor = System.Drawing.Color.DimGray;
            this.listBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHistory.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHistory.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 16;
            this.listBoxHistory.Items.AddRange(new object[] {
            "        History"});
            this.listBoxHistory.Location = new System.Drawing.Point(394, 3);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(120, 416);
            this.listBoxHistory.TabIndex = 2;
            // 
            // pnlCalculaltorAll
            // 
            this.pnlCalculaltorAll.Controls.Add(this.textDisplay);
            this.pnlCalculaltorAll.Controls.Add(this.pnlCalculatorButtons);
            this.pnlCalculaltorAll.Location = new System.Drawing.Point(8, 3);
            this.pnlCalculaltorAll.Name = "pnlCalculaltorAll";
            this.pnlCalculaltorAll.Size = new System.Drawing.Size(379, 416);
            this.pnlCalculaltorAll.TabIndex = 1;
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDisplay.Font = new System.Drawing.Font("Yu Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.textDisplay.Location = new System.Drawing.Point(3, 0);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(376, 63);
            this.textDisplay.TabIndex = 5;
            this.textDisplay.Text = "0";
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlCalculatorButtons
            // 
            this.pnlCalculatorButtons.Controls.Add(this.btnNameId);
            this.pnlCalculatorButtons.Controls.Add(this.pnlAnswer);
            this.pnlCalculatorButtons.Controls.Add(this.pnlOperation);
            this.pnlCalculatorButtons.Controls.Add(this.pnlNumbers);
            this.pnlCalculatorButtons.Controls.Add(this.btnAllClear);
            this.pnlCalculatorButtons.Location = new System.Drawing.Point(0, 69);
            this.pnlCalculatorButtons.Name = "pnlCalculatorButtons";
            this.pnlCalculatorButtons.Size = new System.Drawing.Size(376, 333);
            this.pnlCalculatorButtons.TabIndex = 2;
            // 
            // btnNameId
            // 
            this.btnNameId.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNameId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNameId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameId.ForeColor = System.Drawing.Color.White;
            this.btnNameId.Location = new System.Drawing.Point(163, 310);
            this.btnNameId.Name = "btnNameId";
            this.btnNameId.Size = new System.Drawing.Size(50, 20);
            this.btnNameId.TabIndex = 6;
            this.btnNameId.Text = "Info";
            this.btnNameId.UseVisualStyleBackColor = false;
            this.btnNameId.Click += new System.EventHandler(this.btnNameId_Click);
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.Controls.Add(this.btnAnswer);
            this.pnlAnswer.Controls.Add(this.btnEqual);
            this.pnlAnswer.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAnswer.Location = new System.Drawing.Point(297, 55);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(74, 244);
            this.pnlAnswer.TabIndex = 16;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(3, 14);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(68, 106);
            this.btnAnswer.TabIndex = 19;
            this.btnAnswer.Text = "Ans";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Location = new System.Drawing.Point(3, 126);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(68, 106);
            this.btnEqual.TabIndex = 18;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.btnDivision);
            this.pnlOperation.Controls.Add(this.btnMultiplication);
            this.pnlOperation.Controls.Add(this.btnSubtraction);
            this.pnlOperation.Controls.Add(this.btnSummation);
            this.pnlOperation.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOperation.Location = new System.Drawing.Point(3, 55);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(74, 244);
            this.pnlOperation.TabIndex = 15;
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(3, 182);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(68, 50);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(3, 126);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(68, 50);
            this.btnMultiplication.TabIndex = 16;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtraction.Location = new System.Drawing.Point(3, 70);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(68, 50);
            this.btnSubtraction.TabIndex = 15;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnSummation
            // 
            this.btnSummation.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummation.Location = new System.Drawing.Point(3, 14);
            this.btnSummation.Name = "btnSummation";
            this.btnSummation.Size = new System.Drawing.Size(68, 50);
            this.btnSummation.TabIndex = 14;
            this.btnSummation.Text = "+";
            this.btnSummation.UseVisualStyleBackColor = true;
            this.btnSummation.Click += new System.EventHandler(this.btnSummation_Click);
            // 
            // pnlNumbers
            // 
            this.pnlNumbers.Controls.Add(this.btnDelete);
            this.pnlNumbers.Controls.Add(this.btnPoint);
            this.pnlNumbers.Controls.Add(this.btnNu0);
            this.pnlNumbers.Controls.Add(this.btnNu9);
            this.pnlNumbers.Controls.Add(this.btnNu8);
            this.pnlNumbers.Controls.Add(this.btnNu2);
            this.pnlNumbers.Controls.Add(this.btnNu1);
            this.pnlNumbers.Controls.Add(this.btnNu7);
            this.pnlNumbers.Controls.Add(this.btnNu6);
            this.pnlNumbers.Controls.Add(this.btnNu5);
            this.pnlNumbers.Controls.Add(this.btnNu4);
            this.pnlNumbers.Controls.Add(this.btnNu3);
            this.pnlNumbers.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNumbers.Location = new System.Drawing.Point(83, 55);
            this.pnlNumbers.Name = "pnlNumbers";
            this.pnlNumbers.Size = new System.Drawing.Size(208, 244);
            this.pnlNumbers.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDelete.Location = new System.Drawing.Point(136, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DEL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(24, 183);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(50, 50);
            this.btnPoint.TabIndex = 23;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnNu0
            // 
            this.btnNu0.Location = new System.Drawing.Point(80, 183);
            this.btnNu0.Name = "btnNu0";
            this.btnNu0.Size = new System.Drawing.Size(50, 50);
            this.btnNu0.TabIndex = 22;
            this.btnNu0.Text = "0";
            this.btnNu0.UseVisualStyleBackColor = true;
            this.btnNu0.Click += new System.EventHandler(this.btnNu0_Click);
            // 
            // btnNu9
            // 
            this.btnNu9.Location = new System.Drawing.Point(136, 16);
            this.btnNu9.Name = "btnNu9";
            this.btnNu9.Size = new System.Drawing.Size(50, 50);
            this.btnNu9.TabIndex = 21;
            this.btnNu9.Text = "9";
            this.btnNu9.UseVisualStyleBackColor = true;
            this.btnNu9.Click += new System.EventHandler(this.btnNu9_Click);
            // 
            // btnNu8
            // 
            this.btnNu8.Location = new System.Drawing.Point(80, 16);
            this.btnNu8.Name = "btnNu8";
            this.btnNu8.Size = new System.Drawing.Size(50, 50);
            this.btnNu8.TabIndex = 20;
            this.btnNu8.Text = "8";
            this.btnNu8.UseVisualStyleBackColor = true;
            this.btnNu8.Click += new System.EventHandler(this.btnNu8_Click);
            // 
            // btnNu7
            // 
            this.btnNu7.Location = new System.Drawing.Point(24, 16);
            this.btnNu7.Name = "btnNu7";
            this.btnNu7.Size = new System.Drawing.Size(50, 50);
            this.btnNu7.TabIndex = 19;
            this.btnNu7.Text = "7";
            this.btnNu7.UseVisualStyleBackColor = true;
            this.btnNu7.Click += new System.EventHandler(this.btnNu7_Click);
            // 
            // btnNu6
            // 
            this.btnNu6.Location = new System.Drawing.Point(136, 71);
            this.btnNu6.Name = "btnNu6";
            this.btnNu6.Size = new System.Drawing.Size(50, 50);
            this.btnNu6.TabIndex = 18;
            this.btnNu6.Text = "6";
            this.btnNu6.UseVisualStyleBackColor = true;
            this.btnNu6.Click += new System.EventHandler(this.btnNu6_Click);
            // 
            // btnNu5
            // 
            this.btnNu5.Location = new System.Drawing.Point(80, 71);
            this.btnNu5.Name = "btnNu5";
            this.btnNu5.Size = new System.Drawing.Size(50, 50);
            this.btnNu5.TabIndex = 17;
            this.btnNu5.Text = "5";
            this.btnNu5.UseVisualStyleBackColor = true;
            this.btnNu5.Click += new System.EventHandler(this.btnNu5_Click);
            // 
            // btnNu4
            // 
            this.btnNu4.Location = new System.Drawing.Point(24, 71);
            this.btnNu4.Name = "btnNu4";
            this.btnNu4.Size = new System.Drawing.Size(50, 50);
            this.btnNu4.TabIndex = 16;
            this.btnNu4.Text = "4";
            this.btnNu4.UseVisualStyleBackColor = true;
            this.btnNu4.Click += new System.EventHandler(this.btnNu4_Click);
            // 
            // btnNu3
            // 
            this.btnNu3.Location = new System.Drawing.Point(136, 126);
            this.btnNu3.Name = "btnNu3";
            this.btnNu3.Size = new System.Drawing.Size(50, 50);
            this.btnNu3.TabIndex = 15;
            this.btnNu3.Text = "3";
            this.btnNu3.UseVisualStyleBackColor = true;
            this.btnNu3.Click += new System.EventHandler(this.btnNu3_Click);
            // 
            // btnNu2
            // 
            this.btnNu2.Location = new System.Drawing.Point(80, 127);
            this.btnNu2.Name = "btnNu2";
            this.btnNu2.Size = new System.Drawing.Size(50, 50);
            this.btnNu2.TabIndex = 14;
            this.btnNu2.Text = "2";
            this.btnNu2.UseVisualStyleBackColor = true;
            this.btnNu2.Click += new System.EventHandler(this.btnNu2_Click);
            // 
            // btnNu1
            // 
            this.btnNu1.Location = new System.Drawing.Point(24, 126);
            this.btnNu1.Name = "btnNu1";
            this.btnNu1.Size = new System.Drawing.Size(50, 50);
            this.btnNu1.TabIndex = 13;
            this.btnNu1.Text = "1";
            this.btnNu1.UseVisualStyleBackColor = true;
            this.btnNu1.Click += new System.EventHandler(this.btnNu1_Click);
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnAllClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllClear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllClear.Location = new System.Drawing.Point(150, 3);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(74, 46);
            this.btnAllClear.TabIndex = 1;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(547, 456);
            this.Controls.Add(this.pnlMain);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.pnlMain.ResumeLayout(false);
            this.pnlCalculaltorAll.ResumeLayout(false);
            this.pnlCalculaltorAll.PerformLayout();
            this.pnlCalculatorButtons.ResumeLayout(false);
            this.pnlAnswer.ResumeLayout(false);
            this.pnlOperation.ResumeLayout(false);
            this.pnlNumbers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCalculaltorAll;
        private System.Windows.Forms.Button btnNameId;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Panel pnlCalculatorButtons;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnSummation;
        private System.Windows.Forms.Panel pnlNumbers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnNu0;
        private System.Windows.Forms.Button btnNu9;
        private System.Windows.Forms.Button btnNu8;
        private System.Windows.Forms.Button btnNu7;
        private System.Windows.Forms.Button btnNu6;
        private System.Windows.Forms.Button btnNu5;
        private System.Windows.Forms.Button btnNu4;
        private System.Windows.Forms.Button btnNu3;
        private System.Windows.Forms.Button btnNu2;
        private System.Windows.Forms.Button btnNu1;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.ListBox listBoxHistory;
    }
}

