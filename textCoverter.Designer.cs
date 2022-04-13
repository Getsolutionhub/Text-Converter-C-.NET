namespace getsolutionhubDemo
{
    partial class textCoverter
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
            this.mainTxtBox = new System.Windows.Forms.TextBox();
            this.previewTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordLetterCounter = new System.Windows.Forms.Label();
            this.uppercaseBtn = new System.Windows.Forms.Button();
            this.lowercaseBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.rmSpaceBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTxtBox
            // 
            this.mainTxtBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTxtBox.Location = new System.Drawing.Point(12, 110);
            this.mainTxtBox.Multiline = true;
            this.mainTxtBox.Name = "mainTxtBox";
            this.mainTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTxtBox.Size = new System.Drawing.Size(1174, 238);
            this.mainTxtBox.TabIndex = 0;
            this.mainTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainTxtBox_KeyUp);
            // 
            // previewTxtBox
            // 
            this.previewTxtBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewTxtBox.Location = new System.Drawing.Point(12, 461);
            this.previewTxtBox.Multiline = true;
            this.previewTxtBox.Name = "previewTxtBox";
            this.previewTxtBox.ReadOnly = true;
            this.previewTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.previewTxtBox.Size = new System.Drawing.Size(1174, 238);
            this.previewTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Text Here :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preview Your Text Here :";
            // 
            // wordLetterCounter
            // 
            this.wordLetterCounter.AutoSize = true;
            this.wordLetterCounter.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLetterCounter.Location = new System.Drawing.Point(383, 360);
            this.wordLetterCounter.Name = "wordLetterCounter";
            this.wordLetterCounter.Size = new System.Drawing.Size(494, 28);
            this.wordLetterCounter.TabIndex = 4;
            this.wordLetterCounter.Text = "Words : 0 , Characters : 0 , Spaces : 0";
            // 
            // uppercaseBtn
            // 
            this.uppercaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uppercaseBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaseBtn.Location = new System.Drawing.Point(55, 718);
            this.uppercaseBtn.Name = "uppercaseBtn";
            this.uppercaseBtn.Size = new System.Drawing.Size(201, 43);
            this.uppercaseBtn.TabIndex = 5;
            this.uppercaseBtn.Text = "UPPERCASE";
            this.uppercaseBtn.UseVisualStyleBackColor = true;
            this.uppercaseBtn.Click += new System.EventHandler(this.uppercaseBtn_Click);
            // 
            // lowercaseBtn
            // 
            this.lowercaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lowercaseBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaseBtn.Location = new System.Drawing.Point(275, 718);
            this.lowercaseBtn.Name = "lowercaseBtn";
            this.lowercaseBtn.Size = new System.Drawing.Size(192, 43);
            this.lowercaseBtn.TabIndex = 6;
            this.lowercaseBtn.Text = "lowercase";
            this.lowercaseBtn.UseVisualStyleBackColor = true;
            this.lowercaseBtn.Click += new System.EventHandler(this.lowercaseBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(1037, 718);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 43);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Location = new System.Drawing.Point(495, 718);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(105, 43);
            this.copyBtn.TabIndex = 8;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // rmSpaceBtn
            // 
            this.rmSpaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmSpaceBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmSpaceBtn.Location = new System.Drawing.Point(750, 718);
            this.rmSpaceBtn.Name = "rmSpaceBtn";
            this.rmSpaceBtn.Size = new System.Drawing.Size(265, 43);
            this.rmSpaceBtn.TabIndex = 9;
            this.rmSpaceBtn.Text = "Remove Spaces";
            this.rmSpaceBtn.UseVisualStyleBackColor = true;
            this.rmSpaceBtn.Click += new System.EventHandler(this.rmSpaceBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text Converter :";
            // 
            // pasteBtn
            // 
            this.pasteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasteBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteBtn.Location = new System.Drawing.Point(620, 718);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(107, 43);
            this.pasteBtn.TabIndex = 11;
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // textCoverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1198, 773);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rmSpaceBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.lowercaseBtn);
            this.Controls.Add(this.uppercaseBtn);
            this.Controls.Add(this.wordLetterCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewTxtBox);
            this.Controls.Add(this.mainTxtBox);
            this.MaximizeBox = false;
            this.Name = "textCoverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Coverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTxtBox;
        private System.Windows.Forms.TextBox previewTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordLetterCounter;
        private System.Windows.Forms.Button uppercaseBtn;
        private System.Windows.Forms.Button lowercaseBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button rmSpaceBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pasteBtn;
    }
}