namespace CarritoCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProducts.Items.Add("Pantalon");
            cboProducts.Items.Add("Camisa");
            cboProducts.Items.Add("Zapato");
            cboProducts.Items.Add("Gorra");
            cboProducts.Items.Add("Chaqueta");
            cboProducts.Items.Add("Bufanda");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboProducts.SelectedItem != null)
            {
                string productoSeleccionado = cboProducts.SelectedItem.ToString();
                listShopCart.Items.Add(productoSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto antes de agregarlo al carrito.");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Pantalon 20
            //Camisa 35
            //Zapato 24

            double precioFinal = 0;
            int totalProducts = listShopCart.Items.Count;

            for (int i = 0; i < totalProducts; i++)
            {
                string productoElegido = listShopCart.Items[i].ToString();
                if (productoElegido == "Pantalon")
                {
                    precioFinal += 20;
                }
                if (productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                if (productoElegido == "Zapato")
                {
                    precioFinal += 24;
                }
                if (productoElegido == "Gorra")
                {
                    precioFinal += 10;
                }
                if (productoElegido == "Chaqueta")
                {
                    precioFinal += 50;
                }
                if (productoElegido == "Bufanda")
                {
                    precioFinal += 15;
                }
            }
            if (txtCodigo.Text == "NAVIDAD")
            {
                precioFinal *= 0.9;
            }
            MessageBox.Show("El precio es: $" + precioFinal);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listShopCart.SelectedIndex != -1)
            {
                listShopCart.Items.RemoveAt(listShopCart.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para eliminar.");
            }
        }
    }
}