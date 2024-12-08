namespace Vectores
{
    public partial class Form1 : Form
    {
        private int[] vector; // Vector din�mico
        private int tama�o;   // Tama�o del vector
        private int indice;   // �ndice actual para agregar elementos

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar el tama�o ingresado
            if (int.TryParse(txtTama�o.Text, out tama�o) && tama�o > 0)
            {
                vector = new int[tama�o]; // Crear el vector con el tama�o ingresado
                indice = 0; // Reiniciar el �ndice
                lstVector.Items.Clear(); // Limpiar la lista
                MessageBox.Show($"Vector de tama�o {tama�o} generado con �xito.", "Informaci�n");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un tama�o v�lido (entero positivo).", "Error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que el vector haya sido generado
            if (vector == null)
            {
                MessageBox.Show("Primero genere un vector especificando su tama�o.", "Error");
                return;
            }

            // Validar el elemento ingresado
            if (int.TryParse(txtElemento.Text, out int elemento))
            {
                if (indice < tama�o)
                {
                    vector[indice] = elemento; // Agregar el elemento al vector
                    lstVector.Items.Add($"Elemento[{indice}] = {elemento}"); // Mostrar en la lista
                    indice++;
                    txtElemento.Clear();
                }
                else
                {
                    MessageBox.Show("El vector ya est� lleno. No se pueden agregar m�s elementos.", "Informaci�n");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero entero v�lido.", "Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            vector = null; // Reiniciar el vector
            tama�o = 0;
            indice = 0;
            txtTama�o.Clear();
            txtElemento.Clear();
            lstVector.Items.Clear();
            MessageBox.Show("El vector ha sido limpiado.", "Informaci�n");
        }

    }
}
