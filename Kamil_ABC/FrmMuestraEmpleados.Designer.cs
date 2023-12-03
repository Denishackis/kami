namespace ProyectoKamil
{
    partial class FrmMuestraEmpleados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(12, 12);
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(730, 259);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // FrmMuestraEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 285);
            Controls.Add(dgvEmpleados);
            Name = "FrmMuestraEmpleados";
            Text = "Muestra empleados";
            Load += FrmMuestraEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
    }
}