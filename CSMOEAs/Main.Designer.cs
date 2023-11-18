﻿namespace MOEAPlat
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Mchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataShow = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.combNormalization = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combCrossoverType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combDisplayProcess = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combAggFunction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combPopsize = new System.Windows.Forms.ComboBox();
            this.combDimension = new System.Windows.Forms.ComboBox();
            this.btnAddObj = new System.Windows.Forms.Button();
            this.labelDimension = new System.Windows.Forms.Label();
            this.comBoxAlg = new System.Windows.Forms.ComboBox();
            this.comBoxMOP = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtGeneration = new System.Windows.Forms.TextBox();
            this.labelPopsize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.GenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ucBackPanel = new MOEAPlat.UserControls.ucBackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Mchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Mchart
            // 
            this.Mchart.BackColor = System.Drawing.Color.Transparent;
            this.Mchart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Mchart.ChartAreas.Add(chartArea1);
            this.Mchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.Mchart.Legends.Add(legend1);
            this.Mchart.Location = new System.Drawing.Point(0, 0);
            this.Mchart.Margin = new System.Windows.Forms.Padding(2);
            this.Mchart.Name = "Mchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Mchart.Series.Add(series1);
            this.Mchart.Size = new System.Drawing.Size(553, 320);
            this.Mchart.TabIndex = 0;
            this.Mchart.Text = "chart1";
            this.Mchart.Click += new System.EventHandler(this.Mchart_Click);
            // 
            // DataShow
            // 
            this.DataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataShow.Location = new System.Drawing.Point(0, 0);
            this.DataShow.Margin = new System.Windows.Forms.Padding(2);
            this.DataShow.Name = "DataShow";
            this.DataShow.ReadOnly = true;
            this.DataShow.RowHeadersWidth = 62;
            this.DataShow.RowTemplate.Height = 30;
            this.DataShow.Size = new System.Drawing.Size(383, 295);
            this.DataShow.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(934, 618);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.combNormalization);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.combCrossoverType);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.combDisplayProcess);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.combAggFunction);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.combPopsize);
            this.splitContainer2.Panel1.Controls.Add(this.combDimension);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddObj);
            this.splitContainer2.Panel1.Controls.Add(this.labelDimension);
            this.splitContainer2.Panel1.Controls.Add(this.comBoxAlg);
            this.splitContainer2.Panel1.Controls.Add(this.comBoxMOP);
            this.splitContainer2.Panel1.Controls.Add(this.btnExecute);
            this.splitContainer2.Panel1.Controls.Add(this.txtGeneration);
            this.splitContainer2.Panel1.Controls.Add(this.labelPopsize);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Mchart);
            this.splitContainer2.Size = new System.Drawing.Size(934, 320);
            this.splitContainer2.SplitterDistance = 378;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // combNormalization
            // 
            this.combNormalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combNormalization.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combNormalization.FormattingEnabled = true;
            this.combNormalization.Items.AddRange(new object[] {
            "True",
            "False"});
            this.combNormalization.Location = new System.Drawing.Point(147, 237);
            this.combNormalization.Margin = new System.Windows.Forms.Padding(2);
            this.combNormalization.Name = "combNormalization";
            this.combNormalization.Size = new System.Drawing.Size(114, 23);
            this.combNormalization.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Normalization:";
            // 
            // combCrossoverType
            // 
            this.combCrossoverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCrossoverType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCrossoverType.FormattingEnabled = true;
            this.combCrossoverType.Items.AddRange(new object[] {
            "SBX",
            "DE"});
            this.combCrossoverType.Location = new System.Drawing.Point(146, 185);
            this.combCrossoverType.Margin = new System.Windows.Forms.Padding(2);
            this.combCrossoverType.Name = "combCrossoverType";
            this.combCrossoverType.Size = new System.Drawing.Size(115, 23);
            this.combCrossoverType.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Crossover Type:";
            // 
            // combDisplayProcess
            // 
            this.combDisplayProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDisplayProcess.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combDisplayProcess.FormattingEnabled = true;
            this.combDisplayProcess.Items.AddRange(new object[] {
            "True",
            "False"});
            this.combDisplayProcess.Location = new System.Drawing.Point(146, 211);
            this.combDisplayProcess.Margin = new System.Windows.Forms.Padding(2);
            this.combDisplayProcess.Name = "combDisplayProcess";
            this.combDisplayProcess.Size = new System.Drawing.Size(115, 23);
            this.combDisplayProcess.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Display Process:";
            // 
            // combAggFunction
            // 
            this.combAggFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combAggFunction.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAggFunction.FormattingEnabled = true;
            this.combAggFunction.Items.AddRange(new object[] {
            "Weighted Sum Approach",
            "Tchebycheff Approach",
            "PBI Approach"});
            this.combAggFunction.Location = new System.Drawing.Point(146, 158);
            this.combAggFunction.Margin = new System.Windows.Forms.Padding(2);
            this.combAggFunction.Name = "combAggFunction";
            this.combAggFunction.Size = new System.Drawing.Size(115, 23);
            this.combAggFunction.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Aggregation Function:";
            // 
            // combPopsize
            // 
            this.combPopsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combPopsize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combPopsize.FormattingEnabled = true;
            this.combPopsize.Location = new System.Drawing.Point(146, 132);
            this.combPopsize.Margin = new System.Windows.Forms.Padding(2);
            this.combPopsize.Name = "combPopsize";
            this.combPopsize.Size = new System.Drawing.Size(115, 23);
            this.combPopsize.TabIndex = 13;
            // 
            // combDimension
            // 
            this.combDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDimension.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combDimension.FormattingEnabled = true;
            this.combDimension.Location = new System.Drawing.Point(146, 49);
            this.combDimension.Margin = new System.Windows.Forms.Padding(2);
            this.combDimension.Name = "combDimension";
            this.combDimension.Size = new System.Drawing.Size(115, 23);
            this.combDimension.TabIndex = 12;
            // 
            // btnAddObj
            // 
            this.btnAddObj.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObj.Location = new System.Drawing.Point(22, 290);
            this.btnAddObj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddObj.Name = "btnAddObj";
            this.btnAddObj.Size = new System.Drawing.Size(95, 24);
            this.btnAddObj.TabIndex = 11;
            this.btnAddObj.Text = "Add Objection";
            this.btnAddObj.UseVisualStyleBackColor = true;
            this.btnAddObj.Click += new System.EventHandler(this.btnAddObj_Click);
            // 
            // labelDimension
            // 
            this.labelDimension.AutoSize = true;
            this.labelDimension.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDimension.Location = new System.Drawing.Point(12, 49);
            this.labelDimension.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDimension.Name = "labelDimension";
            this.labelDimension.Size = new System.Drawing.Size(107, 15);
            this.labelDimension.TabIndex = 9;
            this.labelDimension.Text = "Obj/Para Dimension:";
            // 
            // comBoxAlg
            // 
            this.comBoxAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxAlg.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxAlg.FormattingEnabled = true;
            this.comBoxAlg.Location = new System.Drawing.Point(146, 77);
            this.comBoxAlg.Margin = new System.Windows.Forms.Padding(2);
            this.comBoxAlg.Name = "comBoxAlg";
            this.comBoxAlg.Size = new System.Drawing.Size(115, 23);
            this.comBoxAlg.TabIndex = 8;
            this.comBoxAlg.SelectedIndexChanged += new System.EventHandler(this.comBoxAlg_SelectedIndexChanged);
            // 
            // comBoxMOP
            // 
            this.comBoxMOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxMOP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMOP.FormattingEnabled = true;
            this.comBoxMOP.Location = new System.Drawing.Point(146, 21);
            this.comBoxMOP.Margin = new System.Windows.Forms.Padding(2);
            this.comBoxMOP.Name = "comBoxMOP";
            this.comBoxMOP.Size = new System.Drawing.Size(115, 23);
            this.comBoxMOP.TabIndex = 7;
            this.comBoxMOP.SelectedIndexChanged += new System.EventHandler(this.comBoxMOP_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(164, 290);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(91, 24);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Run";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtGeneration
            // 
            this.txtGeneration.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneration.Location = new System.Drawing.Point(146, 105);
            this.txtGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.txtGeneration.Name = "txtGeneration";
            this.txtGeneration.Size = new System.Drawing.Size(115, 21);
            this.txtGeneration.TabIndex = 4;
            // 
            // labelPopsize
            // 
            this.labelPopsize.AutoSize = true;
            this.labelPopsize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopsize.Location = new System.Drawing.Point(30, 132);
            this.labelPopsize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPopsize.Name = "labelPopsize";
            this.labelPopsize.Size = new System.Drawing.Size(93, 15);
            this.labelPopsize.TabIndex = 3;
            this.labelPopsize.Text = "Division/Popsize:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "MaxGeneration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Algorithms:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOP:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.DataShow);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.GenChart);
            this.splitContainer3.Size = new System.Drawing.Size(934, 295);
            this.splitContainer3.SplitterDistance = 383;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // GenChart
            // 
            this.GenChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.GenChart.ChartAreas.Add(chartArea2);
            this.GenChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Name = "Legend1";
            this.GenChart.Legends.Add(legend2);
            this.GenChart.Location = new System.Drawing.Point(0, 0);
            this.GenChart.Margin = new System.Windows.Forms.Padding(2);
            this.GenChart.Name = "GenChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GenChart.Series.Add(series2);
            this.GenChart.Size = new System.Drawing.Size(548, 295);
            this.GenChart.TabIndex = 0;
            this.GenChart.Text = "chart1";
            // 
            // ucBackPanel
            // 
            this.ucBackPanel.BackColor = System.Drawing.Color.Transparent;
            this.ucBackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBackPanel.IsShowMinBtn = true;
            this.ucBackPanel.Location = new System.Drawing.Point(0, 0);
            this.ucBackPanel.Margin = new System.Windows.Forms.Padding(1);
            this.ucBackPanel.Name = "ucBackPanel";
            this.ucBackPanel.Size = new System.Drawing.Size(947, 665);
            this.ucBackPanel.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 665);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucBackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GenChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Mchart;
        private System.Windows.Forms.DataGridView DataShow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenChart;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtGeneration;
        private System.Windows.Forms.Label labelPopsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxAlg;
        private System.Windows.Forms.ComboBox comBoxMOP;
        private System.Windows.Forms.Label labelDimension;
        private System.Windows.Forms.Button btnAddObj;
        private System.Windows.Forms.ComboBox combDimension;
        private System.Windows.Forms.ComboBox combPopsize;
        private System.Windows.Forms.ComboBox combDisplayProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combAggFunction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combCrossoverType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combNormalization;
        private System.Windows.Forms.Label label7;
        private UserControls.ucBackPanel ucBackPanel;
    }
}

