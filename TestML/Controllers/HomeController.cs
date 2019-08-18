using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestML.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //String que recibe
            string[] matriz = { "ATECGA", "CAGEGC", "TTATET", "AGACGE", "GCGTCA", "TCCCCC" };

            //declaro las posibles variables 
            var var1 = "";
            var cant1 = 0;
            var var2 = "";
            var var21 = "";
            var cant2 = 0;
            var cant21 = 0;
            var lenght2 = 0;
            var var3 = "";
            var cant3 = 0;

            //contadores necesarios
            var cont1 = 1;
            var cont2 = 0;

            var cont3 = 0;
               
            //cont de la matriz
            var items = 0;

            //total adn
            var adn = 0;
        
            //Recorro var1 HECHO
            foreach (var item in matriz)
            {
                var1 = item;
                //recorro la var1 para ver si el adn es correcto HECHO 
                for (int contVar1 = 0; contVar1 < var1.Length - 1; contVar1++)
                {   
                    if(var1.Substring(contVar1, 1) == var1.Substring((contVar1 + 1), 1))
                    {
                        cant1++;

                        if (cant1 >= 3)
                        {
                            adn++;
                            cant1 = 0;
                        }                        
                    }
                    else
                    {
                        cant1 = 0;
                    }

                }

                //reinicio variables
                var1 = "";
                cant1 = 0;
            }

            //Variables para el var2
            items = matriz.Count();
            var contVar22 = 0;
            var contVar21 = 0;
            var contString = 1;
            var cont22 = 0;

            //Recorro var2 HECHO
            for(int h = 0; h < items; h++)
            {
                contVar22 = cont22;
                //desde columnas
                for (int i = 0; i < items; i++)
                {
                    if(contVar22 < 6)
                    {
                        var2 += matriz[contVar22].Substring(i, 1);
                        contVar22++;
                    }    
                }

                //recorro el resultado para comprar y ver si cumple con el adn
                for (int contVar2 = 0; contVar2 < var2.Length - 1; contVar2++)
                {
                    if (var2.Substring(contVar2, 1) == var2.Substring((contVar2 + 1), 1))
                    {
                        cant2++;

                        if (cant2 >= 3)
                        {
                            adn++;
                            cant2 = 0;
                        }
                    }
                    else
                    {
                        cant2 = 0;
                    }
                }

                //desde filas
                var contFilas = 0;
                for (int i = contString; i < items; i++)
                {
                    if (contVar21 < 6)
                    {
                        var21 += matriz[contFilas].Substring(i, 1);
                        contFilas++;
                    }
                }

                //recorro el resultado para comprar y ver si cumple con el adn
                for (int contVar2 = 0; contVar2 < var21.Length - 1; contVar2++)
                {
                    if (var21.Substring(contVar2, 1) == var21.Substring((contVar2 + 1), 1))
                    {
                        cant21++;

                        if (cant21 >= 3)
                        {
                            adn++;
                            cant21 = 0;
                        }
                    }
                    else
                    {
                        cant21 = 0;
                    }
                }

                //conteo de matriz
                cont22++;
                contString++;

                //reinicio variables
                var2 = "";
                var21 = "";
                cant2 = 0;
                cant21 = 0;

            }

            //SUMA DE DIAGONAL /
            var sumad2 = "";
            for (int j = 0; j < matriz[0].Length; j++)
            {
                for (int i = matriz[0].Length - j - 1; i == matriz[0].Length - j - 1; i++)
                {
                    sumad2 += matriz[j].Substring(j, 1); ;
                }

            }

            //Recorro var3 HECHO 
            for (var c = 0; c <= matriz.Count() - 1; c++)
            {
                foreach (var item3 in matriz)
                {
                    var3 = var3 + item3.Substring(c, 1);
                }

                for (int contVar3 = 0; contVar3 < var3.Length - 1; contVar3++)
                {
                    if (var3.Substring(contVar3, 1) == var3.Substring((contVar3 + 1), 1))
                    {
                        cant3++;

                        if (cant3 >= 3)
                        {
                            adn++;
                            cant3 = 0;
                        }
                    }
                    else
                    {
                        cant3 = 0;
                    }

                }

                //reinicio variables
                var1 = "";
                cant1 = 0;

                var3 = "";
                cant3 = 0;
            }


            //muestro el resultado 
            if(adn > 1)
            {
                ViewBag.resultado = "true";
            }
            else
            {
                ViewBag.resultado = "false";
            }

            return View();
        }
    }
}