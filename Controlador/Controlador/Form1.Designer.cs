namespace Controlador
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnSetId = new System.Windows.Forms.Button();
            this.inputId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 13);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(256, 42);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Controlar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(12, 61);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(256, 42);
            this.btnParar.TabIndex = 1;
            this.btnParar.Text = "Parar movimento";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(12, 109);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(256, 42);
            this.btnAndar.TabIndex = 2;
            this.btnAndar.Text = "Iniciar movimento";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(12, 157);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(256, 42);
            this.btnLiberar.TabIndex = 3;
            this.btnLiberar.Text = "Liberar controle";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // btnSetId
            // 
            this.btnSetId.Location = new System.Drawing.Point(13, 109);
            this.btnSetId.Name = "btnSetId";
            this.btnSetId.Size = new System.Drawing.Size(255, 42);
            this.btnSetId.TabIndex = 4;
            this.btnSetId.Text = "Iniciar";
            this.btnSetId.UseVisualStyleBackColor = true;
            this.btnSetId.Click += new System.EventHandler(this.btnSetId_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(140, 73);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(91, 20);
            this.inputId.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(43, 76);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(82, 13);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "ID do processo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 211);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.btnSetId);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Button btnSetId;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label labelId;
    }
}

