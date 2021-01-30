
using System;

namespace Examen
{
	/// <summary>
	/// Description of Pantalones.
	/// </summary>
	public class Pantalones : Prenda
	{
		public enum Tipo {Comun, Chupin}
		public Tipo tipo{
			get;
			set;
		}
		public Pantalones(Calidad calidad, double Precio, int Stock, Tipo tipo) :base(calidad, Precio, Stock)
		{
			this.tipo = tipo;
		}
		public Pantalones(int Stock, Tipo tipo) : base(Stock){
			this.tipo = tipo;
		}
	}
}
