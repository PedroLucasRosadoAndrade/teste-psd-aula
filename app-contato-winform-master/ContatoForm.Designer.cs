namespace AppContatoForm
{
    partial class ContatoForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtNome = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.rdSexoGroup = new Sunny.UI.UIRadioButtonGroup();
            this.rdSexo2 = new Sunny.UI.UIRadioButton();
            this.rdSexo1 = new Sunny.UI.UIRadioButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtTelefone = new Sunny.UI.UITextBox();
            this.btnSalvar = new Sunny.UI.UIButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.rdSexoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uiLabel1);
            this.flowLayoutPanel1.Controls.Add(this.txtNome);
            this.flowLayoutPanel1.Controls.Add(this.uiLabel2);
            this.flowLayoutPanel1.Controls.Add(this.dtpDataNasc);
            this.flowLayoutPanel1.Controls.Add(this.rdSexoGroup);
            this.flowLayoutPanel1.Controls.Add(this.uiLabel3);
            this.flowLayoutPanel1.Controls.Add(this.txtEmail);
            this.flowLayoutPanel1.Controls.Add(this.uiLabel4);
            this.flowLayoutPanel1.Controls.Add(this.txtTelefone);
            this.flowLayoutPanel1.Controls.Add(this.btnSalvar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1035, 554);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(4, 0);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(133, 28);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Nome";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtNome.Location = new System.Drawing.Point(5, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNome.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.ShowText = false;
            this.txtNome.Size = new System.Drawing.Size(323, 33);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNome.Watermark = "";
            this.txtNome.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(4, 73);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(507, 28);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "Data Nascimento";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(3, 104);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(368, 22);
            this.dtpDataNasc.TabIndex = 13;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rdSexoGroup
            // 
            this.rdSexoGroup.Controls.Add(this.rdSexo2);
            this.rdSexoGroup.Controls.Add(this.rdSexo1);
            this.rdSexoGroup.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rdSexoGroup.Location = new System.Drawing.Point(5, 135);
            this.rdSexoGroup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rdSexoGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdSexoGroup.Name = "rdSexoGroup";
            this.rdSexoGroup.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.rdSexoGroup.Size = new System.Drawing.Size(360, 160);
            this.rdSexoGroup.TabIndex = 7;
            this.rdSexoGroup.Text = "Sexo";
            this.rdSexoGroup.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdSexoGroup.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rdSexo2
            // 
            this.rdSexo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdSexo2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rdSexo2.Location = new System.Drawing.Point(16, 84);
            this.rdSexo2.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdSexo2.Name = "rdSexo2";
            this.rdSexo2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdSexo2.Size = new System.Drawing.Size(150, 29);
            this.rdSexo2.TabIndex = 1;
            this.rdSexo2.Text = "Feminino";
            this.rdSexo2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rdSexo1
            // 
            this.rdSexo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdSexo1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rdSexo1.Location = new System.Drawing.Point(16, 35);
            this.rdSexo1.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdSexo1.Name = "rdSexo1";
            this.rdSexo1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdSexo1.Size = new System.Drawing.Size(150, 29);
            this.rdSexo1.TabIndex = 0;
            this.rdSexo1.Text = "Masculino";
            this.rdSexo1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(4, 301);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(133, 28);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "E-mail";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtEmail.Location = new System.Drawing.Point(5, 335);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(360, 36);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            this.txtEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(4, 377);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(133, 28);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "Telefone";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtTelefone.Location = new System.Drawing.Point(5, 411);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTelefone.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ShowText = false;
            this.txtTelefone.Size = new System.Drawing.Size(360, 36);
            this.txtTelefone.TabIndex = 11;
            this.txtTelefone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTelefone.Watermark = "";
            this.txtTelefone.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(4, 457);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 43);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 601);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContatoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contato";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.rdSexoGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtNome;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIRadioButtonGroup rdSexoGroup;
        private Sunny.UI.UIRadioButton rdSexo2;
        private Sunny.UI.UIRadioButton rdSexo1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtTelefone;
        private Sunny.UI.UIButton btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
    }
}