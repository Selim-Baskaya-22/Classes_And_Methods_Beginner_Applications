
namespace EntityFrameworkBasic
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.textProductNameUpdate = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.textUnitePriceUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.textUnitePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textStockAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textSearchProduct = new System.Windows.Forms.TextBox();
            this.textMinPrice = new System.Windows.Forms.TextBox();
            this.textMaxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleted);
            this.groupBox2.Controls.Add(this.textProductNameUpdate);
            this.groupBox2.Controls.Add(this.btnProductUpdate);
            this.groupBox2.Controls.Add(this.textUnitePriceUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textStockAmountUpdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(304, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 189);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update and Delete Products";
            // 
            // btnDeleted
            // 
            this.btnDeleted.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleted.Location = new System.Drawing.Point(10, 146);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(249, 30);
            this.btnDeleted.TabIndex = 13;
            this.btnDeleted.Text = "Delete Products";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // textProductNameUpdate
            // 
            this.textProductNameUpdate.Location = new System.Drawing.Point(136, 23);
            this.textProductNameUpdate.Name = "textProductNameUpdate";
            this.textProductNameUpdate.Size = new System.Drawing.Size(123, 20);
            this.textProductNameUpdate.TabIndex = 2;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductUpdate.Location = new System.Drawing.Point(10, 110);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(249, 30);
            this.btnProductUpdate.TabIndex = 12;
            this.btnProductUpdate.Text = "Update Products";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // textUnitePriceUpdate
            // 
            this.textUnitePriceUpdate.Location = new System.Drawing.Point(136, 49);
            this.textUnitePriceUpdate.Name = "textUnitePriceUpdate";
            this.textUnitePriceUpdate.Size = new System.Drawing.Size(123, 20);
            this.textUnitePriceUpdate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock Amount:";
            // 
            // textStockAmountUpdate
            // 
            this.textStockAmountUpdate.Location = new System.Drawing.Point(136, 75);
            this.textStockAmountUpdate.Name = "textStockAmountUpdate";
            this.textStockAmountUpdate.Size = new System.Drawing.Size(123, 20);
            this.textStockAmountUpdate.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unite Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Products Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textProductName);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.textUnitePrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textStockAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 157);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Products";
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(136, 23);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(123, 20);
            this.textProductName.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(10, 110);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(253, 30);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Add Products";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // textUnitePrice
            // 
            this.textUnitePrice.Location = new System.Drawing.Point(136, 49);
            this.textUnitePrice.Name = "textUnitePrice";
            this.textUnitePrice.Size = new System.Drawing.Size(123, 20);
            this.textUnitePrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock Amount:";
            // 
            // textStockAmount
            // 
            this.textStockAmount.Location = new System.Drawing.Point(136, 75);
            this.textStockAmount.Name = "textStockAmount";
            this.textStockAmount.Size = new System.Drawing.Size(123, 20);
            this.textStockAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unit Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Products Name:";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 218);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(838, 290);
            this.dgwProducts.TabIndex = 18;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Product Search:";
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Location = new System.Drawing.Point(146, 17);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(123, 20);
            this.textSearchProduct.TabIndex = 22;
            this.textSearchProduct.TextChanged += new System.EventHandler(this.textSearchProduct_TextChanged);
            // 
            // textMinPrice
            // 
            this.textMinPrice.Location = new System.Drawing.Point(146, 43);
            this.textMinPrice.Name = "textMinPrice";
            this.textMinPrice.Size = new System.Drawing.Size(123, 20);
            this.textMinPrice.TabIndex = 23;
            // 
            // textMaxPrice
            // 
            this.textMaxPrice.Location = new System.Drawing.Point(146, 71);
            this.textMaxPrice.Name = "textMaxPrice";
            this.textMaxPrice.Size = new System.Drawing.Size(123, 20);
            this.textMaxPrice.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(37, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Min Search:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(33, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Max Search:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMinMax);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textSearchProduct);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textMinPrice);
            this.groupBox3.Controls.Add(this.textMaxPrice);
            this.groupBox3.Location = new System.Drawing.Point(585, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 189);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(104, 97);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(165, 23);
            this.btnMinMax.TabIndex = 27;
            this.btnMinMax.Text = "button1";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.TextBox textProductNameUpdate;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox textUnitePriceUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStockAmountUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox textUnitePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStockAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSearchProduct;
        private System.Windows.Forms.TextBox textMinPrice;
        private System.Windows.Forms.TextBox textMaxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMinMax;
    }
}

