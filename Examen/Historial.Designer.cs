
namespace Examen
{
	partial class Historial
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox boxHist;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.boxHist = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// boxHist
			// 
			this.boxHist.AcceptsReturn = true;
			this.boxHist.AcceptsTab = true;
			this.boxHist.AllowDrop = true;
			this.boxHist.Location = new System.Drawing.Point(2, 6);
			this.boxHist.Multiline = true;
			this.boxHist.Name = "boxHist";
			this.boxHist.ReadOnly = true;
			this.boxHist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.boxHist.Size = new System.Drawing.Size(270, 244);
			this.boxHist.TabIndex = 0;
			// 
			// Historial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.boxHist);
			this.Name = "Historial";
			this.Text = "Historial de Cotizaciones";
			this.Load += new System.EventHandler(this.HistorialLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
