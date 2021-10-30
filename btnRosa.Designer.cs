
namespace btnLib
{
    partial class btnRosa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonRosa = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // botonRosa
            // 
            this.botonRosa.Animated = true;
            this.botonRosa.AnimationHoverSpeed = 0.07F;
            this.botonRosa.AnimationSpeed = 0.03F;
            this.botonRosa.BackColor = System.Drawing.Color.Transparent;
            this.botonRosa.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.botonRosa.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.botonRosa.BorderColor = System.Drawing.Color.Black;
            this.botonRosa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonRosa.FocusedColor = System.Drawing.Color.Empty;
            this.botonRosa.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRosa.ForeColor = System.Drawing.Color.White;
            this.botonRosa.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.botonRosa.Image = null;
            this.botonRosa.ImageSize = new System.Drawing.Size(20, 20);
            this.botonRosa.Location = new System.Drawing.Point(0, 0);
            this.botonRosa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonRosa.Name = "botonRosa";
            this.botonRosa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.botonRosa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.botonRosa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonRosa.OnHoverForeColor = System.Drawing.Color.White;
            this.botonRosa.OnHoverImage = null;
            this.botonRosa.OnPressedColor = System.Drawing.Color.Black;
            this.botonRosa.OnPressedDepth = 50;
            this.botonRosa.Radius = 8;
            this.botonRosa.Size = new System.Drawing.Size(130, 40);
            this.botonRosa.TabIndex = 6;
            this.botonRosa.Text = "Botón";
            this.botonRosa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonRosa.UseTransfarantBackground = true;
            // 
            // btnRosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.botonRosa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "btnRosa";
            this.Size = new System.Drawing.Size(130, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton botonRosa;
    }
}
