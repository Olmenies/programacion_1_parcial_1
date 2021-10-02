
namespace programacion_1_parcial_1
{
    partial class Form1
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
            this.groupBoxImpresoras = new System.Windows.Forms.GroupBox();
            this.buttonHPTL1 = new System.Windows.Forms.Button();
            this.buttonXEROXPrint = new System.Windows.Forms.Button();
            this.buttonIBMFullColor = new System.Windows.Forms.Button();
            this.buttonHPOne = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxCantidadImpresiones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxImpresoras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxImpresoras
            // 
            this.groupBoxImpresoras.Controls.Add(this.buttonHPTL1);
            this.groupBoxImpresoras.Controls.Add(this.buttonXEROXPrint);
            this.groupBoxImpresoras.Controls.Add(this.buttonIBMFullColor);
            this.groupBoxImpresoras.Controls.Add(this.buttonHPOne);
            this.groupBoxImpresoras.Location = new System.Drawing.Point(12, 12);
            this.groupBoxImpresoras.Name = "groupBoxImpresoras";
            this.groupBoxImpresoras.Size = new System.Drawing.Size(388, 55);
            this.groupBoxImpresoras.TabIndex = 0;
            this.groupBoxImpresoras.TabStop = false;
            this.groupBoxImpresoras.Text = "Impresoras";
            // 
            // buttonHPTL1
            // 
            this.buttonHPTL1.Location = new System.Drawing.Point(297, 19);
            this.buttonHPTL1.Name = "buttonHPTL1";
            this.buttonHPTL1.Size = new System.Drawing.Size(75, 23);
            this.buttonHPTL1.TabIndex = 3;
            this.buttonHPTL1.Text = "HP TL-1";
            this.buttonHPTL1.UseVisualStyleBackColor = true;
            this.buttonHPTL1.Click += new System.EventHandler(this.buttonHPTL1_Click);
            // 
            // buttonXEROXPrint
            // 
            this.buttonXEROXPrint.Location = new System.Drawing.Point(196, 19);
            this.buttonXEROXPrint.Name = "buttonXEROXPrint";
            this.buttonXEROXPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonXEROXPrint.TabIndex = 2;
            this.buttonXEROXPrint.Text = "XEROX Print";
            this.buttonXEROXPrint.UseVisualStyleBackColor = true;
            this.buttonXEROXPrint.Click += new System.EventHandler(this.buttonXEROXPrint_Click);
            // 
            // buttonIBMFullColor
            // 
            this.buttonIBMFullColor.Location = new System.Drawing.Point(96, 19);
            this.buttonIBMFullColor.Name = "buttonIBMFullColor";
            this.buttonIBMFullColor.Size = new System.Drawing.Size(75, 23);
            this.buttonIBMFullColor.TabIndex = 1;
            this.buttonIBMFullColor.Text = "IBM Full Color";
            this.buttonIBMFullColor.UseVisualStyleBackColor = true;
            this.buttonIBMFullColor.Click += new System.EventHandler(this.buttonIBMFullColor_Click);
            // 
            // buttonHPOne
            // 
            this.buttonHPOne.Location = new System.Drawing.Point(6, 19);
            this.buttonHPOne.Name = "buttonHPOne";
            this.buttonHPOne.Size = new System.Drawing.Size(75, 23);
            this.buttonHPOne.TabIndex = 0;
            this.buttonHPOne.Text = "HP One";
            this.buttonHPOne.UseVisualStyleBackColor = true;
            this.buttonHPOne.Click += new System.EventHandler(this.buttonHPOne_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonImprimir);
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.textBoxCantidadImpresiones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impresoras";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(297, 15);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 7;
            this.buttonImprimir.Text = "IMPRIMIR";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(216, 15);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxCantidadImpresiones
            // 
            this.textBoxCantidadImpresiones.Location = new System.Drawing.Point(110, 17);
            this.textBoxCantidadImpresiones.Name = "textBoxCantidadImpresiones";
            this.textBoxCantidadImpresiones.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidadImpresiones.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de copias:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 110);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 248);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxImpresoras);
            this.Name = "Form1";
            this.Text = "Programación 1 - Parcial 1";
            this.groupBoxImpresoras.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImpresoras;
        private System.Windows.Forms.Button buttonHPTL1;
        private System.Windows.Forms.Button buttonXEROXPrint;
        private System.Windows.Forms.Button buttonIBMFullColor;
        private System.Windows.Forms.Button buttonHPOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxCantidadImpresiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

