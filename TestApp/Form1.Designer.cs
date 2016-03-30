namespace TestApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.question6answer0 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.question5answer0 = new System.Windows.Forms.ComboBox();
            this.question4panel = new System.Windows.Forms.TableLayoutPanel();
            this.question4answer0 = new System.Windows.Forms.RadioButton();
            this.question4answer1 = new System.Windows.Forms.RadioButton();
            this.question4answer2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.question3panel = new System.Windows.Forms.TableLayoutPanel();
            this.question3answer0 = new System.Windows.Forms.CheckBox();
            this.question3answer1 = new System.Windows.Forms.CheckBox();
            this.question3answer2 = new System.Windows.Forms.CheckBox();
            this.question3answer3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.question2panel = new System.Windows.Forms.TableLayoutPanel();
            this.question2answer0 = new System.Windows.Forms.RadioButton();
            this.question2answer1 = new System.Windows.Forms.RadioButton();
            this.question2answer2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.question1answer0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.question4panel.SuspendLayout();
            this.question3panel.SuspendLayout();
            this.question2panel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scorePanel);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.question6answer0);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.question5answer0);
            this.panel1.Controls.Add(this.question4panel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.question3panel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.question2panel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.question1answer0);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 364);
            this.panel1.TabIndex = 0;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(80, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(13, 13);
            this.score.TabIndex = 14;
            this.score.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tvoje skore je: ";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submit.Location = new System.Drawing.Point(19, 297);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(255, 29);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // question6answer0
            // 
            this.question6answer0.CustomFormat = "dd.MM.yyyy";
            this.question6answer0.Location = new System.Drawing.Point(132, 262);
            this.question6answer0.Name = "question6answer0";
            this.question6answer0.Size = new System.Drawing.Size(142, 20);
            this.question6answer0.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zadaj datum epochy: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ktora siet je najrychlejsia: ";
            // 
            // question5answer0
            // 
            this.question5answer0.FormattingEnabled = true;
            this.question5answer0.Items.AddRange(new object[] {
            "Metalicka",
            "Opticka",
            "Koaxialna",
            "Cyklicka"});
            this.question5answer0.Location = new System.Drawing.Point(148, 235);
            this.question5answer0.Name = "question5answer0";
            this.question5answer0.Size = new System.Drawing.Size(126, 21);
            this.question5answer0.TabIndex = 8;
            // 
            // question4panel
            // 
            this.question4panel.ColumnCount = 3;
            this.question4panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.44509F));
            this.question4panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.55491F));
            this.question4panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.question4panel.Controls.Add(this.question4answer0, 0, 0);
            this.question4panel.Controls.Add(this.question4answer1, 1, 0);
            this.question4panel.Controls.Add(this.question4answer2, 2, 0);
            this.question4panel.Location = new System.Drawing.Point(16, 196);
            this.question4panel.Name = "question4panel";
            this.question4panel.RowCount = 1;
            this.question4panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.question4panel.Size = new System.Drawing.Size(258, 29);
            this.question4panel.TabIndex = 7;
            // 
            // question4answer0
            // 
            this.question4answer0.AutoSize = true;
            this.question4answer0.Location = new System.Drawing.Point(3, 3);
            this.question4answer0.Name = "question4answer0";
            this.question4answer0.Size = new System.Drawing.Size(61, 17);
            this.question4answer0.TabIndex = 0;
            this.question4answer0.TabStop = true;
            this.question4answer0.Text = "Fyzicka";
            this.question4answer0.UseVisualStyleBackColor = true;
            // 
            // question4answer1
            // 
            this.question4answer1.AutoSize = true;
            this.question4answer1.Location = new System.Drawing.Point(92, 3);
            this.question4answer1.Name = "question4answer1";
            this.question4answer1.Size = new System.Drawing.Size(66, 17);
            this.question4answer1.TabIndex = 1;
            this.question4answer1.TabStop = true;
            this.question4answer1.Text = "Spajacia";
            this.question4answer1.UseVisualStyleBackColor = true;
            // 
            // question4answer2
            // 
            this.question4answer2.AutoSize = true;
            this.question4answer2.Location = new System.Drawing.Point(175, 3);
            this.question4answer2.Name = "question4answer2";
            this.question4answer2.Size = new System.Drawing.Size(61, 17);
            this.question4answer2.TabIndex = 2;
            this.question4answer2.TabStop = true;
            this.question4answer2.Text = "Sietova";
            this.question4answer2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Switch pracuje na vrstve: ";
            // 
            // question3panel
            // 
            this.question3panel.ColumnCount = 2;
            this.question3panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.question3panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.question3panel.Controls.Add(this.question3answer0, 0, 0);
            this.question3panel.Controls.Add(this.question3answer1, 1, 0);
            this.question3panel.Controls.Add(this.question3answer2, 0, 1);
            this.question3panel.Controls.Add(this.question3answer3, 1, 1);
            this.question3panel.Location = new System.Drawing.Point(16, 116);
            this.question3panel.Name = "question3panel";
            this.question3panel.RowCount = 2;
            this.question3panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.question3panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.question3panel.Size = new System.Drawing.Size(258, 52);
            this.question3panel.TabIndex = 5;
            // 
            // question3answer0
            // 
            this.question3answer0.AutoSize = true;
            this.question3answer0.Location = new System.Drawing.Point(3, 3);
            this.question3answer0.Name = "question3answer0";
            this.question3answer0.Size = new System.Drawing.Size(95, 17);
            this.question3answer0.TabIndex = 0;
            this.question3answer0.Text = "127.35.259.14";
            this.question3answer0.UseVisualStyleBackColor = true;
            // 
            // question3answer1
            // 
            this.question3answer1.AutoSize = true;
            this.question3answer1.Location = new System.Drawing.Point(132, 3);
            this.question3answer1.Name = "question3answer1";
            this.question3answer1.Size = new System.Drawing.Size(89, 17);
            this.question3answer1.TabIndex = 1;
            this.question3answer1.Text = "192.168.1.10";
            this.question3answer1.UseVisualStyleBackColor = true;
            // 
            // question3answer2
            // 
            this.question3answer2.AutoSize = true;
            this.question3answer2.Location = new System.Drawing.Point(3, 29);
            this.question3answer2.Name = "question3answer2";
            this.question3answer2.Size = new System.Drawing.Size(71, 17);
            this.question3answer2.TabIndex = 2;
            this.question3answer2.Text = "10.2.4.10";
            this.question3answer2.UseVisualStyleBackColor = true;
            // 
            // question3answer3
            // 
            this.question3answer3.AutoSize = true;
            this.question3answer3.Location = new System.Drawing.Point(132, 29);
            this.question3answer3.Name = "question3answer3";
            this.question3answer3.Size = new System.Drawing.Size(101, 17);
            this.question3answer3.TabIndex = 3;
            this.question3answer3.Text = "105.14.255.999";
            this.question3answer3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ktore IP adresy su v spravnom tvare: ";
            // 
            // question2panel
            // 
            this.question2panel.ColumnCount = 3;
            this.question2panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.44509F));
            this.question2panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.55491F));
            this.question2panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.question2panel.Controls.Add(this.question2answer0, 0, 0);
            this.question2panel.Controls.Add(this.question2answer1, 1, 0);
            this.question2panel.Controls.Add(this.question2answer2, 2, 0);
            this.question2panel.Location = new System.Drawing.Point(16, 55);
            this.question2panel.Name = "question2panel";
            this.question2panel.RowCount = 1;
            this.question2panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.question2panel.Size = new System.Drawing.Size(258, 29);
            this.question2panel.TabIndex = 3;
            // 
            // question2answer0
            // 
            this.question2answer0.AutoSize = true;
            this.question2answer0.Location = new System.Drawing.Point(3, 3);
            this.question2answer0.Name = "question2answer0";
            this.question2answer0.Size = new System.Drawing.Size(46, 17);
            this.question2answer0.TabIndex = 0;
            this.question2answer0.TabStop = true;
            this.question2answer0.Text = "TCP";
            this.question2answer0.UseVisualStyleBackColor = true;
            // 
            // question2answer1
            // 
            this.question2answer1.AutoSize = true;
            this.question2answer1.Location = new System.Drawing.Point(92, 3);
            this.question2answer1.Name = "question2answer1";
            this.question2answer1.Size = new System.Drawing.Size(35, 17);
            this.question2answer1.TabIndex = 1;
            this.question2answer1.TabStop = true;
            this.question2answer1.Text = "IP";
            this.question2answer1.UseVisualStyleBackColor = true;
            // 
            // question2answer2
            // 
            this.question2answer2.AutoSize = true;
            this.question2answer2.Location = new System.Drawing.Point(175, 3);
            this.question2answer2.Name = "question2answer2";
            this.question2answer2.Size = new System.Drawing.Size(54, 17);
            this.question2answer2.TabIndex = 2;
            this.question2answer2.TabStop = true;
            this.question2answer2.Text = "HTTP";
            this.question2answer2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ktory protokol sa pouziva na transportnej vrstve:";
            // 
            // question1answer0
            // 
            this.question1answer0.Location = new System.Drawing.Point(174, 7);
            this.question1answer0.Name = "question1answer0";
            this.question1answer0.Size = new System.Drawing.Size(100, 20);
            this.question1answer0.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prva pocitacova siet sa volala: ";
            // 
            // scorePanel
            // 
            this.scorePanel.Controls.Add(this.label7);
            this.scorePanel.Controls.Add(this.score);
            this.scorePanel.Location = new System.Drawing.Point(100, 332);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(100, 20);
            this.scorePanel.TabIndex = 15;
            this.scorePanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 386);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Amazing Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.question4panel.ResumeLayout(false);
            this.question4panel.PerformLayout();
            this.question3panel.ResumeLayout(false);
            this.question3panel.PerformLayout();
            this.question2panel.ResumeLayout(false);
            this.question2panel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel question4panel;
        private System.Windows.Forms.RadioButton question4answer0;
        private System.Windows.Forms.RadioButton question4answer1;
        private System.Windows.Forms.RadioButton question4answer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel question3panel;
        private System.Windows.Forms.CheckBox question3answer0;
        private System.Windows.Forms.CheckBox question3answer1;
        private System.Windows.Forms.CheckBox question3answer2;
        private System.Windows.Forms.CheckBox question3answer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel question2panel;
        private System.Windows.Forms.RadioButton question2answer0;
        private System.Windows.Forms.RadioButton question2answer1;
        private System.Windows.Forms.RadioButton question2answer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox question1answer0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox question5answer0;
        private System.Windows.Forms.DateTimePicker question6answer0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel scorePanel;
    }
}

