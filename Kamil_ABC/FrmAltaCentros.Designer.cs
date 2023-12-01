namespace ProyectoKamil
{
    partial class FrmAltaCentros
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
            label1 = new Label();
            txtNombreCentro = new TextBox();
            txtNumeroCentro = new TextBox();
            label2 = new Label();
            txtNombreCiudad = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 13);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Centro:";
            // 
            // txtNombreCentro
            // 
            txtNombreCentro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCentro.Location = new Point(135, 10);
            txtNombreCentro.Name = "txtNombreCentro";
            txtNombreCentro.Size = new Size(353, 23);
            txtNombreCentro.TabIndex = 1;
            // 
            // txtNumeroCentro
            // 
            txtNumeroCentro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumeroCentro.Location = new Point(135, 39);
            txtNumeroCentro.Name = "txtNumeroCentro";
            txtNumeroCentro.Size = new Size(353, 23);
            txtNumeroCentro.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 42);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Número centro:";
            // 
            // txtNombreCiudad
            // 
            txtNombreCiudad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCiudad.Location = new Point(135, 68);
            txtNombreCiudad.Name = "txtNombreCiudad";
            txtNombreCiudad.Size = new Size(353, 23);
            txtNombreCiudad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 71);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre ciudad:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(49, 120);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(173, 43);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(289, 120);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(173, 43);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAltaCentros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 182);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreCiudad);
            Controls.Add(label3);
            Controls.Add(txtNumeroCentro);
            Controls.Add(label2);
            Controls.Add(txtNombreCentro);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmAltaCentros";
            Text = "Alta de centros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCentro;
        private TextBox txtNumeroCentro;
        private Label label2;
        private TextBox txtNombreCiudad;
        private Label label3;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}