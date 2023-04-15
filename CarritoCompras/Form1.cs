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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProducts.SelectedItem.ToString();
            listShopCart.Items.Add(productoSeleccionado);
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
            }
            if (txtCodigo.Text == "NAVIDAD")
            {
                precioFinal *= 0.9;
            }
            MessageBox.Show("El precio es: $" + precioFinal);
        }
    }
}