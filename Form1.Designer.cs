namespace EliseoSmuttEjer5
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
            tb1 = new TextBox();
            tb2 = new TextBox();
            tb3 = new TextBox();
            btn = new Button();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.Location = new Point(102, 22);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 0;
            tb1.Tag = "";
            // 
            // tb2
            // 
            tb2.Location = new Point(102, 65);
            tb2.Name = "tb2";
            tb2.Size = new Size(100, 23);
            tb2.TabIndex = 3;
            // 
            // tb3
            // 
            tb3.Location = new Point(102, 110);
            tb3.Name = "tb3";
            tb3.Size = new Size(100, 23);
            tb3.TabIndex = 2;
            // 
            // btn
            // 
            btn.Location = new Point(93, 149);
            btn.Name = "btn";
            btn.Size = new Size(120, 27);
            btn.TabIndex = 4;
            btn.Text = "guardar datos";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(102, 212);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 15);
            lbl1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(lbl1);
            Controls.Add(btn);
            Controls.Add(tb3);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1;
        private TextBox tb2;
        private TextBox tb3;
        private Button btn;
        private Label lbl1;
    }
}