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
            this.grbParameters = new System.Windows.Forms.GroupBox();
            this.txtSmooth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbFooter = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.grbFuzzyNumber = new System.Windows.Forms.GroupBox();
            this.grbFuzzyNumberB = new System.Windows.Forms.GroupBox();
            this.lblInvalidNumB = new System.Windows.Forms.Label();
            this.txtBTopLeft = new System.Windows.Forms.TextBox();
            this.txtBBotLeft = new System.Windows.Forms.TextBox();
            this.txtBTopRight = new System.Windows.Forms.TextBox();
            this.txtBBotRight = new System.Windows.Forms.TextBox();
            this.grbFuzzyNumberA = new System.Windows.Forms.GroupBox();
            this.lblInvalidNumA = new System.Windows.Forms.Label();
            this.txtATopLeft = new System.Windows.Forms.TextBox();
            this.txtABotLeft = new System.Windows.Forms.TextBox();
            this.txtATopRight = new System.Windows.Forms.TextBox();
            this.txtABotRight = new System.Windows.Forms.TextBox();
            this.grbOperation = new System.Windows.Forms.GroupBox();
            this.chkOperationDiv = new System.Windows.Forms.CheckBox();
            this.chkOperationMul = new System.Windows.Forms.CheckBox();
            this.chkOperationSub = new System.Windows.Forms.CheckBox();
            this.chkOperationAdd = new System.Windows.Forms.CheckBox();
            this.grbBase = new System.Windows.Forms.GroupBox();
            this.radIntervalBased = new System.Windows.Forms.RadioButton();
            this.radEPBased = new System.Windows.Forms.RadioButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.chartFuzzy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.epInValid = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.grbParameters.SuspendLayout();
            this.grbFooter.SuspendLayout();
            this.grbFuzzyNumber.SuspendLayout();
            this.grbFuzzyNumberB.SuspendLayout();
            this.grbFuzzyNumberA.SuspendLayout();
            this.grbOperation.SuspendLayout();
            this.grbBase.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuzzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInValid)).BeginInit();
            this.pnlBottom.SuspendLayout();
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
            this.pnlLeft.Size = new System.Drawing.Size(246, 532);
            this.pnlLeft.TabIndex = 0;
            // 
            // grbParameters
            // 
            this.grbParameters.Controls.Add(this.txtSmooth);
            this.grbParameters.Controls.Add(this.label1);
            this.grbParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbParameters.Location = new System.Drawing.Point(0, 345);
            this.grbParameters.Name = "grbParameters";
            this.grbParameters.Size = new System.Drawing.Size(246, 66);
            this.grbParameters.TabIndex = 5;
            this.grbParameters.TabStop = false;
            this.grbParameters.Text = "Parameters";
            // 
            // txtSmooth
            // 
            this.txtSmooth.Location = new System.Drawing.Point(128, 26);
            this.txtSmooth.Name = "txtSmooth";
            this.txtSmooth.Size = new System.Drawing.Size(86, 20);
            this.txtSmooth.TabIndex = 1;
            this.txtSmooth.Text = "0.05";
            this.txtSmooth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smoothly";
            // 
            // grbFooter
            // 
            this.grbFooter.Controls.Add(this.buttonOK);
            this.grbFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFooter.Location = new System.Drawing.Point(0, 411);
            this.grbFooter.Name = "grbFooter";
            this.grbFooter.Size = new System.Drawing.Size(246, 47);
            this.grbFooter.TabIndex = 4;
            this.grbFooter.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(159, 15);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // grbFuzzyNumber
            // 
            this.grbFuzzyNumber.Controls.Add(this.grbFuzzyNumberB);
            this.grbFuzzyNumber.Controls.Add(this.grbFuzzyNumberA);
            this.grbFuzzyNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFuzzyNumber.Location = new System.Drawing.Point(0, 185);
            this.grbFuzzyNumber.Name = "grbFuzzyNumber";
            this.grbFuzzyNumber.Size = new System.Drawing.Size(246, 160);
            this.grbFuzzyNumber.TabIndex = 2;
            this.grbFuzzyNumber.TabStop = false;
            this.grbFuzzyNumber.Text = "Fuzzy Numbers";
            // 
            // grbFuzzyNumberB
            // 
            this.grbFuzzyNumberB.Controls.Add(this.lblInvalidNumB);
            this.grbFuzzyNumberB.Controls.Add(this.txtBTopLeft);
            this.grbFuzzyNumberB.Controls.Add(this.txtBBotLeft);
            this.grbFuzzyNumberB.Controls.Add(this.txtBTopRight);
            this.grbFuzzyNumberB.Controls.Add(this.txtBBotRight);
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
            // txtBTopLeft
            // 
            this.txtBTopLeft.Location = new System.Drawing.Point(49, 15);
            this.txtBTopLeft.Name = "txtBTopLeft";
            this.txtBTopLeft.Size = new System.Drawing.Size(50, 20);
            this.txtBTopLeft.TabIndex = 1;
            this.txtBTopLeft.Text = "3";
            this.txtBTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBBotLeft
            // 
            this.txtBBotLeft.Location = new System.Drawing.Point(13, 41);
            this.txtBBotLeft.Name = "txtBBotLeft";
            this.txtBBotLeft.Size = new System.Drawing.Size(50, 20);
            this.txtBBotLeft.TabIndex = 0;
            this.txtBBotLeft.Text = "-2";
            this.txtBBotLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBTopRight
            // 
            this.txtBTopRight.Location = new System.Drawing.Point(125, 15);
            this.txtBTopRight.Name = "txtBTopRight";
            this.txtBTopRight.Size = new System.Drawing.Size(50, 20);
            this.txtBTopRight.TabIndex = 2;
            this.txtBTopRight.Text = "4";
            this.txtBTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBBotRight
            // 
            this.txtBBotRight.Location = new System.Drawing.Point(161, 41);
            this.txtBBotRight.Name = "txtBBotRight";
            this.txtBBotRight.Size = new System.Drawing.Size(50, 20);
            this.txtBBotRight.TabIndex = 3;
            this.txtBBotRight.Text = "5";
            this.txtBBotRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbFuzzyNumberA
            // 
            this.grbFuzzyNumberA.Controls.Add(this.lblInvalidNumA);
            this.grbFuzzyNumberA.Controls.Add(this.txtATopLeft);
            this.grbFuzzyNumberA.Controls.Add(this.txtABotLeft);
            this.grbFuzzyNumberA.Controls.Add(this.txtATopRight);
            this.grbFuzzyNumberA.Controls.Add(this.txtABotRight);
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
            // txtATopLeft
            // 
            this.txtATopLeft.Location = new System.Drawing.Point(49, 15);
            this.txtATopLeft.Name = "txtATopLeft";
            this.txtATopLeft.Size = new System.Drawing.Size(50, 20);
            this.txtATopLeft.TabIndex = 1;
            this.txtATopLeft.Text = "1";
            this.txtATopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtABotLeft
            // 
            this.txtABotLeft.Location = new System.Drawing.Point(13, 39);
            this.txtABotLeft.Name = "txtABotLeft";
            this.txtABotLeft.Size = new System.Drawing.Size(50, 20);
            this.txtABotLeft.TabIndex = 0;
            this.txtABotLeft.Text = "-1";
            this.txtABotLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtATopRight
            // 
            this.txtATopRight.Location = new System.Drawing.Point(125, 15);
            this.txtATopRight.Name = "txtATopRight";
            this.txtATopRight.Size = new System.Drawing.Size(50, 20);
            this.txtATopRight.TabIndex = 2;
            this.txtATopRight.Text = "1";
            this.txtATopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtABotRight
            // 
            this.txtABotRight.Location = new System.Drawing.Point(161, 39);
            this.txtABotRight.Name = "txtABotRight";
            this.txtABotRight.Size = new System.Drawing.Size(50, 20);
            this.txtABotRight.TabIndex = 3;
            this.txtABotRight.Text = "2";
            this.txtABotRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbOperation
            // 
            this.grbOperation.Controls.Add(this.chkOperationDiv);
            this.grbOperation.Controls.Add(this.chkOperationMul);
            this.grbOperation.Controls.Add(this.chkOperationSub);
            this.grbOperation.Controls.Add(this.chkOperationAdd);
            this.grbOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbOperation.Location = new System.Drawing.Point(0, 69);
            this.grbOperation.Name = "grbOperation";
            this.grbOperation.Size = new System.Drawing.Size(246, 116);
            this.grbOperation.TabIndex = 1;
            this.grbOperation.TabStop = false;
            this.grbOperation.Text = "Operations";
            // 
            // chkOperationDiv
            // 
            this.chkOperationDiv.AutoSize = true;
            this.chkOperationDiv.Location = new System.Drawing.Point(12, 89);
            this.chkOperationDiv.Name = "chkOperationDiv";
            this.chkOperationDiv.Size = new System.Drawing.Size(63, 17);
            this.chkOperationDiv.TabIndex = 8;
            this.chkOperationDiv.Text = "Division";
            this.chkOperationDiv.UseVisualStyleBackColor = true;
            // 
            // chkOperationMul
            // 
            this.chkOperationMul.AutoSize = true;
            this.chkOperationMul.Location = new System.Drawing.Point(12, 66);
            this.chkOperationMul.Name = "chkOperationMul";
            this.chkOperationMul.Size = new System.Drawing.Size(87, 17);
            this.chkOperationMul.TabIndex = 7;
            this.chkOperationMul.Text = "Multiplication";
            this.chkOperationMul.UseVisualStyleBackColor = true;
            // 
            // chkOperationSub
            // 
            this.chkOperationSub.AutoSize = true;
            this.chkOperationSub.Location = new System.Drawing.Point(12, 43);
            this.chkOperationSub.Name = "chkOperationSub";
            this.chkOperationSub.Size = new System.Drawing.Size(80, 17);
            this.chkOperationSub.TabIndex = 6;
            this.chkOperationSub.Text = "Subtraction";
            this.chkOperationSub.UseVisualStyleBackColor = true;
            // 
            // chkOperationAdd
            // 
            this.chkOperationAdd.AutoSize = true;
            this.chkOperationAdd.Checked = true;
            this.chkOperationAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOperationAdd.Location = new System.Drawing.Point(12, 20);
            this.chkOperationAdd.Name = "chkOperationAdd";
            this.chkOperationAdd.Size = new System.Drawing.Size(64, 17);
            this.chkOperationAdd.TabIndex = 5;
            this.chkOperationAdd.Text = "Addition";
            this.chkOperationAdd.UseVisualStyleBackColor = true;
            // 
            // grbBase
            // 
            this.grbBase.Controls.Add(this.radIntervalBased);
            this.grbBase.Controls.Add(this.radEPBased);
            this.grbBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbBase.Location = new System.Drawing.Point(0, 0);
            this.grbBase.Name = "grbBase";
            this.grbBase.Size = new System.Drawing.Size(246, 69);
            this.grbBase.TabIndex = 0;
            this.grbBase.TabStop = false;
            this.grbBase.Text = "Base";
            // 
            // radIntervalBased
            // 
            this.radIntervalBased.AutoSize = true;
            this.radIntervalBased.Checked = true;
            this.radIntervalBased.Location = new System.Drawing.Point(12, 42);
            this.radIntervalBased.Name = "radIntervalBased";
            this.radIntervalBased.Size = new System.Drawing.Size(109, 17);
            this.radIntervalBased.TabIndex = 2;
            this.radIntervalBased.TabStop = true;
            this.radIntervalBased.Text = "Interval Arithmetic";
            this.radIntervalBased.UseVisualStyleBackColor = true;
            // 
            // radEPBased
            // 
            this.radEPBased.AutoSize = true;
            this.radEPBased.Location = new System.Drawing.Point(12, 19);
            this.radEPBased.Name = "radEPBased";
            this.radEPBased.Size = new System.Drawing.Size(114, 17);
            this.radEPBased.TabIndex = 1;
            this.radEPBased.Text = "Extension Principle";
            this.radEPBased.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chartFuzzy);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(246, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(675, 532);
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
            this.chartFuzzy.Size = new System.Drawing.Size(675, 532);
            this.chartFuzzy.TabIndex = 0;
            this.chartFuzzy.Text = "chart1";
            // 
            // epInValid
            // 
            this.epInValid.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epInValid.ContainerControl = this;
            this.epInValid.Icon = ((System.Drawing.Icon)(resources.GetObject("epInValid.Icon")));
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblInfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 501);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(246, 31);
            this.pnlBottom.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(246, 31);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Just an assignment in class ^o^";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 532);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FuzzyNumberCalc";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.grbParameters.ResumeLayout(false);
            this.grbParameters.PerformLayout();
            this.grbFooter.ResumeLayout(false);
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
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grbBase;
        private System.Windows.Forms.RadioButton radIntervalBased;
        private System.Windows.Forms.RadioButton radEPBased;
        private System.Windows.Forms.GroupBox grbOperation;
        private System.Windows.Forms.GroupBox grbFuzzyNumber;
        private System.Windows.Forms.TextBox txtABotRight;
        private System.Windows.Forms.TextBox txtATopRight;
        private System.Windows.Forms.TextBox txtATopLeft;
        private System.Windows.Forms.TextBox txtABotLeft;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox grbFuzzyNumberB;
        private System.Windows.Forms.TextBox txtBTopLeft;
        private System.Windows.Forms.TextBox txtBBotLeft;
        private System.Windows.Forms.TextBox txtBTopRight;
        private System.Windows.Forms.TextBox txtBBotRight;
        private System.Windows.Forms.GroupBox grbFuzzyNumberA;
        private System.Windows.Forms.GroupBox grbFooter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuzzy;
        private System.Windows.Forms.ErrorProvider epInValid;
        private System.Windows.Forms.Label lblInvalidNumB;
        private System.Windows.Forms.Label lblInvalidNumA;
        private System.Windows.Forms.CheckBox chkOperationDiv;
        private System.Windows.Forms.CheckBox chkOperationMul;
        private System.Windows.Forms.CheckBox chkOperationSub;
        private System.Windows.Forms.CheckBox chkOperationAdd;
        private System.Windows.Forms.GroupBox grbParameters;
        private System.Windows.Forms.TextBox txtSmooth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblInfo;



    }
}

