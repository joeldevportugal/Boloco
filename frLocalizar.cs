using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bloco_Notas
{
    public partial class frLocalizar : Form
    {
        public frLocalizar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void cancelar()
        {
            // Obtém a instância de frBloco
            frBloco fr = (frBloco)Application.OpenForms["frBloco"];
            if (fr != null)
            {
                // Redefine as cores do texto no RichTextBox
                fr.RedefinirCoresTexto();
            }

            this.Close();
        }

        // Evento para substituir todas as palavras
        private void BtnSubstituir_tudo_Click(object sender, EventArgs e)
        {
            substituirTudo();
        }

        private void substituirTudo()
        {
            string palavraProcurada = txtLocalizar.Text;
            string palavraSubstituir = txtSubestituir.Text;
            bool considerarLetras = Chletras.Checked;
            bool procurarParaCima = false;

            // Obtém a instância de frBloco
            frBloco fr = (frBloco)Application.OpenForms["frBloco"];
            if (fr != null)
            {
                if (!string.IsNullOrEmpty(palavraProcurada) && !string.IsNullOrEmpty(palavraSubstituir))
                {
                    // Chama o método de substituição no frBloco
                    int substituicoes = fr.SubstituirPalavra(palavraProcurada, palavraSubstituir, procurarParaCima, considerarLetras, true);

                    // Exibe uma MessageBox confirmando o número de substituições
                    MessageBox.Show($"{substituicoes} palavras substituídas com sucesso.", "Substituição Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Desmarca a seleção
                    fr.DeselecionarTexto();
                }
                else
                {
                    MessageBox.Show("Por favor, insira as palavras para localizar e substituir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento para substituir uma única palavra
        private void btnSubstituir_Click(object sender, EventArgs e)
        {
            substituir();
        }

        private void substituir()
        {
            string palavraProcurada = txtLocalizar.Text;
            string palavraSubstituir = txtSubestituir.Text;
            bool considerarLetras = Chletras.Checked;
            bool procurarParaCima = false;

            // Obtém a instância de frBloco
            frBloco fr = (frBloco)Application.OpenForms["frBloco"];
            if (fr != null)
            {
                if (!string.IsNullOrEmpty(palavraProcurada) && !string.IsNullOrEmpty(palavraSubstituir))
                {
                    // Chama o método de substituição no frBloco
                    int substituicoes = fr.SubstituirPalavra(palavraProcurada, palavraSubstituir, procurarParaCima, considerarLetras, false);

                    if (substituicoes > 0)
                    {
                        MessageBox.Show("Palavra substituída com sucesso.", "Substituição Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma ocorrência da palavra foi encontrada para substituição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Desmarca a seleção
                    fr.DeselecionarTexto();
                }
                else
                {
                    MessageBox.Show("Por favor, insira as palavras para localizar e substituir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento para procurar uma palavra
        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            procurar();
        }

        private void procurar()
        {
            string palavraProcurada = txtLocalizar.Text;
            bool considerarLetras = Chletras.Checked;
            bool procurarParaCima = false;

            // Obtém a instância de frBloco
            frBloco fr = (frBloco)Application.OpenForms["frBloco"];
            if (fr != null)
            {
                if (!string.IsNullOrEmpty(palavraProcurada))
                {
                    fr.ProcurarPalavra(palavraProcurada, procurarParaCima, considerarLetras);

                    // Desmarca a seleção
                    fr.DeselecionarTexto();
                }
                else
                {
                    MessageBox.Show("Por favor, insira uma palavra para procurar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
