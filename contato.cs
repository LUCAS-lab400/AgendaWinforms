namespace AgendaWinForms
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"{Nome} - {Telefone}";
        }
    }
}
