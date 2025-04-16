namespace cadastro_de_produtos
{
    partial class cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            lstProdutos = new ListBox();
            btnCadastra = new Button();
            bntVisualizar = new Button();
            btnListar = new Button();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Name = "txtNome";
            // 
            // txtCategoria
            // 
            resources.ApplyResources(txtCategoria, "txtCategoria");
            txtCategoria.Name = "txtCategoria";
            // 
            // lstProdutos
            // 
            resources.ApplyResources(lstProdutos, "lstProdutos");
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Name = "lstProdutos";
            // 
            // btnCadastra
            // 
            resources.ApplyResources(btnCadastra, "btnCadastra");
            btnCadastra.Name = "btnCadastra";
            btnCadastra.UseVisualStyleBackColor = true;
            btnCadastra.Click += btnCadastra_Click;
            // 
            // bntVisualizar
            // 
            resources.ApplyResources(bntVisualizar, "bntVisualizar");
            bntVisualizar.Name = "bntVisualizar";
            bntVisualizar.UseVisualStyleBackColor = true;
            bntVisualizar.Click += bntVisualizar_Click;
            // 
            // btnListar
            // 
            resources.ApplyResources(btnListar, "btnListar");
            btnListar.Name = "btnListar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtPreco
            // 
            resources.ApplyResources(txtPreco, "txtPreco");
            txtPreco.Name = "txtPreco";
            // 
            // cadastro
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPreco);
            Controls.Add(btnListar);
            Controls.Add(bntVisualizar);
            Controls.Add(btnCadastra);
            Controls.Add(lstProdutos);
            Controls.Add(txtCategoria);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadastro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCategoria;
        private ListBox lstProdutos;
        private Button btnCadastra;
        private Button bntVisualizar;
        private Button btnListar;
        private TextBox txtPreco;
    }
}
