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
            HotOrCold = new Panel();
            DoneBtn = new Button();
            panel1 = new Panel();
            OrderList = new ListBox();
            label1 = new Label();
            itemPanel = new FlowLayoutPanel();
            HotOrCold.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HotBtn
            // 
            HotBtn.Location = new Point(12, 22);
            HotBtn.Name = "HotBtn";
            HotBtn.Size = new Size(264, 47);
            HotBtn.TabIndex = 0;
            HotBtn.Text = "Hot Beverages";
            HotBtn.UseVisualStyleBackColor = true;
            HotBtn.Click += HotBtn_Click;
            // 
            // ColdBtn
            // 
            ColdBtn.Location = new Point(12, 89);
            ColdBtn.Name = "ColdBtn";
            ColdBtn.Size = new Size(264, 47);
            ColdBtn.TabIndex = 1;
            ColdBtn.Text = "Cold Beverages";
            ColdBtn.UseVisualStyleBackColor = true;
            ColdBtn.Click += ColdBtn_Click;
            // 
            // HotOrCold
            // 
            HotOrCold.Controls.Add(DoneBtn);
            HotOrCold.Controls.Add(panel1);
            HotOrCold.Controls.Add(ColdBtn);
            HotOrCold.Controls.Add(HotBtn);
            HotOrCold.Controls.Add(itemPanel);
            HotOrCold.Dock = DockStyle.Fill;
            HotOrCold.Location = new Point(0, 0);
            HotOrCold.Name = "HotOrCold";
            HotOrCold.Size = new Size(1038, 492);
            HotOrCold.TabIndex = 2;
            // 
            // DoneBtn
            // 
            DoneBtn.BackColor = Color.PaleTurquoise;
            DoneBtn.ForeColor = SystemColors.ActiveCaptionText;
            DoneBtn.Location = new Point(12, 448);
            DoneBtn.Name = "DoneBtn";
            DoneBtn.Size = new Size(264, 47);
            DoneBtn.TabIndex = 5;
            DoneBtn.Text = "Done";
            DoneBtn.UseVisualStyleBackColor = false;
            DoneBtn.Click += DoneBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(OrderList);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(12, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 274);
            panel1.TabIndex = 4;
            // 
            // OrderList
            // 
            OrderList.Font = new Font("Segoe UI", 14F);
            OrderList.FormattingEnabled = true;
            OrderList.ItemHeight = 25;
            OrderList.Location = new Point(13, 49);
            OrderList.Name = "OrderList";
            OrderList.Size = new Size(234, 179);
            OrderList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Order Items";
            label1.Click += label1_Click;
            // 
            // itemPanel
            // 
            itemPanel.AutoScroll = true;
            itemPanel.Dock = DockStyle.Fill;
            itemPanel.Location = new Point(0, 0);
            itemPanel.Name = "itemPanel";
            itemPanel.Padding = new Padding(300, 0, 0, 0);
            itemPanel.Size = new Size(1038, 492);
            itemPanel.TabIndex = 6;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 492);
            Controls.Add(HotOrCold);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            HotOrCold.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button HotBtn;
        private Button ColdBtn;
        private Panel HotOrCold;
        private Panel panel1;
        private Label label1;
        private ListBox OrderList;
        private Button DoneBtn;
        private FlowLayoutPanel itemPanel;
    }
}