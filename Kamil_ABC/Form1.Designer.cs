namespace ABC_tarea
{
    partial class Form1
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
            cbTablas = new ComboBox();
            dtgvResultado = new DataGridView();
            btn_conectar = new Button();
            label1 = new Label();
            lbl_estado = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvResultado).BeginInit();
            SuspendLayout();
            // 
            // cbTablas
            // 
            cbTablas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTablas.FormattingEnabled = true;
            cbTablas.Location = new Point(362, 12);
            cbTablas.Name = "cbTablas";
            cbTablas.Size = new Size(148, 23);
            cbTablas.TabIndex = 0;
            cbTablas.SelectedIndexChanged += cbTablas_SelectedIndexChanged;
            // 
            // dtgvResultado
            // 
            dtgvResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvResultado.Location = new Point(12, 41);
            dtgvResultado.Name = "dtgvResultado";
            dtgvResultado.Size = new Size(498, 229);
            dtgvResultado.TabIndex = 1;
            // 
            // btn_conectar
            // 
            btn_conectar.Location = new Point(12, 12);
            btn_conectar.Name = "btn_conectar";
            btn_conectar.Size = new Size(75, 23);
            btn_conectar.TabIndex = 2;
            btn_conectar.Text = "Conectar";
            btn_conectar.UseVisualStyleBackColor = true;
            btn_conectar.Click += btn_conectar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(102, 16);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Estado:";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_estado.ForeColor = Color.Red;
            lbl_estado.Location = new Point(154, 16);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(86, 15);
            lbl_estado.TabIndex = 4;
            lbl_estado.Text = "Desconectado";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(316, 16);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Tablas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 282);
            Controls.Add(label3);
            Controls.Add(lbl_estado);
            Controls.Add(label1);
            Controls.Add(btn_conectar);
            Controls.Add(dtgvResultado);
            Controls.Add(cbTablas);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kamil ABC";
            ((System.ComponentModel.ISupportInitialize)dtgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTablas;
        private DataGridView dtgvResultado;
        private Button btn_conectar;
        private Label label1;
        private Label lbl_estado;
        private Label label3;
    }
}
