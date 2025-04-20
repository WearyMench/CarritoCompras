namespace CarritoCompras
{
    partial class Form1
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
            listShopCart = new ListBox();
            button1 = new Button();
            btnCalcular = new Button();
            cboProducts = new ComboBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // listShopCart
            // 
            listShopCart.FormattingEnabled = true;
            listShopCart.ItemHeight = 15;
            listShopCart.Location = new Point(31, 28);
            listShopCart.Margin = new Padding(3, 2, 3, 2);
            listShopCart.Name = "listShopCart";
            listShopCart.Size = new Size(204, 289);
            listShopCart.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(293, 97);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(389, 97);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(114, 22);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Precio";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboProducts
            // 
            cboProducts.FormattingEnabled = true;
            cboProducts.Location = new Point(293, 63);
            cboProducts.Margin = new Padding(3, 2, 3, 2);
            cboProducts.Name = "cboProducts";
            cboProducts.Size = new Size(210, 23);
            cboProducts.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 141);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 4;
            label1.Text = "Codigo de Descuento";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(442, 139);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(cboProducts);
            Controls.Add(btnCalcular);
            Controls.Add(button1);
            Controls.Add(listShopCart);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Cart";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListBox listShopCart;
        private Button button1;
        private Button btnCalcular;
        private ComboBox cboProducts;
        private Label label1;
        private TextBox txtCodigo;
    }
}