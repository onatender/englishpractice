namespace English_Practice_V1._0
{
    partial class removeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(removeForm));
            listBox1=new ListBox();
            button1=new Button();
            wordCount=new Label();
            textBox1=new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Location=new Point(12, 34);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(302, 229);
            listBox1.TabIndex=0;
            listBox1.SelectedIndexChanged+=listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location=new Point(12, 298);
            button1.Name="button1";
            button1.Size=new Size(302, 23);
            button1.TabIndex=1;
            button1.Text="DELETE SELECTED WORD";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // wordCount
            // 
            wordCount.AutoSize=true;
            wordCount.BackColor=Color.Transparent;
            wordCount.ForeColor=Color.FromArgb(250, 250, 250);
            wordCount.Location=new Point(206, 9);
            wordCount.Name="wordCount";
            wordCount.Size=new Size(87, 15);
            wordCount.TabIndex=2;
            wordCount.Text="Word Count : 0";
            // 
            // textBox1
            // 
            textBox1.ForeColor=Color.Gray;
            textBox1.Location=new Point(12, 269);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(302, 23);
            textBox1.TabIndex=3;
            textBox1.Text="Search";
            textBox1.TextChanged+=textBox1_TextChanged;
            textBox1.Enter+=textBox1_Enter;
            textBox1.Leave+=textBox1_Leave;
            // 
            // removeForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(31, 31, 31);
            ClientSize=new Size(326, 333);
            Controls.Add(textBox1);
            Controls.Add(wordCount);
            Controls.Add(button1);
            Controls.Add(listBox1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            MinimizeBox=false;
            Name="removeForm";
            Text="Remove Word";
            Load+=removeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label wordCount;
        private TextBox textBox1;
    }
}