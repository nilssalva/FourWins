namespace FourWins
{
    partial class TwoPlayers
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
            Back_Button = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // Back_Button
            // 
            Back_Button.AutoSize = true;
            Back_Button.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Back_Button.Location = new Point(717, 415);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(62, 21);
            Back_Button.TabIndex = 0;
            Back_Button.Text = "➥Back";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(230, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(47, 41);
            panel1.TabIndex = 1;
            // 
            // TwoPlayers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(Back_Button);
            Cursor = Cursors.Cross;
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "TwoPlayers";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FourWins ■ Player vs. Player";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Back_Button;
        private Panel panel1;
    }
}