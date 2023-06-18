
namespace frmPrincipalLogs
{
    public partial class frmPrincipalLogs : Form
    {
        Logs logs = new Logs();
        public frmPrincipalLogs()
        {
            InitializeComponent();
           
            logs.MovementOccurred += logs.MovimientoOcurrido;
        }

        private void frmPrincipalLogs_Load(object sender, EventArgs e)
        {
            button1.Click += button1_Click;
            button2.Click += button2_Click; 
            button3.Click += button3_Click; 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            logs.OnMovimientoOcurrido("boton Uno");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logs.OnMovimientoOcurrido("boton Dos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logs.OnMovimientoOcurrido("boton Tres");
        }
    }
}