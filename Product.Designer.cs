namespace Budce
{
    partial class Product
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BuyProduct = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductCount = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.S_NumberofProduct = new System.Windows.Forms.TextBox();
            this.SellProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberofProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.S_Price = new System.Windows.Forms.TextBox();
            this.S_ProductCount = new System.Windows.Forms.TextBox();
            this.S_ProductName = new System.Windows.Forms.TextBox();
            this.DeleteSelledProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FindProfit = new System.Windows.Forms.Button();
            this.Profit = new System.Windows.Forms.TextBox();
            this.Expense = new System.Windows.Forms.TextBox();
            this.FindExpense = new System.Windows.Forms.Button();
            this.Residue = new System.Windows.Forms.TextBox();
            this.ResidueFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 375);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(638, 375);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(719, 200);
            this.dataGridView2.TabIndex = 1;
            // 
            // BuyProduct
            // 
            this.BuyProduct.BackColor = System.Drawing.Color.Bisque;
            this.BuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyProduct.Location = new System.Drawing.Point(212, 5);
            this.BuyProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuyProduct.Name = "BuyProduct";
            this.BuyProduct.Size = new System.Drawing.Size(156, 50);
            this.BuyProduct.TabIndex = 2;
            this.BuyProduct.Text = "Mal al";
            this.BuyProduct.UseVisualStyleBackColor = false;
            this.BuyProduct.Click += new System.EventHandler(this.BuyProduct_Click);
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(411, 57);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(204, 27);
            this.ProductName.TabIndex = 3;
            // 
            // ProductCount
            // 
            this.ProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductCount.Location = new System.Drawing.Point(411, 109);
            this.ProductCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(204, 27);
            this.ProductCount.TabIndex = 4;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(411, 163);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(204, 27);
            this.Price.TabIndex = 5;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteProduct.Location = new System.Drawing.Point(212, 210);
            this.DeleteProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(166, 57);
            this.DeleteProduct.TabIndex = 6;
            this.DeleteProduct.Text = "Alınan malı sistemdən sil";
            this.DeleteProduct.UseVisualStyleBackColor = false;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // S_NumberofProduct
            // 
            this.S_NumberofProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_NumberofProduct.Location = new System.Drawing.Point(956, 277);
            this.S_NumberofProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.S_NumberofProduct.Name = "S_NumberofProduct";
            this.S_NumberofProduct.Size = new System.Drawing.Size(215, 27);
            this.S_NumberofProduct.TabIndex = 7;
            // 
            // SellProduct
            // 
            this.SellProduct.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SellProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellProduct.Location = new System.Drawing.Point(965, 12);
            this.SellProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SellProduct.Name = "SellProduct";
            this.SellProduct.Size = new System.Drawing.Size(160, 46);
            this.SellProduct.TabIndex = 8;
            this.SellProduct.Text = "Mal sat";
            this.SellProduct.UseVisualStyleBackColor = false;
            this.SellProduct.Click += new System.EventHandler(this.SellProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alınacaq malın adını daxil edin       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alınacaq malın sayını daxil edin     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alınacaq malın qiymətini daxil edin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(89, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Silinəcək malın nömrəsini daxil edin :";
            // 
            // NumberofProduct
            // 
            this.NumberofProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberofProduct.Location = new System.Drawing.Point(411, 277);
            this.NumberofProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumberofProduct.Name = "NumberofProduct";
            this.NumberofProduct.Size = new System.Drawing.Size(204, 27);
            this.NumberofProduct.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(633, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Satılacaq malın qiymətini daxil edin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(633, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Satılacaq malın sayını daxil edin     :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(633, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Satılacaq malın adını daxil edin       :";
            // 
            // S_Price
            // 
            this.S_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Price.Location = new System.Drawing.Point(956, 168);
            this.S_Price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.S_Price.Name = "S_Price";
            this.S_Price.Size = new System.Drawing.Size(215, 27);
            this.S_Price.TabIndex = 16;
            // 
            // S_ProductCount
            // 
            this.S_ProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_ProductCount.Location = new System.Drawing.Point(956, 114);
            this.S_ProductCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.S_ProductCount.Name = "S_ProductCount";
            this.S_ProductCount.Size = new System.Drawing.Size(215, 27);
            this.S_ProductCount.TabIndex = 15;
            // 
            // S_ProductName
            // 
            this.S_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_ProductName.Location = new System.Drawing.Point(956, 62);
            this.S_ProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.S_ProductName.Name = "S_ProductName";
            this.S_ProductName.Size = new System.Drawing.Size(215, 27);
            this.S_ProductName.TabIndex = 14;
            // 
            // DeleteSelledProduct
            // 
            this.DeleteSelledProduct.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteSelledProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelledProduct.Location = new System.Drawing.Point(965, 210);
            this.DeleteSelledProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteSelledProduct.Name = "DeleteSelledProduct";
            this.DeleteSelledProduct.Size = new System.Drawing.Size(166, 57);
            this.DeleteSelledProduct.TabIndex = 20;
            this.DeleteSelledProduct.Text = "Satılan malı sistemdən sil";
            this.DeleteSelledProduct.UseVisualStyleBackColor = false;
            this.DeleteSelledProduct.Click += new System.EventHandler(this.DeleteSelledProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(623, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Silinəcək malın nömrəsini daxil edin :";
            // 
            // FindProfit
            // 
            this.FindProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FindProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindProfit.Location = new System.Drawing.Point(1213, 47);
            this.FindProfit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FindProfit.Name = "FindProfit";
            this.FindProfit.Size = new System.Drawing.Size(144, 46);
            this.FindProfit.TabIndex = 22;
            this.FindProfit.Text = "Məxarici tap:";
            this.FindProfit.UseVisualStyleBackColor = false;
            this.FindProfit.Click += new System.EventHandler(this.FindProfit_Click);
            // 
            // Profit
            // 
            this.Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Profit.Location = new System.Drawing.Point(1242, 102);
            this.Profit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(127, 27);
            this.Profit.TabIndex = 23;
            // 
            // Expense
            // 
            this.Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Expense.Location = new System.Drawing.Point(1242, 240);
            this.Expense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(127, 27);
            this.Expense.TabIndex = 25;
            // 
            // FindExpense
            // 
            this.FindExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FindExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindExpense.Location = new System.Drawing.Point(1213, 187);
            this.FindExpense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FindExpense.Name = "FindExpense";
            this.FindExpense.Size = new System.Drawing.Size(144, 47);
            this.FindExpense.TabIndex = 24;
            this.FindExpense.Text = "Mədaxili tap:";
            this.FindExpense.UseVisualStyleBackColor = false;
            this.FindExpense.Click += new System.EventHandler(this.FindExpense_Click);
            // 
            // Residue
            // 
            this.Residue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Residue.Location = new System.Drawing.Point(1242, 342);
            this.Residue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Residue.Name = "Residue";
            this.Residue.Size = new System.Drawing.Size(127, 27);
            this.Residue.TabIndex = 27;
            // 
            // ResidueFind
            // 
            this.ResidueFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ResidueFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResidueFind.Location = new System.Drawing.Point(1213, 282);
            this.ResidueFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResidueFind.Name = "ResidueFind";
            this.ResidueFind.Size = new System.Drawing.Size(144, 46);
            this.ResidueFind.TabIndex = 26;
            this.ResidueFind.Text = "Gəliri tap:";
            this.ResidueFind.UseVisualStyleBackColor = false;
            this.ResidueFind.Click += new System.EventHandler(this.Residue_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 587);
            this.Controls.Add(this.Residue);
            this.Controls.Add(this.ResidueFind);
            this.Controls.Add(this.Expense);
            this.Controls.Add(this.FindExpense);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.FindProfit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteSelledProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.S_Price);
            this.Controls.Add(this.S_ProductCount);
            this.Controls.Add(this.S_ProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberofProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellProduct);
            this.Controls.Add(this.S_NumberofProduct);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProductCount);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.BuyProduct);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Product";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bindingSource1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.Button BuyProduct;
    private System.Windows.Forms.TextBox ProductName;
    private System.Windows.Forms.TextBox ProductCount;
    private System.Windows.Forms.TextBox Price;
    private System.Windows.Forms.Button DeleteProduct;
    private System.Windows.Forms.TextBox S_NumberofProduct;
    private System.Windows.Forms.Button SellProduct;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox NumberofProduct;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox S_Price;
    private System.Windows.Forms.TextBox S_ProductCount;
    private System.Windows.Forms.TextBox S_ProductName;
    private System.Windows.Forms.Button DeleteSelledProduct;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button FindProfit;
    private System.Windows.Forms.TextBox Profit;
    private System.Windows.Forms.TextBox Expense;
    private System.Windows.Forms.Button FindExpense;
    private System.Windows.Forms.TextBox Residue;
    private System.Windows.Forms.Button ResidueFind;
}
}
