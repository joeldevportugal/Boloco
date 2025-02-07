using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Bloco_Notas
{
    public partial class frBloco : Form
    {
        // Mantém o índice da última palavra localizada
        private int ultimaPosicao = -1;
        private PrintDocument printDocument = new PrintDocument();
        private string currentFile = null;

        public frBloco()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void procurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProcurar f = new frProcurar();
            f.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Abrir()
        {
            if (VerificarSalvar())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Text Files|*.txt|All Files|*.*",
                    Title = "Abrir Arquivo"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentFile = openFileDialog.FileName;
                        richTextBox1.Text = File.ReadAllText(currentFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (currentFile == null)
            {
                SaveAs();
            }
            else
            {
                SaveFile();
            }
        }

        private void SaveFile()
        {
            try
            {
                File.WriteAllText(currentFile, richTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files|*.txt|All Files|*.*",
                Title = "Salvar Arquivo"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFile = saveFileDialog.FileName;
                    File.WriteAllText(currentFile, richTextBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void imprimir()
        {
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = richTextBox1.Font;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            e.Graphics.DrawString(richTextBox1.Text, printFont, Brushes.Black, leftMargin, topMargin);
        }

        private bool VerificarSalvar()
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show("Deseja salvar o documento atual?", "Salvar Documento", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    guardarToolStripMenuItem_Click(null, null);
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerificarSalvar())
            {
                richTextBox1.Clear();
                currentFile = null;
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Btnimprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }
        private void copiar()
        {
            Clipboard.SetText(richTextBox1.SelectedText.Length > 0 ? richTextBox1.SelectedText : richTextBox1.Text);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }
        private void Colar()
        {
            if (Clipboard.ContainsText())
            {
                richTextBox1.Paste();
            }
            else
            {
                MessageBox.Show("Não há texto na área de transferência para colar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog
            {
                Font = richTextBox1.Font
            };

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        public void ProcurarPalavra(string palavra, bool procurarParaCima, bool considerarLetras)
        {
            RichTextBoxFinds options = considerarLetras ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;
            int startIndex;

            // Desmarca a seleção anterior
            richTextBox1.Select(0, 0);

            // Se procurarParaCima for true, começamos a busca de trás para frente
            if (procurarParaCima)
            {
                startIndex = (ultimaPosicao == -1) ? richTextBox1.Text.Length : ultimaPosicao - 1;
                ultimaPosicao = richTextBox1.Find(palavra, 0, startIndex, options);
            }
            else
            {
                startIndex = (ultimaPosicao == -1) ? 0 : ultimaPosicao + 1;
                ultimaPosicao = richTextBox1.Find(palavra, startIndex, options);
            }

            if (ultimaPosicao >= 0)
            {
                richTextBox1.Select(ultimaPosicao, palavra.Length);
                richTextBox1.SelectionBackColor = Color.Blue;
                richTextBox1.SelectionColor = Color.White; // Opcional para melhor contraste
            }
            else
            {
                MessageBox.Show("Não há mais nenhuma ocorrência da palavra.", "Fim da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ultimaPosicao = -1; // Reinicia a busca
            }

            // Desmarca a seleção após localização
            DeselecionarTexto();
        }

        public int SubstituirPalavra(string palavraProcurada, string palavraSubstituir, bool procurarParaCima, bool considerarLetras, bool substituirTudo)
        {
            int substituicoes = 0;
            RichTextBoxFinds options = considerarLetras ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;
            int startIndex = procurarParaCima ? richTextBox1.Text.Length : 0;
            int index = procurarParaCima ? richTextBox1.Text.LastIndexOf(palavraProcurada) : richTextBox1.Find(palavraProcurada, startIndex, options);

            while (index >= 0)
            {
                richTextBox1.Select(index, palavraProcurada.Length);
                richTextBox1.SelectedText = palavraSubstituir;
                substituicoes++;

                if (!substituirTudo)
                {
                    break;
                }

                startIndex = procurarParaCima ? index - 1 : index + palavraSubstituir.Length;
                index = procurarParaCima ? richTextBox1.Text.LastIndexOf(palavraProcurada, startIndex) : richTextBox1.Find(palavraProcurada, startIndex, options);
            }

            return substituicoes;
        }

        public void DeselecionarTexto()
        {
            // Desmarca a seleção ao final
            richTextBox1.Select(0, 0);
            richTextBox1.SelectionBackColor = Color.White; // Ou a cor de fundo padrão
            richTextBox1.SelectionColor = Color.Black; // Ou a cor do texto padrão
        }

        public void RedefinirCoresTexto()
        {
            // Redefine as cores do texto no RichTextBox
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White; // Ou a cor de fundo padrão
            richTextBox1.SelectionColor = Color.Black; // Ou a cor do texto padrão
            richTextBox1.Select(0, 0); // Desmarca a seleção
        }
    
    

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.DeselectAll();
        }


        private void BtnCentro_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }


        private void BtnDireita_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.DeselectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNegrito_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Verifica se o texto selecionado já está em negrito
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold; // Alterna entre negrito ou não

                // Aplica o novo estilo de fonte (negrito)
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
            else
            {
                // Se não houver texto selecionado, aplica o estilo de negrito ao texto onde o cursor está
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold; // Alterna entre negrito ou não

                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void BtnItalico_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Verifica se o texto selecionado já está em itálico
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic; // Alterna entre itálico ou não

                // Aplica o novo estilo de fonte (itálico)
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
            else
            {
                // Se não houver texto selecionado, aplica o estilo de itálico ao texto onde o cursor está
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic; // Alterna entre itálico ou não

                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void BtnSublinhado_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Verifica se o texto selecionado já está sublinhado
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline; // Alterna entre sublinhado ou não

                // Aplica o novo estilo de fonte (sublinhado)
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
            else
            {
                // Se não houver texto selecionado, aplica o estilo de sublinhado ao texto onde o cursor está
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline; // Alterna entre sublinhado ou não

                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void BtnColar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void BtnCortar_Click(object sender, EventArgs e)
        {
            Cortar();
        }
        private void Cortar()
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Corta o texto selecionado
                richTextBox1.Cut();
            }
            else
            {
                MessageBox.Show("Selecione o texto para cortar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cortar();
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frLocalizar f = new frLocalizar();
            f.ShowDialog();
        }
    }
}