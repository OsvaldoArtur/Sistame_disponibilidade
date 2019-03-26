namespace GesDisponibilidade.Other
{
    partial class frmFluidos
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
            System.Windows.Forms.Label nomeFluidoLabel;
            System.Windows.Forms.Label unidadeMedidaLabel;
            this.nomeFluidoTextBox = new System.Windows.Forms.TextBox();
            this.unidadeMedidaTextBox = new System.Windows.Forms.TextBox();
            this.fluidos_tbDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fluidos_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeFluidoLabel = new System.Windows.Forms.Label();
            unidadeMedidaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fluidos_tbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluidos_tbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFluidoLabel
            // 
            nomeFluidoLabel.AutoSize = true;
            nomeFluidoLabel.Location = new System.Drawing.Point(26, 87);
            nomeFluidoLabel.Name = "nomeFluidoLabel";
            nomeFluidoLabel.Size = new System.Drawing.Size(90, 19);
            nomeFluidoLabel.TabIndex = 1;
            nomeFluidoLabel.Text = "Nome Fluido:";
            // 
            // unidadeMedidaLabel
            // 
            unidadeMedidaLabel.AutoSize = true;
            unidadeMedidaLabel.Location = new System.Drawing.Point(402, 87);
            unidadeMedidaLabel.Name = "unidadeMedidaLabel";
            unidadeMedidaLabel.Size = new System.Drawing.Size(113, 19);
            unidadeMedidaLabel.TabIndex = 3;
            unidadeMedidaLabel.Text = "Unidade Medida:";
            // 
            // nomeFluidoTextBox
            // 
            this.nomeFluidoTextBox.Location = new System.Drawing.Point(122, 84);
            this.nomeFluidoTextBox.Name = "nomeFluidoTextBox";
            this.nomeFluidoTextBox.Size = new System.Drawing.Size(274, 25);
            this.nomeFluidoTextBox.TabIndex = 0;
            // 
            // unidadeMedidaTextBox
            // 
            this.unidadeMedidaTextBox.Location = new System.Drawing.Point(521, 84);
            this.unidadeMedidaTextBox.Name = "unidadeMedidaTextBox";
            this.unidadeMedidaTextBox.Size = new System.Drawing.Size(156, 25);
            this.unidadeMedidaTextBox.TabIndex = 1;
            // 
            // fluidos_tbDataGridView
            // 
            this.fluidos_tbDataGridView.AllowUserToAddRows = false;
            this.fluidos_tbDataGridView.AllowUserToDeleteRows = false;
            this.fluidos_tbDataGridView.AutoGenerateColumns = false;
            this.fluidos_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fluidos_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.fluidos_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fluidos_tbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.fluidos_tbDataGridView.DataSource = this.fluidos_tbBindingSource;
            this.fluidos_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fluidos_tbDataGridView.Location = new System.Drawing.Point(23, 154);
            this.fluidos_tbDataGridView.Name = "fluidos_tbDataGridView";
            this.fluidos_tbDataGridView.ReadOnly = true;
            this.fluidos_tbDataGridView.Size = new System.Drawing.Size(654, 280);
            this.fluidos_tbDataGridView.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Teal;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(561, 115);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 33);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar Dados";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFluido";
            this.dataGridViewTextBoxColumn1.HeaderText = "idFluido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeFluido";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeFluido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnidadeMedida";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnidadeMedida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fluidos_tbBindingSource
            // 
            this.fluidos_tbBindingSource.DataSource = typeof(GesDisponibilidade.Fluidos_tb);
            // 
            // frmFluidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.fluidos_tbDataGridView);
            this.Controls.Add(unidadeMedidaLabel);
            this.Controls.Add(this.unidadeMedidaTextBox);
            this.Controls.Add(nomeFluidoLabel);
            this.Controls.Add(this.nomeFluidoTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmFluidos";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Text = "Fluidos";
            this.Load += new System.EventHandler(this.frmFluidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluidos_tbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluidos_tbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fluidos_tbBindingSource;
        private System.Windows.Forms.TextBox nomeFluidoTextBox;
        private System.Windows.Forms.TextBox unidadeMedidaTextBox;
        private System.Windows.Forms.DataGridView fluidos_tbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnSalvar;
    }
}