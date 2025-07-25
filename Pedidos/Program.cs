
using Pedidos;
using static System.Runtime.InteropServices.JavaScript.JSType;

Producto producto = new Producto();
producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 5000;
producto.Stock = 10;

producto.MostrarInformacion();
producto.DisminuirStock(2);
producto.MostrarInformacion();

producto.DisminuirStock(15);
producto.MostrarInformacion();

Producto producto1 = new Producto();
producto.Id = 2;
producto.Nombre = "Mouse";
producto.Precio = 250;
producto.Stock = 15;

producto.MostrarInformacion();
