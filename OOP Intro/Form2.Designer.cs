namespace OOP_Intro
{
    partial class Form2
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
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.btnOpenCharacter = new System.Windows.Forms.Button();
            this.PutInterest = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(50, 40);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(100, 22);
            this.txtPlayerOne.TabIndex = 0;
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Location = new System.Drawing.Point(269, 40);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(100, 22);
            this.txtPlayerTwo.TabIndex = 0;
            // 
            // btnOpenCharacter
            // 
            this.btnOpenCharacter.Location = new System.Drawing.Point(151, 98);
            this.btnOpenCharacter.Name = "btnOpenCharacter";
            this.btnOpenCharacter.Size = new System.Drawing.Size(123, 23);
            this.btnOpenCharacter.TabIndex = 1;
            this.btnOpenCharacter.Text = "New Challange";
            this.btnOpenCharacter.UseVisualStyleBackColor = true;
            this.btnOpenCharacter.Click += new System.EventHandler(this.btnOpenCharacter_Click);
            // 
            // PutInterest
            // 
            this.PutInterest.Location = new System.Drawing.Point(151, 161);
            this.PutInterest.Name = "PutInterest";
            this.PutInterest.Size = new System.Drawing.Size(123, 23);
            this.PutInterest.TabIndex = 1;
            this.PutInterest.Text = "Interest";
            this.PutInterest.UseVisualStyleBackColor = true;
            this.PutInterest.Click += new System.EventHandler(this.PutInterest_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(151, 233);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.PutInterest);
            this.Controls.Add(this.btnOpenCharacter);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.Button btnOpenCharacter;
        private System.Windows.Forms.Button PutInterest;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
    }
}