/* Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total 
en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que 
devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  

Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras 
deberan quedar en cero. (Sin billetes)
*/

using EjercicioBilletera.Modelo;

var Billetera1 = new Billetera(); //creamos la primer billetera y la llenamos
Billetera1.LlenarBilletera();

Console.WriteLine();
Console.WriteLine("En su Billetera usted tiene $" + Billetera1.Total());
Console.WriteLine();

var Billetera2 = new Billetera(); //creamos la segunda billetera y la llenamos
Billetera2.LlenarBilletera();

Console.WriteLine();
Console.WriteLine("En su segunda Billetera usted tiene $" + Billetera2.Total());
Console.WriteLine();

//usando la Billetera1 llamo al metodo combinar y le paso la Billetera2 (como devuelve otra billetera, la guardo en Billetera3)
Billetera Billetera3 = Billetera1.Combinar(Billetera2);

Console.WriteLine("*** Todo el dinero de sus 2 Billeteras se junto en una Tercer Billetera que ahora tiene $" + Billetera3.Total() + " ***");
Console.WriteLine();

//vacio las billeteras
Billetera1.VaciarBilletera();
Billetera2.VaciarBilletera();

Console.WriteLine($"*** En la Billetera1 hay $ {Billetera1.Total()}, en la Billetera2 hay $ {Billetera2.Total()} ***");