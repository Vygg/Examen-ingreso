/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 30/01/2021
 * Time: 08:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Examen
{
	
	public class Cotizacion
	{
		public static int IDcount = 1;
		public int NumeroID{
			get;
			private set;
		}
		public DateTime Fecha{
			get;
			private set;
		}
		public int CantidadUnidades{
			get;
			set;
		}
		public double Resultado{
			get;
			private set;
		}
		public Vendedor vendedor{
			get;
			private set;
		}
		public Prenda prendaCotizada{
			get;
			set;
		}
		public Cotizacion()
		{
			this.Fecha = DateTime.Now;
		}
		public Cotizacion(int CantidadUnidades, double Resultado, Vendedor vendedor, Prenda prendaCotizada){
			this.NumeroID = NumeroID;
			this.CantidadUnidades = CantidadUnidades;
			this.Resultado = Resultado;
			this.vendedor = vendedor;
			this.prendaCotizada = prendaCotizada;
			
			this.Fecha = DateTime.Now;
			this.NumeroID = IDcount;
			IDcount++;
		}
	}
}
