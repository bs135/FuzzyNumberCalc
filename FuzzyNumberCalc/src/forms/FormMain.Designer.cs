namespace FuzzyNumberCalc
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.grbFooter = new System.Windows.Forms.GroupBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.grbParameters = new System.Windows.Forms.GroupBox();
            this.textBoxSmoothly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbFuzzyNumber = new System.Windows.Forms.GroupBox();
            this.grbFuzzyNumberB = new System.Windows.Forms.GroupBox();
            this.lblInvalidNumB = new System.Windows.Forms.Label();
            this.textBoxBTopLeft = new System.Windows.Forms.TextBox();
            this.textBoxBBotLeft = new System.Windows.Forms.TextBox();
            this.textBoxBTopRight = new System.Windows.Forms.TextBox();
            this.textBoxBBotRight = new System.Windows.Forms.TextBox();
            this.grbFuzzyNumberA = new System.Windows.Forms.GroupBox();
            this.lblInvalidNumA = new System.Windows.Forms.Label();
            this.textBoxATopLeft = new System.Windows.Forms.TextBox();
            this.textBoxABotLeft = new System.Windows.Forms.TextBox();
            this.textBoxATopRight = new System.Windows.Forms.TextBox();
            this.textBoxABotRight = new System.Windows.Forms.TextBox();
            this.grbOperation = new System.Windows.Forms.GroupBox();
            this.checkBoxOperationDiv = new System.Windows.Forms.CheckBox();
            this.checkBoxOperationMul = new System.Windows.Forms.CheckBox();
            this.checkBoxOperationSub = new System.Windows.Forms.CheckBox();
            this.checkBoxOperationAdd = new System.Windows.Forms.CheckBox();
            this.grbBase = new System.Windows.Forms.GroupBox();
            this.optionBoxIntervalBased = new System.Windows.Forms.RadioButton();
            this.optionBoxEPBased = new System.Windows.Forms.RadioButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.chartFuzzy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.epInValid = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxNumOfFracDigi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDrawLine = new System.Windows.Forms.CheckBox();
            this.pnlLeft.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.grbFooter.SuspendLayout();
            this.grbParameters.SuspendLayout();
            this.grbFuzzyNumber.SuspendLayout();
            this.grbFuzzyNumberB.SuspendLayout();
            this.grbFuzzyNumberA.SuspendLayout();
            this.grbOperation.SuspendLayout();
            this.grbBase.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuzzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInValid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlBottom);
            this.pnlLeft.Controls.Add(this.grbFooter);
            this.pnlLeft.Controls.Add(this.grbParameters);
            this.pnlLeft.Controls.Add(this.grbFuzzyNumber);
            this.pnlLeft.Controls.Add(this.grbOperation);
            this.pnlLeft.Controls.Add(this.grbBase);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(246, 637);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.textBoxLog);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 568);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(246, 69);
            this.pnlBottom.TabIndex = 6;
            // 
            // grbFooter
            // 
            this.grbFooter.Controls.Add(this.buttonRun);
            this.grbFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFooter.Location = new System.Drawing.Point(0, 428);
            this.grbFooter.Name = "grbFooter";
            this.grbFooter.Size = new System.Drawing.Size(246, 47);
            this.grbFooter.TabIndex = 4;
            this.grbFooter.TabStop = false;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(159, 15);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // grbParameters
            // 
            this.grbParameters.Controls.Add(this.checkBoxDrawLine);
            this.grbParameters.Controls.Add(this.label2);
            this.grbParameters.Controls.Add(this.textBoxNumOfFracDigi);
            this.grbParameters.Controls.Add(this.textBoxSmoothly);
            this.grbParameters.Controls.Add(this.label1);
            this.grbParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbParameters.Location = new System.Drawing.Point(0, 335);
            this.grbParameters.Name = "grbParameters";
            this.grbParameters.Size = new System.Drawing.Size(246, 93);
            this.grbParameters.TabIndex = 5;
            this.grbParameters.TabStop = false;
            this.grbParameters.Text = "Parameters";
            // 
            // textBoxSmoothly
            // 
            this.textBoxSmoothly.Location = new System.Drawing.Point(128, 16);
            this.textBoxSmoothly.Name = "textBoxSmoothly";
            this.textBoxSmoothly.Size = new System.Drawing.Size(86, 20);
            this.textBoxSmoothly.TabIndex = 1;
            this.textBoxSmoothly.Text = "0.05";
            this.textBoxSmoothly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smoothly";
            // 
            // grbFuzzyNumber
            // 
            this.grbFuzzyNumber.Controls.Add(this.grbFuzzyNumberB);
            this.grbFuzzyNumber.Controls.Add(this.grbFuzzyNumberA);
            this.grbFuzzyNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFuzzyNumber.Location = new System.Drawing.Point(0, 175);
            this.grbFuzzyNumber.Name = "grbFuzzyNumber";
            this.grbFuzzyNumber.Size = new System.Drawing.Size(246, 160);
            this.grbFuzzyNumber.TabIndex = 2;
            this.grbFuzzyNumber.TabStop = false;
            this.grbFuzzyNumber.Text = "Fuzzy Numbers";
            // 
            // grbFuzzyNumberB
            // 
            this.grbFuzzyNumberB.Controls.Add(this.lblInvalidNumB);
            this.grbFuzzyNumberB.Controls.Add(this.textBoxBTopLeft);
            this.grbFuzzyNumberB.Controls.Add(this.textBoxBBotLeft);
            this.grbFuzzyNumberB.Controls.Add(this.textBoxBTopRight);
            this.grbFuzzyNumberB.Controls.Add(this.textBoxBBotRight);
            this.grbFuzzyNumberB.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFuzzyNumberB.Location = new System.Drawing.Point(3, 85);
            this.grbFuzzyNumberB.Name = "grbFuzzyNumberB";
            this.grbFuzzyNumberB.Size = new System.Drawing.Size(240, 69);
            this.grbFuzzyNumberB.TabIndex = 1;
            this.grbFuzzyNumberB.TabStop = false;
            this.grbFuzzyNumberB.Text = "B";
            // 
            // lblInvalidNumB
            // 
            this.lblInvalidNumB.AutoSize = true;
            this.lblInvalidNumB.Location = new System.Drawing.Point(3, 15);
            this.lblInvalidNumB.Name = "lblInvalidNumB";
            this.lblInvalidNumB.Size = new System.Drawing.Size(10, 13);
            this.lblInvalidNumB.TabIndex = 5;
            this.lblInvalidNumB.Text = " ";
            // 
            // textBoxBTopLeft
            // 
            this.textBoxBTopLeft.Location = new System.Drawing.Point(49, 15);
            this.textBoxBTopLeft.Name = "textBoxBTopLeft";
            this.textBoxBTopLeft.Size = new System.Drawing.Size(50, 20);
            this.textBoxBTopLeft.TabIndex = 1;
            this.textBoxBTopLeft.Text = "3";
            this.textBoxBTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBBotLeft
            // 
            this.textBoxBBotLeft.Location = new System.Drawing.Point(13, 39);
            this.textBoxBBotLeft.Name = "textBoxBBotLeft";
            this.textBoxBBotLeft.Size = new System.Drawing.Size(50, 20);
            this.textBoxBBotLeft.TabIndex = 0;
            this.textBoxBBotLeft.Text = "-2";
            this.textBoxBBotLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBTopRight
            // 
            this.textBoxBTopRight.Location = new System.Drawing.Point(125, 15);
            this.textBoxBTopRight.Name = "textBoxBTopRight";
            this.textBoxBTopRight.Size = new System.Drawing.Size(50, 20);
            this.textBoxBTopRight.TabIndex = 2;
            this.textBoxBTopRight.Text = "4";
            this.textBoxBTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBBotRight
            // 
            this.textBoxBBotRight.Location = new System.Drawing.Point(161, 39);
            this.textBoxBBotRight.Name = "textBoxBBotRight";
            this.textBoxBBotRight.Size = new System.Drawing.Size(50, 20);
            this.textBoxBBotRight.TabIndex = 3;
            this.textBoxBBotRight.Text = "5";
            this.textBoxBBotRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbFuzzyNumberA
            // 
            this.grbFuzzyNumberA.Controls.Add(this.lblInvalidNumA);
            this.grbFuzzyNumberA.Controls.Add(this.textBoxATopLeft);
            this.grbFuzzyNumberA.Controls.Add(this.textBoxABotLeft);
            this.grbFuzzyNumberA.Controls.Add(this.textBoxATopRight);
            this.grbFuzzyNumberA.Controls.Add(this.textBoxABotRight);
            this.grbFuzzyNumberA.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFuzzyNumberA.Location = new System.Drawing.Point(3, 16);
            this.grbFuzzyNumberA.Name = "grbFuzzyNumberA";
            this.grbFuzzyNumberA.Size = new System.Drawing.Size(240, 69);
            this.grbFuzzyNumberA.TabIndex = 0;
            this.grbFuzzyNumberA.TabStop = false;
            this.grbFuzzyNumberA.Text = "A";
            // 
            // lblInvalidNumA
            // 
            this.lblInvalidNumA.AutoSize = true;
            this.lblInvalidNumA.Location = new System.Drawing.Point(3, 15);
            this.lblInvalidNumA.Name = "lblInvalidNumA";
            this.lblInvalidNumA.Size = new System.Drawing.Size(10, 13);
            this.lblInvalidNumA.TabIndex = 4;
            this.lblInvalidNumA.Text = " ";
            // 
            // textBoxATopLeft
            // 
            this.textBoxATopLeft.Location = new System.Drawing.Point(49, 15);
            this.textBoxATopLeft.Name = "textBoxATopLeft";
            this.textBoxATopLeft.Size = new System.Drawing.Size(50, 20);
            this.textBoxATopLeft.TabIndex = 1;
            this.textBoxATopLeft.Text = "1";
            this.textBoxATopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxABotLeft
            // 
            this.textBoxABotLeft.Location = new System.Drawing.Point(13, 39);
            this.textBoxABotLeft.Name = "textBoxABotLeft";
            this.textBoxABotLeft.Size = new System.Drawing.Size(50, 20);
            this.textBoxABotLeft.TabIndex = 0;
            this.textBoxABotLeft.Text = "-1";
            this.textBoxABotLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxATopRight
            // 
            this.textBoxATopRight.Location = new System.Drawing.Point(125, 15);
            this.textBoxATopRight.Name = "textBoxATopRight";
            this.textBoxATopRight.Size = new System.Drawing.Size(50, 20);
            this.textBoxATopRight.TabIndex = 2;
            this.textBoxATopRight.Text = "1";
            this.textBoxATopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxABotRight
            // 
            this.textBoxABotRight.Location = new System.Drawing.Point(161, 39);
            this.textBoxABotRight.Name = "textBoxABotRight";
            this.textBoxABotRight.Size = new System.Drawing.Size(50, 20);
            this.textBoxABotRight.TabIndex = 3;
            this.textBoxABotRight.Text = "2";
            this.textBoxABotRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbOperation
            // 
            this.grbOperation.Controls.Add(this.checkBoxOperationDiv);
            this.grbOperation.Controls.Add(this.checkBoxOperationMul);
            this.grbOperation.Controls.Add(this.checkBoxOperationSub);
            this.grbOperation.Controls.Add(this.checkBoxOperationAdd);
            this.grbOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbOperation.Location = new System.Drawing.Point(0, 65);
            this.grbOperation.Name = "grbOperation";
            this.grbOperation.Size = new System.Drawing.Size(246, 110);
            this.grbOperation.TabIndex = 1;
            this.grbOperation.TabStop = false;
            this.grbOperation.Text = "Operations";
            // 
            // checkBoxOperationDiv
            // 
            this.checkBoxOperationDiv.AutoSize = true;
            this.checkBoxOperationDiv.Location = new System.Drawing.Point(12, 89);
            this.checkBoxOperationDiv.Name = "checkBoxOperationDiv";
            this.checkBoxOperationDiv.Size = new System.Drawing.Size(63, 17);
            this.checkBoxOperationDiv.TabIndex = 8;
            this.checkBoxOperationDiv.Text = "Division";
            this.checkBoxOperationDiv.UseVisualStyleBackColor = true;
            // 
            // checkBoxOperationMul
            // 
            this.checkBoxOperationMul.AutoSize = true;
            this.checkBoxOperationMul.Location = new System.Drawing.Point(12, 66);
            this.checkBoxOperationMul.Name = "checkBoxOperationMul";
            this.checkBoxOperationMul.Size = new System.Drawing.Size(87, 17);
            this.checkBoxOperationMul.TabIndex = 7;
            this.checkBoxOperationMul.Text = "Multiplication";
            this.checkBoxOperationMul.UseVisualStyleBackColor = true;
            // 
            // checkBoxOperationSub
            // 
            this.checkBoxOperationSub.AutoSize = true;
            this.checkBoxOperationSub.Location = new System.Drawing.Point(12, 43);
            this.checkBoxOperationSub.Name = "checkBoxOperationSub";
            this.checkBoxOperationSub.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOperationSub.TabIndex = 6;
            this.checkBoxOperationSub.Text = "Subtraction";
            this.checkBoxOperationSub.UseVisualStyleBackColor = true;
            // 
            // checkBoxOperationAdd
            // 
            this.checkBoxOperationAdd.AutoSize = true;
            this.checkBoxOperationAdd.Checked = true;
            this.checkBoxOperationAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOperationAdd.Location = new System.Drawing.Point(12, 20);
            this.checkBoxOperationAdd.Name = "checkBoxOperationAdd";
            this.checkBoxOperationAdd.Size = new System.Drawing.Size(64, 17);
            this.checkBoxOperationAdd.TabIndex = 5;
            this.checkBoxOperationAdd.Text = "Addition";
            this.checkBoxOperationAdd.UseVisualStyleBackColor = true;
            // 
            // grbBase
            // 
            this.grbBase.Controls.Add(this.optionBoxIntervalBased);
            this.grbBase.Controls.Add(this.optionBoxEPBased);
            this.grbBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbBase.Location = new System.Drawing.Point(0, 0);
            this.grbBase.Name = "grbBase";
            this.grbBase.Size = new System.Drawing.Size(246, 65);
            this.grbBase.TabIndex = 0;
            this.grbBase.TabStop = false;
            this.grbBase.Text = "Base";
            // 
            // optionBoxIntervalBased
            // 
            this.optionBoxIntervalBased.AutoSize = true;
            this.optionBoxIntervalBased.Location = new System.Drawing.Point(12, 42);
            this.optionBoxIntervalBased.Name = "optionBoxIntervalBased";
            this.optionBoxIntervalBased.Size = new System.Drawing.Size(109, 17);
            this.optionBoxIntervalBased.TabIndex = 2;
            this.optionBoxIntervalBased.Text = "Interval Arithmetic";
            this.optionBoxIntervalBased.UseVisualStyleBackColor = true;
            // 
            // optionBoxEPBased
            // 
            this.optionBoxEPBased.AutoSize = true;
            this.optionBoxEPBased.Checked = true;
            this.optionBoxEPBased.Location = new System.Drawing.Point(12, 19);
            this.optionBoxEPBased.Name = "optionBoxEPBased";
            this.optionBoxEPBased.Size = new System.Drawing.Size(114, 17);
            this.optionBoxEPBased.TabIndex = 1;
            this.optionBoxEPBased.TabStop = true;
            this.optionBoxEPBased.Text = "Extension Principle";
            this.optionBoxEPBased.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chartFuzzy);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(246, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(873, 637);
            this.pnlMain.TabIndex = 1;
            // 
            // chartFuzzy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFuzzy.ChartAreas.Add(chartArea1);
            this.chartFuzzy.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFuzzy.Legends.Add(legend1);
            this.chartFuzzy.Location = new System.Drawing.Point(0, 0);
            this.chartFuzzy.Name = "chartFuzzy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFuzzy.Series.Add(series1);
            this.chartFuzzy.Size = new System.Drawing.Size(873, 637);
            this.chartFuzzy.TabIndex = 0;
            this.chartFuzzy.Text = "chart1";
            // 
            // epInValid
            // 
            this.epInValid.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epInValid.ContainerControl = this;
            this.epInValid.Icon = ((System.Drawing.Icon)(resources.GetObject("epInValid.Icon")));
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(246, 69);
            this.textBoxLog.TabIndex = 0;
            // 
            // textBoxNumOfFracDigi
            // 
            this.textBoxNumOfFracDigi.Location = new System.Drawing.Point(128, 42);
            this.textBoxNumOfFracDigi.Name = "textBoxNumOfFracDigi";
            this.textBoxNumOfFracDigi.Size = new System.Drawing.Size(86, 20);
            this.textBoxNumOfFracDigi.TabIndex = 2;
            this.textBoxNumOfFracDigi.Text = "2";
            this.textBoxNumOfFracDigi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of fractional digits (in round number)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxDrawLine
            // 
            this.checkBoxDrawLine.AutoSize = true;
            this.checkBoxDrawLine.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDrawLine.Checked = true;
            this.checkBoxDrawLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawLine.Location = new System.Drawing.Point(72, 72);
            this.checkBoxDrawLine.Name = "checkBoxDrawLine";
            this.checkBoxDrawLine.Size = new System.Drawing.Size(70, 17);
            this.checkBoxDrawLine.TabIndex = 4;
            this.checkBoxDrawLine.Text = "Draw line";
            this.checkBoxDrawLine.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 637);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FuzzyNumberCalc";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.grbFooter.ResumeLayout(false);
            this.grbParameters.ResumeLayout(false);
            this.grbParameters.PerformLayout();
            this.grbFuzzyNumber.ResumeLayout(false);
            this.grbFuzzyNumberB.ResumeLayout(false);
            this.grbFuzzyNumberB.PerformLayout();
            this.grbFuzzyNumberA.ResumeLayout(false);
            this.grbFuzzyNumberA.PerformLayout();
            this.grbOperation.ResumeLayout(false);
            this.grbOperation.PerformLayout();
            this.grbBase.ResumeLayout(false);
            this.grbBase.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFuzzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grbBase;
        private System.Windows.Forms.RadioButton optionBoxIntervalBased;
        private System.Windows.Forms.RadioButton optionBoxEPBased;
        private System.Windows.Forms.GroupBox grbOperation;
        private System.Windows.Forms.GroupBox grbFuzzyNumber;
        private System.Windows.Forms.TextBox textBoxABotRight;
        private System.Windows.Forms.TextBox textBoxATopRight;
        private System.Windows.Forms.TextBox textBoxATopLeft;
        private System.Windows.Forms.TextBox textBoxABotLeft;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox grbFuzzyNumberB;
        private System.Windows.Forms.TextBox textBoxBTopLeft;
        private System.Windows.Forms.TextBox textBoxBBotLeft;
        private System.Windows.Forms.TextBox textBoxBTopRight;
        private System.Windows.Forms.TextBox textBoxBBotRight;
        private System.Windows.Forms.GroupBox grbFuzzyNumberA;
        private System.Windows.Forms.GroupBox grbFooter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuzzy;
        private System.Windows.Forms.ErrorProvider epInValid;
        private System.Windows.Forms.Label lblInvalidNumB;
        private System.Windows.Forms.Label lblInvalidNumA;
        private System.Windows.Forms.CheckBox checkBoxOperationDiv;
        private System.Windows.Forms.CheckBox checkBoxOperationMul;
        private System.Windows.Forms.CheckBox checkBoxOperationSub;
        private System.Windows.Forms.CheckBox checkBoxOperationAdd;
        private System.Windows.Forms.GroupBox grbParameters;
        private System.Windows.Forms.TextBox textBoxSmoothly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxNumOfFracDigi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDrawLine;



    }
}

