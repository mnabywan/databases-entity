namespace MyDataBase
{
    partial class AddOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.Cancell = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingNavigator)).BeginInit();
            this.categoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(MyDataBase.Category);
            // 
            // categoryBindingNavigator
            // 
            this.categoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoryBindingNavigator.BindingSource = this.categoryBindingSource;
            this.categoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.categoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoryBindingNavigatorSaveItem});
            this.categoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoryBindingNavigator.Name = "categoryBindingNavigator";
            this.categoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoryBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.categoryBindingNavigator.TabIndex = 0;
            this.categoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // categoryBindingNavigatorSaveItem
            // 
            this.categoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryBindingNavigatorSaveItem.Enabled = false;
            this.categoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryBindingNavigatorSaveItem.Image")));
            this.categoryBindingNavigatorSaveItem.Name = "categoryBindingNavigatorSaveItem";
            this.categoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.categoryBindingNavigatorSaveItem.Text = "Zapisz dane";
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataSource = typeof(MyDataBase.Category);
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataSource = typeof(MyDataBase.Category);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "Name", true));
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(123, 79);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(300, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "Name";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category ";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.categoryBindingSource;
            // 
            // productsComboBox
            // 
            this.productsComboBox.DataSource = this.productsBindingSource;
            this.productsComboBox.DisplayMember = "Name";
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(123, 134);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(152, 24);
            this.productsComboBox.TabIndex = 3;
            this.productsComboBox.SelectedIndexChanged += new System.EventHandler(this.productsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(123, 196);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(96, 22);
            this.quantityTextBox.TabIndex = 8;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(577, 79);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(211, 22);
            this.customerNameTextBox.TabIndex = 9;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(1181, 358);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(36, 17);
            this.sumLabel.TabIndex = 11;
            this.sumLabel.Text = "Sum";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(502, 237);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(64, 17);
            this.productsLabel.TabIndex = 12;
            this.productsLabel.Text = "Products";
            // 
            // Cancell
            // 
            this.Cancell.Location = new System.Drawing.Point(354, 293);
            this.Cancell.Name = "Cancell";
            this.Cancell.Size = new System.Drawing.Size(111, 44);
            this.Cancell.TabIndex = 13;
            this.Cancell.Text = "Cancel";
            this.Cancell.UseVisualStyleBackColor = true;
            this.Cancell.Click += new System.EventHandler(this.Cancell_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(489, 293);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(111, 44);
            this.buyButton.TabIndex = 14;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(639, 293);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(111, 44);
            this.orderButton.TabIndex = 15;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.Location = new System.Drawing.Point(344, 134);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.ReadOnly = true;
            this.unitsInStockTextBox.Size = new System.Drawing.Size(100, 22);
            this.unitsInStockTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "UnitsInStock";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sumLabel1
            // 
            this.sumLabel1.AutoSize = true;
            this.sumLabel1.Location = new System.Drawing.Point(502, 201);
            this.sumLabel1.Name = "sumLabel1";
            this.sumLabel1.Size = new System.Drawing.Size(36, 17);
            this.sumLabel1.TabIndex = 18;
            this.sumLabel1.Text = "Sum";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sumLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unitsInStockTextBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.Cancell);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryBindingNavigator);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingNavigator)).EndInit();
            this.categoryBindingNavigator.ResumeLayout(false);
            this.categoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingNavigator categoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoryBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ComboBox productsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button Cancell;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sumLabel1;
    }
}