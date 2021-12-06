
namespace CadenadeCarac
{
    partial class EjercicioN2
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese las palabras que desea invertir:";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(261, 31);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(142, 20);
            this.Txt1.TabIndex = 1;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(438, 31);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 39);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sus palabras invertidas son:";
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(261, 80);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(142, 20);
            this.Txt2.TabIndex = 4;
            // 
            // EjercicioN2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label1);
            this.Name = "EjercicioN2";
            this.Text = "EjercicioN2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt2;
    }
}