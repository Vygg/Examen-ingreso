/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 30/01/2021
 * Time: 08:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Examen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Tienda miTienda;
		private Vendedor miVendedor;
		private Prenda prendaSeleccionada;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			miTienda = new Tienda("Vendemos Ropa", "Calle Falsa 123");
			miVendedor = new Vendedor("Pepe", "Argento", "ABC123");
			nombreTienda.Text = miTienda.Nombre;
			direccionTienda.Text = miTienda.Direccion;
			codigoVendedor.Text = miVendedor.CodigoVendedor;
			nombreVendedor.Text = miVendedor.Nombre + " " + miVendedor.Apellido;
			
			
			//Carga de prendas
			miTienda.ListaPrendas.Add(new Camisas(true, Camisas.Manga.Corta, 200));
			miTienda.ListaPrendas.Add(new Camisas(false, Camisas.Manga.Corta, 300));
			miTienda.ListaPrendas.Add(new Camisas(true, Camisas.Manga.Larga, 150));
			miTienda.ListaPrendas.Add(new Camisas(false, Camisas.Manga.Larga, 350));
			
			miTienda.ListaPrendas.Add(new Pantalones(1500, Pantalones.Tipo.Chupin));
			miTienda.ListaPrendas.Add(new Pantalones(500, Pantalones.Tipo.Comun));
			
			ActualizarLabelStock();
			                          
		}
		void ActualizarLabelStock(){
			int stockActual;
			Prenda p = null;
			if(radioCamisa.Checked)
				p = new Camisas(checkMao.Checked, checkManga.Checked ? Camisas.Manga.Corta : Camisas.Manga.Larga, 0);
			if(radioPantalon.Checked)
				p = new Pantalones(0, checkChupin.Checked ? Pantalones.Tipo.Chupin : Pantalones.Tipo.Comun);
			p = miTienda.BuscarPrenda(p);
			stockActual = p.Stock;
			prendaSeleccionada = p;
			stock.Text = "Unidades de stock disponibles: "+ stockActual;
		}
		void RadioCamisaCheckedChanged(object sender, EventArgs e)
		{

			checkChupin.Checked = false;
			checkChupin.Enabled = false;
			
			checkManga.Enabled = true;
			checkMao.Enabled = true;
			ActualizarLabelStock();
		}
		void RadioPantalonCheckedChanged(object sender, EventArgs e)
		{


			checkManga.Checked = false;
			checkManga.Enabled = false;
			checkMao.Checked = false;
			checkMao.Enabled = false;
			
			checkChupin.Enabled = true;
			ActualizarLabelStock();

		}
		void CheckMangaCheckedChanged(object sender, EventArgs e)
		{
			ActualizarLabelStock();
		}
		void CheckMaoCheckedChanged(object sender, EventArgs e)
		{
			ActualizarLabelStock();
		}
		void CheckChupinCheckedChanged(object sender, EventArgs e)
		{
			ActualizarLabelStock();
		}
		void ButtonCotizarClick(object sender, EventArgs e)
		{
			try{
				if(radioStandard.Checked)
					prendaSeleccionada.calidad = Prenda.Calidad.Standard;
				if(radioPremium.Checked)
					prendaSeleccionada.calidad = Prenda.Calidad.Premium;
				Cotizacion cot = miVendedor.Cotizar(prendaSeleccionada, int.Parse(textBoxCantidad.Text), double.Parse(textBoxPrecio.Text));
				labelCotizacion.Text = "$ "+ cot.Resultado.ToString();
			}
			catch(FormatException){
				MessageBox.Show("Por favor, ingrese un valor entero para la Cantidad y un valor entero o decimal para el Precio","Error de formato",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(SobrepasaStockException exc){
				MessageBox.Show(exc.Message, "Error de Stock",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}
		
		void LabelHistorialClick(object sender, EventArgs e)
		{
			
		}
		void NombreTiendaClick(object sender, EventArgs e)
		{
	
		}
		void LinkHistorialLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Historial nuevoHist = new Historial(miVendedor);
			nuevoHist.Show();
		}
		
	}
}
