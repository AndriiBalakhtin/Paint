namespace Paint_15._1
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
            this.components = new System.ComponentModel.Container();
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.Color.White;
            this.paintBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintBox.Location = new System.Drawing.Point(12, 12);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(800, 400);
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(737, 418);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 449);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.paintBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox paintBox;
        private System.Windows.Forms.Timer timer1;
        private Button ClearBtn;
    }
}