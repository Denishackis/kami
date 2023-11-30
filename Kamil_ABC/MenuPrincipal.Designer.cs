namespace ABC_tarea
{
    partial class MenuPrincipal
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
            gbEmpleados = new GroupBox();
            btnVerEmpleado = new Button();
            btnAltaEmpleado = new Button();
            gbDirectivos = new GroupBox();
            btnVerDirectivo = new Button();
            btnAltaDirectivo = new Button();
            gbCentros = new GroupBox();
            btnVerCentro = new Button();
            btnAltaCentro = new Button();
            gbEmpleados.SuspendLayout();
            gbDirectivos.SuspendLayout();
            gbCentros.SuspendLayout();
            SuspendLayout();
            // 
            // gbEmpleados
            // 
            gbEmpleados.Controls.Add(btnVerEmpleado);
            gbEmpleados.Controls.Add(btnAltaEmpleado);
            gbEmpleados.Location = new Point(12, 12);
            gbEmpleados.Name = "gbEmpleados";
            gbEmpleados.Size = new Size(145, 185);
            gbEmpleados.TabIndex = 7;
            gbEmpleados.TabStop = false;
            gbEmpleados.Text = "Empleados";
            // 
            // btnVerEmpleado
            // 
            btnVerEmpleado.Location = new Point(6, 112);
            btnVerEmpleado.Name = "btnVerEmpleado";
            btnVerEmpleado.Size = new Size(133, 43);
            btnVerEmpleado.TabIndex = 2;
            btnVerEmpleado.Text = "Ver";
            btnVerEmpleado.UseVisualStyleBackColor = true;
            btnVerEmpleado.Click += btnVerEmpleado_Click;
            // 
            // btnAltaEmpleado
            // 
            btnAltaEmpleado.Location = new Point(6, 38);
            btnAltaEmpleado.Name = "btnAltaEmpleado";
            btnAltaEmpleado.Size = new Size(133, 43);
            btnAltaEmpleado.TabIndex = 0;
            btnAltaEmpleado.Text = "Alta";
            btnAltaEmpleado.UseVisualStyleBackColor = true;
            btnAltaEmpleado.Click += btnAltaEmpleado_Click;
            // 
            // gbDirectivos
            // 
            gbDirectivos.Controls.Add(btnVerDirectivo);
            gbDirectivos.Controls.Add(btnAltaDirectivo);
            gbDirectivos.Location = new Point(188, 12);
            gbDirectivos.Name = "gbDirectivos";
            gbDirectivos.Size = new Size(145, 185);
            gbDirectivos.TabIndex = 8;
            gbDirectivos.TabStop = false;
            gbDirectivos.Text = "Directivos";
            // 
            // btnVerDirectivo
            // 
            btnVerDirectivo.Location = new Point(6, 112);
            btnVerDirectivo.Name = "btnVerDirectivo";
            btnVerDirectivo.Size = new Size(133, 43);
            btnVerDirectivo.TabIndex = 4;
            btnVerDirectivo.Text = "Ver";
            btnVerDirectivo.UseVisualStyleBackColor = true;
            // 
            // btnAltaDirectivo
            // 
            btnAltaDirectivo.Location = new Point(6, 38);
            btnAltaDirectivo.Name = "btnAltaDirectivo";
            btnAltaDirectivo.Size = new Size(133, 43);
            btnAltaDirectivo.TabIndex = 3;
            btnAltaDirectivo.Text = "Alta";
            btnAltaDirectivo.UseVisualStyleBackColor = true;
            // 
            // gbCentros
            // 
            gbCentros.Controls.Add(btnVerCentro);
            gbCentros.Controls.Add(btnAltaCentro);
            gbCentros.Location = new Point(364, 12);
            gbCentros.Name = "gbCentros";
            gbCentros.Size = new Size(145, 185);
            gbCentros.TabIndex = 8;
            gbCentros.TabStop = false;
            gbCentros.Text = "Centros";
            // 
            // btnVerCentro
            // 
            btnVerCentro.Location = new Point(6, 112);
            btnVerCentro.Name = "btnVerCentro";
            btnVerCentro.Size = new Size(133, 43);
            btnVerCentro.TabIndex = 6;
            btnVerCentro.Text = "Ver";
            btnVerCentro.UseVisualStyleBackColor = true;
            // 
            // btnAltaCentro
            // 
            btnAltaCentro.Location = new Point(6, 38);
            btnAltaCentro.Name = "btnAltaCentro";
            btnAltaCentro.Size = new Size(133, 43);
            btnAltaCentro.TabIndex = 5;
            btnAltaCentro.Text = "Alta";
            btnAltaCentro.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 214);
            Controls.Add(gbCentros);
            Controls.Add(gbDirectivos);
            Controls.Add(gbEmpleados);
            MaximizeBox = false;
            Name = "MenuPrincipal";
            Text = "Kamil ABC";
            gbEmpleados.ResumeLayout(false);
            gbDirectivos.ResumeLayout(false);
            gbCentros.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbEmpleados;
        private GroupBox gbDirectivos;
        private GroupBox gbCentros;
        private Button btnVerEmpleado;
        private Button btnAltaEmpleado;
        private Button btnVerDirectivo;
        private Button btnAltaDirectivo;
        private Button btnVerCentro;
        private Button btnAltaCentro;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
