namespace BiblWorm
{
    partial class Library
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
            this.formBM = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkReturn = new System.Windows.Forms.CheckBox();
            this.checkAvailability = new System.Windows.Forms.CheckBox();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.numericInventory = new System.Windows.Forms.NumericUpDown();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.numericPages = new System.Windows.Forms.NumericUpDown();
            this.textPublish = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.tabMagazines = new System.Windows.Forms.TabPage();
            this.checkSort = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.formBM.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPages)).BeginInit();
            this.SuspendLayout();
            // 
            // formBM
            // 
            this.formBM.Controls.Add(this.tabBooks);
            this.formBM.Controls.Add(this.tabMagazines);
            this.formBM.Location = new System.Drawing.Point(1, 1);
            this.formBM.Name = "formBM";
            this.formBM.SelectedIndex = 0;
            this.formBM.Size = new System.Drawing.Size(283, 407);
            this.formBM.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.label7);
            this.tabBooks.Controls.Add(this.label6);
            this.tabBooks.Controls.Add(this.label5);
            this.tabBooks.Controls.Add(this.label4);
            this.tabBooks.Controls.Add(this.label3);
            this.tabBooks.Controls.Add(this.label2);
            this.tabBooks.Controls.Add(this.label1);
            this.tabBooks.Controls.Add(this.buttonAdd);
            this.tabBooks.Controls.Add(this.checkReturn);
            this.tabBooks.Controls.Add(this.checkAvailability);
            this.tabBooks.Controls.Add(this.numericDuration);
            this.tabBooks.Controls.Add(this.numericInventory);
            this.tabBooks.Controls.Add(this.numericYear);
            this.tabBooks.Controls.Add(this.numericPages);
            this.tabBooks.Controls.Add(this.textPublish);
            this.tabBooks.Controls.Add(this.textName);
            this.tabBooks.Controls.Add(this.textAuthor);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(275, 381);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Книги";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Срок пользования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Инвентарий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Год издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Страниц";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Автор";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 324);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(262, 40);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkReturn
            // 
            this.checkReturn.AutoSize = true;
            this.checkReturn.Location = new System.Drawing.Point(137, 277);
            this.checkReturn.Name = "checkReturn";
            this.checkReturn.Size = new System.Drawing.Size(132, 17);
            this.checkReturn.TabIndex = 8;
            this.checkReturn.Text = "Возвращение в срок";
            this.checkReturn.UseVisualStyleBackColor = true;
            // 
            // checkAvailability
            // 
            this.checkAvailability.AutoSize = true;
            this.checkAvailability.Location = new System.Drawing.Point(7, 277);
            this.checkAvailability.Name = "checkAvailability";
            this.checkAvailability.Size = new System.Drawing.Size(69, 17);
            this.checkAvailability.TabIndex = 7;
            this.checkAvailability.Text = "Наличие";
            this.checkAvailability.UseVisualStyleBackColor = true;
            // 
            // numericDuration
            // 
            this.numericDuration.Location = new System.Drawing.Point(149, 222);
            this.numericDuration.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(120, 20);
            this.numericDuration.TabIndex = 6;
            // 
            // numericInventory
            // 
            this.numericInventory.Location = new System.Drawing.Point(86, 186);
            this.numericInventory.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericInventory.Name = "numericInventory";
            this.numericInventory.Size = new System.Drawing.Size(183, 20);
            this.numericInventory.TabIndex = 5;
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(86, 150);
            this.numericYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(183, 20);
            this.numericYear.TabIndex = 4;
            // 
            // numericPages
            // 
            this.numericPages.Location = new System.Drawing.Point(86, 115);
            this.numericPages.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericPages.Name = "numericPages";
            this.numericPages.Size = new System.Drawing.Size(183, 20);
            this.numericPages.TabIndex = 3;
            // 
            // textPublish
            // 
            this.textPublish.Location = new System.Drawing.Point(86, 76);
            this.textPublish.Name = "textPublish";
            this.textPublish.Size = new System.Drawing.Size(183, 20);
            this.textPublish.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(86, 41);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(183, 20);
            this.textName.TabIndex = 1;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(86, 6);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(183, 20);
            this.textAuthor.TabIndex = 0;
            // 
            // tabMagazines
            // 
            this.tabMagazines.Location = new System.Drawing.Point(4, 22);
            this.tabMagazines.Name = "tabMagazines";
            this.tabMagazines.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagazines.Size = new System.Drawing.Size(275, 381);
            this.tabMagazines.TabIndex = 1;
            this.tabMagazines.Text = "Журналы";
            this.tabMagazines.UseVisualStyleBackColor = true;
            // 
            // checkSort
            // 
            this.checkSort.AutoSize = true;
            this.checkSort.Location = new System.Drawing.Point(461, 370);
            this.checkSort.Name = "checkSort";
            this.checkSort.Size = new System.Drawing.Size(181, 17);
            this.checkSort.TabIndex = 1;
            this.checkSort.Text = "Сортировать по инвентарному";
            this.checkSort.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(286, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(356, 332);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(290, 364);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(147, 23);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "Посмотреть";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkSort);
            this.Controls.Add(this.formBM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Library";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Bibliotheque_Load);
            this.formBM.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl formBM;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkReturn;
        private System.Windows.Forms.CheckBox checkAvailability;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.NumericUpDown numericInventory;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.NumericUpDown numericPages;
        private System.Windows.Forms.TextBox textPublish;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TabPage tabMagazines;
        private System.Windows.Forms.CheckBox checkSort;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

