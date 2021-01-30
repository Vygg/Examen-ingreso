/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 30/01/2021
 * Time: 08:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Examen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox checkManga;
		private System.Windows.Forms.CheckBox checkChupin;
		private System.Windows.Forms.CheckBox checkMao;
		private System.Windows.Forms.RadioButton radioCamisa;
		private System.Windows.Forms.RadioButton radioPantalon;
		private System.Windows.Forms.Label nombreTienda;
		private System.Windows.Forms.Label direccionTienda;
		private System.Windows.Forms.Label stock;
		private System.Windows.Forms.GroupBox groupPrenda;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupCalidad;
		private System.Windows.Forms.RadioButton radioPremium;
		private System.Windows.Forms.RadioButton radioStandard;
		private System.Windows.Forms.GroupBox groupPrecio;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPrecio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCotizar;
		private System.Windows.Forms.Label labelCotizacion;
		private System.Windows.Forms.Label nombreVendedor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label codigoVendedor;
		private System.Windows.Forms.LinkLabel linkHistorial;
		
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
			this.checkManga = new System.Windows.Forms.CheckBox();
			this.checkChupin = new System.Windows.Forms.CheckBox();
			this.checkMao = new System.Windows.Forms.CheckBox();
			this.radioCamisa = new System.Windows.Forms.RadioButton();
			this.radioPantalon = new System.Windows.Forms.RadioButton();
			this.nombreTienda = new System.Windows.Forms.Label();
			this.direccionTienda = new System.Windows.Forms.Label();
			this.stock = new System.Windows.Forms.Label();
			this.groupPrenda = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupCalidad = new System.Windows.Forms.GroupBox();
			this.radioPremium = new System.Windows.Forms.RadioButton();
			this.radioStandard = new System.Windows.Forms.RadioButton();
			this.groupPrecio = new System.Windows.Forms.GroupBox();
			this.textBoxCantidad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPrecio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCotizar = new System.Windows.Forms.Button();
			this.labelCotizacion = new System.Windows.Forms.Label();
			this.nombreVendedor = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.codigoVendedor = new System.Windows.Forms.Label();
			this.linkHistorial = new System.Windows.Forms.LinkLabel();
			this.groupPrenda.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupCalidad.SuspendLayout();
			this.groupPrecio.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkManga
			// 
			this.checkManga.Location = new System.Drawing.Point(132, 19);
			this.checkManga.Name = "checkManga";
			this.checkManga.Size = new System.Drawing.Size(104, 24);
			this.checkManga.TabIndex = 0;
			this.checkManga.Text = "Manga corta";
			this.checkManga.UseVisualStyleBackColor = true;
			this.checkManga.CheckedChanged += new System.EventHandler(this.CheckMangaCheckedChanged);
			// 
			// checkChupin
			// 
			this.checkChupin.Enabled = false;
			this.checkChupin.Location = new System.Drawing.Point(132, 50);
			this.checkChupin.Name = "checkChupin";
			this.checkChupin.Size = new System.Drawing.Size(104, 24);
			this.checkChupin.TabIndex = 1;
			this.checkChupin.Text = "Chupin";
			this.checkChupin.UseVisualStyleBackColor = true;
			this.checkChupin.CheckedChanged += new System.EventHandler(this.CheckChupinCheckedChanged);
			// 
			// checkMao
			// 
			this.checkMao.Location = new System.Drawing.Point(256, 19);
			this.checkMao.Name = "checkMao";
			this.checkMao.Size = new System.Drawing.Size(84, 24);
			this.checkMao.TabIndex = 2;
			this.checkMao.Text = "Cuello Mao";
			this.checkMao.UseVisualStyleBackColor = true;
			this.checkMao.CheckedChanged += new System.EventHandler(this.CheckMaoCheckedChanged);
			// 
			// radioCamisa
			// 
			this.radioCamisa.Checked = true;
			this.radioCamisa.Location = new System.Drawing.Point(6, 19);
			this.radioCamisa.Name = "radioCamisa";
			this.radioCamisa.Size = new System.Drawing.Size(87, 24);
			this.radioCamisa.TabIndex = 3;
			this.radioCamisa.TabStop = true;
			this.radioCamisa.Text = "Camisa";
			this.radioCamisa.UseVisualStyleBackColor = true;
			this.radioCamisa.CheckedChanged += new System.EventHandler(this.RadioCamisaCheckedChanged);
			// 
			// radioPantalon
			// 
			this.radioPantalon.Location = new System.Drawing.Point(6, 49);
			this.radioPantalon.Name = "radioPantalon";
			this.radioPantalon.Size = new System.Drawing.Size(87, 24);
			this.radioPantalon.TabIndex = 4;
			this.radioPantalon.Text = "Pantalón";
			this.radioPantalon.UseVisualStyleBackColor = true;
			this.radioPantalon.CheckedChanged += new System.EventHandler(this.RadioPantalonCheckedChanged);
			// 
			// nombreTienda
			// 
			this.nombreTienda.Location = new System.Drawing.Point(12, 9);
			this.nombreTienda.Name = "nombreTienda";
			this.nombreTienda.Size = new System.Drawing.Size(100, 23);
			this.nombreTienda.TabIndex = 5;
			this.nombreTienda.Text = "Nombre Tienda";
			this.nombreTienda.Click += new System.EventHandler(this.NombreTiendaClick);
			// 
			// direccionTienda
			// 
			this.direccionTienda.Location = new System.Drawing.Point(293, 9);
			this.direccionTienda.Name = "direccionTienda";
			this.direccionTienda.Size = new System.Drawing.Size(100, 23);
			this.direccionTienda.TabIndex = 6;
			this.direccionTienda.Text = "Dirección Tienda";
			// 
			// stock
			// 
			this.stock.Location = new System.Drawing.Point(6, 12);
			this.stock.Name = "stock";
			this.stock.Size = new System.Drawing.Size(358, 17);
			this.stock.TabIndex = 0;
			this.stock.Text = "Unidades de Stock disponibles: __";
			this.stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupPrenda
			// 
			this.groupPrenda.Controls.Add(this.checkMao);
			this.groupPrenda.Controls.Add(this.checkChupin);
			this.groupPrenda.Controls.Add(this.radioCamisa);
			this.groupPrenda.Controls.Add(this.checkManga);
			this.groupPrenda.Controls.Add(this.radioPantalon);
			this.groupPrenda.Location = new System.Drawing.Point(12, 70);
			this.groupPrenda.Name = "groupPrenda";
			this.groupPrenda.Size = new System.Drawing.Size(400, 100);
			this.groupPrenda.TabIndex = 9;
			this.groupPrenda.TabStop = false;
			this.groupPrenda.Text = "Prenda";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.stock);
			this.groupBox1.Location = new System.Drawing.Point(12, 176);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 32);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// groupCalidad
			// 
			this.groupCalidad.Controls.Add(this.radioPremium);
			this.groupCalidad.Controls.Add(this.radioStandard);
			this.groupCalidad.Location = new System.Drawing.Point(12, 214);
			this.groupCalidad.Name = "groupCalidad";
			this.groupCalidad.Size = new System.Drawing.Size(182, 42);
			this.groupCalidad.TabIndex = 11;
			this.groupCalidad.TabStop = false;
			this.groupCalidad.Text = "Calidad de Prenda";
			// 
			// radioPremium
			// 
			this.radioPremium.Location = new System.Drawing.Point(78, 12);
			this.radioPremium.Name = "radioPremium";
			this.radioPremium.Size = new System.Drawing.Size(98, 24);
			this.radioPremium.TabIndex = 1;
			this.radioPremium.Text = "Premium";
			this.radioPremium.UseVisualStyleBackColor = true;
			// 
			// radioStandard
			// 
			this.radioStandard.Checked = true;
			this.radioStandard.Location = new System.Drawing.Point(6, 12);
			this.radioStandard.Name = "radioStandard";
			this.radioStandard.Size = new System.Drawing.Size(104, 24);
			this.radioStandard.TabIndex = 0;
			this.radioStandard.TabStop = true;
			this.radioStandard.Text = "Standard";
			this.radioStandard.UseVisualStyleBackColor = true;
			// 
			// groupPrecio
			// 
			this.groupPrecio.Controls.Add(this.textBoxCantidad);
			this.groupPrecio.Controls.Add(this.label2);
			this.groupPrecio.Controls.Add(this.textBoxPrecio);
			this.groupPrecio.Controls.Add(this.label1);
			this.groupPrecio.Location = new System.Drawing.Point(200, 214);
			this.groupPrecio.Name = "groupPrecio";
			this.groupPrecio.Size = new System.Drawing.Size(212, 42);
			this.groupPrecio.TabIndex = 12;
			this.groupPrecio.TabStop = false;
			this.groupPrecio.Text = "Precio unitario y Cantidad";
			// 
			// textBoxCantidad
			// 
			this.textBoxCantidad.Location = new System.Drawing.Point(153, 15);
			this.textBoxCantidad.Name = "textBoxCantidad";
			this.textBoxCantidad.Size = new System.Drawing.Size(53, 20);
			this.textBoxCantidad.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(93, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cantidad";
			// 
			// textBoxPrecio
			// 
			this.textBoxPrecio.Location = new System.Drawing.Point(22, 15);
			this.textBoxPrecio.Name = "textBoxPrecio";
			this.textBoxPrecio.Size = new System.Drawing.Size(65, 20);
			this.textBoxPrecio.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "$";
			// 
			// buttonCotizar
			// 
			this.buttonCotizar.Location = new System.Drawing.Point(18, 262);
			this.buttonCotizar.Name = "buttonCotizar";
			this.buttonCotizar.Size = new System.Drawing.Size(176, 58);
			this.buttonCotizar.TabIndex = 13;
			this.buttonCotizar.Text = "COTIZAR";
			this.buttonCotizar.UseVisualStyleBackColor = true;
			this.buttonCotizar.Click += new System.EventHandler(this.ButtonCotizarClick);
			// 
			// labelCotizacion
			// 
			this.labelCotizacion.Location = new System.Drawing.Point(206, 285);
			this.labelCotizacion.Name = "labelCotizacion";
			this.labelCotizacion.Size = new System.Drawing.Size(200, 18);
			this.labelCotizacion.TabIndex = 14;
			this.labelCotizacion.Text = "$ _________";
			// 
			// nombreVendedor
			// 
			this.nombreVendedor.Location = new System.Drawing.Point(12, 44);
			this.nombreVendedor.Name = "nombreVendedor";
			this.nombreVendedor.Size = new System.Drawing.Size(148, 23);
			this.nombreVendedor.TabIndex = 15;
			this.nombreVendedor.Text = "Nombre y Apellido Vendedor";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(166, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(10, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "|";
			// 
			// codigoVendedor
			// 
			this.codigoVendedor.Location = new System.Drawing.Point(182, 44);
			this.codigoVendedor.Name = "codigoVendedor";
			this.codigoVendedor.Size = new System.Drawing.Size(92, 16);
			this.codigoVendedor.TabIndex = 17;
			this.codigoVendedor.Text = "CódigoVendedor";
			// 
			// linkHistorial
			// 
			this.linkHistorial.Location = new System.Drawing.Point(293, 44);
			this.linkHistorial.Name = "linkHistorial";
			this.linkHistorial.Size = new System.Drawing.Size(119, 23);
			this.linkHistorial.TabIndex = 18;
			this.linkHistorial.TabStop = true;
			this.linkHistorial.Text = "Historial Cotizaciones";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 327);
			this.Controls.Add(this.linkHistorial);
			this.Controls.Add(this.codigoVendedor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nombreVendedor);
			this.Controls.Add(this.labelCotizacion);
			this.Controls.Add(this.buttonCotizar);
			this.Controls.Add(this.groupPrecio);
			this.Controls.Add(this.groupCalidad);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupPrenda);
			this.Controls.Add(this.direccionTienda);
			this.Controls.Add(this.nombreTienda);
			this.Name = "MainForm";
			this.Text = "Examen";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupPrenda.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupCalidad.ResumeLayout(false);
			this.groupPrecio.ResumeLayout(false);
			this.groupPrecio.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
