namespace English_Practice_V1._0
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
            label1=new Label();
            radioButton1=new RadioButton();
            radioButton2=new RadioButton();
            radioButton3=new RadioButton();
            radioButton4=new RadioButton();
            button1=new Button();
            menuStrip1=new MenuStrip();
            addWordToolStripMenuItem=new ToolStripMenuItem();
            removeWordToolStripMenuItem=new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor=Color.FromArgb(214, 214, 214);
            label1.Location=new Point(12, 23);
            label1.Name="label1";
            label1.Size=new Size(194, 65);
            label1.TabIndex=0;
            label1.Text="you must";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            label1.Click+=label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize=true;
            radioButton1.ForeColor=Color.FromArgb(214, 214, 214);
            radioButton1.Location=new Point(12, 106);
            radioButton1.Name="radioButton1";
            radioButton1.Size=new Size(45, 19);
            radioButton1.TabIndex=1;
            radioButton1.TabStop=true;
            radioButton1.Text="add";
            radioButton1.UseVisualStyleBackColor=true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize=true;
            radioButton2.ForeColor=Color.FromArgb(214, 214, 214);
            radioButton2.Location=new Point(12, 131);
            radioButton2.Name="radioButton2";
            radioButton2.Size=new Size(62, 19);
            radioButton2.TabIndex=2;
            radioButton2.TabStop=true;
            radioButton2.Text="at least";
            radioButton2.UseVisualStyleBackColor=true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize=true;
            radioButton3.ForeColor=Color.FromArgb(214, 214, 214);
            radioButton3.Location=new Point(12, 156);
            radioButton3.Name="radioButton3";
            radioButton3.Size=new Size(31, 19);
            radioButton3.TabIndex=3;
            radioButton3.TabStop=true;
            radioButton3.Text="5";
            radioButton3.UseVisualStyleBackColor=true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize=true;
            radioButton4.ForeColor=Color.FromArgb(214, 214, 214);
            radioButton4.Location=new Point(12, 181);
            radioButton4.Name="radioButton4";
            radioButton4.Size=new Size(57, 19);
            radioButton4.TabIndex=4;
            radioButton4.TabStop=true;
            radioButton4.Text="words";
            radioButton4.UseVisualStyleBackColor=true;
            // 
            // button1
            // 
            button1.Location=new Point(27, 225);
            button1.Name="button1";
            button1.Size=new Size(154, 23);
            button1.TabIndex=5;
            button1.Text="CHECK";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor=Color.FromArgb(31, 31, 31);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addWordToolStripMenuItem, removeWordToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(218, 24);
            menuStrip1.TabIndex=6;
            menuStrip1.Text="menuStrip1";
            // 
            // addWordToolStripMenuItem
            // 
            addWordToolStripMenuItem.BackColor=Color.Transparent;
            addWordToolStripMenuItem.ForeColor=Color.FromArgb(214, 214, 214);
            addWordToolStripMenuItem.Image=Properties.Resources.add;
            addWordToolStripMenuItem.Name="addWordToolStripMenuItem";
            addWordToolStripMenuItem.Size=new Size(89, 20);
            addWordToolStripMenuItem.Text="Add Word";
            addWordToolStripMenuItem.Click+=addWordToolStripMenuItem_Click;
            // 
            // removeWordToolStripMenuItem
            // 
            removeWordToolStripMenuItem.BackColor=Color.Transparent;
            removeWordToolStripMenuItem.ForeColor=Color.FromArgb(250, 250, 250);
            removeWordToolStripMenuItem.Image=Properties.Resources.removeBut;
            removeWordToolStripMenuItem.Name="removeWordToolStripMenuItem";
            removeWordToolStripMenuItem.Size=new Size(110, 20);
            removeWordToolStripMenuItem.Text="Remove Word";
            removeWordToolStripMenuItem.Click+=removeWordToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleMode=AutoScaleMode.None;
            BackColor=Color.FromArgb(31, 31, 31);
            ClientSize=new Size(218, 260);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MainMenuStrip=menuStrip1;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="Form1";
            Text="English Practice";
            Load+=Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addWordToolStripMenuItem;
        private ToolStripMenuItem removeWordToolStripMenuItem;
    }
}