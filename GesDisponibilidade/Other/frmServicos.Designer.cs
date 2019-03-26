namespace GesDisponibilidade.Other
{
    partial class frmServicos
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
            System.Windows.Forms.Label nomeServicoLabel;
            System.Windows.Forms.Label descricaoServicoLabel;
            this.nomeServicoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoServicoTextBox = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.servicos_tbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicos_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeServicoLabel = new System.Windows.Forms.Label();
            descricaoServicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_tbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_tbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeServicoLabel
            // 
            nomeServicoLabel.AutoSize = true;
            nomeServicoLabel.Location = new System.Drawing.Point(26, 78);
            nomeServicoLabel.Name = "nomeServicoLabel";
            nomeServicoLabel.Size = new System.Drawing.Size(96, 19);
            nomeServicoLabel.TabIndex = 1;
            nomeServicoLabel.Text = "Nome Servico:";
            // 
            // nomeServicoTextBox
            // 
            this.nomeServicoTextBox.Location = new System.Drawing.Point(30, 100);
            this.nomeServicoTextBox.Name = "nomeServicoTextBox";
            this.nomeServicoTextBox.Size = new System.Drawing.Size(215, 25);
            this.nomeServicoTextBox.TabIndex = 0;
            // 
            // descricaoServicoLabel
            // 
            descricaoServicoLabel.AutoSize = true;
            descricaoServicoLabel.Location = new System.Drawing.Point(247, 78);
            descricaoServicoLabel.Name = "descricaoServicoLabel";
            descricaoServicoLabel.Size = new System.Drawing.Size(117, 19);
            descricaoServicoLabel.TabIndex = 3;
            descricaoServicoLabel.Text = "Descricao Servico:";
            // 
            // descricaoServicoTextBox
            // 
            this.descricaoServicoTextBox.Location = new System.Drawing.Point(251, 100);
            this.descricaoServicoTextBox.Name = "descricaoServicoTextBox";
            this.descricaoServicoTextBox.Size = new System.Drawing.Size(335, 25);
            this.descricaoServicoTextBox.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Teal;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(470, 131);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 33);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar Dados";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // servicos_tbDataGridView
            // 
            this.servicos_tbDataGridView.AllowUserToAddRows = false;
            this.servicos_tbDataGridView.AllowUserToDeleteRows = false;
            this.servicos_tbDataGridView.AutoGenerateColumns = false;
            this.servicos_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicos_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.servicos_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicos_tbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.servicos_tbDataGridView.DataSource = this.servicos_tbBindingSource;
            this.servicos_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.servicos_tbDataGridView.Location = new System.Drawing.Point(23, 170);
            this.servicos_tbDataGridView.Name = "servicos_tbDataGridView";
            this.servicos_tbDataGridView.ReadOnly = true;
            this.servicos_tbDataGridView.Size = new System.Drawing.Size(563, 274);
            this.servicos_tbDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idServicos";
            this.dataGridViewTextBoxColumn1.HeaderText = "idServicos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeServico";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeServico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescricaoServico";
            this.dataGridViewTextBoxColumn3.HeaderText = "DescricaoServico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // servicos_tbBindingSource
            // 
            this.servicos_tbBindingSource.DataSource = typeof(GesDisponibilidade.Servicos_tb);
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 470);
            this.Controls.Add(this.servicos_tbDataGridView);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(descricaoServicoLabel);
            this.Controls.Add(this.descricaoServicoTextBox);
            this.Controls.Add(nomeServicoLabel);
            this.Controls.Add(this.nomeServicoTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmServicos";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.frmServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicos_tbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_tbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource servicos_tbBindingSource;
        private System.Windows.Forms.TextBox nomeServicoTextBox;
        private System.Windows.Forms.TextBox descricaoServicoTextBox;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView servicos_tbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}