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
            OrderList = new ListBox();
            label1 = new Label();
            ColdMenuPanel = new Panel();
            ColdMenuFlow = new FlowLayoutPanel();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            HotMenuPanel = new Panel();
            HotMenuFlow = new FlowLayoutPanel();
            esspressoBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            helpProvider1 = new HelpProvider();
            HotOrCold.SuspendLayout();
            panel1.SuspendLayout();
            ColdMenuPanel.SuspendLayout();
            ColdMenuFlow.SuspendLayout();
            HotMenuPanel.SuspendLayout();
            HotMenuFlow.SuspendLayout();
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
            HotOrCold.Controls.Add(ColdMenuPanel);
            HotOrCold.Controls.Add(HotMenuPanel);
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
            // OrderList
            // 
            OrderList.FormattingEnabled = true;
            OrderList.ItemHeight = 15;
            OrderList.Location = new Point(13, 49);
            OrderList.Name = "OrderList";
            OrderList.Size = new Size(234, 199);
            OrderList.TabIndex = 1;
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
            // ColdMenuPanel
            // 
            ColdMenuPanel.Controls.Add(ColdMenuFlow);
            ColdMenuPanel.Location = new Point(706, 22);
            ColdMenuPanel.Name = "ColdMenuPanel";
            ColdMenuPanel.Size = new Size(384, 429);
            ColdMenuPanel.TabIndex = 3;
            ColdMenuPanel.Paint += ColdMenu_Paint;
            // 
            // ColdMenuFlow
            // 
            ColdMenuFlow.Controls.Add(button10);
            ColdMenuFlow.Controls.Add(button11);
            ColdMenuFlow.Controls.Add(button12);
            ColdMenuFlow.Controls.Add(button13);
            ColdMenuFlow.Controls.Add(button14);
            ColdMenuFlow.Controls.Add(button15);
            ColdMenuFlow.Controls.Add(button16);
            ColdMenuFlow.Controls.Add(button17);
            ColdMenuFlow.Controls.Add(button18);
            ColdMenuFlow.Dock = DockStyle.Fill;
            ColdMenuFlow.Location = new Point(0, 0);
            ColdMenuFlow.Name = "ColdMenuFlow";
            ColdMenuFlow.Size = new Size(384, 429);
            ColdMenuFlow.TabIndex = 1;
            // 
            // button10
            // 
            button10.Location = new Point(3, 3);
            button10.Name = "button10";
            button10.Size = new Size(119, 134);
            button10.TabIndex = 0;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(128, 3);
            button11.Name = "button11";
            button11.Size = new Size(119, 134);
            button11.TabIndex = 1;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(253, 3);
            button12.Name = "button12";
            button12.Size = new Size(119, 134);
            button12.TabIndex = 2;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(3, 143);
            button13.Name = "button13";
            button13.Size = new Size(119, 134);
            button13.TabIndex = 3;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(128, 143);
            button14.Name = "button14";
            button14.Size = new Size(119, 134);
            button14.TabIndex = 4;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(253, 143);
            button15.Name = "button15";
            button15.Size = new Size(119, 134);
            button15.TabIndex = 5;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(3, 283);
            button16.Name = "button16";
            button16.Size = new Size(119, 134);
            button16.TabIndex = 6;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(128, 283);
            button17.Name = "button17";
            button17.Size = new Size(119, 134);
            button17.TabIndex = 7;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(253, 283);
            button18.Name = "button18";
            button18.Size = new Size(119, 134);
            button18.TabIndex = 8;
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = true;
            // 
            // HotMenuPanel
            // 
            HotMenuPanel.Controls.Add(HotMenuFlow);
            HotMenuPanel.Location = new Point(301, 22);
            HotMenuPanel.Name = "HotMenuPanel";
            HotMenuPanel.Size = new Size(384, 429);
            HotMenuPanel.TabIndex = 2;
            // 
            // HotMenuFlow
            // 
            HotMenuFlow.Controls.Add(esspressoBtn);
            HotMenuFlow.Controls.Add(button2);
            HotMenuFlow.Controls.Add(button3);
            HotMenuFlow.Controls.Add(button4);
            HotMenuFlow.Controls.Add(button5);
            HotMenuFlow.Controls.Add(button6);
            HotMenuFlow.Controls.Add(button7);
            HotMenuFlow.Controls.Add(button8);
            HotMenuFlow.Controls.Add(button9);
            HotMenuFlow.Dock = DockStyle.Fill;
            HotMenuFlow.Location = new Point(0, 0);
            HotMenuFlow.Name = "HotMenuFlow";
            HotMenuFlow.Size = new Size(384, 429);
            HotMenuFlow.TabIndex = 0;
            // 
            // esspressoBtn
            // 
            esspressoBtn.BackColor = Color.FromArgb(255, 192, 128);
            esspressoBtn.BackgroundImage = Properties.Resources.Esspresso;
            esspressoBtn.BackgroundImageLayout = ImageLayout.Center;
            esspressoBtn.Location = new Point(3, 3);
            esspressoBtn.Name = "esspressoBtn";
            esspressoBtn.Size = new Size(119, 134);
            esspressoBtn.TabIndex = 0;
            esspressoBtn.Text = "Esspresso";
            esspressoBtn.UseVisualStyleBackColor = false;
            esspressoBtn.Click += esspressoBtn_Click;
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
            ColdMenuPanel.ResumeLayout(false);
            ColdMenuFlow.ResumeLayout(false);
            HotMenuPanel.ResumeLayout(false);
            HotMenuFlow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button HotBtn;
        private Button ColdBtn;
        private Panel HotOrCold;
        private HelpProvider helpProvider1;
        private Panel HotMenuPanel;
        private Panel ColdMenuPanel;
        private FlowLayoutPanel HotMenuFlow;
        private Button esspressoBtn;
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
        private FlowLayoutPanel ColdMenuFlow;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
    }
}