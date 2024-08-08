namespace Bitcoin_Address_Generator
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
            passphrase_label = new Label();
            segwitUnComp_label = new Label();
            legacyAddresUnComp_label = new Label();
            publicKeyUnComp_label = new Label();
            privateKeyUnComp_label = new Label();
            secretExponent_label = new Label();
            segwitP2SHUnComp_label = new Label();
            passphrase_textBox = new TextBox();
            secretExponent_textBox = new TextBox();
            privateKeyUnComp_textBox = new TextBox();
            publicKeyUnComp_textBox = new TextBox();
            legacyAddresUnComp_textBox = new TextBox();
            segwitUnComp_textBox = new TextBox();
            segwitP2SHUnComp_textBox = new TextBox();
            taprootBIP86Comp_textBox = new TextBox();
            segwitP2SHComp_textBox = new TextBox();
            segwitComp_textBox = new TextBox();
            legacyAddresComp_textBox = new TextBox();
            publicKeyComp_textBox = new TextBox();
            privateKeyComp_textBox = new TextBox();
            taprootBIP86Comp_label = new Label();
            segwitP2SHComp_label = new Label();
            privateKeyComp_label = new Label();
            publicKeyComp_label = new Label();
            legacyAddresComp_label = new Label();
            segwitComp_label = new Label();
            SuspendLayout();
            // 
            // passphrase_label
            // 
            passphrase_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passphrase_label.AutoSize = true;
            passphrase_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passphrase_label.Location = new Point(118, 35);
            passphrase_label.Name = "passphrase_label";
            passphrase_label.Size = new Size(102, 21);
            passphrase_label.TabIndex = 0;
            passphrase_label.Text = "Passphrase : ";
            // 
            // segwitUnComp_label
            // 
            segwitUnComp_label.AutoSize = true;
            segwitUnComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            segwitUnComp_label.Location = new Point(70, 258);
            segwitUnComp_label.Name = "segwitUnComp_label";
            segwitUnComp_label.Size = new Size(150, 21);
            segwitUnComp_label.TabIndex = 8;
            segwitUnComp_label.Text = "Segwit (UnComp) : ";
            // 
            // legacyAddresUnComp_label
            // 
            legacyAddresUnComp_label.AutoSize = true;
            legacyAddresUnComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            legacyAddresUnComp_label.Location = new Point(12, 229);
            legacyAddresUnComp_label.Name = "legacyAddresUnComp_label";
            legacyAddresUnComp_label.Size = new Size(208, 21);
            legacyAddresUnComp_label.TabIndex = 2;
            legacyAddresUnComp_label.Text = "Legacy Addres (UnComp) : ";
            // 
            // publicKeyUnComp_label
            // 
            publicKeyUnComp_label.AutoSize = true;
            publicKeyUnComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            publicKeyUnComp_label.Location = new Point(45, 164);
            publicKeyUnComp_label.Name = "publicKeyUnComp_label";
            publicKeyUnComp_label.Size = new Size(175, 21);
            publicKeyUnComp_label.TabIndex = 3;
            publicKeyUnComp_label.Text = "Public Key (UnComp) : ";
            // 
            // privateKeyUnComp_label
            // 
            privateKeyUnComp_label.AutoSize = true;
            privateKeyUnComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            privateKeyUnComp_label.Location = new Point(39, 133);
            privateKeyUnComp_label.Name = "privateKeyUnComp_label";
            privateKeyUnComp_label.Size = new Size(181, 21);
            privateKeyUnComp_label.TabIndex = 4;
            privateKeyUnComp_label.Text = "Private Key (UnComp) : ";
            // 
            // secretExponent_label
            // 
            secretExponent_label.AutoSize = true;
            secretExponent_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            secretExponent_label.Location = new Point(78, 84);
            secretExponent_label.Name = "secretExponent_label";
            secretExponent_label.Size = new Size(142, 21);
            secretExponent_label.TabIndex = 5;
            secretExponent_label.Text = "Secret Exponent : ";
            // 
            // segwitP2SHUnComp_label
            // 
            segwitP2SHUnComp_label.AutoSize = true;
            segwitP2SHUnComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            segwitP2SHUnComp_label.Location = new Point(31, 287);
            segwitP2SHUnComp_label.Name = "segwitP2SHUnComp_label";
            segwitP2SHUnComp_label.Size = new Size(189, 21);
            segwitP2SHUnComp_label.TabIndex = 7;
            segwitP2SHUnComp_label.Text = "SegwitP2SH (UnComp) : ";
            // 
            // passphrase_textBox
            // 
            passphrase_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passphrase_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passphrase_textBox.Location = new Point(226, 34);
            passphrase_textBox.Name = "passphrase_textBox";
            passphrase_textBox.Size = new Size(489, 25);
            passphrase_textBox.TabIndex = 14;
            passphrase_textBox.TextChanged += passphrase_textBox_TextChanged;
            // 
            // secretExponent_textBox
            // 
            secretExponent_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            secretExponent_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            secretExponent_textBox.Location = new Point(226, 83);
            secretExponent_textBox.Name = "secretExponent_textBox";
            secretExponent_textBox.ReadOnly = true;
            secretExponent_textBox.Size = new Size(489, 25);
            secretExponent_textBox.TabIndex = 15;
            // 
            // privateKeyUnComp_textBox
            // 
            privateKeyUnComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            privateKeyUnComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            privateKeyUnComp_textBox.Location = new Point(226, 132);
            privateKeyUnComp_textBox.Name = "privateKeyUnComp_textBox";
            privateKeyUnComp_textBox.ReadOnly = true;
            privateKeyUnComp_textBox.Size = new Size(489, 25);
            privateKeyUnComp_textBox.TabIndex = 16;
            // 
            // publicKeyUnComp_textBox
            // 
            publicKeyUnComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            publicKeyUnComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            publicKeyUnComp_textBox.Location = new Point(226, 163);
            publicKeyUnComp_textBox.Multiline = true;
            publicKeyUnComp_textBox.Name = "publicKeyUnComp_textBox";
            publicKeyUnComp_textBox.ReadOnly = true;
            publicKeyUnComp_textBox.Size = new Size(489, 45);
            publicKeyUnComp_textBox.TabIndex = 17;
            // 
            // legacyAddresUnComp_textBox
            // 
            legacyAddresUnComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            legacyAddresUnComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            legacyAddresUnComp_textBox.Location = new Point(226, 228);
            legacyAddresUnComp_textBox.Name = "legacyAddresUnComp_textBox";
            legacyAddresUnComp_textBox.ReadOnly = true;
            legacyAddresUnComp_textBox.Size = new Size(489, 25);
            legacyAddresUnComp_textBox.TabIndex = 18;
            // 
            // segwitUnComp_textBox
            // 
            segwitUnComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            segwitUnComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            segwitUnComp_textBox.Location = new Point(226, 257);
            segwitUnComp_textBox.Name = "segwitUnComp_textBox";
            segwitUnComp_textBox.ReadOnly = true;
            segwitUnComp_textBox.Size = new Size(489, 25);
            segwitUnComp_textBox.TabIndex = 19;
            // 
            // segwitP2SHUnComp_textBox
            // 
            segwitP2SHUnComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            segwitP2SHUnComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            segwitP2SHUnComp_textBox.Location = new Point(226, 286);
            segwitP2SHUnComp_textBox.Name = "segwitP2SHUnComp_textBox";
            segwitP2SHUnComp_textBox.ReadOnly = true;
            segwitP2SHUnComp_textBox.Size = new Size(489, 25);
            segwitP2SHUnComp_textBox.TabIndex = 20;
            // 
            // taprootBIP86Comp_textBox
            // 
            taprootBIP86Comp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taprootBIP86Comp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            taprootBIP86Comp_textBox.Location = new Point(226, 491);
            taprootBIP86Comp_textBox.Name = "taprootBIP86Comp_textBox";
            taprootBIP86Comp_textBox.ReadOnly = true;
            taprootBIP86Comp_textBox.Size = new Size(489, 25);
            taprootBIP86Comp_textBox.TabIndex = 33;
            // 
            // segwitP2SHComp_textBox
            // 
            segwitP2SHComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            segwitP2SHComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            segwitP2SHComp_textBox.Location = new Point(226, 462);
            segwitP2SHComp_textBox.Name = "segwitP2SHComp_textBox";
            segwitP2SHComp_textBox.ReadOnly = true;
            segwitP2SHComp_textBox.Size = new Size(489, 25);
            segwitP2SHComp_textBox.TabIndex = 32;
            // 
            // segwitComp_textBox
            // 
            segwitComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            segwitComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            segwitComp_textBox.Location = new Point(226, 433);
            segwitComp_textBox.Name = "segwitComp_textBox";
            segwitComp_textBox.ReadOnly = true;
            segwitComp_textBox.Size = new Size(489, 25);
            segwitComp_textBox.TabIndex = 31;
            segwitComp_textBox.TextChanged += segwitComp_textBox_TextChanged;
            // 
            // legacyAddresComp_textBox
            // 
            legacyAddresComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            legacyAddresComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            legacyAddresComp_textBox.Location = new Point(226, 404);
            legacyAddresComp_textBox.Name = "legacyAddresComp_textBox";
            legacyAddresComp_textBox.ReadOnly = true;
            legacyAddresComp_textBox.Size = new Size(489, 25);
            legacyAddresComp_textBox.TabIndex = 30;
            // 
            // publicKeyComp_textBox
            // 
            publicKeyComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            publicKeyComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            publicKeyComp_textBox.Location = new Point(226, 375);
            publicKeyComp_textBox.Name = "publicKeyComp_textBox";
            publicKeyComp_textBox.ReadOnly = true;
            publicKeyComp_textBox.Size = new Size(489, 25);
            publicKeyComp_textBox.TabIndex = 29;
            // 
            // privateKeyComp_textBox
            // 
            privateKeyComp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            privateKeyComp_textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            privateKeyComp_textBox.Location = new Point(226, 346);
            privateKeyComp_textBox.Name = "privateKeyComp_textBox";
            privateKeyComp_textBox.ReadOnly = true;
            privateKeyComp_textBox.Size = new Size(489, 25);
            privateKeyComp_textBox.TabIndex = 28;
            // 
            // taprootBIP86Comp_label
            // 
            taprootBIP86Comp_label.AutoSize = true;
            taprootBIP86Comp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            taprootBIP86Comp_label.Location = new Point(41, 492);
            taprootBIP86Comp_label.Name = "taprootBIP86Comp_label";
            taprootBIP86Comp_label.Size = new Size(179, 21);
            taprootBIP86Comp_label.TabIndex = 0;
            taprootBIP86Comp_label.Text = "TaprootBIP86 (Comp) : ";
            // 
            // segwitP2SHComp_label
            // 
            segwitP2SHComp_label.AutoSize = true;
            segwitP2SHComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            segwitP2SHComp_label.Location = new Point(51, 463);
            segwitP2SHComp_label.Name = "segwitP2SHComp_label";
            segwitP2SHComp_label.Size = new Size(169, 21);
            segwitP2SHComp_label.TabIndex = 1;
            segwitP2SHComp_label.Text = "SegwitP2SH (Comp) : ";
            // 
            // privateKeyComp_label
            // 
            privateKeyComp_label.AutoSize = true;
            privateKeyComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            privateKeyComp_label.Location = new Point(59, 347);
            privateKeyComp_label.Name = "privateKeyComp_label";
            privateKeyComp_label.Size = new Size(161, 21);
            privateKeyComp_label.TabIndex = 5;
            privateKeyComp_label.Text = "Private Key (Comp) : ";
            // 
            // publicKeyComp_label
            // 
            publicKeyComp_label.AutoSize = true;
            publicKeyComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            publicKeyComp_label.Location = new Point(65, 376);
            publicKeyComp_label.Name = "publicKeyComp_label";
            publicKeyComp_label.Size = new Size(155, 21);
            publicKeyComp_label.TabIndex = 4;
            publicKeyComp_label.Text = "Public Key (Comp) : ";
            // 
            // legacyAddresComp_label
            // 
            legacyAddresComp_label.AutoSize = true;
            legacyAddresComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            legacyAddresComp_label.Location = new Point(32, 405);
            legacyAddresComp_label.Name = "legacyAddresComp_label";
            legacyAddresComp_label.Size = new Size(188, 21);
            legacyAddresComp_label.TabIndex = 3;
            legacyAddresComp_label.Text = "Legacy Addres (Comp) : ";
            // 
            // segwitComp_label
            // 
            segwitComp_label.AutoSize = true;
            segwitComp_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            segwitComp_label.Location = new Point(90, 434);
            segwitComp_label.Name = "segwitComp_label";
            segwitComp_label.Size = new Size(130, 21);
            segwitComp_label.TabIndex = 2;
            segwitComp_label.Text = "Segwit (Comp) : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 550);
            Controls.Add(taprootBIP86Comp_textBox);
            Controls.Add(segwitP2SHComp_textBox);
            Controls.Add(segwitComp_textBox);
            Controls.Add(legacyAddresComp_textBox);
            Controls.Add(publicKeyComp_textBox);
            Controls.Add(privateKeyComp_textBox);
            Controls.Add(taprootBIP86Comp_label);
            Controls.Add(segwitP2SHComp_label);
            Controls.Add(privateKeyComp_label);
            Controls.Add(publicKeyComp_label);
            Controls.Add(legacyAddresComp_label);
            Controls.Add(segwitComp_label);
            Controls.Add(segwitP2SHUnComp_textBox);
            Controls.Add(segwitUnComp_textBox);
            Controls.Add(legacyAddresUnComp_textBox);
            Controls.Add(publicKeyUnComp_textBox);
            Controls.Add(privateKeyUnComp_textBox);
            Controls.Add(secretExponent_textBox);
            Controls.Add(passphrase_textBox);
            Controls.Add(segwitP2SHUnComp_label);
            Controls.Add(secretExponent_label);
            Controls.Add(privateKeyUnComp_label);
            Controls.Add(publicKeyUnComp_label);
            Controls.Add(legacyAddresUnComp_label);
            Controls.Add(segwitUnComp_label);
            Controls.Add(passphrase_label);
            Name = "Form1";
            Text = "Bitcoin Address Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passphrase_label;
        private Label segwitUnComp_label;
        private Label legacyAddresUnComp_label;
        private Label publicKeyUnComp_label;
        private Label privateKeyUnComp_label;
        private Label secretExponent_label;
        private Label segwitP2SHUnComp_label;
        private TextBox passphrase_textBox;
        private TextBox secretExponent_textBox;
        private TextBox privateKeyUnComp_textBox;
        private TextBox publicKeyUnComp_textBox;
        private TextBox legacyAddresUnComp_textBox;
        private TextBox segwitUnComp_textBox;
        private TextBox segwitP2SHUnComp_textBox;
        private TextBox taprootBIP86Comp_textBox;
        private TextBox segwitP2SHComp_textBox;
        private TextBox segwitComp_textBox;
        private TextBox legacyAddresComp_textBox;
        private TextBox publicKeyComp_textBox;
        private TextBox privateKeyComp_textBox;
        private Label taprootBIP86Comp_label;
        private Label segwitP2SHComp_label;
        private Label privateKeyComp_label;
        private Label publicKeyComp_label;
        private Label legacyAddresComp_label;
        private Label segwitComp_label;
    }
}
