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
            HotMenuPanel = new Panel();
            HotMenuFlow = new FlowLayoutPanel();
            esspressoBtn = new Button();
            latteBtn = new Button();
            capuchinoBtn = new Button();
            macchiatoBtn = new Button();
            americanoBtn = new Button();
            brewedBtn = new Button();
            flatwhiteBtn = new Button();
            mochaBtn = new Button();
            whiteMochaBtn = new Button();
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
            helpProvider1 = new HelpProvider();
            DoneBtn = new Button();
            HotOrCold.SuspendLayout();
            panel1.SuspendLayout();
            HotMenuPanel.SuspendLayout();
            HotMenuFlow.SuspendLayout();
            ColdMenuPanel.SuspendLayout();
            ColdMenuFlow.SuspendLayout();
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
            HotOrCold.Controls.Add(HotMenuPanel);
            HotOrCold.Controls.Add(ColdBtn);
            HotOrCold.Controls.Add(HotBtn);
            HotOrCold.Controls.Add(ColdMenuPanel);
            HotOrCold.Dock = DockStyle.Fill;
            HotOrCold.Location = new Point(0, 0);
            HotOrCold.Name = "HotOrCold";
            HotOrCold.Size = new Size(756, 533);
            HotOrCold.TabIndex = 2;
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
            // HotMenuPanel
            // 
            HotMenuPanel.Controls.Add(HotMenuFlow);
            HotMenuPanel.Location = new Point(352, 22);
            HotMenuPanel.Name = "HotMenuPanel";
            HotMenuPanel.Size = new Size(384, 471);
            HotMenuPanel.TabIndex = 2;
            // 
            // HotMenuFlow
            // 
            HotMenuFlow.Controls.Add(esspressoBtn);
            HotMenuFlow.Controls.Add(latteBtn);
            HotMenuFlow.Controls.Add(capuchinoBtn);
            HotMenuFlow.Controls.Add(macchiatoBtn);
            HotMenuFlow.Controls.Add(americanoBtn);
            HotMenuFlow.Controls.Add(brewedBtn);
            HotMenuFlow.Controls.Add(flatwhiteBtn);
            HotMenuFlow.Controls.Add(mochaBtn);
            HotMenuFlow.Controls.Add(whiteMochaBtn);
            HotMenuFlow.Dock = DockStyle.Fill;
            HotMenuFlow.Location = new Point(0, 0);
            HotMenuFlow.Name = "HotMenuFlow";
            HotMenuFlow.Size = new Size(384, 471);
            HotMenuFlow.TabIndex = 0;
            // 
            // esspressoBtn
            // 
            esspressoBtn.BackColor = Color.FromArgb(255, 192, 128);
            esspressoBtn.BackgroundImage = Properties.Resources.Esspresso;
            esspressoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            esspressoBtn.Font = new Font("Segoe UI", 12F);
            esspressoBtn.ForeColor = SystemColors.ControlText;
            esspressoBtn.Location = new Point(2, 2);
            esspressoBtn.Margin = new Padding(2);
            esspressoBtn.Name = "esspressoBtn";
            esspressoBtn.RightToLeft = RightToLeft.No;
            esspressoBtn.Size = new Size(119, 150);
            esspressoBtn.TabIndex = 0;
            esspressoBtn.Text = "Esspresso\r\n";
            esspressoBtn.TextAlign = ContentAlignment.BottomCenter;
            esspressoBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            esspressoBtn.UseVisualStyleBackColor = false;
            esspressoBtn.Click += esspressoBtn_Click;
            // 
            // latteBtn
            // 
            latteBtn.BackgroundImage = Properties.Resources.Latte;
            latteBtn.BackgroundImageLayout = ImageLayout.Zoom;
            latteBtn.Font = new Font("Segoe UI", 12F);
            latteBtn.ImageAlign = ContentAlignment.BottomCenter;
            latteBtn.Location = new Point(126, 3);
            latteBtn.Name = "latteBtn";
            latteBtn.Size = new Size(119, 150);
            latteBtn.TabIndex = 1;
            latteBtn.Text = "Latte";
            latteBtn.TextAlign = ContentAlignment.BottomCenter;
            latteBtn.UseVisualStyleBackColor = true;
            latteBtn.Click += latteBtn_Click;
            // 
            // capuchinoBtn
            // 
            capuchinoBtn.BackgroundImage = Properties.Resources.capuchino;
            capuchinoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            capuchinoBtn.Font = new Font("Segoe UI", 12F);
            capuchinoBtn.Location = new Point(251, 3);
            capuchinoBtn.Name = "capuchinoBtn";
            capuchinoBtn.Size = new Size(119, 150);
            capuchinoBtn.TabIndex = 5;
            capuchinoBtn.Text = "Capuchino";
            capuchinoBtn.TextAlign = ContentAlignment.BottomCenter;
            capuchinoBtn.UseVisualStyleBackColor = true;
            capuchinoBtn.Click += capuchinoBtn_Click;
            // 
            // macchiatoBtn
            // 
            macchiatoBtn.BackgroundImage = Properties.Resources.Machiato;
            macchiatoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            macchiatoBtn.Font = new Font("Segoe UI", 12F);
            macchiatoBtn.Location = new Point(3, 159);
            macchiatoBtn.Name = "macchiatoBtn";
            macchiatoBtn.Size = new Size(119, 150);
            macchiatoBtn.TabIndex = 7;
            macchiatoBtn.Text = "Macchiato";
            macchiatoBtn.TextAlign = ContentAlignment.BottomCenter;
            macchiatoBtn.UseVisualStyleBackColor = true;
            macchiatoBtn.Click += macchiatoBtn_Click;
            // 
            // americanoBtn
            // 
            americanoBtn.BackgroundImage = Properties.Resources.pngtree_americano_coffee_beans_transparent_white_background_png_image_6698453;
            americanoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            americanoBtn.Font = new Font("Segoe UI", 12F);
            americanoBtn.Location = new Point(128, 159);
            americanoBtn.Name = "americanoBtn";
            americanoBtn.Size = new Size(119, 150);
            americanoBtn.TabIndex = 2;
            americanoBtn.Text = "Americano";
            americanoBtn.TextAlign = ContentAlignment.BottomCenter;
            americanoBtn.UseVisualStyleBackColor = true;
            americanoBtn.Click += americanoBtn_Click;
            // 
            // brewedBtn
            // 
            brewedBtn.BackgroundImage = Properties.Resources.Brewed;
            brewedBtn.BackgroundImageLayout = ImageLayout.Stretch;
            brewedBtn.Font = new Font("Segoe UI", 12F);
            brewedBtn.Location = new Point(253, 159);
            brewedBtn.Name = "brewedBtn";
            brewedBtn.Size = new Size(119, 150);
            brewedBtn.TabIndex = 4;
            brewedBtn.Text = "Brewed";
            brewedBtn.TextAlign = ContentAlignment.BottomCenter;
            brewedBtn.UseVisualStyleBackColor = true;
            brewedBtn.Click += brewedBtn_Click;
            // 
            // flatwhiteBtn
            // 
            flatwhiteBtn.BackgroundImage = Properties.Resources.FlatWhite;
            flatwhiteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            flatwhiteBtn.Font = new Font("Segoe UI", 12F);
            flatwhiteBtn.Location = new Point(3, 315);
            flatwhiteBtn.Name = "flatwhiteBtn";
            flatwhiteBtn.Size = new Size(119, 150);
            flatwhiteBtn.TabIndex = 6;
            flatwhiteBtn.Text = "Flat White";
            flatwhiteBtn.TextAlign = ContentAlignment.BottomCenter;
            flatwhiteBtn.UseVisualStyleBackColor = true;
            flatwhiteBtn.Click += flatwhiteBtn_Click;
            // 
            // mochaBtn
            // 
            mochaBtn.BackgroundImage = Properties.Resources.Mocha1;
            mochaBtn.BackgroundImageLayout = ImageLayout.Stretch;
            mochaBtn.Font = new Font("Segoe UI", 12F);
            mochaBtn.Location = new Point(128, 315);
            mochaBtn.Name = "mochaBtn";
            mochaBtn.Size = new Size(119, 150);
            mochaBtn.TabIndex = 3;
            mochaBtn.Text = "Mocha";
            mochaBtn.TextAlign = ContentAlignment.BottomCenter;
            mochaBtn.UseVisualStyleBackColor = true;
            mochaBtn.Click += mochaBtn_Click;
            // 
            // whiteMochaBtn
            // 
            whiteMochaBtn.BackgroundImage = Properties.Resources.White_Mocha;
            whiteMochaBtn.BackgroundImageLayout = ImageLayout.Stretch;
            whiteMochaBtn.Font = new Font("Segoe UI", 12F);
            whiteMochaBtn.Location = new Point(253, 315);
            whiteMochaBtn.Name = "whiteMochaBtn";
            whiteMochaBtn.Size = new Size(119, 150);
            whiteMochaBtn.TabIndex = 8;
            whiteMochaBtn.Text = "White Mocha ";
            whiteMochaBtn.TextAlign = ContentAlignment.BottomCenter;
            whiteMochaBtn.UseVisualStyleBackColor = true;
            whiteMochaBtn.Click += whiteMochaBtn_Click;
            // 
            // ColdMenuPanel
            // 
            ColdMenuPanel.Controls.Add(ColdMenuFlow);
            ColdMenuPanel.Location = new Point(352, 22);
            ColdMenuPanel.Name = "ColdMenuPanel";
            ColdMenuPanel.Size = new Size(384, 471);
            ColdMenuPanel.TabIndex = 3;
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
            ColdMenuFlow.Size = new Size(384, 471);
            ColdMenuFlow.TabIndex = 1;
            // 
            // button10
            // 
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.Font = new Font("Segoe UI", 12F);
            button10.Location = new Point(3, 3);
            button10.Name = "button10";
            button10.Size = new Size(119, 149);
            button10.TabIndex = 0;
            button10.Text = "button10";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button11.Font = new Font("Segoe UI", 12F);
            button11.Location = new Point(128, 3);
            button11.Name = "button11";
            button11.Size = new Size(119, 149);
            button11.TabIndex = 1;
            button11.Text = "button11";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.Font = new Font("Segoe UI", 12F);
            button12.Location = new Point(253, 3);
            button12.Name = "button12";
            button12.Size = new Size(119, 149);
            button12.TabIndex = 2;
            button12.Text = "button12";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.Stretch;
            button13.Font = new Font("Segoe UI", 12F);
            button13.Location = new Point(3, 158);
            button13.Name = "button13";
            button13.Size = new Size(119, 149);
            button13.TabIndex = 3;
            button13.Text = "button13";
            button13.TextAlign = ContentAlignment.BottomCenter;
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.BackgroundImageLayout = ImageLayout.Stretch;
            button14.Font = new Font("Segoe UI", 12F);
            button14.Location = new Point(128, 158);
            button14.Name = "button14";
            button14.Size = new Size(119, 149);
            button14.TabIndex = 4;
            button14.Text = "button14";
            button14.TextAlign = ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.BackgroundImageLayout = ImageLayout.Stretch;
            button15.Font = new Font("Segoe UI", 12F);
            button15.Location = new Point(253, 158);
            button15.Name = "button15";
            button15.Size = new Size(119, 149);
            button15.TabIndex = 5;
            button15.Text = "button15";
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.BackgroundImageLayout = ImageLayout.Stretch;
            button16.Font = new Font("Segoe UI", 12F);
            button16.Location = new Point(3, 313);
            button16.Name = "button16";
            button16.Size = new Size(119, 149);
            button16.TabIndex = 6;
            button16.Text = "button16";
            button16.TextAlign = ContentAlignment.BottomCenter;
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.BackgroundImageLayout = ImageLayout.Stretch;
            button17.Font = new Font("Segoe UI", 12F);
            button17.Location = new Point(128, 313);
            button17.Name = "button17";
            button17.Size = new Size(119, 149);
            button17.TabIndex = 7;
            button17.Text = "button17";
            button17.TextAlign = ContentAlignment.BottomCenter;
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.BackgroundImageLayout = ImageLayout.Stretch;
            button18.Font = new Font("Segoe UI", 12F);
            button18.Location = new Point(253, 313);
            button18.Name = "button18";
            button18.Size = new Size(119, 149);
            button18.TabIndex = 8;
            button18.Text = "button18";
            button18.TextAlign = ContentAlignment.BottomCenter;
            button18.UseVisualStyleBackColor = true;
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 533);
            Controls.Add(HotOrCold);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            HotOrCold.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HotMenuPanel.ResumeLayout(false);
            HotMenuFlow.ResumeLayout(false);
            ColdMenuPanel.ResumeLayout(false);
            ColdMenuFlow.ResumeLayout(false);
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
        private Button latteBtn;
        private Button americanoBtn;
        private Button mochaBtn;
        private Button brewedBtn;
        private Button capuchinoBtn;
        private Button flatwhiteBtn;
        private Button macchiatoBtn;
        private Button whiteMochaBtn;
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
        private Button DoneBtn;
    }
}