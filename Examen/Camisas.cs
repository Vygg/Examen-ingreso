
using System;

namespace Examen
{
	/// <summary>
	/// Description of Camisas.
	/// </summary>
	public class Camisas : Prenda
	{
		public enum Manga{Corta, Larga}
		public Manga manga{
			get;
			set;
		}
		public bool esMao{
			get;
			set;
		}
		public Camisas(Calidad calidad, double Precio, int Stock, Manga manga, bool esMao) :base(calidad, Precio, Stock)
		{
			this.manga = manga;
			this.esMao = esMao;

		}
		public Camisas(bool esMao, Manga manga, int Stock) : base(Stock){
			this.esMao = esMao;
			this.manga = manga;
		}
	}
}
