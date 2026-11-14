using System;
using System.Collections.Generic;

public class Pizza
{

	public string Nombre { get; set; }
	public List<string> Ingredientes { get; set; } = new List<string>();
	public string Tamaño { get; set; }
	public decimal PrecioVenta { get; set; }
	public decimal CostoProduccion { get; set; }
	public int TiempoProduccion { get; set; }

	public decimal CalcularGanancia()

	{
		return PrecioVenta - CostoProduccion;
	}

	public bool ContieneIngrediente(string ingrediente)
	{
		return Ingredientes.Contains(ingrediente);
	}



}