namespace Vectores
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
            btnGenerar = new Button();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            txtTamaño = new TextBox();
            txtElemento = new TextBox();
            lstVector = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(309, 53);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 29);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(309, 114);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(309, 168);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtTamaño
            // 
            txtTamaño.Location = new Point(12, 67);
            txtTamaño.Name = "txtTamaño";
            txtTamaño.Size = new Size(125, 27);
            txtTamaño.TabIndex = 3;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(12, 132);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(125, 27);
            txtElemento.TabIndex = 4;
            // 
            // lstVector
            // 
            lstVector.FormattingEnabled = true;
            lstVector.Location = new Point(51, 250);
            lstVector.Name = "lstVector";
            lstVector.Size = new Size(211, 124);
            lstVector.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 74);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 6;
            label1.Text = "Crear Vector";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 135);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 7;
            label2.Text = "Agregar Dato";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstVector);
            Controls.Add(txtElemento);
            Controls.Add(txtTamaño);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Button btnAgregar;
        private Button btnLimpiar;
        private TextBox txtTamaño;
        private TextBox txtElemento;
        private ListBox lstVector;
        private Label label1;
        private Label label2;
    }
}
