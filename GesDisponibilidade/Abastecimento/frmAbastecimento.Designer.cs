namespace GesDisponibilidade.Abastecimento
{
    partial class frmAbastecimento
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
            System.Windows.Forms.Label dataAbastecimentoLabel;
            System.Windows.Forms.Label kmInicioLabel;
            System.Windows.Forms.Label litrosLabel;
            System.Windows.Forms.Label precoLitroLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxBuscaCarro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.precoLitroTextBox = new System.Windows.Forms.TextBox();
            this.abastecimento_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.litrosTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.dataAbastecimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kmInicioTextBox = new System.Windows.Forms.TextBox();
            this.lblEncontrar = new System.Windows.Forms.Label();
            dataAbastecimentoLabel = new System.Windows.Forms.Label();
            kmInicioLabel = new System.Windows.Forms.Label();
            litrosLabel = new System.Windows.Forms.Label();
            precoLitroLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abastecimento_tbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAbastecimentoLabel
            // 
            dataAbastecimentoLabel.AutoSize = true;
            dataAbastecimentoLabel.Location = new System.Drawing.Point(16, 22);
            dataAbastecimentoLabel.Name = "dataAbastecimentoLabel";
            dataAbastecimentoLabel.Size = new System.Drawing.Size(41, 19);
            dataAbastecimentoLabel.TabIndex = 8;
            dataAbastecimentoLabel.Text = "Data:";
            // 
            // kmInicioLabel
            // 
            kmInicioLabel.AutoSize = true;
            kmInicioLabel.Location = new System.Drawing.Point(247, 22);
            kmInicioLabel.Name = "kmInicioLabel";
            kmInicioLabel.Size = new System.Drawing.Size(74, 19);
            kmInicioLabel.TabIndex = 10;
            kmInicioLabel.Text = "Km Actual:";
            // 
            // litrosLabel
            // 
            litrosLabel.AutoSize = true;
            litrosLabel.Location = new System.Drawing.Point(137, 22);
            litrosLabel.Name = "litrosLabel";
            litrosLabel.Size = new System.Drawing.Size(46, 19);
            litrosLabel.TabIndex = 18;
            litrosLabel.Text = "Litros:";
            // 
            // precoLitroLabel
            // 
            precoLitroLabel.AutoSize = true;
            precoLitroLabel.Location = new System.Drawing.Point(485, 21);
            precoLitroLabel.Name = "precoLitroLabel";
            precoLitroLabel.Size = new System.Drawing.Size(78, 19);
            precoLitroLabel.TabIndex = 19;
            precoLitroLabel.Text = "Preco Litro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEncontrar);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.textBoxBuscaCarro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(23, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(330, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 19);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Abastecimentos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxBuscaCarro
            // 
            this.textBoxBuscaCarro.Location = new System.Drawing.Point(10, 43);
            this.textBoxBuscaCarro.Name = "textBoxBuscaCarro";
            this.textBoxBuscaCarro.Size = new System.Drawing.Size(314, 25);
            this.textBoxBuscaCarro.TabIndex = 10;
            this.textBoxBuscaCarro.TextChanged += new System.EventHandler(this.textBoxBuscaCarro_TextChanged);
            this.textBoxBuscaCarro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscaCarro_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar por Matricula:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtKmCadastro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtEstadoConservacao);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCombustivel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMatricula);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(23, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 201);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do veiculo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Km de Cadastro";
            // 
            // txtKmCadastro
            // 
            this.txtKmCadastro.Location = new System.Drawing.Point(409, 122);
            this.txtKmCadastro.Name = "txtKmCadastro";
            this.txtKmCadastro.Size = new System.Drawing.Size(256, 25);
            this.txtKmCadastro.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Estado de Conservacao";
            // 
            // txtEstadoConservacao
            // 
            this.txtEstadoConservacao.Location = new System.Drawing.Point(518, 72);
            this.txtEstadoConservacao.Name = "txtEstadoConservacao";
            this.txtEstadoConservacao.Size = new System.Drawing.Size(147, 25);
            this.txtEstadoConservacao.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Combustivel";
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(177, 122);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(226, 25);
            this.txtCombustivel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(362, 72);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(150, 25);
            this.txtModelo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(177, 72);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(179, 25);
            this.txtMatricula.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(precoLitroLabel);
            this.groupBox4.Controls.Add(this.precoLitroTextBox);
            this.groupBox4.Controls.Add(litrosLabel);
            this.groupBox4.Controls.Add(this.litrosTextBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.btn1);
            this.groupBox4.Controls.Add(dataAbastecimentoLabel);
            this.groupBox4.Controls.Add(this.dataAbastecimentoDateTimePicker);
            this.groupBox4.Controls.Add(this.kmInicioTextBox);
            this.groupBox4.Controls.Add(kmInicioLabel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(23, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(688, 126);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Abastecimento";
            // 
            // precoLitroTextBox
            // 
            this.precoLitroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abastecimento_tbBindingSource, "PrecoLitro", true));
            this.precoLitroTextBox.Location = new System.Drawing.Point(489, 43);
            this.precoLitroTextBox.Name = "precoLitroTextBox";
            this.precoLitroTextBox.Size = new System.Drawing.Size(193, 25);
            this.precoLitroTextBox.TabIndex = 20;
            this.precoLitroTextBox.TextChanged += new System.EventHandler(this.precoLitroTextBox_TextChanged);
            // 
            // abastecimento_tbBindingSource
            // 
            this.abastecimento_tbBindingSource.DataSource = typeof(GesDisponibilidade.Abastecimento_tb);
            // 
            // litrosTextBox
            // 
            this.litrosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abastecimento_tbBindingSource, "Litros", true));
            this.litrosTextBox.Location = new System.Drawing.Point(142, 43);
            this.litrosTextBox.Name = "litrosTextBox";
            this.litrosTextBox.Size = new System.Drawing.Size(100, 25);
            this.litrosTextBox.TabIndex = 19;
            this.litrosTextBox.TextChanged += new System.EventHandler(this.litrosTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Km Anterior (Aproximado):";
            this.label8.Visible = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.Teal;
            this.btn2.Image = global::GesDisponibilidade.Properties.Resources.GasPump_25px;
            this.btn2.Location = new System.Drawing.Point(532, 86);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 34);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "PRIMEIRO ABAS.";
            this.btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abastecimento_tbBindingSource, "KmInicio", true));
            this.textBox1.Location = new System.Drawing.Point(251, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 25);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.Color.Teal;
            this.btn1.Image = global::GesDisponibilidade.Properties.Resources.GasPump_25px;
            this.btn1.Location = new System.Drawing.Point(548, 86);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(123, 34);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "ABASTECER";
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dataAbastecimentoDateTimePicker
            // 
            this.dataAbastecimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abastecimento_tbBindingSource, "DataAbastecimento", true));
            this.dataAbastecimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAbastecimentoDateTimePicker.Location = new System.Drawing.Point(20, 44);
            this.dataAbastecimentoDateTimePicker.Name = "dataAbastecimentoDateTimePicker";
            this.dataAbastecimentoDateTimePicker.Size = new System.Drawing.Size(115, 25);
            this.dataAbastecimentoDateTimePicker.TabIndex = 9;
            // 
            // kmInicioTextBox
            // 
            this.kmInicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abastecimento_tbBindingSource, "KmInicio", true));
            this.kmInicioTextBox.Location = new System.Drawing.Point(251, 44);
            this.kmInicioTextBox.Name = "kmInicioTextBox";
            this.kmInicioTextBox.Size = new System.Drawing.Size(232, 25);
            this.kmInicioTextBox.TabIndex = 11;
            this.kmInicioTextBox.TextChanged += new System.EventHandler(this.kmInicioTextBox_TextChanged);
            // 
            // lblEncontrar
            // 
            this.lblEncontrar.AutoSize = true;
            this.lblEncontrar.ForeColor = System.Drawing.Color.Teal;
            this.lblEncontrar.Location = new System.Drawing.Point(466, 46);
            this.lblEncontrar.Name = "lblEncontrar";
            this.lblEncontrar.Size = new System.Drawing.Size(12, 19);
            this.lblEncontrar.TabIndex = 17;
            this.lblEncontrar.Text = ".";
            // 
            // frmAbastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 508);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmAbastecimento";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Text = "ABASTECIMENTOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abastecimento_tbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource abastecimento_tbBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxBuscaCarro;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dataAbastecimentoDateTimePicker;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kmInicioTextBox;
        private System.Windows.Forms.TextBox litrosTextBox;
        private System.Windows.Forms.TextBox precoLitroTextBox;
        private System.Windows.Forms.Label lblEncontrar;
    }
}