namespace Vectores
{
    public partial class Form1 : Form
    {
        private int[] vector; // Vector dinámico
        private int tamaño;   // Tamaño del vector
        private int indice;   // Índice actual para agregar elementos

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar el tamaño ingresado
            if (int.TryParse(txtTamaño.Text, out tamaño) && tamaño > 0)
            {
                vector = new int[tamaño]; // Crear el vector con el tamaño ingresado
                indice = 0; // Reiniciar el índice
                lstVector.Items.Clear(); // Limpiar la lista
                MessageBox.Show($"Vector de tamaño {tamaño} generado con éxito.", "Información");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un tamaño válido (entero positivo).", "Error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que el vector haya sido generado
            if (vector == null)
            {
                MessageBox.Show("Primero genere un vector especificando su tamaño.", "Error");
                return;
            }

            // Validar el elemento ingresado
            if (int.TryParse(txtElemento.Text, out int elemento))
            {
                if (indice < tamaño)
                {
                    vector[indice] = elemento; // Agregar el elemento al vector
                    lstVector.Items.Add($"Elemento[{indice}] = {elemento}"); // Mostrar en la lista
                    indice++;
                    txtElemento.Clear();
                }
                else
                {
                    MessageBox.Show("El vector ya está lleno. No se pueden agregar más elementos.", "Información");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            vector = null; // Reiniciar el vector
            tamaño = 0;
            indice = 0;
            txtTamaño.Clear();
            txtElemento.Clear();
            lstVector.Items.Clear();
            MessageBox.Show("El vector ha sido limpiado.", "Información");
        }

    }
}
