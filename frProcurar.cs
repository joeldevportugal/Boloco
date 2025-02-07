using System;
using System.Windows.Forms;

namespace Bloco_Notas
{
    public partial class frProcurar : Form
    {
        public frProcurar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActiveControl=null;
            Cancelar();
        }
        private void Cancelar()
        {
            this.Close();
        }
        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            procurar();
        }
        private void procurar()
        {
            string palavraProcurada = txtProcurar.Text;
            bool procurarParaCima = RCima.Checked;
            bool considerarLetras = ChLetras.Checked;

            frBloco fr = (frBloco)Application.OpenForms["frBloco"];
            if (fr != null)
            {
                if (!string.IsNullOrEmpty(palavraProcurada))
                {
                    fr.ProcurarPalavra(palavraProcurada, procurarParaCima, considerarLetras);
                }
                else
                {
                    MessageBox.Show("Por favor, insira uma palavra para procurar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
