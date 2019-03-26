namespace GesDisponibilidade
{
    partial class frmMarca
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
            System.Windows.Forms.Label nomeMarcaLabel;
            this.nomeMarcaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.marca_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marca_tbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeMarcaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marca_tbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marca_tbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeMarcaLabel
            // 
            nomeMarcaLabel.AutoSize = true;
            nomeMarcaLabel.Location = new System.Drawing.Point(26, 84);
            nomeMarcaLabel.Name = "nomeMarcaLabel";
            nomeMarcaLabel.Size = new System.Drawing.Size(91, 19);
            nomeMarcaLabel.TabIndex = 2;
            nomeMarcaLabel.Text = "Nome Marca:";
            // 
            // nomeMarcaTextBox
            // 
            this.nomeMarcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marca_tbBindingSource, "NomeMarca", true));
            this.nomeMarcaTextBox.Location = new System.Drawing.Point(123, 81);
            this.nomeMarcaTextBox.Name = "nomeMarcaTextBox";
            this.nomeMarcaTextBox.Size = new System.Drawing.Size(308, 25);
            this.nomeMarcaTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GesDisponibilidade.Properties.Resources.icons8_Save_25px;
            this.button1.Location = new System.Drawing.Point(338, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marca_tbBindingSource
            // 
            this.marca_tbBindingSource.DataSource = typeof(GesDisponibilidade.Marca_tb);
            // 
            // marca_tbDataGridView
            // 
            this.marca_tbDataGridView.AllowUserToAddRows = false;
            this.marca_tbDataGridView.AllowUserToDeleteRows = false;
            this.marca_tbDataGridView.AutoGenerateColumns = false;
            this.marca_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.marca_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.marca_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marca_tbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.marca_tbDataGridView.DataSource = this.marca_tbBindingSource;
            this.marca_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.marca_tbDataGridView.Location = new System.Drawing.Point(23, 157);
            this.marca_tbDataGridView.Name = "marca_tbDataGridView";
            this.marca_tbDataGridView.ReadOnly = true;
            this.marca_tbDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marca_tbDataGridView.Size = new System.Drawing.Size(408, 264);
            this.marca_tbDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idMarca";
            this.dataGridViewTextBoxColumn1.HeaderText = "idMarca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeMarca";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeMarca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataRegistro";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataRegistro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RegistradoPor";
            this.dataGridViewTextBoxColumn4.HeaderText = "RegistradoPor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ActualizadoPor";
            this.dataGridViewTextBoxColumn5.HeaderText = "ActualizadoPor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 447);
            this.Controls.Add(this.marca_tbDataGridView);
            this.Controls.Add(nomeMarcaLabel);
            this.Controls.Add(this.nomeMarcaTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmMarca";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Text = "Adicionar Marca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marca_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marca_tbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource marca_tbBindingSource;
        private System.Windows.Forms.TextBox nomeMarcaTextBox;
        private System.Windows.Forms.DataGridView marca_tbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}