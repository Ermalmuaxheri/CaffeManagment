﻿namespace edomndtest2
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
            checkoutBtn = new Button();
            VoidBtn = new Button();
            AddCoffeBtn = new Button();
            DoneBtn = new Button();
            Totali = new Label();
            label1 = new Label();
            MenuList = new ListView();
            Name = new ColumnHeader();
            Quantity = new ColumnHeader();
            Price = new ColumnHeader();
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
            splitContainer1.Panel1.Controls.Add(checkoutBtn);
            splitContainer1.Panel1.Controls.Add(VoidBtn);
            splitContainer1.Panel1.Controls.Add(AddCoffeBtn);
            splitContainer1.Panel1.Controls.Add(DoneBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Totali);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(MenuList);
            splitContainer1.Size = new Size(651, 531);
            splitContainer1.SplitterDistance = 100;
            splitContainer1.TabIndex = 0;
            // 
            // checkoutBtn
            // 
            checkoutBtn.Location = new Point(372, 1);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(137, 97);
            checkoutBtn.TabIndex = 1;
            checkoutBtn.Text = "Checkout";
            checkoutBtn.UseVisualStyleBackColor = true;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // VoidBtn
            // 
            VoidBtn.Location = new Point(543, 38);
            VoidBtn.Name = "VoidBtn";
            VoidBtn.Size = new Size(75, 23);
            VoidBtn.TabIndex = 2;
            VoidBtn.Text = "Void";
            VoidBtn.UseVisualStyleBackColor = true;
            VoidBtn.Click += VoidBtn_Click;
            // 
            // AddCoffeBtn
            // 
            AddCoffeBtn.Location = new Point(202, 1);
            AddCoffeBtn.Name = "AddCoffeBtn";
            AddCoffeBtn.Size = new Size(137, 97);
            AddCoffeBtn.TabIndex = 0;
            AddCoffeBtn.Text = "Add To Order";
            AddCoffeBtn.UseVisualStyleBackColor = true;
            AddCoffeBtn.Click += AddCoffeBtn_Click;
            // 
            // DoneBtn
            // 
            DoneBtn.Location = new Point(30, 1);
            DoneBtn.Name = "DoneBtn";
            DoneBtn.Size = new Size(137, 97);
            DoneBtn.TabIndex = 0;
            DoneBtn.Text = "Done";
            DoneBtn.UseVisualStyleBackColor = true;
            DoneBtn.Click += DoneBtn_Click;
            // 
            // Totali
            // 
            Totali.AutoSize = true;
            Totali.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Totali.Location = new Point(458, 365);
            Totali.Name = "Totali";
            Totali.Size = new Size(83, 37);
            Totali.TabIndex = 2;
            Totali.Text = "______";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 365);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 1;
            label1.Text = "Total:";
            // 
            // MenuList
            // 
            MenuList.BorderStyle = BorderStyle.None;
            MenuList.Columns.AddRange(new ColumnHeader[] { Name, Quantity, Price });
            MenuList.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuList.Location = new Point(0, 0);
            MenuList.Name = "MenuList";
            MenuList.Size = new Size(651, 345);
            MenuList.TabIndex = 0;
            MenuList.UseCompatibleStateImageBehavior = false;
            MenuList.View = View.Details;
            MenuList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 200;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.TextAlign = HorizontalAlignment.Center;
            Quantity.Width = 200;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.TextAlign = HorizontalAlignment.Center;
            Price.Width = 200;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 531);
            Controls.Add(splitContainer1);
            //Name = "TableForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button DoneBtn;
        private Button VoidBtn;
        private Button AddCoffeBtn;
        private Button checkoutBtn;
        private ListView MenuList;
        private ColumnHeader Name;
        private ColumnHeader Quantity;
        private ColumnHeader Price;
        private Label Totali;
        private Label label1;
    }
}