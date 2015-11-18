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
            this.grbFooter = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grbFuzzyNumber = new System.Windows.Forms.GroupBox();
            this.grbFuzzyNumberB = new System.Windows.Forms.GroupBox();
            this.txtBTopLeft = new System.Windows.Forms.TextBox();
            this.txtBBotLeft = new System.Windows.Forms.TextBox();
            this.txtBTopRight = new System.Windows.Forms.TextBox();
            this.txtBBotRight = new System.Windows.Forms.TextBox();
            this.grbFuzzyNumberA = new System.Windows.Forms.GroupBox();
            this.txtATopLeft = new System.Windows.Forms.TextBox();
            this.txtABotLeft = new System.Windows.Forms.TextBox();
            this.txtATopRight = new System.Windows.Forms.TextBox();
            this.txtABotRight = new System.Windows.Forms.TextBox();
            this.grbOperation = new System.Windows.Forms.GroupBox();
            this.radOperationDiv = new System.Windows.Forms.RadioButton();
            this.radOperationMul = new System.Windows.Forms.RadioButton();
            this.radOperationSub = new System.Windows.Forms.RadioButton();
            this.radOperationAdd = new System.Windows.Forms.RadioButton();
            this.grbBase = new System.Windows.Forms.GroupBox();
            this.radIntervalBased = new System.Windows.Forms.RadioButton();
            this.radEPBased = new System.Windows.Forms.RadioButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.chartFuzzy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.epValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLeft.SuspendLayout();
            this.grbFooter.SuspendLayout();
            this.grbFuzzyNumber.SuspendLayout();
            this.grbFuzzyNumberB.SuspendLayout();
            this.grbFuzzyNumberA.SuspendLayout();
            this.grbOperation.SuspendLayout();
            this.grbBase.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuzzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grbFooter);
            this.pnlLeft.Controls.Add(this.grbFuzzyNumber);
            this.pnlLeft.Controls.Add(this.grbOperation);
            this.pnlLeft.Controls.Add(this.grbBase);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(246, 409);
            this.pnlLeft.TabIndex = 0;
            // 
            // grbFooter
            // 
            this.grbFooter.Controls.Add(this.button1);
            this.grbFooter.Controls.Add(this.btnOK);
            this.grbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbFooter.Location = new System.Drawing.Point(0, 362);
            this.grbFooter.Name = "grbFooter";
            this.grbFooter.Size = new System.Drawing.Size(246, 47);
            this.grbFooter.TabIndex = 4;
            this.grbFooter.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(159, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.txtBBotLeft.Text = "2";
            this.txtBBotLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBTopRight
            // 
            this.txtBTopRight.Location = new System.Drawing.Point(125, 15);
            this.txtBTopRight.Name = "txtBTopRight";
            this.txtBTopRight.Size = new System.Drawing.Size(50, 20);
            this.txtBTopRight.TabIndex = 2;
            this.txtBTopRight.Text = "3";
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
            // txtATopLeft
            // 
            this.txtATopLeft.Location = new System.Drawing.Point(49, 15);
            this.txtATopLeft.Name = "txtATopLeft";
            this.txtATopLeft.Size = new System.Drawing.Size(50, 20);
            this.txtATopLeft.TabIndex = 1;
            this.txtATopLeft.Text = "3";
            this.txtATopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtABotLeft
            // 
            this.txtABotLeft.Location = new System.Drawing.Point(13, 39);
            this.txtABotLeft.Name = "txtABotLeft";
            this.txtABotLeft.Size = new System.Drawing.Size(50, 20);
            this.txtABotLeft.TabIndex = 0;
            this.txtABotLeft.Text = "1";
            this.txtABotLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtATopRight
            // 
            this.txtATopRight.Location = new System.Drawing.Point(125, 15);
            this.txtATopRight.Name = "txtATopRight";
            this.txtATopRight.Size = new System.Drawing.Size(50, 20);
            this.txtATopRight.TabIndex = 2;
            this.txtATopRight.Text = "3.5";
            this.txtATopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtABotRight
            // 
            this.txtABotRight.Location = new System.Drawing.Point(161, 39);
            this.txtABotRight.Name = "txtABotRight";
            this.txtABotRight.Size = new System.Drawing.Size(50, 20);
            this.txtABotRight.TabIndex = 3;
            this.txtABotRight.Text = "5";
            this.txtABotRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbOperation
            // 
            this.grbOperation.Controls.Add(this.radOperationDiv);
            this.grbOperation.Controls.Add(this.radOperationMul);
            this.grbOperation.Controls.Add(this.radOperationSub);
            this.grbOperation.Controls.Add(this.radOperationAdd);
            this.grbOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbOperation.Location = new System.Drawing.Point(0, 69);
            this.grbOperation.Name = "grbOperation";
            this.grbOperation.Size = new System.Drawing.Size(246, 116);
            this.grbOperation.TabIndex = 1;
            this.grbOperation.TabStop = false;
            this.grbOperation.Text = "Operations";
            // 
            // radOperationDiv
            // 
            this.radOperationDiv.AutoSize = true;
            this.radOperationDiv.Location = new System.Drawing.Point(12, 88);
            this.radOperationDiv.Name = "radOperationDiv";
            this.radOperationDiv.Size = new System.Drawing.Size(62, 17);
            this.radOperationDiv.TabIndex = 4;
            this.radOperationDiv.Text = "Division";
            this.radOperationDiv.UseVisualStyleBackColor = true;
            // 
            // radOperationMul
            // 
            this.radOperationMul.AutoSize = true;
            this.radOperationMul.Location = new System.Drawing.Point(12, 65);
            this.radOperationMul.Name = "radOperationMul";
            this.radOperationMul.Size = new System.Drawing.Size(86, 17);
            this.radOperationMul.TabIndex = 3;
            this.radOperationMul.Text = "Multiplication";
            this.radOperationMul.UseVisualStyleBackColor = true;
            // 
            // radOperationSub
            // 
            this.radOperationSub.AutoSize = true;
            this.radOperationSub.Location = new System.Drawing.Point(12, 42);
            this.radOperationSub.Name = "radOperationSub";
            this.radOperationSub.Size = new System.Drawing.Size(79, 17);
            this.radOperationSub.TabIndex = 2;
            this.radOperationSub.Text = "Subtraction";
            this.radOperationSub.UseVisualStyleBackColor = true;
            // 
            // radOperationAdd
            // 
            this.radOperationAdd.AutoSize = true;
            this.radOperationAdd.Checked = true;
            this.radOperationAdd.Location = new System.Drawing.Point(12, 19);
            this.radOperationAdd.Name = "radOperationAdd";
            this.radOperationAdd.Size = new System.Drawing.Size(63, 17);
            this.radOperationAdd.TabIndex = 1;
            this.radOperationAdd.TabStop = true;
            this.radOperationAdd.Text = "Addition";
            this.radOperationAdd.UseVisualStyleBackColor = true;
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
            this.radIntervalBased.Location = new System.Drawing.Point(12, 42);
            this.radIntervalBased.Name = "radIntervalBased";
            this.radIntervalBased.Size = new System.Drawing.Size(109, 17);
            this.radIntervalBased.TabIndex = 2;
            this.radIntervalBased.Text = "Interval Arithmetic";
            this.radIntervalBased.UseVisualStyleBackColor = true;
            // 
            // radEPBased
            // 
            this.radEPBased.AutoSize = true;
            this.radEPBased.Checked = true;
            this.radEPBased.Location = new System.Drawing.Point(12, 19);
            this.radEPBased.Name = "radEPBased";
            this.radEPBased.Size = new System.Drawing.Size(114, 17);
            this.radEPBased.TabIndex = 1;
            this.radEPBased.TabStop = true;
            this.radEPBased.Text = "Extension Principle";
            this.radEPBased.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chartFuzzy);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(246, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(675, 409);
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
            this.chartFuzzy.Size = new System.Drawing.Size(675, 409);
            this.chartFuzzy.TabIndex = 0;
            this.chartFuzzy.Text = "chart1";
            // 
            // epValidate
            // 
            this.epValidate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epValidate.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 409);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FuzzyNumberCalc";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlLeft.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.epValidate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grbBase;
        private System.Windows.Forms.RadioButton radIntervalBased;
        private System.Windows.Forms.RadioButton radEPBased;
        private System.Windows.Forms.GroupBox grbOperation;
        private System.Windows.Forms.RadioButton radOperationSub;
        private System.Windows.Forms.RadioButton radOperationAdd;
        private System.Windows.Forms.RadioButton radOperationDiv;
        private System.Windows.Forms.RadioButton radOperationMul;
        private System.Windows.Forms.GroupBox grbFuzzyNumber;
        private System.Windows.Forms.TextBox txtABotRight;
        private System.Windows.Forms.TextBox txtATopRight;
        private System.Windows.Forms.TextBox txtATopLeft;
        private System.Windows.Forms.TextBox txtABotLeft;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grbFuzzyNumberB;
        private System.Windows.Forms.TextBox txtBTopLeft;
        private System.Windows.Forms.TextBox txtBBotLeft;
        private System.Windows.Forms.TextBox txtBTopRight;
        private System.Windows.Forms.TextBox txtBBotRight;
        private System.Windows.Forms.GroupBox grbFuzzyNumberA;
        private System.Windows.Forms.GroupBox grbFooter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuzzy;
        private System.Windows.Forms.ErrorProvider epValidate;
        private System.Windows.Forms.Button button1;



    }
}

