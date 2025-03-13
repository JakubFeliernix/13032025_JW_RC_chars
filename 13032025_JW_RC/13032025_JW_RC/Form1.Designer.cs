namespace _13032025_JW_RC
{
    partial class Form1
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
            myChart = new LiveCharts.WinForms.CartesianChart();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // myChart
            // 
            myChart.Location = new Point(31, 122);
            myChart.Name = "myChart";
            myChart.Size = new Size(1377, 506);
            myChart.TabIndex = 0;
            myChart.Text = "cartesianChart1";
            myChart.ChildChanged += myChart_ChildChanged;
            // 
            // button1
            // 
            button1.Location = new Point(516, 12);
            button1.Name = "button1";
            button1.Size = new Size(206, 23);
            button1.TabIndex = 1;
            button1.Text = "Dodaj punkt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(516, 54);
            button2.Name = "button2";
            button2.Size = new Size(196, 23);
            button2.TabIndex = 2;
            button2.Text = "Dodaj kolekcje";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(516, 93);
            button3.Name = "button3";
            button3.Size = new Size(196, 23);
            button3.TabIndex = 3;
            button3.Text = "usuń i dodaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 640);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(myChart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart myChart;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
