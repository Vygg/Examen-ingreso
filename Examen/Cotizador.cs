
using System;

namespace Examen
{
	/// <summary>
	/// Description of Cotizador.
	/// </summary>
	public static class Cotizador
	{
		public static Cotizacion Cotizar(Prenda prenda, int cantidadUnidades, double precioBase, Vendedor vendedor){
			double result = precioBase;
			double multi = 1;
			if (cantidadUnidades > prenda.Stock)
				throw new SobrepasaStockException("Se sobrepasa el stock disponible.");
			if (prenda.calidad == Prenda.Calidad.Premium)
				result = result * 1.3;
			
			if (prenda.GetType().Name == "Camisas"){
				multi = CotizarCamisas((Camisas)prenda);
			}
			if (prenda.GetType().Name == "Pantalones"){
				multi = CotizarPantalones((Pantalones)prenda);
			}
			
			result = result * multi * cantidadUnidades;
			Cotizacion cot = new Cotizacion(cantidadUnidades, result, vendedor, prenda);
			return cot;
		}
		private static double CotizarCamisas(Camisas prenda){
			double mult = 1;
			if (prenda.manga == Camisas.Manga.Corta)
				mult = mult * 0.9;
			if (prenda.esMao)
				mult = mult * 1.03;
			
			return mult;
		}
		private static double CotizarPantalones(Pantalones prenda){
			double mult = 1;
			if (prenda.tipo == Pantalones.Tipo.Chupin)
				mult = mult * 0.88;
			
			return mult;
		}
	}
}
