using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBilletera.Modelo
{
    public class Billetera
    {
        //propiedades de la clase Billetera
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        //constructor de la clase Billetera
        public Billetera()
        {
            Console.WriteLine("Se a creado una Billetera, vamos a llenarla: ");
        }

        //constructor que usa parametros
        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100, int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            BilletesDe10 = billetesDe10;
            BilletesDe20 = billetesDe20;
            BilletesDe50 = billetesDe50;
            BilletesDe100 = billetesDe100;
            BilletesDe200 = billetesDe200;
            BilletesDe500 = billetesDe500;
            BilletesDe1000 = billetesDe1000;
        }

        //metodo para llenar la billetera creada (no devuelve nada, por eso el VOID)
        public void LlenarBilletera()
        {
            Console.Write("Ingrese cuantos Billetes de $10 tiene: ");
            BilletesDe10 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cuantos Billetes de $20 tiene: ");
            BilletesDe20 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cuantos Billetes de $50 tiene: ");
            BilletesDe50 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cuantos Billetes de $100 tiene: ");
            BilletesDe100 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cuantos Billetes de $200 tiene: ");
            BilletesDe200 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cuantos Billetes de $500 tiene: ");
            BilletesDe500 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cuantos Billetes de $1000 tiene: ");
            BilletesDe1000 = int.Parse(Console.ReadLine());
        }

        //metodo TOTAL (El tipo del metodo es un "decimal", porq devuelve un DECIMAL)
        public decimal Total() 
        {
            decimal suma = 0;
            suma = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;
            return suma;
        }

        //metodo COMBINAR (El tipo del metodo es "Billetera" porq tiene que devolver una billetera)
        public Billetera Combinar(Billetera segundaBilletera)
        {
            int SumaDe10 = BilletesDe10 + segundaBilletera.BilletesDe10;
            int SumaDe20 = BilletesDe20 + segundaBilletera.BilletesDe20;
            int SumaDe50 = BilletesDe50 + segundaBilletera.BilletesDe50;
            int SumaDe100 = BilletesDe100 + segundaBilletera.BilletesDe100;
            int SumaDe200 = BilletesDe200 + segundaBilletera.BilletesDe200;
            int SumaDe500 = BilletesDe500 + segundaBilletera.BilletesDe500;
            int SumaDe1000 = BilletesDe1000 + segundaBilletera.BilletesDe1000;

            //uso el constructor que usa parametros para crear la 3er billetera y pasar los billetes de las 2 billeteras
            var nuevaBilletera = new Billetera(SumaDe10, SumaDe20, SumaDe50, SumaDe100, SumaDe200, SumaDe500, SumaDe1000);
            return nuevaBilletera;
        }

        //metodo que vacia Billeteras
        public void VaciarBilletera() 
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }
    }
}
