namespace EliseoSmuttEjer5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RegistrarDatos(string nombre, string mail, string texto)
        {
            DateTime fecha = DateTime.Now;
            string datos = $"Nombre: {nombre}\r\n Mail {mail}\r\n Su mensaje: {texto}\r\n Fecha de envio del mensaje: {fecha}";
            lbl1.Text = datos;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string nombre = tb1.Text;
            string mail = tb2.Text;
            string texto = tb3.Text;

            RegistrarDatos(nombre, mail, texto);
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
        }
    }
}