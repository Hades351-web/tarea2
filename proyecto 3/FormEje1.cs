using System;
//using PantallaCarga.FormCarga;


namespace proyecto_3
{
    public partial class FormEje1 : Form
    {


        public FormEje1()
        {



            InitializeComponent();
            lblPregunta.Text = "De que tamaño quieres tu arreglo? ";
            lblResp1.Text = "";
            lblResp2.Text = "";
            lblResp3.Text = "";
            lblResp4.Text = "";
            lblResp5.Text = "";
            lblResp6.Text = "";
            // txtTamArr.Text = "";
            txtTamArr.MaxLength = 3;

            btnGen3.Text = "Generar";
        }


        private void button1_Click(object sender, EventArgs e)
        {


            try
            {


                if (string.IsNullOrEmpty(txtTamArr.Text) || int.Parse(txtTamArr.Text) > 100 || int.Parse(txtTamArr.Text) < 1)
                {
                    MessageBox.Show("Por favor ingresa un numero entre 1 y 100.");
                    txtTamArr.Clear();
                }
                else
                {

                    int[] arreglo = new int[int.Parse(txtTamArr.Text)];
                    Random rand = new Random();


                    for (int i = 0; i < arreglo.Length; i++)
                    {


                        arreglo[i] = rand.Next(-100, 101);




                    }
                    lblResp1.Text = "Tus numeros generados son:";
                    lblResp2.Text = string.Join(", ", arreglo);

                    lblResp3.Text = "De los cuales son positivos:";
                    int[] numPos = Array.FindAll(arreglo, num => num > 0);

                    foreach (int num in numPos)
                    {
                        lblResp4.Text = string.Join(", ", numPos);

                    }

                    lblResp5.Text = "Y los numeros negativos son:";
                    int[] numNeg = Array.FindAll(arreglo, num => num < 0);

                    foreach (int num in numNeg)
                    {
                        lblResp6.Text = string.Join(", ", numNeg);
                    }
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }




        }

        private void txtTamArr_TextChanged(object sender, EventArgs e)
        {


            try
            {
                if (int.Parse(txtTamArr.Text) > 100)
                {
                    MessageBox.Show("Por favor ingresa un numero entre 1 y 100.");
                    txtTamArr.Clear();
                }

            }
            catch (Exception)
            {

            }
        }

        private void txtTamArr_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario actual
         //   Pantalladecarga.FormCarga pantallaDeCarga = new Pantalladecarga.FormCarga(); // Crear instancia del formulario
         //   pantallaDeCarga.Show();
        }
    }
}
