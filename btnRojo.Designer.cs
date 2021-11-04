
namespace btnLib
{
    partial class btnRojo
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
            this.botonRojo = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // botonRojo
            // 
            this.botonRojo.Animated = true;
            this.botonRojo.AnimationHoverSpeed = 0.07F;
            this.botonRojo.AnimationSpeed = 0.03F;
            this.botonRojo.BackColor = System.Drawing.Color.Transparent;
            this.botonRojo.BaseColor1 = System.Drawing.Color.Red;
            this.botonRojo.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonRojo.BorderColor = System.Drawing.Color.Black;
            this.botonRojo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonRojo.FocusedColor = System.Drawing.Color.Empty;
            this.botonRojo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRojo.ForeColor = System.Drawing.Color.White;
            this.botonRojo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.botonRojo.Image = null;
            this.botonRojo.ImageSize = new System.Drawing.Size(20, 20);
            this.botonRojo.Location = new System.Drawing.Point(0, 0);
            this.botonRojo.Name = "botonRojo";
            this.botonRojo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonRojo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonRojo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonRojo.OnHoverForeColor = System.Drawing.Color.White;
            this.botonRojo.OnHoverImage = null;
            this.botonRojo.OnPressedColor = System.Drawing.Color.Black;
            this.botonRojo.OnPressedDepth = 50;
            this.botonRojo.Radius = 8;
            this.botonRojo.Size = new System.Drawing.Size(98, 32);
            this.botonRojo.TabIndex = 6;
            this.botonRojo.Text = "Botón";
            this.botonRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonRojo.UseTransfarantBackground = true;
            // 
            // btnRojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.botonRojo);
            this.Name = "btnRojo";
            this.Size = new System.Drawing.Size(98, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton botonRojo;
    }
}
