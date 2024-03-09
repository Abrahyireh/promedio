namespace notasDeEstudianteyPromedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcualar_Click(object sender, EventArgs e)
        {
            int Nota1 = Convert.ToInt32(txt_Nota1.Text);
            int Nota2 = Convert.ToInt32(txt_Nota2.Text);
            int Nota3 = Convert.ToInt32(txt_Nota3.Text);
            int Nota4 = Convert.ToInt32(txt_Nota4.Text);
            int PromedioNota = Nota1 + Nota2 + Nota3 + Nota4;
            int Resultado1 = PromedioNota / 4;

            string Resultado = $"{Resultado1}";
            txt_Promedio.Text = Resultado.ToString();

            if (Resultado1 >= 70)
            {
                txt_Estado.Text = "el estidiante paso";
                txt_Estado.ForeColor = Color.Green;


            }
            else
            {
                txt_Estado.Text = "el estudiante no paso";
                txt_Estado.ForeColor = Color.Red;

            }



        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nota1.Clear();
            txt_Nota2.Clear();
            txt_Nota3.Clear();
            txt_Nota4.Clear();
            txt_Promedio.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}