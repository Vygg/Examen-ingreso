
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examen
{
	/// <summary>
	/// Description of Historial.
	/// </summary>
	public partial class Historial : Form
	{
		Vendedor miVendedor;
		public Historial(Vendedor miVendedor)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.miVendedor = miVendedor;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void HistorialLoad(object sender, EventArgs e)
		{
			
			foreach(Cotizacion cot in miVendedor.listaCotizaciones){
				boxHist.AppendText("ID: " +cot.NumeroID);
				boxHist.AppendText(Environment.NewLine);
				boxHist.AppendText("Cantidad de Unidades: " + cot.CantidadUnidades);
				boxHist.AppendText(Environment.NewLine);
				boxHist.AppendText("Precio total: " + cot.Resultado);
				boxHist.AppendText(Environment.NewLine);				
				boxHist.AppendText("Fecha: " + cot.Fecha);
				boxHist.AppendText(Environment.NewLine);


				boxHist.AppendText("-----------------------------------");
				boxHist.AppendText(Environment.NewLine);
			}
			;
		}
		
	}
}
