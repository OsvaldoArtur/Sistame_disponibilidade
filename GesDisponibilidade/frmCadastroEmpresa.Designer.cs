namespace GesDisponibilidade
{
    partial class frmCadastroEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeEmpresaLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nuitLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.nomeEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nuitTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.empresa_tbDataGridView = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeEmpresaLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nuitLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresa_tbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresa_tbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeEmpresaLabel
            // 
            nomeEmpresaLabel.AutoSize = true;
            nomeEmpresaLabel.Location = new System.Drawing.Point(26, 84);
            nomeEmpresaLabel.Name = "nomeEmpresaLabel";
            nomeEmpresaLabel.Size = new System.Drawing.Size(105, 19);
            nomeEmpresaLabel.TabIndex = 1;
            nomeEmpresaLabel.Text = "Nome Empresa:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(63, 115);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(68, 19);
            enderecoLabel.TabIndex = 3;
            enderecoLabel.Text = "Endereco:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(87, 146);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 19);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // nuitLabel
            // 
            nuitLabel.AutoSize = true;
            nuitLabel.Location = new System.Drawing.Point(395, 84);
            nuitLabel.Name = "nuitLabel";
            nuitLabel.Size = new System.Drawing.Size(38, 19);
            nuitLabel.TabIndex = 7;
            nuitLabel.Text = "Nuit:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(371, 115);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(62, 19);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "Telefone:";
            // 
            // nomeEmpresaTextBox
            // 
            this.nomeEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresa_tbBindingSource, "NomeEmpresa", true));
            this.nomeEmpresaTextBox.Location = new System.Drawing.Point(137, 81);
            this.nomeEmpresaTextBox.Name = "nomeEmpresaTextBox";
            this.nomeEmpresaTextBox.Size = new System.Drawing.Size(228, 25);
            this.nomeEmpresaTextBox.TabIndex = 2;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresa_tbBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(137, 112);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(228, 25);
            this.enderecoTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresa_tbBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(137, 143);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(228, 25);
            this.emailTextBox.TabIndex = 6;
            // 
            // nuitTextBox
            // 
            this.nuitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresa_tbBindingSource, "Nuit", true));
            this.nuitTextBox.Location = new System.Drawing.Point(439, 81);
            this.nuitTextBox.Name = "nuitTextBox";
            this.nuitTextBox.Size = new System.Drawing.Size(199, 25);
            this.nuitTextBox.TabIndex = 8;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresa_tbBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(439, 112);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(199, 25);
            this.telefoneTextBox.TabIndex = 10;
            // 
            // empresa_tbDataGridView
            // 
            this.empresa_tbDataGridView.AllowUserToAddRows = false;
            this.empresa_tbDataGridView.AllowUserToDeleteRows = false;
            this.empresa_tbDataGridView.AutoGenerateColumns = false;
            this.empresa_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.empresa_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresa_tbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.empresa_tbDataGridView.DataSource = this.empresa_tbBindingSource;
            this.empresa_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.empresa_tbDataGridView.Location = new System.Drawing.Point(23, 236);
            this.empresa_tbDataGridView.Name = "empresa_tbDataGridView";
            this.empresa_tbDataGridView.ReadOnly = true;
            this.empresa_tbDataGridView.Size = new System.Drawing.Size(795, 213);
            this.empresa_tbDataGridView.TabIndex = 11;
            this.empresa_tbDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empresa_tbDataGridView_CellContentClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(554, 146);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 19);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buscar Logo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Teal;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(522, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 33);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar Dados";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GesDisponibilidade.Properties.Resources.Full_Image_528px;
            this.pictureBox1.Location = new System.Drawing.Point(644, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEmpresa";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEmpresa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeEmpresa";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeEmpresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nuit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nuit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // empresa_tbBindingSource
            // 
            this.empresa_tbBindingSource.DataSource = typeof(GesDisponibilidade.Empresa_tb);
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 475);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.empresa_tbDataGridView);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(nuitLabel);
            this.Controls.Add(this.nuitTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(nomeEmpresaLabel);
            this.Controls.Add(this.nomeEmpresaTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmCadastroEmpresa";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.frmCadastroEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresa_tbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresa_tbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource empresa_tbBindingSource;
        private System.Windows.Forms.TextBox nomeEmpresaTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nuitTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.DataGridView empresa_tbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSalvar;
    }
}