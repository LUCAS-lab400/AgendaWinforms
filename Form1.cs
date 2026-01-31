using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaWinForms
{
    public partial class Form1 : Form
    {
        private List<Contato> agenda = new List<Contato>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("Digite nome e telefone válidos.");
                return;
            }

            agenda.Add(new Contato(nome, telefone));
            AtualizarLista();
            MessageBox.Show("Contato adicionado com sucesso!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busca = txtNome.Text;
            Contato encontrado = agenda.Find(c => c.Nome.Equals(busca, StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
                MessageBox.Show("Contato encontrado: " + encontrado);
            else
                MessageBox.Show("Contato não encontrado.");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string remover = txtNome.Text;
            Contato contatoRemover = agenda.Find(c => c.Nome.Equals(remover, StringComparison.OrdinalIgnoreCase));

            if (contatoRemover != null)
            {
                agenda.Remove(contatoRemover);
                AtualizarLista();
                MessageBox.Show("Contato removido com sucesso!");
            }
            else
                MessageBox.Show("Contato não encontrado.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string editar = txtNome.Text;
            Contato contatoEditar = agenda.Find(c => c.Nome.Equals(editar, StringComparison.OrdinalIgnoreCase));

            if (contatoEditar != null)
            {
                string novoNome = txtNome.Text;
                string novoTelefone = txtTelefone.Text;

                if (!string.IsNullOrWhiteSpace(novoNome))
                    contatoEditar.Nome = novoNome;

                if (!string.IsNullOrWhiteSpace(novoTelefone))
                    contatoEditar.Telefone = novoTelefone;

                AtualizarLista();
                MessageBox.Show("Contato atualizado com sucesso!");
            }
            else
                MessageBox.Show("Contato não encontrado.");
        }

        private void AtualizarLista()
        {
            lstContatos.Items.Clear();
            foreach (var contato in agenda)
                lstContatos.Items.Add(contato);
        }
    }
}
