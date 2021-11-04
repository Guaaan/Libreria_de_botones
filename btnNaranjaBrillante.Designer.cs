
namespace btnLib
{
    partial class btnNaranjaBrillante
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
            this.botonNaranjaBrillante = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // botonNaranjaBrillante
            // 
            this.botonNaranjaBrillante.Animated = true;
            this.botonNaranjaBrillante.AnimationHoverSpeed = 0.07F;
            this.botonNaranjaBrillante.AnimationSpeed = 0.03F;
            this.botonNaranjaBrillante.BackColor = System.Drawing.Color.Transparent;
            this.botonNaranjaBrillante.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(67)))));
            this.botonNaranjaBrillante.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(88)))), ((int)(((byte)(32)))));
            this.botonNaranjaBrillante.BorderColor = System.Drawing.Color.Black;
            this.botonNaranjaBrillante.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonNaranjaBrillante.FocusedColor = System.Drawing.Color.Empty;
            this.botonNaranjaBrillante.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNaranjaBrillante.ForeColor = System.Drawing.Color.White;
            this.botonNaranjaBrillante.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.botonNaranjaBrillante.Image = null;
            this.botonNaranjaBrillante.ImageSize = new System.Drawing.Size(20, 20);
            this.botonNaranjaBrillante.Location = new System.Drawing.Point(0, 0);
            this.botonNaranjaBrillante.Name = "botonNaranjaBrillante";
            this.botonNaranjaBrillante.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(55)))));
            this.botonNaranjaBrillante.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(55)))));
            this.botonNaranjaBrillante.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonNaranjaBrillante.OnHoverForeColor = System.Drawing.Color.White;
            this.botonNaranjaBrillante.OnHoverImage = null;
            this.botonNaranjaBrillante.OnPressedColor = System.Drawing.Color.Black;
            this.botonNaranjaBrillante.OnPressedDepth = 50;
            this.botonNaranjaBrillante.Radius = 8;
            this.botonNaranjaBrillante.Size = new System.Drawing.Size(98, 32);
            this.botonNaranjaBrillante.TabIndex = 5;
            this.botonNaranjaBrillante.Text = "Botón";
            this.botonNaranjaBrillante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonNaranjaBrillante.UseTransfarantBackground = true;
            // 
            // btnNaranjaBrillante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.botonNaranjaBrillante);
            this.Name = "btnNaranjaBrillante";
            this.Size = new System.Drawing.Size(98, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton botonNaranjaBrillante;
    }
}
