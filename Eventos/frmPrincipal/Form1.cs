namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        public delegate void MovementEventHandler(string movement);
        public event MovementEventHandler MovementOccurred;
        

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MovementOccurred += frmPrincipalMevimientoOcurrido;


            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnModificar.Click += btnModificar_Click; 

        }
        private void frmPrincipalMevimientoOcurrido(string movimiento)
        {
            lbMovimiento.Text = "Ultimo movimiento " + movimiento; 
        }

        protected virtual void OnMevimientoOcurrido(string movimiento)
        {
            if (MovementOccurred != null)
            {
                MovementOccurred(movimiento);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnMevimientoOcurrido("add");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnMevimientoOcurrido("delete");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OnMevimientoOcurrido("modificar");
        }
    }
}