namespace FourWins
{
    partial class Menue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menue));
            game_title = new Label();
            author_title = new Label();
            nav_list_item_1 = new Label();
            nav_list_item_2 = new Label();
            nav_list_item_3 = new Label();
            nav_list_item_4 = new Label();
            Help_Panel = new Panel();
            SuspendLayout();
            // 
            // game_title
            // 
            game_title.AutoSize = true;
            game_title.BackColor = Color.Transparent;
            game_title.Font = new Font("Franklin Gothic Heavy", 72F, FontStyle.Underline, GraphicsUnit.Point);
            game_title.Location = new Point(-2, -5);
            game_title.Name = "game_title";
            game_title.Size = new Size(544, 120);
            game_title.TabIndex = 3;
            game_title.Text = "Four➍Wins";
            // 
            // author_title
            // 
            author_title.AutoSize = true;
            author_title.BackColor = Color.Transparent;
            author_title.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Italic, GraphicsUnit.Point);
            author_title.Location = new Point(471, 103);
            author_title.Name = "author_title";
            author_title.Size = new Size(146, 21);
            author_title.TabIndex = 2;
            author_title.Text = "by Nils Hindel v1.0";
            // 
            // nav_list_item_1
            // 
            nav_list_item_1.AutoSize = true;
            nav_list_item_1.BackColor = Color.Transparent;
            nav_list_item_1.Font = new Font("Franklin Gothic Heavy", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            nav_list_item_1.Location = new Point(31, 141);
            nav_list_item_1.Name = "nav_list_item_1";
            nav_list_item_1.Size = new Size(263, 41);
            nav_list_item_1.TabIndex = 4;
            nav_list_item_1.Text = "SPIELMODUS 1";
            nav_list_item_1.MouseEnter += Nav_list_item_MouseEnter;
            nav_list_item_1.MouseLeave += Nav_list_item_MouseLeave;
            // 
            // nav_list_item_2
            // 
            nav_list_item_2.AutoSize = true;
            nav_list_item_2.BackColor = Color.Transparent;
            nav_list_item_2.Font = new Font("Franklin Gothic Heavy", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            nav_list_item_2.Location = new Point(31, 200);
            nav_list_item_2.Name = "nav_list_item_2";
            nav_list_item_2.Size = new Size(263, 41);
            nav_list_item_2.TabIndex = 5;
            nav_list_item_2.Text = "SPIELMODUS 2";
            nav_list_item_2.MouseEnter += Nav_list_item_MouseEnter;
            nav_list_item_2.MouseLeave += Nav_list_item_MouseLeave;
            // 
            // nav_list_item_3
            // 
            nav_list_item_3.AutoSize = true;
            nav_list_item_3.BackColor = Color.Transparent;
            nav_list_item_3.Font = new Font("Franklin Gothic Heavy", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            nav_list_item_3.Location = new Point(31, 259);
            nav_list_item_3.Name = "nav_list_item_3";
            nav_list_item_3.Size = new Size(263, 41);
            nav_list_item_3.TabIndex = 6;
            nav_list_item_3.Text = "SPIELMODUS 3";
            nav_list_item_3.MouseEnter += Nav_list_item_MouseEnter;
            nav_list_item_3.MouseLeave += Nav_list_item_MouseLeave;
            // 
            // nav_list_item_4
            // 
            nav_list_item_4.AutoSize = true;
            nav_list_item_4.BackColor = Color.Transparent;
            nav_list_item_4.Font = new Font("Franklin Gothic Heavy", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            nav_list_item_4.Location = new Point(31, 317);
            nav_list_item_4.Name = "nav_list_item_4";
            nav_list_item_4.Size = new Size(263, 41);
            nav_list_item_4.TabIndex = 7;
            nav_list_item_4.Text = "SPIELMODUS 4";
            nav_list_item_4.MouseEnter += Nav_list_item_MouseEnter;
            nav_list_item_4.MouseLeave += Nav_list_item_MouseLeave;
            // 
            // Help_Panel
            // 
            Help_Panel.BackgroundImage = (Image)resources.GetObject("Help_Panel.BackgroundImage");
            Help_Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Help_Panel.Location = new Point(548, 245);
            Help_Panel.Name = "Help_Panel";
            Help_Panel.Size = new Size(299, 214);
            Help_Panel.TabIndex = 8;
            // 
            // Menue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Help_Panel);
            Controls.Add(nav_list_item_4);
            Controls.Add(nav_list_item_3);
            Controls.Add(nav_list_item_2);
            Controls.Add(nav_list_item_1);
            Controls.Add(author_title);
            Controls.Add(game_title);
            Cursor = Cursors.Cross;
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "Menue";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FourWins ■ Menue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label game_title;
        private Label author_title;
        private Label nav_list_item_1;
        private Label nav_list_item_2;
        private Label nav_list_item_3;
        private Label nav_list_item_4;
        private Panel Help_Panel;
    }
}