namespace TemplateTest
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.nmbNumberOvVertexInGraph = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVertexSize = new System.Windows.Forms.Label();
            this.lblEdgeSize = new System.Windows.Forms.Label();
            this.tmrFast = new System.Windows.Forms.Timer(this.components);
            this.lblGraphParameter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdClearLog = new System.Windows.Forms.Button();
            this.lblGraphInsertTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGraphFindTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGraphFindByValueTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAddTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkPrintLog = new System.Windows.Forms.CheckBox();
            this.chkWriteLog = new System.Windows.Forms.CheckBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrSec = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmbNumberOvVertexInGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vertexs size";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmbNumberOvVertexInGraph
            // 
            this.nmbNumberOvVertexInGraph.Location = new System.Drawing.Point(559, 41);
            this.nmbNumberOvVertexInGraph.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmbNumberOvVertexInGraph.Name = "nmbNumberOvVertexInGraph";
            this.nmbNumberOvVertexInGraph.Size = new System.Drawing.Size(98, 20);
            this.nmbNumberOvVertexInGraph.TabIndex = 1;
            this.nmbNumberOvVertexInGraph.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(663, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "* 100";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(406, 76);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(518, 292);
            this.txtLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "| V | = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "| E | = ";
            // 
            // lblVertexSize
            // 
            this.lblVertexSize.AutoSize = true;
            this.lblVertexSize.Location = new System.Drawing.Point(116, 372);
            this.lblVertexSize.Name = "lblVertexSize";
            this.lblVertexSize.Size = new System.Drawing.Size(13, 13);
            this.lblVertexSize.TabIndex = 6;
            this.lblVertexSize.Text = "0";
            // 
            // lblEdgeSize
            // 
            this.lblEdgeSize.AutoSize = true;
            this.lblEdgeSize.Location = new System.Drawing.Point(116, 390);
            this.lblEdgeSize.Name = "lblEdgeSize";
            this.lblEdgeSize.Size = new System.Drawing.Size(13, 13);
            this.lblEdgeSize.TabIndex = 7;
            this.lblEdgeSize.Text = "0";
            // 
            // tmrFast
            // 
            this.tmrFast.Enabled = true;
            this.tmrFast.Interval = 300;
            this.tmrFast.Tick += new System.EventHandler(this.tmrFast_Tick);
            // 
            // lblGraphParameter
            // 
            this.lblGraphParameter.AutoSize = true;
            this.lblGraphParameter.Location = new System.Drawing.Point(116, 412);
            this.lblGraphParameter.Name = "lblGraphParameter";
            this.lblGraphParameter.Size = new System.Drawing.Size(13, 13);
            this.lblGraphParameter.TabIndex = 9;
            this.lblGraphParameter.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "| V | / | E | = ";
            // 
            // cmdClearLog
            // 
            this.cmdClearLog.Location = new System.Drawing.Point(797, 38);
            this.cmdClearLog.Name = "cmdClearLog";
            this.cmdClearLog.Size = new System.Drawing.Size(75, 23);
            this.cmdClearLog.TabIndex = 10;
            this.cmdClearLog.Text = "Clear";
            this.cmdClearLog.UseVisualStyleBackColor = true;
            this.cmdClearLog.Click += new System.EventHandler(this.cmdClearLog_Click);
            // 
            // lblGraphInsertTime
            // 
            this.lblGraphInsertTime.AutoSize = true;
            this.lblGraphInsertTime.Location = new System.Drawing.Point(283, 390);
            this.lblGraphInsertTime.Name = "lblGraphInsertTime";
            this.lblGraphInsertTime.Size = new System.Drawing.Size(13, 13);
            this.lblGraphInsertTime.TabIndex = 12;
            this.lblGraphInsertTime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "G insert time";
            // 
            // lblGraphFindTime
            // 
            this.lblGraphFindTime.AutoSize = true;
            this.lblGraphFindTime.Location = new System.Drawing.Point(283, 410);
            this.lblGraphFindTime.Name = "lblGraphFindTime";
            this.lblGraphFindTime.Size = new System.Drawing.Size(13, 13);
            this.lblGraphFindTime.TabIndex = 14;
            this.lblGraphFindTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "G find time";
            // 
            // lblGraphFindByValueTime
            // 
            this.lblGraphFindByValueTime.AutoSize = true;
            this.lblGraphFindByValueTime.Location = new System.Drawing.Point(283, 427);
            this.lblGraphFindByValueTime.Name = "lblGraphFindByValueTime";
            this.lblGraphFindByValueTime.Size = new System.Drawing.Size(13, 13);
            this.lblGraphFindByValueTime.TabIndex = 16;
            this.lblGraphFindByValueTime.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "G find time by val";
            // 
            // lblAddTime
            // 
            this.lblAddTime.AutoSize = true;
            this.lblAddTime.Location = new System.Drawing.Point(283, 372);
            this.lblAddTime.Name = "lblAddTime";
            this.lblAddTime.Size = new System.Drawing.Size(13, 13);
            this.lblAddTime.TabIndex = 18;
            this.lblAddTime.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "G add time";
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(536, 371);
            this.chart1.Name = "chart1";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series2";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series3";
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Series.Add(series21);
            this.chart1.Size = new System.Drawing.Size(518, 142);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // chkPrintLog
            // 
            this.chkPrintLog.AutoSize = true;
            this.chkPrintLog.Location = new System.Drawing.Point(807, 12);
            this.chkPrintLog.Name = "chkPrintLog";
            this.chkPrintLog.Size = new System.Drawing.Size(65, 17);
            this.chkPrintLog.TabIndex = 20;
            this.chkPrintLog.Text = "PrintLog";
            this.chkPrintLog.UseVisualStyleBackColor = true;
            // 
            // chkWriteLog
            // 
            this.chkWriteLog.AutoSize = true;
            this.chkWriteLog.Location = new System.Drawing.Point(726, 12);
            this.chkWriteLog.Name = "chkWriteLog";
            this.chkWriteLog.Size = new System.Drawing.Size(69, 17);
            this.chkWriteLog.TabIndex = 21;
            this.chkWriteLog.Text = "WriteLog";
            this.chkWriteLog.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(536, 519);
            this.chart2.Name = "chart2";
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Series1";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Series2";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Series3";
            this.chart2.Series.Add(series22);
            this.chart2.Series.Add(series23);
            this.chart2.Series.Add(series24);
            this.chart2.Size = new System.Drawing.Size(518, 142);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart3.Legends.Add(legend9);
            this.chart3.Location = new System.Drawing.Point(12, 519);
            this.chart3.Name = "chart3";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "Legend1";
            series25.Name = "Series1";
            series26.ChartArea = "ChartArea1";
            series26.Legend = "Legend1";
            series26.Name = "Series2";
            series27.ChartArea = "ChartArea1";
            series27.Legend = "Legend1";
            series27.Name = "Series3";
            this.chart3.Series.Add(series25);
            this.chart3.Series.Add(series26);
            this.chart3.Series.Add(series27);
            this.chart3.Size = new System.Drawing.Size(518, 142);
            this.chart3.TabIndex = 23;
            this.chart3.Text = "chart3";
            // 
            // tmrSec
            // 
            this.tmrSec.Enabled = true;
            this.tmrSec.Interval = 1000;
            this.tmrSec.Tick += new System.EventHandler(this.tmrSec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chkWriteLog);
            this.Controls.Add(this.chkPrintLog);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblAddTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGraphFindByValueTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblGraphFindTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGraphInsertTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdClearLog);
            this.Controls.Add(this.lblGraphParameter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEdgeSize);
            this.Controls.Add(this.lblVertexSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmbNumberOvVertexInGraph);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbNumberOvVertexInGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmbNumberOvVertexInGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVertexSize;
        private System.Windows.Forms.Label lblEdgeSize;
        private System.Windows.Forms.Timer tmrFast;
        private System.Windows.Forms.Label lblGraphParameter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdClearLog;
        private System.Windows.Forms.Label lblGraphInsertTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGraphFindTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGraphFindByValueTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox chkPrintLog;
        private System.Windows.Forms.CheckBox chkWriteLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Timer tmrSec;
    }
}

