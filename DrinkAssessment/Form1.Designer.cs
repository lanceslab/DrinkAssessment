namespace DrinkAssessment
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
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.listBoxDesc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(33, 32);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 0;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.Location = new System.Drawing.Point(30, 58);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(645, 23);
            this.labelDisplay.TabIndex = 1;
            // 
            // listBoxDesc
            // 
            this.listBoxDesc.FormattingEnabled = true;
            this.listBoxDesc.ItemHeight = 16;
            this.listBoxDesc.Location = new System.Drawing.Point(33, 127);
            this.listBoxDesc.Name = "listBoxDesc";
            this.listBoxDesc.Size = new System.Drawing.Size(734, 196);
            this.listBoxDesc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxDesc);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.buttonDisplay);
            this.Name = "Form1";
            this.Text = "Display Drink Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.ListBox listBoxDesc;
    }
}

