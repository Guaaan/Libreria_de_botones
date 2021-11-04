
namespace btnLib
{
    partial class btnMorado
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
            this.botonMorado = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // botonMorado
            // 
            this.botonMorado.Animated = true;
            this.botonMorado.AnimationHoverSpeed = 0.07F;
            this.botonMorado.AnimationSpeed = 0.03F;
            this.botonMorado.BackColor = System.Drawing.Color.Transparent;
            this.botonMorado.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(29)))), ((int)(((byte)(147)))));
            this.botonMorado.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(19)))), ((int)(((byte)(98)))));
            this.botonMorado.BorderColor = System.Drawing.Color.Black;
            this.botonMorado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonMorado.FocusedColor = System.Drawing.Color.Empty;
            this.botonMorado.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMorado.ForeColor = System.Drawing.Color.White;
            this.botonMorado.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.botonMorado.Image = null;
            this.botonMorado.ImageSize = new System.Drawing.Size(20, 20);
            this.botonMorado.Location = new System.Drawing.Point(0, 0);
            this.botonMorado.Name = "botonMorado";
            this.botonMorado.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(12)))), ((int)(((byte)(65)))));
            this.botonMorado.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(12)))), ((int)(((byte)(65)))));
            this.botonMorado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonMorado.OnHoverForeColor = System.Drawing.Color.White;
            this.botonMorado.OnHoverImage = null;
            this.botonMorado.OnPressedColor = System.Drawing.Color.Black;
            this.botonMorado.OnPressedDepth = 50;
            this.botonMorado.Radius = 8;
            this.botonMorado.Size = new System.Drawing.Size(98, 32);
            this.botonMorado.TabIndex = 1;
            this.botonMorado.Text = "Botón";
            this.botonMorado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonMorado.UseTransfarantBackground = true;
            // 
            // btnMorado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.botonMorado);
            this.Name = "btnMorado";
            this.Size = new System.Drawing.Size(98, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton botonMorado;
    }
}
