
using System;
using System.Collections.Generic;

namespace Examen
{
	/// <summary>
	/// Description of Tienda.
	/// </summary>
	public class Tienda
	{
		public String Nombre{
			get;
			set;
		}
		public String Direccion{
			get;
			set;
		}
		public List<Prenda> ListaPrendas{
			get;
			private set;
		}
		public Tienda(String Nombre, String Direccion)
		{
			this.Nombre = Nombre;
			this.Direccion = Direccion;
			this.ListaPrendas = new List<Prenda>();
		}
		public Prenda BuscarPrenda(Prenda prendaABuscar){
			if (prendaABuscar.GetType().Name == "Pantalones"){
				Pantalones pantalonABuscar = (Pantalones)prendaABuscar;
				foreach(Prenda p in ListaPrendas){
					if(p.GetType().Name == "Pantalones"){
						Pantalones c;
						c = (Pantalones) p;
						if(c.tipo == pantalonABuscar.tipo)
							return c;
					}
				}
			}
			else if(prendaABuscar.GetType().Name == "Camisas"){
				Camisas camisaABuscar = (Camisas)prendaABuscar;
				foreach(Prenda p in ListaPrendas){
					if(p.GetType().Name == "Camisas"){
						Camisas c;
						c = (Camisas) p;
						if(c.manga == camisaABuscar.manga && c.esMao == camisaABuscar.esMao)
							return c;
						
					}
				}
				
			}
			return prendaABuscar;
			
			
		}
	}
}
