using System;
using System.Collections.Generic;


Pizza miPizza = new Pizza();

miPizza.Nombre = "Vegetariana";
miPizza.Ingredientes = new List<string>
{
	"Ají",
	"Cebolla",
	"Tomate",
	"Champiñón"
};

miPizza.Tamaño = "Mediano";
miPizza.PrecioVenta = 725;
miPizza.CostoProduccion = 450;
miPizza.TiempoProduccion = 7;

Console.WriteLine("=== INFORMACIÓN DE LA PIZZA ===");
Console.WriteLine("Nombre: " + miPizza.Nombre);
Console.WriteLine("Ingredientes: " + string.Join(", ", miPizza.Ingredientes));
Console.WriteLine("Tamaño: " + miPizza.Tamaño);
Console.WriteLine("Precio de venta: RD$" + miPizza.PrecioVenta);
Console.WriteLine("Costo de producción: RD$" + miPizza.CostoProduccion);
Console.WriteLine("Tiempo de producción: " + miPizza.TiempoProduccion + " minutos");

Console.WriteLine("Ganancia neta: RD$" + miPizza.CalcularGanancia());

Console.WriteLine("¿Contiene Ají?: " + (miPizza.ContieneIngrediente("Ají") ? "Verdadero" : "Falso"));

