
namespace Test_Score_Average_Demo
{
    partial class testScoreAverage
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
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.testScore1PromptLabel = new System.Windows.Forms.Label();
            this.testScore2PromptLabel = new System.Windows.Forms.Label();
            this.testScore3PromptLabel = new System.Windows.Forms.Label();
            this.outputPromptLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.outputPromptLabel);
            this.testScoreGroupBox.Controls.Add(this.testScore3PromptLabel);
            this.testScoreGroupBox.Controls.Add(this.testScore2PromptLabel);
            this.testScoreGroupBox.Controls.Add(this.testScore1PromptLabel);
            this.testScoreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScoreGroupBox.Location = new System.Drawing.Point(46, 35);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Size = new System.Drawing.Size(508, 283);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "Enter Three Test Scores";
            // 
            // testScore1PromptLabel
            // 
            this.testScore1PromptLabel.AutoSize = true;
            this.testScore1PromptLabel.Location = new System.Drawing.Point(100, 54);
            this.testScore1PromptLabel.Name = "testScore1PromptLabel";
            this.testScore1PromptLabel.Size = new System.Drawing.Size(114, 20);
            this.testScore1PromptLabel.TabIndex = 0;
            this.testScore1PromptLabel.Text = "Test Score #1";
            // 
            // testScore2PromptLabel
            // 
            this.testScore2PromptLabel.AutoSize = true;
            this.testScore2PromptLabel.Location = new System.Drawing.Point(100, 100);
            this.testScore2PromptLabel.Name = "testScore2PromptLabel";
            this.testScore2PromptLabel.Size = new System.Drawing.Size(114, 20);
            this.testScore2PromptLabel.TabIndex = 1;
            this.testScore2PromptLabel.Text = "Test Score #2";
            // 
            // testScore3PromptLabel
            // 
            this.testScore3PromptLabel.AutoSize = true;
            this.testScore3PromptLabel.Location = new System.Drawing.Point(100, 146);
            this.testScore3PromptLabel.Name = "testScore3PromptLabel";
            this.testScore3PromptLabel.Size = new System.Drawing.Size(114, 20);
            this.testScore3PromptLabel.TabIndex = 2;
            this.testScore3PromptLabel.Text = "Test Score #3";
            // 
            // outputPromptLabel
            // 
            this.outputPromptLabel.AutoSize = true;
            this.outputPromptLabel.Location = new System.Drawing.Point(100, 211);
            this.outputPromptLabel.Name = "outputPromptLabel";
            this.outputPromptLabel.Size = new System.Drawing.Size(70, 20);
            this.outputPromptLabel.TabIndex = 3;
            this.outputPromptLabel.Text = "Average";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(248, 207);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(104, 27);
            this.averageLabel.TabIndex = 3;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(248, 143);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(104, 27);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(248, 97);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(104, 27);
            this.test2TextBox.TabIndex = 1;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(248, 51);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(104, 27);
            this.test1TextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(123, 324);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 70);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(294, 324);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 32);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(294, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 32);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // testScoreAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 412);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Name = "testScoreAverage";
            this.Text = "Test Score Average";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label outputPromptLabel;
        private System.Windows.Forms.Label testScore3PromptLabel;
        private System.Windows.Forms.Label testScore2PromptLabel;
        private System.Windows.Forms.Label testScore1PromptLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

