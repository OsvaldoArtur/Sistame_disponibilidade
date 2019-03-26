namespace GesDisponibilidade.Manutencao
{
    partial class frmManutencao
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label dataManutencaoLabel;
            System.Windows.Forms.Label kilometragemManutencaoLabel;
            System.Windows.Forms.Label nivelTanqueLabel;
            System.Windows.Forms.Label tipoManutencaoLabel;
            System.Windows.Forms.Label valorManutencaoLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label horaInicioLabel;
            System.Windows.Forms.Label horaFimLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fluidostbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantidadef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnManutencao = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.horaInicioTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horaFimTextBox = new System.Windows.Forms.MaskedTextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.manutencao_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorManutencaoTextBox = new System.Windows.Forms.TextBox();
            this.tipoManutencaoComboBox = new System.Windows.Forms.ComboBox();
            this.nivelTanqueComboBox = new System.Windows.Forms.ComboBox();
            this.kilometragemManutencaoTextBox = new System.Windows.Forms.TextBox();
            this.dataManutencaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.servicostbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtKmCadastro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstadoConservacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEncontrar = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxBuscaCarro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaViaturatbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idClienteLabel = new System.Windows.Forms.Label();
            dataManutencaoLabel = new System.Windows.Forms.Label();
            kilometragemManutencaoLabel = new System.Windows.Forms.Label();
            nivelTanqueLabel = new System.Windows.Forms.Label();
            tipoManutencaoLabel = new System.Windows.Forms.Label();
            valorManutencaoLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            horaInicioLabel = new System.Windows.Forms.Label();
            horaFimLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluidostbBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencao_tbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicostbBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaViaturatbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(246, 66);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(72, 19);
            idClienteLabel.TabIndex = 34;
            idClienteLabel.Text = "Motorista:";
            // 
            // dataManutencaoLabel
            // 
            dataManutencaoLabel.AutoSize = true;
            dataManutencaoLabel.Location = new System.Drawing.Point(1002, 16);
            dataManutencaoLabel.Name = "dataManutencaoLabel";
            dataManutencaoLabel.Size = new System.Drawing.Size(41, 19);
            dataManutencaoLabel.TabIndex = 35;
            dataManutencaoLabel.Text = "Data:";
            // 
            // kilometragemManutencaoLabel
            // 
            kilometragemManutencaoLabel.AutoSize = true;
            kilometragemManutencaoLabel.Location = new System.Drawing.Point(674, 66);
            kilometragemManutencaoLabel.Name = "kilometragemManutencaoLabel";
            kilometragemManutencaoLabel.Size = new System.Drawing.Size(67, 19);
            kilometragemManutencaoLabel.TabIndex = 36;
            kilometragemManutencaoLabel.Text = "Km Man.:";
            // 
            // nivelTanqueLabel
            // 
            nivelTanqueLabel.AutoSize = true;
            nivelTanqueLabel.Location = new System.Drawing.Point(508, 66);
            nivelTanqueLabel.Name = "nivelTanqueLabel";
            nivelTanqueLabel.Size = new System.Drawing.Size(55, 19);
            nivelTanqueLabel.TabIndex = 37;
            nivelTanqueLabel.Text = "Tanque:";
            // 
            // tipoManutencaoLabel
            // 
            tipoManutencaoLabel.AutoSize = true;
            tipoManutencaoLabel.Location = new System.Drawing.Point(1002, 66);
            tipoManutencaoLabel.Name = "tipoManutencaoLabel";
            tipoManutencaoLabel.Size = new System.Drawing.Size(38, 19);
            tipoManutencaoLabel.TabIndex = 38;
            tipoManutencaoLabel.Text = "Tipo:";
            // 
            // valorManutencaoLabel
            // 
            valorManutencaoLabel.AutoSize = true;
            valorManutencaoLabel.Location = new System.Drawing.Point(851, 66);
            valorManutencaoLabel.Name = "valorManutencaoLabel";
            valorManutencaoLabel.Size = new System.Drawing.Size(43, 19);
            valorManutencaoLabel.TabIndex = 39;
            valorManutencaoLabel.Text = "Valor:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(14, 116);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(90, 19);
            observacoesLabel.TabIndex = 40;
            observacoesLabel.Text = "Observacoes:";
            // 
            // horaInicioLabel
            // 
            horaInicioLabel.AutoSize = true;
            horaInicioLabel.Location = new System.Drawing.Point(775, 141);
            horaInicioLabel.Name = "horaInicioLabel";
            horaInicioLabel.Size = new System.Drawing.Size(44, 19);
            horaInicioLabel.TabIndex = 41;
            horaInicioLabel.Text = "Inicio:";
            // 
            // horaFimLabel
            // 
            horaFimLabel.AutoSize = true;
            horaFimLabel.Location = new System.Drawing.Point(785, 172);
            horaFimLabel.Name = "horaFimLabel";
            horaFimLabel.Size = new System.Drawing.Size(34, 19);
            horaFimLabel.TabIndex = 42;
            horaFimLabel.Text = "Fim:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 496);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1154, 170);
            this.panel4.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 170);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pecas Utilizadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Peca,
            this.Quantidade,
            this.Preco});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 134);
            this.dataGridView1.TabIndex = 0;
            // 
            // Peca
            // 
            this.Peca.HeaderText = "Peca";
            this.Peca.Name = "Peca";
            // 
            // Quantidade
            // 
            this.Quantidade.FillWeight = 10F;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Preco
            // 
            this.Preco.FillWeight = 20F;
            this.Preco.HeaderText = "Preco";
            this.Preco.Name = "Preco";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fluidos Utilizados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Quantidadef,
            this.Valorf});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1140, 134);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataSource = this.fluidostbBindingSource;
            this.Column1.DisplayMember = "NomeFluido";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "Fluidos";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "idFluido";
            // 
            // fluidostbBindingSource
            // 
            this.fluidostbBindingSource.DataSource = typeof(GesDisponibilidade.Fluidos_tb);
            // 
            // Quantidadef
            // 
            this.Quantidadef.FillWeight = 20F;
            this.Quantidadef.HeaderText = "Quantidade";
            this.Quantidadef.Name = "Quantidadef";
            // 
            // Valorf
            // 
            this.Valorf.FillWeight = 30F;
            this.Valorf.HeaderText = "Valor";
            this.Valorf.Name = "Valorf";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnManutencao);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.horaInicioTextBox);
            this.panel3.Controls.Add(this.horaFimTextBox);
            this.panel3.Controls.Add(horaFimLabel);
            this.panel3.Controls.Add(horaInicioLabel);
            this.panel3.Controls.Add(observacoesLabel);
            this.panel3.Controls.Add(this.observacoesTextBox);
            this.panel3.Controls.Add(valorManutencaoLabel);
            this.panel3.Controls.Add(this.valorManutencaoTextBox);
            this.panel3.Controls.Add(tipoManutencaoLabel);
            this.panel3.Controls.Add(this.tipoManutencaoComboBox);
            this.panel3.Controls.Add(nivelTanqueLabel);
            this.panel3.Controls.Add(this.nivelTanqueComboBox);
            this.panel3.Controls.Add(kilometragemManutencaoLabel);
            this.panel3.Controls.Add(this.kilometragemManutencaoTextBox);
            this.panel3.Controls.Add(dataManutencaoLabel);
            this.panel3.Controls.Add(this.dataManutencaoDateTimePicker);
            this.panel3.Controls.Add(idClienteLabel);
            this.panel3.Controls.Add(this.idClienteTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtKmCadastro);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtEstadoConservacao);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtCombustivel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtModelo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtMatricula);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 263);
            this.panel3.TabIndex = 1;
            // 
            // btnManutencao
            // 
            this.btnManutencao.BackColor = System.Drawing.Color.Black;
            this.btnManutencao.Enabled = false;
            this.btnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManutencao.ForeColor = System.Drawing.Color.White;
            this.btnManutencao.Image = global::GesDisponibilidade.Properties.Resources.icons8_Work_25px;
            this.btnManutencao.Location = new System.Drawing.Point(1001, 223);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(150, 34);
            this.btnManutencao.TabIndex = 11;
            this.btnManutencao.Text = "MANUTENCAO";
            this.btnManutencao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManutencao.UseVisualStyleBackColor = false;
            this.btnManutencao.Click += new System.EventHandler(this.btnManutencao_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(766, 234);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 23);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Realizada com sucesso.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // horaInicioTextBox
            // 
            this.horaInicioTextBox.Location = new System.Drawing.Point(825, 138);
            this.horaInicioTextBox.Mask = "00:00";
            this.horaInicioTextBox.Name = "horaInicioTextBox";
            this.horaInicioTextBox.Size = new System.Drawing.Size(100, 25);
            this.horaInicioTextBox.TabIndex = 8;
            this.horaInicioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.horaInicioTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // horaFimTextBox
            // 
            this.horaFimTextBox.Location = new System.Drawing.Point(825, 169);
            this.horaFimTextBox.Mask = "00:00";
            this.horaFimTextBox.Name = "horaFimTextBox";
            this.horaFimTextBox.Size = new System.Drawing.Size(100, 25);
            this.horaFimTextBox.TabIndex = 9;
            this.horaFimTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.horaFimTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manutencao_tbBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(14, 138);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(746, 119);
            this.observacoesTextBox.TabIndex = 7;
            // 
            // manutencao_tbBindingSource
            // 
            this.manutencao_tbBindingSource.DataSource = typeof(GesDisponibilidade.Manutencao_tb);
            // 
            // valorManutencaoTextBox
            // 
            this.valorManutencaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manutencao_tbBindingSource, "ValorManutencao", true));
            this.valorManutencaoTextBox.Location = new System.Drawing.Point(855, 88);
            this.valorManutencaoTextBox.Name = "valorManutencaoTextBox";
            this.valorManutencaoTextBox.Size = new System.Drawing.Size(145, 25);
            this.valorManutencaoTextBox.TabIndex = 5;
            this.valorManutencaoTextBox.TextChanged += new System.EventHandler(this.valorManutencaoTextBox_TextChanged);
            // 
            // tipoManutencaoComboBox
            // 
            this.tipoManutencaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manutencao_tbBindingSource, "TipoManutencao", true));
            this.tipoManutencaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoManutencaoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipoManutencaoComboBox.FormattingEnabled = true;
            this.tipoManutencaoComboBox.Items.AddRange(new object[] {
            "Preventiva",
            "Conserto",
            "Revisao"});
            this.tipoManutencaoComboBox.Location = new System.Drawing.Point(1006, 88);
            this.tipoManutencaoComboBox.Name = "tipoManutencaoComboBox";
            this.tipoManutencaoComboBox.Size = new System.Drawing.Size(136, 25);
            this.tipoManutencaoComboBox.TabIndex = 6;
            // 
            // nivelTanqueComboBox
            // 
            this.nivelTanqueComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manutencao_tbBindingSource, "NivelTanque", true));
            this.nivelTanqueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelTanqueComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nivelTanqueComboBox.FormattingEnabled = true;
            this.nivelTanqueComboBox.Items.AddRange(new object[] {
            "Vazio",
            "1⁄2",
            "1⁄4",
            "3⁄4",
            "Cheio"});
            this.nivelTanqueComboBox.Location = new System.Drawing.Point(512, 88);
            this.nivelTanqueComboBox.Name = "nivelTanqueComboBox";
            this.nivelTanqueComboBox.Size = new System.Drawing.Size(160, 25);
            this.nivelTanqueComboBox.TabIndex = 3;
            // 
            // kilometragemManutencaoTextBox
            // 
            this.kilometragemManutencaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manutencao_tbBindingSource, "KilometragemManutencao", true));
            this.kilometragemManutencaoTextBox.Location = new System.Drawing.Point(678, 88);
            this.kilometragemManutencaoTextBox.Name = "kilometragemManutencaoTextBox";
            this.kilometragemManutencaoTextBox.Size = new System.Drawing.Size(171, 25);
            this.kilometragemManutencaoTextBox.TabIndex = 4;
            this.kilometragemManutencaoTextBox.TextChanged += new System.EventHandler(this.kilometragemManutencaoTextBox_TextChanged);
            // 
            // dataManutencaoDateTimePicker
            // 
            this.dataManutencaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manutencao_tbBindingSource, "DataManutencao", true));
            this.dataManutencaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataManutencaoDateTimePicker.Location = new System.Drawing.Point(1006, 38);
            this.dataManutencaoDateTimePicker.Name = "dataManutencaoDateTimePicker";
            this.dataManutencaoDateTimePicker.Size = new System.Drawing.Size(132, 25);
            this.dataManutencaoDateTimePicker.TabIndex = 0;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.idClienteTextBox.Location = new System.Drawing.Point(250, 88);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(256, 25);
            this.idClienteTextBox.TabIndex = 2;
            this.idClienteTextBox.TextChanged += new System.EventHandler(this.idClienteTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Servico";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.servicostbBindingSource;
            this.comboBox1.DisplayMember = "NomeServico";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "idServicos";
            // 
            // servicostbBindingSource
            // 
            this.servicostbBindingSource.DataSource = typeof(GesDisponibilidade.Servicos_tb);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Km de Cadastro";
            // 
            // txtKmCadastro
            // 
            this.txtKmCadastro.Enabled = false;
            this.txtKmCadastro.Location = new System.Drawing.Point(744, 38);
            this.txtKmCadastro.Name = "txtKmCadastro";
            this.txtKmCadastro.Size = new System.Drawing.Size(256, 25);
            this.txtKmCadastro.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estado de Conservacao";
            // 
            // txtEstadoConservacao
            // 
            this.txtEstadoConservacao.Enabled = false;
            this.txtEstadoConservacao.Location = new System.Drawing.Point(359, 38);
            this.txtEstadoConservacao.Name = "txtEstadoConservacao";
            this.txtEstadoConservacao.Size = new System.Drawing.Size(147, 25);
            this.txtEstadoConservacao.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Combustivel";
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Enabled = false;
            this.txtCombustivel.Location = new System.Drawing.Point(512, 38);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(226, 25);
            this.txtCombustivel.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(203, 38);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(150, 25);
            this.txtModelo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Location = new System.Drawing.Point(18, 38);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(179, 25);
            this.txtMatricula.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEncontrar);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.textBoxBuscaCarro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 63);
            this.panel2.TabIndex = 0;
            // 
            // lblEncontrar
            // 
            this.lblEncontrar.AutoSize = true;
            this.lblEncontrar.ForeColor = System.Drawing.Color.Teal;
            this.lblEncontrar.Location = new System.Drawing.Point(460, 32);
            this.lblEncontrar.Name = "lblEncontrar";
            this.lblEncontrar.Size = new System.Drawing.Size(12, 19);
            this.lblEncontrar.TabIndex = 16;
            this.lblEncontrar.Text = ".";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(338, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 19);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Manutencoes";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxBuscaCarro
            // 
            this.textBoxBuscaCarro.Location = new System.Drawing.Point(18, 32);
            this.textBoxBuscaCarro.Name = "textBoxBuscaCarro";
            this.textBoxBuscaCarro.Size = new System.Drawing.Size(314, 25);
            this.textBoxBuscaCarro.TabIndex = 0;
            this.textBoxBuscaCarro.TextChanged += new System.EventHandler(this.textBoxBuscaCarro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar por Matricula:";
            // 
            // entradaViaturatbBindingSource
            // 
            this.entradaViaturatbBindingSource.DataSource = typeof(GesDisponibilidade.EntradaViatura_tb);
            // 
            // frmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmManutencao";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Manutencao";
            this.Load += new System.EventHandler(this.frmManutencao_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluidostbBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencao_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicostbBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaViaturatbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxBuscaCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEncontrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKmCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstadoConservacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox horaInicioTextBox;
        private System.Windows.Forms.MaskedTextBox horaFimTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.BindingSource manutencao_tbBindingSource;
        private System.Windows.Forms.TextBox valorManutencaoTextBox;
        private System.Windows.Forms.ComboBox tipoManutencaoComboBox;
        private System.Windows.Forms.ComboBox nivelTanqueComboBox;
        private System.Windows.Forms.TextBox kilometragemManutencaoTextBox;
        private System.Windows.Forms.DateTimePicker dataManutencaoDateTimePicker;
        private System.Windows.Forms.BindingSource servicostbBindingSource;
        private System.Windows.Forms.Button btnManutencao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fluidostbBindingSource;
        private System.Windows.Forms.BindingSource entradaViaturatbBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidadef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorf;
    }
}