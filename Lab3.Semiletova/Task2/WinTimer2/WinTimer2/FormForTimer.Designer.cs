namespace WinTimer2
{
    partial class FormForTimer
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
            this.userTimer21 = new WinTimer2.UserTimer2();
            this.SuspendLayout();
            // 
            // userTimer21
            // 
            this.userTimer21.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTimer21.Location = new System.Drawing.Point(49, 31);
            this.userTimer21.Name = "userTimer21";
            this.userTimer21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userTimer21.Size = new System.Drawing.Size(178, 40);
            this.userTimer21.TabIndex = 0;
            this.userTimer21.Text = "userTimer21";
            // 
            // FormForTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 99);
            this.Controls.Add(this.userTimer21);
            this.Name = "FormForTimer";
            this.Text = "FormForTimer";
            this.ResumeLayout(false);

        }

        #endregion

        private UserTimer2 userTimer21;
    }
}

