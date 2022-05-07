namespace FirstDesktopApp
{
    partial class MainForm
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
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.Sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputListBox
            // 
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.ItemHeight = 17;
            this.inputListBox.Location = new System.Drawing.Point(49, 69);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(177, 123);
            this.inputListBox.TabIndex = 0;
            //this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.inputListBox_SelectedIndexChanged);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 17;
            this.outputListBox.Location = new System.Drawing.Point(296, 69);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(180, 123);
            this.outputListBox.TabIndex = 1;
            //this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.outputListBox_SelectedIndexChanged);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(189, 217);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(138, 30);
            this.Sort.TabIndex = 2;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.inputListBox);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox inputListBox;
        private ListBox outputListBox;
        private Button Sort;
        private Label label1;
        private Label label2;
    }
}