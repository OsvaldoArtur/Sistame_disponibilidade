namespace GesDisponibilidade
{
    partial class frmSaidaViatura
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
            System.Windows.Forms.Label idViaturaLabel;
            System.Windows.Forms.Label dataSaidaLabel;
            System.Windows.Forms.Label dataDevolucaoLabel;
            this.saidaViatura_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.idViaturaComboBox = new System.Windows.Forms.ComboBox();
            this.viaturatbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelAnoFabrico = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalDias = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idViaturaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            dataDevolucaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saidaViatura_tbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viaturatbBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(26, 188);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 19);
            idClienteLabel.TabIndex = 1;
            idClienteLabel.Text = "Cliente:";
            // 
            // idViaturaLabel
            // 
            idViaturaLabel.AutoSize = true;
            idViaturaLabel.Location = new System.Drawing.Point(24, 219);
            idViaturaLabel.Name = "idViaturaLabel";
            idViaturaLabel.Size = new System.Drawing.Size(56, 19);
            idViaturaLabel.TabIndex = 2;
            idViaturaLabel.Text = "Viatura:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.Location = new System.Drawing.Point(26, 244);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(77, 19);
            dataSaidaLabel.TabIndex = 4;
            dataSaidaLabel.Text = "Data Saida:";
            // 
            // dataDevolucaoLabel
            // 
            dataDevolucaoLabel.AutoSize = true;
            dataDevolucaoLabel.Location = new System.Drawing.Point(232, 244);
            dataDevolucaoLabel.Name = "dataDevolucaoLabel";
            dataDevolucaoLabel.Size = new System.Drawing.Size(109, 19);
            dataDevolucaoLabel.TabIndex = 6;
            dataDevolucaoLabel.Text = "Data Devolucao:";
            // 
            // saidaViatura_tbBindingSource
            // 
            this.saidaViatura_tbBindingSource.DataSource = typeof(GesDisponibilidade.SaidaViatura_tb);
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.idClienteTextBox.Location = new System.Drawing.Point(86, 185);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(350, 25);
            this.idClienteTextBox.TabIndex = 2;
            this.idClienteTextBox.TextChanged += new System.EventHandler(this.idClienteTextBox_TextChanged);
            // 
            // idViaturaComboBox
            // 
            this.idViaturaComboBox.DataSource = this.viaturatbBindingSource;
            this.idViaturaComboBox.DisplayMember = "Matricula";
            this.idViaturaComboBox.FormattingEnabled = true;
            this.idViaturaComboBox.Location = new System.Drawing.Point(86, 216);
            this.idViaturaComboBox.Name = "idViaturaComboBox";
            this.idViaturaComboBox.Size = new System.Drawing.Size(224, 25);
            this.idViaturaComboBox.TabIndex = 3;
            this.idViaturaComboBox.ValueMember = "idViaturas";
            this.idViaturaComboBox.SelectedIndexChanged += new System.EventHandler(this.idViaturaComboBox_SelectedIndexChanged);
            // 
            // viaturatbBindingSource
            // 
            this.viaturatbBindingSource.DataSource = typeof(GesDisponibilidade.Viatura_tb);
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(30, 266);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dataSaidaDateTimePicker.TabIndex = 5;
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(236, 266);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dataDevolucaoDateTimePicker.TabIndex = 7;
            this.dataDevolucaoDateTimePicker.ValueChanged += new System.EventHandler(this.dataDevolucaoDateTimePicker_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(23, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 78);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Basicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula do Carro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelEstado);
            this.groupBox2.Controls.Add(this.labelMarca);
            this.groupBox2.Controls.Add(this.labelMatricula);
            this.groupBox2.Controls.Add(this.labelAnoFabrico);
            this.groupBox2.Controls.Add(this.labelModelo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(442, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 214);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Viatura";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(6, 129);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(12, 19);
            this.labelEstado.TabIndex = 0;
            this.labelEstado.Text = ".";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(6, 102);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(12, 19);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = ".";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(6, 75);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(12, 19);
            this.labelMatricula.TabIndex = 0;
            this.labelMatricula.Text = ".";
            // 
            // labelAnoFabrico
            // 
            this.labelAnoFabrico.AutoSize = true;
            this.labelAnoFabrico.Location = new System.Drawing.Point(6, 48);
            this.labelAnoFabrico.Name = "labelAnoFabrico";
            this.labelAnoFabrico.Size = new System.Drawing.Size(12, 19);
            this.labelAnoFabrico.TabIndex = 0;
            this.labelAnoFabrico.Text = ".";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(6, 21);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(12, 19);
            this.labelModelo.TabIndex = 0;
            this.labelModelo.Text = ".";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GesDisponibilidade.Properties.Resources.Delivery_25px;
            this.button1.Location = new System.Drawing.Point(323, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delivery";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total de dias:";
            // 
            // labelTotalDias
            // 
            this.labelTotalDias.AutoSize = true;
            this.labelTotalDias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDias.Location = new System.Drawing.Point(123, 342);
            this.labelTotalDias.Name = "labelTotalDias";
            this.labelTotalDias.Size = new System.Drawing.Size(13, 19);
            this.labelTotalDias.TabIndex = 1;
            this.labelTotalDias.Text = ".";
            // 
            // frmSaidaViatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 396);
            this.Controls.Add(this.labelTotalDias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(dataDevolucaoLabel);
            this.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.Controls.Add(dataSaidaLabel);
            this.Controls.Add(this.dataSaidaDateTimePicker);
            this.Controls.Add(idViaturaLabel);
            this.Controls.Add(this.idViaturaComboBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmSaidaViatura";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Text = "Saida Viatura";
            this.Load += new System.EventHandler(this.frmSaidaViatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saidaViatura_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viaturatbBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource saidaViatura_tbBindingSource;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.ComboBox idViaturaComboBox;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
        private System.Windows.Forms.BindingSource viaturatbBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelAnoFabrico;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalDias;
    }
}