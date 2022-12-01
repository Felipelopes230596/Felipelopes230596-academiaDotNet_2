namespace lista_exercicios_11
{
    partial class Form_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome_completo = new System.Windows.Forms.TextBox();
            this.button_adicionarLista = new System.Windows.Forms.Button();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.listar_emails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // textBox_nome_completo
            // 
            this.textBox_nome_completo.Location = new System.Drawing.Point(146, 14);
            this.textBox_nome_completo.Name = "textBox_nome_completo";
            this.textBox_nome_completo.Size = new System.Drawing.Size(311, 26);
            this.textBox_nome_completo.TabIndex = 1;
            // 
            // button_adicionarLista
            // 
            this.button_adicionarLista.Location = new System.Drawing.Point(17, 136);
            this.button_adicionarLista.Name = "button_adicionarLista";
            this.button_adicionarLista.Size = new System.Drawing.Size(122, 29);
            this.button_adicionarLista.TabIndex = 2;
            this.button_adicionarLista.Text = "Inserir";
            this.button_adicionarLista.UseVisualStyleBackColor = true;
            this.button_adicionarLista.Click += new System.EventHandler(this.button_adicionarLista_Click);
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Location = new System.Drawing.Point(17, 171);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.ReadOnly = true;
            this.textBox_listaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaNomes.Size = new System.Drawing.Size(193, 361);
            this.textBox_listaNomes.TabIndex = 3;
            // 
            // listar_emails
            // 
            this.listar_emails.Location = new System.Drawing.Point(225, 136);
            this.listar_emails.Name = "listar_emails";
            this.listar_emails.Size = new System.Drawing.Size(122, 29);
            this.listar_emails.TabIndex = 4;
            this.listar_emails.Text = "Listar Emails";
            this.listar_emails.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Listar Domínios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(146, 61);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(311, 26);
            this.textBox_email.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(193, 358);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(435, 171);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(193, 358);
            this.textBox3.TabIndex = 9;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 587);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listar_emails);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.button_adicionarLista);
            this.Controls.Add(this.textBox_nome_completo);
            this.Controls.Add(this.label1);
            this.Name = "Form_principal";
            this.Text = "Titulo do formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nome_completo;
        private Button button_adicionarLista;
        private TextBox textBox_listaNomes;
        private Button listar_emails;
        private Button button1;
        private TextBox textBox_email;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}