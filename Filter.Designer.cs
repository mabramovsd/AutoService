namespace AutoService
{
    partial class Filter
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
            this.filterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.kuzovCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(457, 32);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(162, 54);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Найти";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterClick);
            this.filterButton.MouseEnter += new System.EventHandler(this.filterButton_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тип кузова";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(93, 32);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(92, 20);
            this.priceTextBox.TabIndex = 17;
            this.priceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // kuzovCheckedListBox
            // 
            this.kuzovCheckedListBox.FormattingEnabled = true;
            this.kuzovCheckedListBox.Items.AddRange(new object[] {
            "Седан",
            "Хэтчбек",
            "Суперкар"});
            this.kuzovCheckedListBox.Location = new System.Drawing.Point(272, 32);
            this.kuzovCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kuzovCheckedListBox.Name = "kuzovCheckedListBox";
            this.kuzovCheckedListBox.Size = new System.Drawing.Size(98, 49);
            this.kuzovCheckedListBox.TabIndex = 18;
            this.kuzovCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.kuzovCheckedListBox_ItemCheck);
            this.kuzovCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kuzovCheckedListBox_MouseClick);
            this.kuzovCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.kuzovCheckedListBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(93, 56);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(92, 20);
            this.searchTextBox.TabIndex = 20;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Название";
            // 
            // carsPanel
            // 
            this.carsPanel.AutoScroll = true;
            this.carsPanel.Location = new System.Drawing.Point(4, 102);
            this.carsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carsPanel.Name = "carsPanel";
            this.carsPanel.Size = new System.Drawing.Size(625, 297);
            this.carsPanel.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 24);
            this.button1.TabIndex = 22;
            this.button1.Text = "Фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.button1);
            this.filterPanel.Controls.Add(this.filterButton);
            this.filterPanel.Controls.Add(this.label2);
            this.filterPanel.Controls.Add(this.searchTextBox);
            this.filterPanel.Controls.Add(this.priceTextBox);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.kuzovCheckedListBox);
            this.filterPanel.Location = new System.Drawing.Point(4, 2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(625, 95);
            this.filterPanel.TabIndex = 23;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(634, 408);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.carsPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Filter";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckedListBox kuzovCheckedListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel carsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel filterPanel;
    }
}