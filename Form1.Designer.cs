namespace AgendaWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListBox lstContatos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lstContatos = new System.Windows.Forms.ListBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(20, 20);
            this.lblNome.AutoSize = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 20);
            this.txtNome.Size = new System.Drawing.Size(300, 25); // largura maior
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F); // fonte mais legível
            // 
            // lblTelefone
            // 
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Location = new System.Drawing.Point(20, 60);
            this.lblTelefone.AutoSize = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(80, 60);
            this.txtTelefone.Size = new System.Drawing.Size(300, 25); // largura maior
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Location = new System.Drawing.Point(20, 100);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(120, 100);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Text = "Remover";
            this.btnRemover.Location = new System.Drawing.Point(220, 100);
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Text = "Editar";
            this.btnEditar.Location = new System.Drawing.Point(320, 100);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lstContatos
            // 
            this.lstContatos.Location = new System.Drawing.Point(20, 140);
            this.lstContatos.Size = new System.Drawing.Size(360, 200);
            this.lstContatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(420, 370);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lstContatos);
            this.Text = "Agenda de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
