namespace edomndtest2
{
    partial class TableForm
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
            splitContainer1 = new SplitContainer();
            VoidBtn = new Button();
            DiscountBtn = new Button();
            AddCoffeBtn = new Button();
            DoneBtn = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.Add(VoidBtn);
            splitContainer1.Panel1.Controls.Add(DiscountBtn);
            splitContainer1.Panel1.Controls.Add(AddCoffeBtn);
            splitContainer1.Panel1.Controls.Add(DoneBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBox1);
            splitContainer1.Size = new Size(673, 531);
            splitContainer1.SplitterDistance = 100;
            splitContainer1.TabIndex = 0;
            // 
            // VoidBtn
            // 
            VoidBtn.Location = new Point(546, 50);
            VoidBtn.Name = "VoidBtn";
            VoidBtn.Size = new Size(75, 23);
            VoidBtn.TabIndex = 2;
            VoidBtn.Text = "Void";
            VoidBtn.UseVisualStyleBackColor = true;
            // 
            // DiscountBtn
            // 
            DiscountBtn.Location = new Point(546, 21);
            DiscountBtn.Name = "DiscountBtn";
            DiscountBtn.Size = new Size(75, 23);
            DiscountBtn.TabIndex = 1;
            DiscountBtn.Text = "%";
            DiscountBtn.UseVisualStyleBackColor = true;
            // 
            // AddCoffeBtn
            // 
            AddCoffeBtn.Location = new Point(328, 3);
            AddCoffeBtn.Name = "AddCoffeBtn";
            AddCoffeBtn.Size = new Size(187, 97);
            AddCoffeBtn.TabIndex = 0;
            AddCoffeBtn.Text = "Add To Order";
            AddCoffeBtn.UseVisualStyleBackColor = true;
            AddCoffeBtn.Click += AddCoffeBtn_Click;
            // 
            // DoneBtn
            // 
            DoneBtn.Location = new Point(135, 3);
            DoneBtn.Name = "DoneBtn";
            DoneBtn.Size = new Size(187, 97);
            DoneBtn.TabIndex = 0;
            DoneBtn.Text = "Done";
            DoneBtn.UseVisualStyleBackColor = true;
            DoneBtn.Click += DoneBtn_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(673, 427);
            listBox1.TabIndex = 0;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 531);
            Controls.Add(splitContainer1);
            Name = "TableForm";
            Text = "TableForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button DoneBtn;
        private Button VoidBtn;
        private Button DiscountBtn;
        private Button AddCoffeBtn;
        private ListBox listBox1;
    }
}