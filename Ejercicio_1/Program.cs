using Ejercicio_1;

UsuarioStreaming usuario1;
usuario1 = new UsuarioStreaming();

usuario1.nombre = "Juan";
usuario1.apellido = "Perez";
usuario1.email = "juan.perez@gmail.com";
usuario1.fechaSuscripcion = DateTime.Now.AddDays(-1);

UsuarioStreaming usuario2;
usuario2 = new UsuarioStreaming();

usuario2.nombre = "Juliana";
usuario2.apellido = "Labrovich";
usuario2.email = "j.labrovich@gmail.com";
usuario2.fechaSuscripcion = DateTime.Now.AddDays(-5);

DateTime fecha = new DateTime(2024, 6, 1);

usuario1.mostrarInformacion();
usuario2.mostrarInformacion();

/*usuario1.nombre = "Juan";
  usuario1.SetNombre("Juan");
  usuario1.fechaSuscripcion = DateTime.Now;
  usuario1.SetFechaSuscripcion(DateTime.Now);*/

// Ejercicio 3
if (usuario1.Equals(usuario2))
    Console.WriteLine("Los usuarios son iguales");
else
    Console.WriteLine("Los usuarios son distintos");

Console.WriteLine();

MonederoDigital m = new MonederoDigital();
m.Saldo = 1000000;

Console.WriteLine("El saldo es: " + m.Saldo);

Guerrero guerrero = new Guerrero("Guerrero 1", 10, "Espada", 100);
guerrero.Arma = "Espada";
guerrero.Fuerza = 100;
guerrero.Nombre = "Guerrero 1";
guerrero.Nivel = 10;

Console.WriteLine("Guerrero: " + guerrero.MostrarInformación());

Enemigo enemigo = new Enemigo("Enemigo 1", 5);

Console.WriteLine("Enemigo: " + enemigo.MostrarInformación());

// ejercicio 8
