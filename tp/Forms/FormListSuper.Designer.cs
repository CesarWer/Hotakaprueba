namespace Forms
{
    partial class FormListSuper
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevoElemento = new System.Windows.Forms.Button();
            this.DGVDespensa = new System.Windows.Forms.DataGridView();
            this.Realizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BTNVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDespensa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Super";
            // 
            // BtnNuevoElemento
            // 
            this.BtnNuevoElemento.Location = new System.Drawing.Point(12, 392);
            this.BtnNuevoElemento.Name = "BtnNuevoElemento";
            this.BtnNuevoElemento.Size = new System.Drawing.Size(110, 23);
            this.BtnNuevoElemento.TabIndex = 6;
            this.BtnNuevoElemento.Text = "Nuevo Elemento";
            this.BtnNuevoElemento.UseVisualStyleBackColor = true;
            // 
            // DGVDespensa
            // 
            this.DGVDespensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDespensa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Realizado});
            this.DGVDespensa.Location = new System.Drawing.Point(12, 93);
            this.DGVDespensa.Name = "DGVDespensa";
            this.DGVDespensa.Size = new System.Drawing.Size(776, 293);
            this.DGVDespensa.TabIndex = 5;
            // 
            // Realizado
            // 
            this.Realizado.HeaderText = "Realizado";
            this.Realizado.Name = "Realizado";
            // 
            // BTNVolver
            // 
            this.BTNVolver.Location = new System.Drawing.Point(12, 421);
            this.BTNVolver.Name = "BTNVolver";
            this.BTNVolver.Size = new System.Drawing.Size(75, 23);
            this.BTNVolver.TabIndex = 19;
            this.BTNVolver.Text = "Volver";
            this.BTNVolver.UseVisualStyleBackColor = true;
            this.BTNVolver.Click += new System.EventHandler(this.BTNVolver_Click);
            // 
            // FormListSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNuevoElemento);
            this.Controls.Add(this.DGVDespensa);
            this.Name = "FormListSuper";
            this.Text = "Lista Super";
            this.Load += new System.EventHandler(this.FormListSuper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDespensa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNuevoElemento;
        private System.Windows.Forms.DataGridView DGVDespensa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Realizado;
        private System.Windows.Forms.Button BTNVolver;
    }
}