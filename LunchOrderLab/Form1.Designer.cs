namespace LunchOrderLab
{
    partial class frmLunchOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBoxMainCourse = new GroupBox();
            rdoBtnSalad = new RadioButton();
            rdoBtnPizza = new RadioButton();
            rdoBtnHamburger = new RadioButton();
            grpBoxAddOnItems = new GroupBox();
            chkBoxAddOn3 = new CheckBox();
            chkBoxAddOn2 = new CheckBox();
            chkBoxAddOn1 = new CheckBox();
            grpBoxOrderTotal = new GroupBox();
            lblOrderTotal = new Label();
            lblTax = new Label();
            lblSubtotal = new Label();
            txtBoxOrderTotal = new TextBox();
            txtBoxTax = new TextBox();
            txtBoxSubtotal = new TextBox();
            btnPlaceOrder = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpBoxMainCourse.SuspendLayout();
            grpBoxAddOnItems.SuspendLayout();
            grpBoxOrderTotal.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxMainCourse
            // 
            grpBoxMainCourse.Controls.Add(rdoBtnSalad);
            grpBoxMainCourse.Controls.Add(rdoBtnPizza);
            grpBoxMainCourse.Controls.Add(rdoBtnHamburger);
            grpBoxMainCourse.Location = new Point(12, 12);
            grpBoxMainCourse.Name = "grpBoxMainCourse";
            grpBoxMainCourse.Size = new Size(250, 125);
            grpBoxMainCourse.TabIndex = 0;
            grpBoxMainCourse.TabStop = false;
            grpBoxMainCourse.Text = "Main Course";
            // 
            // rdoBtnSalad
            // 
            rdoBtnSalad.AutoSize = true;
            rdoBtnSalad.Location = new Point(6, 86);
            rdoBtnSalad.Name = "rdoBtnSalad";
            rdoBtnSalad.Size = new Size(116, 24);
            rdoBtnSalad.TabIndex = 2;
            rdoBtnSalad.TabStop = true;
            rdoBtnSalad.Text = "Salad - $4.95";
            rdoBtnSalad.UseVisualStyleBackColor = true;
            rdoBtnSalad.CheckedChanged += rdoBtnSalad_CheckedChanged;
            // 
            // rdoBtnPizza
            // 
            rdoBtnPizza.AutoSize = true;
            rdoBtnPizza.Location = new Point(6, 56);
            rdoBtnPizza.Name = "rdoBtnPizza";
            rdoBtnPizza.Size = new Size(113, 24);
            rdoBtnPizza.TabIndex = 1;
            rdoBtnPizza.TabStop = true;
            rdoBtnPizza.Text = "Pizza - $5.95";
            rdoBtnPizza.UseVisualStyleBackColor = true;
            rdoBtnPizza.CheckedChanged += rdoBtnPizza_CheckedChanged;
            // 
            // rdoBtnHamburger
            // 
            rdoBtnHamburger.AutoSize = true;
            rdoBtnHamburger.Location = new Point(6, 26);
            rdoBtnHamburger.Name = "rdoBtnHamburger";
            rdoBtnHamburger.Size = new Size(155, 24);
            rdoBtnHamburger.TabIndex = 0;
            rdoBtnHamburger.TabStop = true;
            rdoBtnHamburger.Text = "Hamburger - $6.95";
            rdoBtnHamburger.UseVisualStyleBackColor = true;
            rdoBtnHamburger.CheckedChanged += rdoBtnHamburger_CheckedChanged;
            // 
            // grpBoxAddOnItems
            // 
            grpBoxAddOnItems.Controls.Add(chkBoxAddOn3);
            grpBoxAddOnItems.Controls.Add(chkBoxAddOn2);
            grpBoxAddOnItems.Controls.Add(chkBoxAddOn1);
            grpBoxAddOnItems.Location = new Point(288, 12);
            grpBoxAddOnItems.Name = "grpBoxAddOnItems";
            grpBoxAddOnItems.Size = new Size(250, 125);
            grpBoxAddOnItems.TabIndex = 1;
            grpBoxAddOnItems.TabStop = false;
            grpBoxAddOnItems.Text = "Add-on items";
            // 
            // chkBoxAddOn3
            // 
            chkBoxAddOn3.AutoSize = true;
            chkBoxAddOn3.Location = new Point(6, 86);
            chkBoxAddOn3.Name = "chkBoxAddOn3";
            chkBoxAddOn3.Size = new Size(18, 17);
            chkBoxAddOn3.TabIndex = 2;
            chkBoxAddOn3.UseVisualStyleBackColor = true;
            // 
            // chkBoxAddOn2
            // 
            chkBoxAddOn2.AutoSize = true;
            chkBoxAddOn2.Location = new Point(6, 56);
            chkBoxAddOn2.Name = "chkBoxAddOn2";
            chkBoxAddOn2.Size = new Size(18, 17);
            chkBoxAddOn2.TabIndex = 1;
            chkBoxAddOn2.UseVisualStyleBackColor = true;
            // 
            // chkBoxAddOn1
            // 
            chkBoxAddOn1.AutoSize = true;
            chkBoxAddOn1.Location = new Point(6, 26);
            chkBoxAddOn1.Name = "chkBoxAddOn1";
            chkBoxAddOn1.Size = new Size(18, 17);
            chkBoxAddOn1.TabIndex = 0;
            chkBoxAddOn1.UseVisualStyleBackColor = true;
            // 
            // grpBoxOrderTotal
            // 
            grpBoxOrderTotal.Controls.Add(lblOrderTotal);
            grpBoxOrderTotal.Controls.Add(lblTax);
            grpBoxOrderTotal.Controls.Add(lblSubtotal);
            grpBoxOrderTotal.Controls.Add(txtBoxOrderTotal);
            grpBoxOrderTotal.Controls.Add(txtBoxTax);
            grpBoxOrderTotal.Controls.Add(txtBoxSubtotal);
            grpBoxOrderTotal.Location = new Point(12, 301);
            grpBoxOrderTotal.Name = "grpBoxOrderTotal";
            grpBoxOrderTotal.Size = new Size(352, 137);
            grpBoxOrderTotal.TabIndex = 2;
            grpBoxOrderTotal.TabStop = false;
            grpBoxOrderTotal.Text = "Order Total";
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new Point(36, 104);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(86, 20);
            lblOrderTotal.TabIndex = 5;
            lblOrderTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(54, 65);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(67, 20);
            lblTax.TabIndex = 4;
            lblTax.Text = "Tax (5%):";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(54, 26);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "Subtotal";
            // 
            // txtBoxOrderTotal
            // 
            txtBoxOrderTotal.BackColor = SystemColors.ControlLightLight;
            txtBoxOrderTotal.Location = new Point(125, 104);
            txtBoxOrderTotal.Name = "txtBoxOrderTotal";
            txtBoxOrderTotal.ReadOnly = true;
            txtBoxOrderTotal.Size = new Size(221, 27);
            txtBoxOrderTotal.TabIndex = 2;
            // 
            // txtBoxTax
            // 
            txtBoxTax.BackColor = SystemColors.ControlLightLight;
            txtBoxTax.Location = new Point(125, 65);
            txtBoxTax.Name = "txtBoxTax";
            txtBoxTax.ReadOnly = true;
            txtBoxTax.Size = new Size(221, 27);
            txtBoxTax.TabIndex = 1;
            // 
            // txtBoxSubtotal
            // 
            txtBoxSubtotal.BackColor = SystemColors.ControlLightLight;
            txtBoxSubtotal.Location = new Point(125, 26);
            txtBoxSubtotal.Name = "txtBoxSubtotal";
            txtBoxSubtotal.ReadOnly = true;
            txtBoxSubtotal.Size = new Size(221, 27);
            txtBoxSubtotal.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(370, 327);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(168, 29);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(370, 366);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(168, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(370, 405);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLunchOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnPlaceOrder);
            Controls.Add(grpBoxOrderTotal);
            Controls.Add(grpBoxAddOnItems);
            Controls.Add(grpBoxMainCourse);
            Name = "frmLunchOrder";
            Text = "Lunch Order";
            Load += frmLunchOrder_Load;
            grpBoxMainCourse.ResumeLayout(false);
            grpBoxMainCourse.PerformLayout();
            grpBoxAddOnItems.ResumeLayout(false);
            grpBoxAddOnItems.PerformLayout();
            grpBoxOrderTotal.ResumeLayout(false);
            grpBoxOrderTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxMainCourse;
        private GroupBox grpBoxAddOnItems;
        private GroupBox grpBoxOrderTotal;
        private RadioButton rdoBtnSalad;
        private RadioButton rdoBtnPizza;
        private RadioButton rdoBtnHamburger;
        private Button btnPlaceOrder;
        private Button btnReset;
        private Button btnExit;
        private TextBox txtBoxOrderTotal;
        private TextBox txtBoxTax;
        private TextBox txtBoxSubtotal;
        private Label lblOrderTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private CheckBox chkBoxAddOn3;
        private CheckBox chkBoxAddOn2;
        private CheckBox chkBoxAddOn1;
    }
}
