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
            panel1 = new Panel();
            label1 = new Label();
            ColdMenu = new Panel();
            HotMenu = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            helpProvider1 = new HelpProvider();
            OrderList = new ListBox();
            HotOrCold.SuspendLayout();
            panel1.SuspendLayout();
            HotMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            ColdBtn.Location = new Point(12, 88);
            ColdBtn.Name = "ColdBtn";
            ColdBtn.Size = new Size(264, 47);
            ColdBtn.TabIndex = 1;
            ColdBtn.Text = "Cold Beverages";
            ColdBtn.UseVisualStyleBackColor = true;
            ColdBtn.Click += ColdBtn_Click;
            // 
            // HotOrCold
            // 
            HotOrCold.Controls.Add(panel1);
            HotOrCold.Controls.Add(ColdMenu);
            HotOrCold.Controls.Add(HotMenu);
            HotOrCold.Controls.Add(ColdBtn);
            HotOrCold.Controls.Add(HotBtn);
            HotOrCold.Dock = DockStyle.Fill;
            HotOrCold.Location = new Point(0, 0);
            HotOrCold.Name = "HotOrCold";
            HotOrCold.Size = new Size(1123, 517);
            HotOrCold.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(OrderList);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(12, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 274);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ColdMenu
            // 
            ColdMenu.Location = new Point(706, 22);
            ColdMenu.Name = "ColdMenu";
            ColdMenu.Size = new Size(384, 404);
            ColdMenu.TabIndex = 3;
            ColdMenu.Paint += ColdMenu_Paint;
            // 
            // HotMenu
            // 
            HotMenu.Controls.Add(flowLayoutPanel1);
            HotMenu.Location = new Point(301, 22);
            HotMenu.Name = "HotMenu";
            HotMenu.Size = new Size(384, 404);
            HotMenu.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(384, 404);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 134);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(128, 3);
            button2.Name = "button2";
            button2.Size = new Size(119, 134);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(253, 3);
            button3.Name = "button3";
            button3.Size = new Size(119, 134);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 143);
            button4.Name = "button4";
            button4.Size = new Size(119, 134);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(128, 143);
            button5.Name = "button5";
            button5.Size = new Size(119, 134);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(253, 143);
            button6.Name = "button6";
            button6.Size = new Size(119, 134);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(3, 283);
            button7.Name = "button7";
            button7.Size = new Size(119, 134);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(128, 283);
            button8.Name = "button8";
            button8.Size = new Size(119, 134);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(253, 283);
            button9.Name = "button9";
            button9.Size = new Size(119, 134);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // OrderList
            // 
            OrderList.FormattingEnabled = true;
            OrderList.ItemHeight = 15;
            OrderList.Location = new Point(13, 49);
            OrderList.Name = "OrderList";
            OrderList.Size = new Size(234, 199);
            OrderList.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 517);
            Controls.Add(HotOrCold);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            HotOrCold.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HotMenu.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button HotBtn;
        private Button ColdBtn;
        private Panel HotOrCold;
        private HelpProvider helpProvider1;
        private Panel HotMenu;
        private Panel ColdMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ListBox OrderList;
    }
}