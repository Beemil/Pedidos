
using Pedidos;
using static System.Runtime.InteropServices.JavaScript.JSType;

Producto producto = new Producto();
producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 5000;
producto.Stock = 10;

producto.MostrarInformacion();


Producto producto1 = new Producto();
producto.Id = 2;
producto.Nombre = "Mouse";
producto.Precio = 250;
producto.Stock = 15;

producto.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(producto, 1);
pedido.AgregarItem(producto1, 5);
pedido.MostrarDetalles();

producto.MostrarInformacion();
producto1.MostrarInformacion();
