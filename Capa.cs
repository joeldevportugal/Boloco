using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bloco_Notas
{
    public partial class Capa : Form
    {
      
        public Capa()
        {
            InitializeComponent();
            this.Shown += Capa_Shown; // Chamar o progresso quando o formulário for mostrado
        }

        private async void Capa_Shown(object sender, EventArgs e)
        {
            await ContagemProgresso();
        }

        private async void Avanco_Click(object sender, EventArgs e)
        {
            try
            {
                await ContagemProgresso();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ContagemProgresso()
        {
            try
            {
                Avanco.Value = 0; // Se houver uma ProgressBar, resetar o valor
                for (int i = 0; i <= 100; i++)
                {
                    Avanco.Value = i; // Atualiza a barra de progresso
                    await Task.Delay(50);  // Ajuste a velocidade da contagem se necessário
                }

                // Quando a contagem atingir 100, mostrar frBloco e ocultar Capa
                this.Hide();
                using (frBloco bloco = new frBloco())
                {
                    bloco.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
