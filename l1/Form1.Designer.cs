namespace l1
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
            this.textBoxStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownStudent1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStudent2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownStudent3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownStudent5 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownStudent4 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewToDisplay = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.Location = new System.Drawing.Point(12, 42);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.Size = new System.Drawing.Size(152, 26);
            this.textBoxStudent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прізвище студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оцінка 1";
            // 
            // numericUpDownStudent1
            // 
            this.numericUpDownStudent1.Location = new System.Drawing.Point(189, 42);
            this.numericUpDownStudent1.Name = "numericUpDownStudent1";
            this.numericUpDownStudent1.Size = new System.Drawing.Size(83, 26);
            this.numericUpDownStudent1.TabIndex = 4;
            // 
            // numericUpDownStudent2
            // 
            this.numericUpDownStudent2.Location = new System.Drawing.Point(293, 43);
            this.numericUpDownStudent2.Name = "numericUpDownStudent2";
            this.numericUpDownStudent2.Size = new System.Drawing.Size(83, 26);
            this.numericUpDownStudent2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оцінка 2";
            // 
            // numericUpDownStudent3
            // 
            this.numericUpDownStudent3.Location = new System.Drawing.Point(391, 42);
            this.numericUpDownStudent3.Name = "numericUpDownStudent3";
            this.numericUpDownStudent3.Size = new System.Drawing.Size(83, 26);
            this.numericUpDownStudent3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Оцінка 3";
            // 
            // numericUpDownStudent5
            // 
            this.numericUpDownStudent5.Location = new System.Drawing.Point(590, 43);
            this.numericUpDownStudent5.Name = "numericUpDownStudent5";
            this.numericUpDownStudent5.Size = new System.Drawing.Size(83, 26);
            this.numericUpDownStudent5.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Оцінка 5";
            // 
            // numericUpDownStudent4
            // 
            this.numericUpDownStudent4.Location = new System.Drawing.Point(492, 44);
            this.numericUpDownStudent4.Name = "numericUpDownStudent4";
            this.numericUpDownStudent4.Size = new System.Drawing.Size(83, 26);
            this.numericUpDownStudent4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Оцінка 4";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(12, 94);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(148, 36);
            this.buttonWrite.TabIndex = 13;
            this.buttonWrite.Text = "Записати";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(189, 94);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 36);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonViewToDisplay
            // 
            this.buttonViewToDisplay.Location = new System.Drawing.Point(365, 94);
            this.buttonViewToDisplay.Name = "buttonViewToDisplay";
            this.buttonViewToDisplay.Size = new System.Drawing.Size(195, 36);
            this.buttonViewToDisplay.TabIndex = 15;
            this.buttonViewToDisplay.Text = "Вивести інформацію";
            this.buttonViewToDisplay.UseVisualStyleBackColor = true;
            this.buttonViewToDisplay.Click += new System.EventHandler(this.buttonViewToDisplay_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(16, 153);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(707, 131);
            this.richTextBox.TabIndex = 16;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 296);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonViewToDisplay);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.numericUpDownStudent5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownStudent4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownStudent3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownStudent2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownStudent1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudent4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStudent1;
        private System.Windows.Forms.NumericUpDown numericUpDownStudent2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownStudent3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownStudent5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownStudent4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewToDisplay;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

