namespace GesDisponibilidade
{
    partial class frmDisponivi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abastecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioSaidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioAbastecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutencaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(26, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 306);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disponibilidade";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(23, 48);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(743, 115);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 85);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Principal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.abastecimentoToolStripMenuItem,
            this.relatorioSaidaToolStripMenuItem,
            this.saidaVeiculoToolStripMenuItem,
            this.manutencaoToolStripMenuItem,
            this.cadastroDeUsuariosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 79);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.motoristaToolStripMenuItem,
            this.fluidosToolStripMenuItem,
            this.servicoToolStripMenuItem,
            this.veiculoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Add_50px;
            this.cadastroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 75);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Garage_Closed_25px;
            this.empresaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // motoristaToolStripMenuItem
            // 
            this.motoristaToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Driver_25px;
            this.motoristaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.motoristaToolStripMenuItem.Name = "motoristaToolStripMenuItem";
            this.motoristaToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.motoristaToolStripMenuItem.Text = "Motorista";
            this.motoristaToolStripMenuItem.Click += new System.EventHandler(this.motoristaToolStripMenuItem_Click);
            // 
            // fluidosToolStripMenuItem
            // 
            this.fluidosToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Engine_Oil_Level_25px;
            this.fluidosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fluidosToolStripMenuItem.Name = "fluidosToolStripMenuItem";
            this.fluidosToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.fluidosToolStripMenuItem.Text = "Fluidos";
            this.fluidosToolStripMenuItem.Click += new System.EventHandler(this.fluidosToolStripMenuItem_Click);
            // 
            // servicoToolStripMenuItem
            // 
            this.servicoToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Car_Service_25px;
            this.servicoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.servicoToolStripMenuItem.Name = "servicoToolStripMenuItem";
            this.servicoToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.servicoToolStripMenuItem.Text = "Servico";
            this.servicoToolStripMenuItem.Click += new System.EventHandler(this.servicoToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Car_25px;
            this.veiculoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.veiculoToolStripMenuItem.Text = "Veiculos";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // abastecimentoToolStripMenuItem
            // 
            this.abastecimentoToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Gas_Station_48px;
            this.abastecimentoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.abastecimentoToolStripMenuItem.Name = "abastecimentoToolStripMenuItem";
            this.abastecimentoToolStripMenuItem.Size = new System.Drawing.Size(99, 75);
            this.abastecimentoToolStripMenuItem.Text = "Abastecimento";
            this.abastecimentoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abastecimentoToolStripMenuItem.Click += new System.EventHandler(this.abastecimentoToolStripMenuItem_Click);
            // 
            // relatorioSaidaToolStripMenuItem
            // 
            this.relatorioSaidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioAbastecimentoToolStripMenuItem,
            this.saidaToolStripMenuItem});
            this.relatorioSaidaToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Calendar_48px;
            this.relatorioSaidaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relatorioSaidaToolStripMenuItem.Name = "relatorioSaidaToolStripMenuItem";
            this.relatorioSaidaToolStripMenuItem.Size = new System.Drawing.Size(71, 75);
            this.relatorioSaidaToolStripMenuItem.Text = "Relatorios";
            this.relatorioSaidaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.relatorioSaidaToolStripMenuItem.Click += new System.EventHandler(this.relatorioSaidaToolStripMenuItem_Click);
            // 
            // relatorioAbastecimentoToolStripMenuItem
            // 
            this.relatorioAbastecimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem,
            this.individualToolStripMenuItem});
            this.relatorioAbastecimentoToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Page_Overview_2_25px;
            this.relatorioAbastecimentoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relatorioAbastecimentoToolStripMenuItem.Name = "relatorioAbastecimentoToolStripMenuItem";
            this.relatorioAbastecimentoToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.relatorioAbastecimentoToolStripMenuItem.Text = "Relatorio Abastecimento";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Page_Overview_4_25px;
            this.geralToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.geralToolStripMenuItem.Text = "Geral";
            this.geralToolStripMenuItem.Click += new System.EventHandler(this.geralToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Page_Overview_24_25px;
            this.individualToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.individualToolStripMenuItem.Text = "Individual";
            // 
            // saidaToolStripMenuItem
            // 
            this.saidaToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Delivery_25px1;
            this.saidaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            this.saidaToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.saidaToolStripMenuItem.Text = "Relatorio Saida";
            this.saidaToolStripMenuItem.Click += new System.EventHandler(this.saidaToolStripMenuItem_Click);
            // 
            // saidaVeiculoToolStripMenuItem
            // 
            this.saidaVeiculoToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Delivery_48px;
            this.saidaVeiculoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saidaVeiculoToolStripMenuItem.Name = "saidaVeiculoToolStripMenuItem";
            this.saidaVeiculoToolStripMenuItem.Size = new System.Drawing.Size(88, 75);
            this.saidaVeiculoToolStripMenuItem.Text = "Saida Veiculo";
            this.saidaVeiculoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saidaVeiculoToolStripMenuItem.Click += new System.EventHandler(this.saidaVeiculoToolStripMenuItem_Click);
            // 
            // manutencaoToolStripMenuItem
            // 
            this.manutencaoToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Maintenance_48px;
            this.manutencaoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manutencaoToolStripMenuItem.Name = "manutencaoToolStripMenuItem";
            this.manutencaoToolStripMenuItem.Size = new System.Drawing.Size(86, 75);
            this.manutencaoToolStripMenuItem.Text = "Manutencao";
            this.manutencaoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manutencaoToolStripMenuItem.Click += new System.EventHandler(this.manutencaoToolStripMenuItem_Click);
            // 
            // cadastroDeUsuariosToolStripMenuItem
            // 
            this.cadastroDeUsuariosToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.User_Credentials_40px;
            this.cadastroDeUsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastroDeUsuariosToolStripMenuItem.Name = "cadastroDeUsuariosToolStripMenuItem";
            this.cadastroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(130, 75);
            this.cadastroDeUsuariosToolStripMenuItem.Text = "Cadastro de Usuarios";
            this.cadastroDeUsuariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::GesDisponibilidade.Properties.Resources.Cancel_48px;
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(60, 75);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDisponivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 504);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox2);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmDisponivi";
            this.Padding = new System.Windows.Forms.Padding(23, 48, 23, 26);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDisponivi_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioSaidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abastecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutencaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioAbastecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}