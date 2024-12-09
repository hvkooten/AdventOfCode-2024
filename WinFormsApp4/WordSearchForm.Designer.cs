namespace WordSearchApp
{
    partial class WordSearchForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            wordInput = new System.Windows.Forms.TextBox();
            textInput = new System.Windows.Forms.TextBox();
            calculateButton = new System.Windows.Forms.Button();
            closeButton = new System.Windows.Forms.Button();
            verticalLabel = new System.Windows.Forms.Label();
            horizontalLabel = new System.Windows.Forms.Label();
            diagonalLabel = new System.Windows.Forms.Label();
            xmasPatternLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            verticalOutput = new System.Windows.Forms.TextBox();
            horizontalOutput = new System.Windows.Forms.TextBox();
            diagonalOutput = new System.Windows.Forms.TextBox();
            xmasPatternOutput = new System.Windows.Forms.TextBox();
            totalOutput = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // wordInput
            // 
            wordInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            wordInput.Location = new System.Drawing.Point(14, 14);
            wordInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            wordInput.Name = "wordInput";
            wordInput.Size = new System.Drawing.Size(693, 23);
            wordInput.TabIndex = 0;
            wordInput.Text = "XMAS";
            // 
            // textInput
            // 
            textInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textInput.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textInput.Location = new System.Drawing.Point(14, 44);
            textInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new System.Drawing.Size(693, 365);
            textInput.TabIndex = 1;
            textInput.Text = "MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX";
            // 
            // calculateButton
            // 
            calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            calculateButton.Location = new System.Drawing.Point(14, 417);
            calculateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new System.Drawing.Size(88, 27);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += CalculateButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            closeButton.Location = new System.Drawing.Point(620, 417);
            closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(88, 27);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // verticalLabel
            // 
            verticalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            verticalLabel.Location = new System.Drawing.Point(14, 454);
            verticalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            verticalLabel.Name = "verticalLabel";
            verticalLabel.Size = new System.Drawing.Size(88, 23);
            verticalLabel.TabIndex = 4;
            verticalLabel.Text = "Vertical:";
            // 
            // horizontalLabel
            // 
            horizontalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            horizontalLabel.Location = new System.Drawing.Point(14, 484);
            horizontalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            horizontalLabel.Name = "horizontalLabel";
            horizontalLabel.Size = new System.Drawing.Size(88, 23);
            horizontalLabel.TabIndex = 5;
            horizontalLabel.Text = "Horizontal:";
            // 
            // diagonalLabel
            // 
            diagonalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            diagonalLabel.Location = new System.Drawing.Point(14, 514);
            diagonalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            diagonalLabel.Name = "diagonalLabel";
            diagonalLabel.Size = new System.Drawing.Size(88, 23);
            diagonalLabel.TabIndex = 6;
            diagonalLabel.Text = "Diagonal:";
            // 
            // xmasPatternLabel
            // 
            xmasPatternLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            xmasPatternLabel.Location = new System.Drawing.Point(14, 544);
            xmasPatternLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            xmasPatternLabel.Name = "xmasPatternLabel";
            xmasPatternLabel.Size = new System.Drawing.Size(88, 23);
            xmasPatternLabel.TabIndex = 7;
            xmasPatternLabel.Text = "X-MAS Pattern:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            totalLabel.Location = new System.Drawing.Point(14, 574);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(88, 23);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total:";
            // 
            // verticalOutput
            // 
            verticalOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            verticalOutput.Location = new System.Drawing.Point(110, 454);
            verticalOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            verticalOutput.Name = "verticalOutput";
            verticalOutput.ReadOnly = true;
            verticalOutput.Size = new System.Drawing.Size(597, 23);
            verticalOutput.TabIndex = 9;
            // 
            // horizontalOutput
            // 
            horizontalOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            horizontalOutput.Location = new System.Drawing.Point(110, 484);
            horizontalOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            horizontalOutput.Name = "horizontalOutput";
            horizontalOutput.ReadOnly = true;
            horizontalOutput.Size = new System.Drawing.Size(597, 23);
            horizontalOutput.TabIndex = 10;
            // 
            // diagonalOutput
            // 
            diagonalOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            diagonalOutput.Location = new System.Drawing.Point(110, 514);
            diagonalOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            diagonalOutput.Name = "diagonalOutput";
            diagonalOutput.ReadOnly = true;
            diagonalOutput.Size = new System.Drawing.Size(597, 23);
            diagonalOutput.TabIndex = 11;
            // 
            // xmasPatternOutput
            // 
            xmasPatternOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            xmasPatternOutput.Location = new System.Drawing.Point(110, 544);
            xmasPatternOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            xmasPatternOutput.Name = "xmasPatternOutput";
            xmasPatternOutput.ReadOnly = true;
            xmasPatternOutput.Size = new System.Drawing.Size(597, 23);
            xmasPatternOutput.TabIndex = 12;
            // 
            // totalOutput
            // 
            totalOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            totalOutput.Location = new System.Drawing.Point(110, 574);
            totalOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            totalOutput.Name = "totalOutput";
            totalOutput.ReadOnly = true;
            totalOutput.Size = new System.Drawing.Size(597, 23);
            totalOutput.TabIndex = 13;
            // 
            // WordSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(721, 607);
            Controls.Add(wordInput);
            Controls.Add(textInput);
            Controls.Add(calculateButton);
            Controls.Add(closeButton);
            Controls.Add(verticalLabel);
            Controls.Add(horizontalLabel);
            Controls.Add(diagonalLabel);
            Controls.Add(xmasPatternLabel);
            Controls.Add(totalLabel);
            Controls.Add(verticalOutput);
            Controls.Add(horizontalOutput);
            Controls.Add(diagonalOutput);
            Controls.Add(xmasPatternOutput);
            Controls.Add(totalOutput);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "WordSearchForm";
            Text = "Word Search";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox wordInput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label verticalLabel;
        private System.Windows.Forms.Label horizontalLabel;
        private System.Windows.Forms.Label diagonalLabel;
        private System.Windows.Forms.Label xmasPatternLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox verticalOutput;
        private System.Windows.Forms.TextBox horizontalOutput;
        private System.Windows.Forms.TextBox diagonalOutput;
        private System.Windows.Forms.TextBox xmasPatternOutput;
        private System.Windows.Forms.TextBox totalOutput;
    }
}
