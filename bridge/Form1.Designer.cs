
namespace bridge
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
            this.ahly_1 = new System.Windows.Forms.Button();
            this.alex_1 = new System.Windows.Forms.Button();
            this.masr_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ahly_1
            // 
            this.ahly_1.BackColor = System.Drawing.Color.DarkGray;
            this.ahly_1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ahly_1.Location = new System.Drawing.Point(552, 30);
            this.ahly_1.Name = "ahly_1";
            this.ahly_1.Size = new System.Drawing.Size(264, 391);
            this.ahly_1.TabIndex = 5;
            this.ahly_1.Text = "Al Ahly";
            this.ahly_1.UseVisualStyleBackColor = false;
            this.ahly_1.Click += new System.EventHandler(this.ahly_1_Click);
            // 
            // alex_1
            // 
            this.alex_1.BackColor = System.Drawing.Color.DarkGray;
            this.alex_1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alex_1.Location = new System.Drawing.Point(282, 30);
            this.alex_1.Name = "alex_1";
            this.alex_1.Size = new System.Drawing.Size(264, 391);
            this.alex_1.TabIndex = 4;
            this.alex_1.Text = "Alex";
            this.alex_1.UseVisualStyleBackColor = false;
            this.alex_1.Click += new System.EventHandler(this.alex_1_Click);
            // 
            // masr_1
            // 
            this.masr_1.BackColor = System.Drawing.Color.DarkGray;
            this.masr_1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.masr_1.Location = new System.Drawing.Point(12, 30);
            this.masr_1.Name = "masr_1";
            this.masr_1.Size = new System.Drawing.Size(264, 391);
            this.masr_1.TabIndex = 3;
            this.masr_1.Text = "Masr";
            this.masr_1.UseVisualStyleBackColor = false;
            this.masr_1.Click += new System.EventHandler(this.masr_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.ahly_1);
            this.Controls.Add(this.alex_1);
            this.Controls.Add(this.masr_1);
            this.Name = "Form1";
            this.Text = "payment system";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ahly_1;
        private System.Windows.Forms.Button alex_1;
        private System.Windows.Forms.Button masr_1;
    }
}

