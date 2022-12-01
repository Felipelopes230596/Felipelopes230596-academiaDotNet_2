namespace lista_exercicios_11
{
    public partial class Form_principal : Form
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();
        public Form_principal()
        {
            InitializeComponent();
        }
        //metodo que trata evento de um componente
        private void button_adicionarLista_Click(object sender, EventArgs e)
        {
            if (textBox_nome_completo.Text.Length == 0)  
            {
                
            }
            
        }

        private void inserirTextBox_lista()
        {
            if (textBox_nome_completo.Text == "")
            {
                MessageBox.Show("Para adiconar nome é preciso digitar algo", "ATENÇÃO");
            }
            else
            {
                if (listaNomes.Contains(textBox_nome_completo.Text.ToUpper()))
                {
                    MessageBox.Show("Nome já existe, digite novamente", "ATENÇÃO");
                }
                else if (!textBox_nome_completo.Text.Contains(" "))
                {
                    MessageBox.Show("Nome completo obrigatório, digite novamente", "ATENÇÃO");
                }
                else
                {
                    listaNomes.Add(textBox_nome_completo.Text.ToUpper());

                    listaNomes.Sort();

                    //inserir o conteudo da lista ordenada
                    atualizarTextBox_lista();

                    textBox_nome_completo.Text = String.Empty;
                }
            }
            textBox_nome_completo.Focus();

        }

        private void atualizarTextBox_lista()
        {
            textBox_listaNomes.Text = String.Empty;

            foreach (var item in listaNomes)
            {
                textBox_listaNomes.Text = item + Environment.NewLine;
            }
        }


        private void textBox_nome_completo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inserirTextBox_lista();
            }
        }
    }
}