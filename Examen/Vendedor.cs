
using System;
using System.Collections.Generic;
namespace Examen
{
	
	public class Vendedor
	{
		public String Apellido{
			get;
			set;
		}
		public String CodigoVendedor{
			get;
			set;
		}
		
		public String Nombre {
			get;
			set;
		}
		private List<Cotizacion> listaCotizaciones = new List<Cotizacion>();
		public Vendedor( String Nombre, String Apellido, String CodigoVendedor)
		{
			this.Nombre = Nombre;
			this.Apellido = Apellido;
			this.CodigoVendedor = CodigoVendedor;
		}
	}
}
