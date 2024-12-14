using proyecto_3;






namespace Pantalladecarga
{
    public partial class FormCarga : Form
    {

        public FormCarga()
        {


            InitializeComponent();

            btnEjer1.Text = "Ejercicio 1";

        }

        private void btnEjer1_Click(object sender, EventArgs e)
        {
            this.Hide();   
            proyecto_3.FormEje1 formEje1 = new proyecto_3.FormEje1();
            formEje1.Show();
            





        }
    }
}
