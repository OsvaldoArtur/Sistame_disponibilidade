namespace GesDisponibilidade
{
    partial class frmAdicionarViaturas
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
            System.Windows.Forms.Label anoFabricoLabel;
            System.Windows.Forms.Label idMarcaLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label modeloViaturaLabel;
            System.Windows.Forms.Label destinoUsoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label idFluidoLabel;
            System.Windows.Forms.Label kmCadastroLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kmCadastroTextBox = new System.Windows.Forms.TextBox();
            this.viatura_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idFluidoComboBox = new System.Windows.Forms.ComboBox();
            this.fluidostbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.destinoUsoTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.anoFabricoTextBox = new System.Windows.Forms.TextBox();
            this.idMarcaComboBox = new System.Windows.Forms.ComboBox();
            this.marcatbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.modeloViaturaTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.viatura_tbDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloViaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoFabricoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCarroMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            anoFabricoLabel = new System.Windows.Forms.Label();
            idMarcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloViaturaLabel = new System.Windows.Forms.Label();
            destinoUsoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            idFluidoLabel = new System.Windows.Forms.Label();
            kmCadastroLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viatura_tbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluidostbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcatbBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viatura_tbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCarroMarcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anoFabricoLabel
            // 
            anoFabricoLabel.AutoSize = true;
            anoFabricoLabel.Location = new System.Drawing.Point(269, 141);
            anoFabricoLabel.Name = "anoFabricoLabel";
            anoFabricoLabel.Size = new System.Drawing.Size(85, 19);
            anoFabricoLabel.TabIndex = 15;
            anoFabricoLabel.Text = "Ano Fabrico:";
            // 
            // idMarcaLabel
            // 
            idMarcaLabel.AutoSize = true;
            idMarcaLabel.Location = new System.Drawing.Point(63, 79);
            idMarcaLabel.Name = "idMarcaLabel";
            idMarcaLabel.Size = new System.Drawing.Size(50, 19);
            idMarcaLabel.TabIndex = 13;
            idMarcaLabel.Text = "Marca:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(44, 141);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(69, 19);
            matriculaLabel.TabIndex = 10;
            matriculaLabel.Text = "Matricula:";
            // 
            // modeloViaturaLabel
            // 
            modeloViaturaLabel.AutoSize = true;
            modeloViaturaLabel.Location = new System.Drawing.Point(6, 110);
            modeloViaturaLabel.Name = "modeloViaturaLabel";
            modeloViaturaLabel.Size = new System.Drawing.Size(107, 19);
            modeloViaturaLabel.TabIndex = 9;
            modeloViaturaLabel.Text = "Modelo Viatura:";
            // 
            // destinoUsoLabel
            // 
            destinoUsoLabel.AutoSize = true;
            destinoUsoLabel.Location = new System.Drawing.Point(26, 169);
            destinoUsoLabel.Name = "destinoUsoLabel";
            destinoUsoLabel.Size = new System.Drawing.Size(87, 19);
            destinoUsoLabel.TabIndex = 20;
            destinoUsoLabel.Text = "Destino Uso:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(394, 110);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(53, 19);
            estadoLabel.TabIndex = 21;
            estadoLabel.Text = "Estado:";
            // 
            // idFluidoLabel
            // 
            idFluidoLabel.AutoSize = true;
            idFluidoLabel.Location = new System.Drawing.Point(490, 141);
            idFluidoLabel.Name = "idFluidoLabel";
            idFluidoLabel.Size = new System.Drawing.Size(49, 19);
            idFluidoLabel.TabIndex = 22;
            idFluidoLabel.Text = "Fluido:";
            // 
            // kmCadastroLabel
            // 
            kmCadastroLabel.AutoSize = true;
            kmCadastroLabel.Location = new System.Drawing.Point(435, 79);
            kmCadastroLabel.Name = "kmCadastroLabel";
            kmCadastroLabel.Size = new System.Drawing.Size(91, 19);
            kmCadastroLabel.TabIndex = 23;
            kmCadastroLabel.Text = "Km Cadastro:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(23, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(kmCadastroLabel);
            this.tabPage1.Controls.Add(this.kmCadastroTextBox);
            this.tabPage1.Controls.Add(idFluidoLabel);
            this.tabPage1.Controls.Add(this.idFluidoComboBox);
            this.tabPage1.Controls.Add(estadoLabel);
            this.tabPage1.Controls.Add(this.estadoComboBox);
            this.tabPage1.Controls.Add(destinoUsoLabel);
            this.tabPage1.Controls.Add(this.destinoUsoTextBox);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(anoFabricoLabel);
            this.tabPage1.Controls.Add(this.anoFabricoTextBox);
            this.tabPage1.Controls.Add(idMarcaLabel);
            this.tabPage1.Controls.Add(this.idMarcaComboBox);
            this.tabPage1.Controls.Add(matriculaLabel);
            this.tabPage1.Controls.Add(this.matriculaTextBox);
            this.tabPage1.Controls.Add(modeloViaturaLabel);
            this.tabPage1.Controls.Add(this.modeloViaturaTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nova viatura";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kmCadastroTextBox
            // 
            this.kmCadastroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viatura_tbBindingSource, "KmCadastro", true));
            this.kmCadastroTextBox.Location = new System.Drawing.Point(532, 76);
            this.kmCadastroTextBox.Name = "kmCadastroTextBox";
            this.kmCadastroTextBox.Size = new System.Drawing.Size(134, 25);
            this.kmCadastroTextBox.TabIndex = 1;
            // 
            // viatura_tbBindingSource
            // 
            this.viatura_tbBindingSource.DataSource = typeof(GesDisponibilidade.Viatura_tb);
            // 
            // idFluidoComboBox
            // 
            this.idFluidoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viatura_tbBindingSource, "idFluido", true));
            this.idFluidoComboBox.DataSource = this.fluidostbBindingSource;
            this.idFluidoComboBox.DisplayMember = "NomeFluido";
            this.idFluidoComboBox.FormattingEnabled = true;
            this.idFluidoComboBox.Location = new System.Drawing.Point(545, 138);
            this.idFluidoComboBox.Name = "idFluidoComboBox";
            this.idFluidoComboBox.Size = new System.Drawing.Size(121, 25);
            this.idFluidoComboBox.TabIndex = 6;
            this.idFluidoComboBox.ValueMember = "idFluido";
            // 
            // fluidostbBindingSource
            // 
            this.fluidostbBindingSource.DataSource = typeof(GesDisponibilidade.Fluidos_tb);
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viatura_tbBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Bom",
            "Regular",
            "Critico"});
            this.estadoComboBox.Location = new System.Drawing.Point(453, 107);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(213, 25);
            this.estadoComboBox.TabIndex = 3;
            // 
            // destinoUsoTextBox
            // 
            this.destinoUsoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viatura_tbBindingSource, "DestinoUso", true));
            this.destinoUsoTextBox.Location = new System.Drawing.Point(119, 169);
            this.destinoUsoTextBox.Multiline = true;
            this.destinoUsoTextBox.Name = "destinoUsoTextBox";
            this.destinoUsoTextBox.Size = new System.Drawing.Size(547, 93);
            this.destinoUsoTextBox.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(766, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 19);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buscar Foto";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::GesDisponibilidade.Properties.Resources.icons8_Plus_25px_8;
            this.button3.Location = new System.Drawing.Point(394, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 6;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GesDisponibilidade.Properties.Resources.Traffic_Jam_96px;
            this.pictureBox1.Location = new System.Drawing.Point(672, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GesDisponibilidade.Properties.Resources.icons8_Menu_25px_10;
            this.button2.Location = new System.Drawing.Point(762, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Lista";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GesDisponibilidade.Properties.Resources.icons8_Save_25px;
            this.button1.Location = new System.Drawing.Point(573, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salvar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anoFabricoTextBox
            // 
            this.anoFabricoTextBox.Location = new System.Drawing.Point(360, 138);
            this.anoFabricoTextBox.Name = "anoFabricoTextBox";
            this.anoFabricoTextBox.Size = new System.Drawing.Size(124, 25);
            this.anoFabricoTextBox.TabIndex = 5;
            // 
            // idMarcaComboBox
            // 
            this.idMarcaComboBox.DataSource = this.marcatbBindingSource;
            this.idMarcaComboBox.DisplayMember = "NomeMarca";
            this.idMarcaComboBox.FormattingEnabled = true;
            this.idMarcaComboBox.Location = new System.Drawing.Point(119, 76);
            this.idMarcaComboBox.Name = "idMarcaComboBox";
            this.idMarcaComboBox.Size = new System.Drawing.Size(269, 25);
            this.idMarcaComboBox.TabIndex = 0;
            this.idMarcaComboBox.ValueMember = "idMarca";
            this.idMarcaComboBox.SelectedIndexChanged += new System.EventHandler(this.idMarcaComboBox_SelectedIndexChanged);
            // 
            // marcatbBindingSource
            // 
            this.marcatbBindingSource.DataSource = typeof(GesDisponibilidade.Marca_tb);
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.Location = new System.Drawing.Point(119, 138);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(144, 25);
            this.matriculaTextBox.TabIndex = 4;
            // 
            // modeloViaturaTextBox
            // 
            this.modeloViaturaTextBox.Location = new System.Drawing.Point(119, 107);
            this.modeloViaturaTextBox.Name = "modeloViaturaTextBox";
            this.modeloViaturaTextBox.Size = new System.Drawing.Size(269, 25);
            this.modeloViaturaTextBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.viatura_tbDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de viaturas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // viatura_tbDataGridView
            // 
            this.viatura_tbDataGridView.AllowUserToAddRows = false;
            this.viatura_tbDataGridView.AllowUserToDeleteRows = false;
            this.viatura_tbDataGridView.AutoGenerateColumns = false;
            this.viatura_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viatura_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.viatura_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viatura_tbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeMarcaDataGridViewTextBoxColumn,
            this.modeloViaturaDataGridViewTextBoxColumn,
            this.anoFabricoDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.dataRegistroDataGridViewTextBoxColumn});
            this.viatura_tbDataGridView.DataSource = this.viewCarroMarcaBindingSource;
            this.viatura_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viatura_tbDataGridView.Location = new System.Drawing.Point(3, 3);
            this.viatura_tbDataGridView.Name = "viatura_tbDataGridView";
            this.viatura_tbDataGridView.ReadOnly = true;
            this.viatura_tbDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viatura_tbDataGridView.Size = new System.Drawing.Size(855, 356);
            this.viatura_tbDataGridView.TabIndex = 0;
            // 
            // nomeMarcaDataGridViewTextBoxColumn
            // 
            this.nomeMarcaDataGridViewTextBoxColumn.DataPropertyName = "NomeMarca";
            this.nomeMarcaDataGridViewTextBoxColumn.HeaderText = "NomeMarca";
            this.nomeMarcaDataGridViewTextBoxColumn.Name = "nomeMarcaDataGridViewTextBoxColumn";
            this.nomeMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloViaturaDataGridViewTextBoxColumn
            // 
            this.modeloViaturaDataGridViewTextBoxColumn.DataPropertyName = "ModeloViatura";
            this.modeloViaturaDataGridViewTextBoxColumn.HeaderText = "ModeloViatura";
            this.modeloViaturaDataGridViewTextBoxColumn.Name = "modeloViaturaDataGridViewTextBoxColumn";
            this.modeloViaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoFabricoDataGridViewTextBoxColumn
            // 
            this.anoFabricoDataGridViewTextBoxColumn.DataPropertyName = "AnoFabrico";
            this.anoFabricoDataGridViewTextBoxColumn.HeaderText = "AnoFabrico";
            this.anoFabricoDataGridViewTextBoxColumn.Name = "anoFabricoDataGridViewTextBoxColumn";
            this.anoFabricoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRegistroDataGridViewTextBoxColumn
            // 
            this.dataRegistroDataGridViewTextBoxColumn.DataPropertyName = "DataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.HeaderText = "DataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.Name = "dataRegistroDataGridViewTextBoxColumn";
            this.dataRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewCarroMarcaBindingSource
            // 
            this.viewCarroMarcaBindingSource.DataSource = typeof(GesDisponibilidade.View_CarroMarca);
            // 
            // frmAdicionarViaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 496);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmAdicionarViaturas";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Text = "Nova Viatura";
            this.Load += new System.EventHandler(this.frmAdicionarViaturas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viatura_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluidostbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcatbBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viatura_tbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCarroMarcaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource viatura_tbBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox anoFabricoTextBox;
        private System.Windows.Forms.ComboBox idMarcaComboBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox modeloViaturaTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView viatura_tbDataGridView;
        private System.Windows.Forms.BindingSource marcatbBindingSource;
        private System.Windows.Forms.BindingSource viewCarroMarcaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloViaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoFabricoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox kmCadastroTextBox;
        private System.Windows.Forms.ComboBox idFluidoComboBox;
        private System.Windows.Forms.BindingSource fluidostbBindingSource;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox destinoUsoTextBox;
    }
}