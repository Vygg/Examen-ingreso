
using System;

namespace Examen
{

	public abstract class Prenda
	{
		public enum Calidad {Standard, Premium}
		public Calidad? calidad{
			get;
			set;
		}
		public double? Precio{
			get;
			set;
		}
		public int Stock{
			get;
			set;
		}
		protected Prenda(Calidad calidad, double Precio, int Stock)
		{
			this.calidad = calidad;
			this.Precio = Precio;
			this.Stock = Stock;
		}
		protected Prenda(int Stock){
			this.Stock = Stock;
		}
	}
}
