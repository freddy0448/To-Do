namespace View
{
    public partial class ViewForm : Form
    {
        int index;
        public ViewForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int dgvIndex = dgvToDo.Rows.Add();

            //Las celdas son columnas
            dgvToDo.Rows[dgvIndex].Cells[0].Value = txtEvent.Text;
            dgvToDo.Rows[dgvIndex].Cells[1].Value = txtDate.Text;

            dgvToDo.Rows[dgvIndex].Cells[2].Value = txtHour.Text;

            dgvToDo.Rows[dgvIndex].Cells[3].Value = txtAddress.Text;

            txtEvent.Text = "";
            txtDate.Text = "";
            txtHour.Text = "";
            txtAddress.Text = "";
        }

        private void pctrbEdit_Click(object sender, EventArgs e)
        {
            //Necesito el indice de la columna a editar
            DataGridViewRow dataGridViewRow = dgvToDo.Rows[index];

            //Las celdas son columnas

            dataGridViewRow.Cells[0].Value = txtEvent.Text;
            dataGridViewRow.Cells[1].Value = txtDate.Text;
            dataGridViewRow.Cells[2].Value = txtHour.Text;
            dataGridViewRow.Cells[3].Value = txtAddress.Text;

            txtEvent.Text = "";
            txtDate.Text = "";
            txtHour.Text = "";
            txtAddress.Text = "";

        }

        private void dgvToDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvToDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Este metodo es declarado hiendo a Properties>Mouse>CellClick

            index = e.RowIndex;
            //Dame el indice (numero de fila) que selecciono
            DataGridViewRow dataGridViewRow = dgvToDo.Rows[index];

            //Ponme el valor que este en la fila seleccionada de la primera columna en su textbox correspondiente.
            txtEvent.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtDate.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtHour.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtAddress.Text = dataGridViewRow.Cells[3].Value.ToString();

        }

        private void pctrbDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvToDo.SelectedRows)
            {
                dgvToDo.Rows.RemoveAt(item.Index);
            }
        }
    }
}