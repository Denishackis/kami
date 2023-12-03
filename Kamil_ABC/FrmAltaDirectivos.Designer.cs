namespace ProyectoKamil
{
    partial class FrmAltaDirectivos
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
            txtNombre = new TextBox();
            txtApePaterno = new TextBox();
            label2 = new Label();
            txtApeMaterno = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            cbCentro = new ComboBox();
            label6 = new Label();
            cbPuesto = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cbCentroSupervisa = new ComboBox();
            label7 = new Label();
            rbActivaPagoCombustible = new RadioButton();
            rbDesactivaPagoCombustible = new RadioButton();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(135, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(353, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApePaterno
            // 
            txtApePaterno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApePaterno.Location = new Point(135, 39);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(353, 23);
            txtApePaterno.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 42);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido paterno:";
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApeMaterno.Location = new Point(135, 68);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(353, 23);
            txtApeMaterno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 71);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido materno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 103);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(135, 97);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(126, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 138);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Centro:";
            // 
            // cbCentro
            // 
            cbCentro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCentro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCentro.FormattingEnabled = true;
            cbCentro.Location = new Point(135, 135);
            cbCentro.Name = "cbCentro";
            cbCentro.Size = new Size(353, 23);
            cbCentro.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 170);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 10;
            label6.Text = "Puesto:";
            // 
            // cbPuesto
            // 
            cbPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPuesto.FormattingEnabled = true;
            cbPuesto.Location = new Point(135, 167);
            cbPuesto.Name = "cbPuesto";
            cbPuesto.Size = new Size(353, 23);
            cbPuesto.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(49, 289);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(173, 43);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(289, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(173, 43);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbCentroSupervisa
            // 
            cbCentroSupervisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCentroSupervisa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCentroSupervisa.FormattingEnabled = true;
            cbCentroSupervisa.Location = new Point(135, 196);
            cbCentroSupervisa.Name = "cbCentroSupervisa";
            cbCentroSupervisa.Size = new Size(353, 23);
            cbCentroSupervisa.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 199);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 14;
            label7.Text = "Centro que supervisa:";
            // 
            // rbActivaPagoCombustible
            // 
            rbActivaPagoCombustible.AutoSize = true;
            rbActivaPagoCombustible.Location = new Point(136, 238);
            rbActivaPagoCombustible.Name = "rbActivaPagoCombustible";
            rbActivaPagoCombustible.Size = new Size(92, 19);
            rbActivaPagoCombustible.TabIndex = 16;
            rbActivaPagoCombustible.Text = "Activar pago";
            rbActivaPagoCombustible.UseVisualStyleBackColor = true;
            // 
            // rbDesactivaPagoCombustible
            // 
            rbDesactivaPagoCombustible.AutoSize = true;
            rbDesactivaPagoCombustible.Checked = true;
            rbDesactivaPagoCombustible.Location = new Point(256, 238);
            rbDesactivaPagoCombustible.Name = "rbDesactivaPagoCombustible";
            rbDesactivaPagoCombustible.Size = new Size(109, 19);
            rbDesactivaPagoCombustible.TabIndex = 17;
            rbDesactivaPagoCombustible.TabStop = true;
            rbDesactivaPagoCombustible.Text = "Desactivar pago";
            rbDesactivaPagoCombustible.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 238);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 18;
            label8.Text = "Combustible:";
            // 
            // FrmAltaDirectivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 348);
            Controls.Add(label8);
            Controls.Add(rbDesactivaPagoCombustible);
            Controls.Add(rbActivaPagoCombustible);
            Controls.Add(cbCentroSupervisa);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cbPuesto);
            Controls.Add(label6);
            Controls.Add(cbCentro);
            Controls.Add(label5);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(txtApeMaterno);
            Controls.Add(label3);
            Controls.Add(txtApePaterno);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmAltaDirectivos";
            Text = "Alta de empleados";
            Load += FrmAltaDirectivos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApePaterno;
        private Label label2;
        private TextBox txtApeMaterno;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private ComboBox cbCentro;
        private Label label6;
        private ComboBox cbPuesto;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cbCentroSupervisa;
        private Label label7;
        private RadioButton rbActivaPagoCombustible;
        private RadioButton rbDesactivaPagoCombustible;
        private Label label8;
    }
}