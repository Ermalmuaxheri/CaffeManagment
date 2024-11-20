namespace edomndtest2
{
    partial class Menu
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
            HotBtn = new Button();
            ColdBtn = new Button();
            listView1 = new ListView();
            toolStripContainer1 = new ToolStripContainer();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // HotBtn
            // 
            HotBtn.Location = new Point(116, 95);
            HotBtn.Name = "HotBtn";
            HotBtn.Size = new Size(264, 230);
            HotBtn.TabIndex = 0;
            HotBtn.Text = "Hot Beverages";
            HotBtn.UseVisualStyleBackColor = true;
            HotBtn.Click += HotBtn_Click;
            // 
            // ColdBtn
            // 
            ColdBtn.Location = new Point(432, 95);
            ColdBtn.Name = "ColdBtn";
            ColdBtn.Size = new Size(264, 230);
            ColdBtn.TabIndex = 1;
            ColdBtn.Text = "Cold Beverages";
            ColdBtn.UseVisualStyleBackColor = true;
            ColdBtn.Click += ColdBtn_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(68, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(150, 150);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Location = new Point(115, 69);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(150, 175);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Controls.Add(listView1);
            Controls.Add(ColdBtn);
            Controls.Add(HotBtn);
            Name = "Menu";
            Text = "Menu";
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button HotBtn;
        private Button ColdBtn;
        private ListView listView1;
        private ToolStripContainer toolStripContainer1;
    }
}