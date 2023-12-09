namespace English_Practice_V1._0
{
    partial class wordForm
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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordForm));
            textBox1=new TextBox();
            textBox2=new TextBox();
            button1=new Button();
            timer1=new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor=Color.Gray;
            textBox1.Location=new Point(12, 12);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(142, 23);
            textBox1.TabIndex=0;
            textBox1.Text="English";
            textBox1.Enter+=textBox1_Enter;
            textBox1.KeyPress+=textBox1_KeyPress;
            textBox1.Leave+=textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.ForeColor=Color.Gray;
            textBox2.Location=new Point(12, 41);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(142, 23);
            textBox2.TabIndex=1;
            textBox2.Text="Turkish";
            textBox2.Enter+=textBox2_Enter;
            textBox2.KeyPress+=textBox1_KeyPress;
            textBox2.Leave+=textBox2_Leave;
            // 
            // button1
            // 
            button1.Location=new Point(12, 70);
            button1.Name="button1";
            button1.Size=new Size(142, 23);
            button1.TabIndex=2;
            button1.Text="ADD";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // wordForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(31, 31, 31);
            ClientSize=new Size(167, 110);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            MinimizeBox=false;
            Name="wordForm";
            Text="Add Word";
            Load+=wordForm_Load;
            KeyPress+=wordForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}