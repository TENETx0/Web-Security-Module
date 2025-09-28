
namespace SecurityModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 30);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "SECURITY MODULE";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.WindowFrame;
            groupBox1.Location = new Point(105, 361);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(944, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Terms and Conditions";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Bookman Old Style", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(16, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(909, 160);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(105, 87);
            label2.Name = "label2";
            label2.Size = new Size(442, 214);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(588, 87);
            label3.Name = "label3";
            label3.Size = new Size(558, 271);
            label3.TabIndex = 3;
            label3.Click += label3_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(526, 641);
            button1.Name = "button1";
            button1.Size = new Size(218, 41);
            button1.TabIndex = 4;
            button1.Text = "Start Hacking !";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(526, 572);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(206, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "I Agree and Continue";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 694);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "SecMod";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private EventHandler label3_Click;
    }
}
