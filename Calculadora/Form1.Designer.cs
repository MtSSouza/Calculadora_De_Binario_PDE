namespace Calculadora010
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
            this.textBoxDecimal = new System.Windows.Forms.TextBox();
            this.btSum = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btConv = new System.Windows.Forms.Button();
            this.BinaryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHexadecimal = new System.Windows.Forms.TextBox();
            this.btResult = new System.Windows.Forms.Button();
            this.textBoxBinary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOperation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBinary2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxDecimal.Location = new System.Drawing.Point(166, 35);
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(123, 20);
            this.textBoxDecimal.TabIndex = 0;
            this.textBoxDecimal.TextChanged += new System.EventHandler(this.textBoxDecimal_TextChanged_1);
            this.textBoxDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPressed);
            // 
            // btSum
            // 
            this.btSum.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btSum.Location = new System.Drawing.Point(108, 185);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(52, 89);
            this.btSum.TabIndex = 11;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // btSub
            // 
            this.btSub.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btSub.Location = new System.Drawing.Point(108, 127);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(52, 52);
            this.btSub.TabIndex = 12;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btMult.Location = new System.Drawing.Point(166, 165);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(105, 23);
            this.btMult.TabIndex = 13;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btDiv.Location = new System.Drawing.Point(166, 127);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(105, 28);
            this.btDiv.TabIndex = 14;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btConv
            // 
            this.btConv.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btConv.Location = new System.Drawing.Point(12, 136);
            this.btConv.Name = "btConv";
            this.btConv.Size = new System.Drawing.Size(90, 52);
            this.btConv.TabIndex = 15;
            this.btConv.Text = "Converter";
            this.btConv.UseVisualStyleBackColor = true;
            this.btConv.Click += new System.EventHandler(this.btConv_Click);
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.AutoSize = true;
            this.BinaryLabel.Location = new System.Drawing.Point(9, 9);
            this.BinaryLabel.Name = "BinaryLabel";
            this.BinaryLabel.Size = new System.Drawing.Size(36, 13);
            this.BinaryLabel.TabIndex = 17;
            this.BinaryLabel.Text = "num 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "hexadecimal:";
            // 
            // textBoxHexadecimal
            // 
            this.textBoxHexadecimal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxHexadecimal.Location = new System.Drawing.Point(166, 74);
            this.textBoxHexadecimal.Name = "textBoxHexadecimal";
            this.textBoxHexadecimal.Size = new System.Drawing.Size(123, 20);
            this.textBoxHexadecimal.TabIndex = 20;
            this.textBoxHexadecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPressed);
            // 
            // btResult
            // 
            this.btResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btResult.Location = new System.Drawing.Point(12, 194);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(90, 52);
            this.btResult.TabIndex = 21;
            this.btResult.Text = "Resultado";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxBinary.Location = new System.Drawing.Point(8, 25);
            this.textBoxBinary.Multiline = true;
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.Size = new System.Drawing.Size(105, 20);
            this.textBoxBinary.TabIndex = 22;
            this.textBoxBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Decimal:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxResult.Location = new System.Drawing.Point(166, 232);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(123, 43);
            this.textBoxResult.TabIndex = 25;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            this.textBoxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPressed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Result:";
            // 
            // textBoxOperation
            // 
            this.textBoxOperation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOperation.Location = new System.Drawing.Point(75, 110);
            this.textBoxOperation.Name = "textBoxOperation";
            this.textBoxOperation.Size = new System.Drawing.Size(27, 20);
            this.textBoxOperation.TabIndex = 27;
            this.textBoxOperation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sinal:";
            // 
            // textBoxBinary2
            // 
            this.textBoxBinary2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxBinary2.Location = new System.Drawing.Point(8, 74);
            this.textBoxBinary2.Name = "textBoxBinary2";
            this.textBoxBinary2.Size = new System.Drawing.Size(105, 20);
            this.textBoxBinary2.TabIndex = 29;
            this.textBoxBinary2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "num 2";
            // 
            // btClear
            // 
            this.btClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btClear.Location = new System.Drawing.Point(12, 252);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(90, 22);
            this.btClear.TabIndex = 31;
            this.btClear.Text = "Apagar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(295, 287);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBinary2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBinary);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.textBoxHexadecimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BinaryLabel);
            this.Controls.Add(this.btConv);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.textBoxDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BinaryCalculator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecimal;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btConv;
        private System.Windows.Forms.Label BinaryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHexadecimal;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.TextBox textBoxBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBinary2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClear;
    }
}

