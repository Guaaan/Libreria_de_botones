
namespace btnLib
{
    partial class btnVolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnVolver));
            this.botonVolver = new Guna.UI.WinForms.GunaGradientButton();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Animated = true;
            this.botonVolver.AnimationHoverSpeed = 0.07F;
            this.botonVolver.AnimationSpeed = 0.03F;
            this.botonVolver.BackColor = System.Drawing.Color.Transparent;
            this.botonVolver.BaseColor1 = System.Drawing.Color.Red;
            this.botonVolver.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonVolver.BorderColor = System.Drawing.Color.Black;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonVolver.FocusedColor = System.Drawing.Color.Empty;
            this.botonVolver.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.White;
            this.botonVolver.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.botonVolver.Image = ((System.Drawing.Image)(resources.GetObject("botonVolver.Image")));
            this.botonVolver.ImageSize = new System.Drawing.Size(25, 25);
            this.botonVolver.Location = new System.Drawing.Point(0, 0);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonVolver.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonVolver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonVolver.OnHoverForeColor = System.Drawing.Color.White;
            this.botonVolver.OnHoverImage = null;
            this.botonVolver.OnPressedColor = System.Drawing.Color.Black;
            this.botonVolver.Radius = 8;
            this.botonVolver.Size = new System.Drawing.Size(105, 30);
            this.botonVolver.TabIndex = 278;
            this.botonVolver.Text = "Volver";
            this.botonVolver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.botonVolver.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnVolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.botonVolver);
            this.Name = "btnVolver";
            this.Size = new System.Drawing.Size(105, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton botonVolver;
        private System.Windows.Forms.ImageList imageList1;
    }
}
