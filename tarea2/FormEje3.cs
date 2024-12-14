using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace tarea2
{
    public partial class FormEje3 : Form
    {




        public FormEje3()
        {
            
            InitializeComponent();


            lblArr1.Text = "Introduce el tamaño del arreglo 1:";
            lblArr2.Text = "Introduce el tamaño del arreglo 2:";
            btnGen.Text = "Generar";
            lblGen.Text = "";
            lblGen.Text = "";
            lblResp1.Text = "";
            lblResArr1.Text = "";
            lblResp2.Text = "";
            lblResArr2.Text = "";
            lblRep.Text = "";
            lblNumRep.Text = "";
            lblNoRep.Text = "";
            lblRespNoRep.Text = "";
            lblNoRepArr1.Text = "";
            lblRespNoRepArr1.Text = "";
            lblNoRepArr2.Text = "";
            lblRespNoRepArr2.Text = "";

        }









        private void btnGen_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtArr1.Text) || string.IsNullOrEmpty(txtArr2.Text))
            {
                MessageBox.Show("Debes introducir ambos numeros.");
            }

            else
            {
                int[] arreglo1 = new int[int.Parse(txtArr1.Text)];
                Random ran1 = new Random();

                for (int i = 0; i < arreglo1.Length; i++)
                {


                    arreglo1[i] = ran1.Next(1, 501);


                }

                int[] arreglo2 = new int[int.Parse(txtArr2.Text)];
                Random ran2 = new Random();

                for (int x = 0; x < arreglo2.Length; x++)
                {
                    arreglo2[x] = ran2.Next(1, 501);
                }


                var repeArr1 = arreglo1.Intersect(arreglo2);
                var noRepArr1 = arreglo1.Except(arreglo2);
                var noRepArr2 = arreglo2.Except(arreglo1);


                


                lblGen.Text = "Los numeros generados son,";
                lblResp1.Text = "Del arreglo 1: ";
                lblResArr1.Text = string.Join(", ", arreglo1);
                lblResp2.Text = "Del arreglo 2:";
                lblResArr2.Text = string.Join(", ", arreglo2);
                lblRep.Text = "Se repitieron los numeros:";
                lblNumRep.Text = string.Join(", ", repeArr1);
                lblNoRep.Text = "No se repitieron los siguientes numeros:";
                lblRespNoRep.Text = (string.Join(", ", noRepArr1) + " " + string.Join(", ", noRepArr2));
                lblNoRepArr1.Text = "Los siguientes son unicos del arreglo 1:";
                lblRespNoRepArr1.Text = string.Join(", ", noRepArr1);
                lblNoRepArr2.Text = "Los siguientes son unicos del arreglo 2:";
                lblRespNoRepArr2.Text = string.Join(", ", noRepArr2);




                if (repeArr1.LongCount() == 0)
                {
                    lblRep.Text = "";

                }
            }



        }

        private void txtArr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtArr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
    }
}
