namespace Test.App
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
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.Location = new System.Drawing.Point(269, 176);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(155, 55);
            this.btnAddMessage.TabIndex = 0;
            this.btnAddMessage.Text = "btnAddMessage";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddMessage;
    }
}