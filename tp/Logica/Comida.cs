using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class Comida
    {
        Archivo archivos = new Archivo(); 
        Administrador_recetas admin_recetas = new Administrador_recetas();
        public List<Receta> Comidas_ok()
        {
            bool encontrado = true;
            List<Producto> despensa = new List<Producto>();
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidasok = new List<Receta>();
            comidas = admin_recetas.obtener_recetas();
            despensa = archivos.Buscar();
            foreach (Receta receta in comidas)
            {
                foreach (Producto ingrediente in receta.ingredientes)
                {
                    foreach (Producto producto in despensa)
                    {
                        if (producto.Nombre == ingrediente.Nombre)
                        {
                            if (producto is Bebida)
                            {
                                Bebida bebida_selec = (Bebida)producto;
                                if (bebida_selec.cantidad<bebida_selec.CantMinima)
                                {
                                    encontrado=false;
                                    break;
                                }
                            }
                            else if (producto is Cantidad)
                            {
                                Cantidad cantidad_selec = (Cantidad)producto;
                                if (cantidad_selec.cantidad < cantidad_selec.CantMinima)
                                {
                                    encontrado = false;
                                    break;
                                }
                            }
                            else if (producto is Kilo_litro)
                            {
                                Kilo_litro kilolitro_selec = (Kilo_litro)producto;
                                if (kilolitro_selec.CantKilos < kilolitro_selec.CantMinima)
                                {
                                    encontrado = false;
                                    break;
                                }
                            }
                        }

                    }
                    if (encontrado == false)
                    {
                        break;
                    }
                }
                if (encontrado == true)
                {
                    comidasok.Add(receta);
                }
                else
                {
                    encontrado = true;
                }
            }
            return comidas;
        }

        public void comida_preparada(string nombre)
        {
            List<Receta> historial_comidas = new List<Receta>();
            Receta comida_preparar = new Receta();
            List<Receta> comidas = new List<Receta>();
            comidas = Comidas_ok();
            List<Producto> despensa = new List<Producto>();
            despensa = archivos.Buscar();
            foreach (Receta comida in comidas)
            {
                if (nombre == comida.nombre)
                {
                    comida_preparar = comida;
                    break;
                }
            }
            historial_comidas.Add(comida_preparar);
            // metodo de guardar historial
            foreach (Producto ingrediente in comida_preparar.ingredientes)
            {
                foreach (Producto producto in despensa)
                {
                    if (ingrediente.id == producto.id)
                    {
                        if (producto is Bebida)
                        {
                            Bebida bebida_selec = (Bebida)producto;
                            bebida_selec.cantidad = bebida_selec.CantMinima;
                            break;
                        }
                        else if (producto is Cantidad)
                        {
                            Cantidad cantidad_selec = (Cantidad)producto;
                            cantidad_selec.cantidad = cantidad_selec.CantMinima;
                            break;
                        }
                        else if (producto is Kilo_litro)
                        {
                            Kilo_litro kilolitro_selec = (Kilo_litro)producto;
                            kilolitro_selec.CantKilos = kilolitro_selec.CantMinima;
                            break;
                        }
                    }
                }
            }
            archivos.Cargar(despensa);
        }
    }
}
