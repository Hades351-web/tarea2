using System.Security.Cryptography.X509Certificates;

namespace proyecto_2
{
    public partial class FormEje2 : Form
    {
        int numLeft = 20;


        public FormEje2()
        {


            //   int numLeft = 20;
            InitializeComponent();

            lblAdd.Text = "Escribe un numero entre 1 y 1000 y presiona agregar.";
            lblInst.Text = "Faltan " + (numLeft) + "  numeros.";
            lblOrde.Text = "";
            lblSuPar.Text = "";
            lblSumImp.Text = "";
            lblSuPar.Text = "";
            lblSumImp.Text = "";
            lblPar.Text = "";
            lblImp.Text = "";
            btnAdd.Text = "Agegar";
            btnDell.Text = "Eliminar";
            btnStart.Text = "Calcular";










        }

        //private void lstb_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        public void btnAdd_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(txtNum.Text) || int.Parse(txtNum.Text) > 1000 || int.Parse(txtNum.Text) < 1)
            {

                MessageBox.Show("Solo numeros entre 1 y 1000");
                txtNum.Clear();
            }

            else
            {

                if (numLeft < 1)

                {
                    txtNum.Enabled = false;
                    lblInst.Text = "Presiona Calcular. ";
                }
                else
                {



                    if (numLeft < 1)
                    {

                        MessageBox.Show("Calcular ahora.");

                    }
                    else
                    {

                        if (string.IsNullOrEmpty(txtNum.Text))
                        {
                            MessageBox.Show("Escribe un numero primero.");
                        }

                        else
                        {
                            lstNum.Items.Add(int.Parse(txtNum.Text));
                            txtNum.Clear();

                            numLeft--;

                            lblInst.Text = ("Faltan " + (numLeft) + " numeros.");

                        }

                    }
                }
            }

        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }



        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (numLeft > 0)
            {
                MessageBox.Show("Por favor ingresa todos los numeros.");








            }
            else
            {
                lblOrde.Text = "Tus numeros de menor a mayor son:";
                lblPar.Text = "Los numeros pares son:";
                lblImp.Text = "Los numeros impares son:";
                lblSuPar.Text = "La suma de los pares es:";
                lblSumImp.Text = "La suma de los impares es:";



                List<int> numeros = new List<int>();
                foreach (int numero in lstNum.Items)
                {
                    numeros.Add(numero);
                }

                // Ordenar la lista de menor a mayor
                numeros.Sort(); // ¡Así de simple para ordenar de menor a mayor!

                // Limpiar el ListBox de destino
                lstOrde.Items.Clear();

                // Agregar los elementos ordenados al ListBox de destino
                foreach (int numero in numeros)
                {
                    lstOrde.Items.Add(numero);
                }

                List<int> pares = new List<int>();
                foreach (int par in lstNum.Items)
                {

                    if (par % 2 == 0)
                    {
                        pares.Add(par);
                    }

                }
                lstPar.Items.Clear();
                foreach (int par in pares)
                {
                    lstPar.Items.Add(par);

                }
                lblSumaPar.Text = pares.Sum().ToString();
                List<int> impares = new List<int>();
                foreach (int impar in lstNum.Items)
                {
                    if (impar % 2 > 0)
                    {
                        impares.Add(impar);
                    }
                }
                lstImp.Items.Clear();
                foreach (int impar in impares)
                {
                    lstImp.Items.Add(impar);
                }

                lblSumaImp.Text = impares.Sum().ToString();







            }
        }
    }
}
