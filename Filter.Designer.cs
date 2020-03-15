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
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(568, 3);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(180, 51);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тип кузова";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(128, 7);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 17;
            this.priceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            // 
            // kuzovCheckedListBox
            // 
            this.kuzovCheckedListBox.FormattingEnabled = true;
            this.kuzovCheckedListBox.Items.AddRange(new object[] {
            "Седан",
            "Хэтчбек",
            "Суперкар"});
            this.kuzovCheckedListBox.Location = new System.Drawing.Point(363, 7);
            this.kuzovCheckedListBox.Name = "kuzovCheckedListBox";
            this.kuzovCheckedListBox.Size = new System.Drawing.Size(129, 72);
            this.kuzovCheckedListBox.TabIndex = 18;
            this.kuzovCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.kuzovCheckedListBox_ItemCheck);
            this.kuzovCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kuzovCheckedListBox_MouseClick);
            this.kuzovCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.kuzovCheckedListBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(128, 37);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(121, 22);
            this.searchTextBox.TabIndex = 20;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Название";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kuzovCheckedListBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterButton);
            this.Name = "Filter";
            this.Text = "Sedan";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckedListBox kuzovCheckedListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label3;
    }
}