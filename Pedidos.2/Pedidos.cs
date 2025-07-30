
using Pedidos;
using Pedidos.Herencia;

Producto producto = new Producto();
producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 5000;
producto.Stock = 10;

producto.MostrarInformacion();

Producto producto1 = new Producto(); 
producto1.Id = 2;
producto1.Nombre = "Mouse";
producto1.Precio = 250;
producto1.Stock = 15;

producto1.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(producto, 1);
pedido.AgregarItem(producto1, 5);
pedido.MostrarDetalles();

producto.MostrarInformacion();
producto1.MostrarInformacion();

Electronico electronico = new Electronico();
electronico.Id = 1;
electronico.Nombre = "Iphone 17 Pro Max";
electronico.Precio = 1000;
electronico.Stock = 200;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
electronico.MostrarInformacion();

Libro libro = new Libro();
libro.Id = 1;
libro.Nombre = "Veil";
libro.Precio = 850;
libro.Stock = 10;
libro.Isbn = "978-3-16-148410-0";
libro.Autor = "Koteri";
libro.numeroPaginas = 300;
libro.MostrarInformacion();