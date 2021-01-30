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
		public int NumeroID{
			get;
		}
		public DateTime Fecha{
			get;
		}
		public int CantidadUnidades{
			get;
			set;
		}
		public double Resultado{
			get;
			private set;
		}
		public Cotizacion()
		{
		}
	}
}
