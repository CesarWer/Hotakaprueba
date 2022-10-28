using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Administrador_recetas
    {
        Archivo Archivos2 = new Archivo();
        public List<Receta> obtener_recetas()
        {
            List<Producto> ingredientes = new List<Producto>();
            List<Receta> recetas = new List<Receta>();
            List<Receta_archivos> recetas_archivos = new List<Receta_archivos>();
            recetas_archivos = Archivos2.leer_recetas_archivos();
            foreach (Receta_archivos receta_a in recetas_archivos)
            {
                Receta receta = new Receta();
                receta.nombre = receta_a.nombre;
                receta.tipo_receta = receta_a.tipo_receta;
                foreach  (int codigo in receta_a.codigos)
                {
                    foreach (Producto ingrediente in ingredientes)
                    {
                        if (ingrediente.id == codigo)
                        {
                            receta.ingredientes.Add(ingrediente);
                            break;
                        }
                    }   
                }
            }
            return recetas;
        }
        
        public List<Receta_archivos> guardar_receta(List<Receta> recetas)
        {
            List<Receta_archivos> recetas_codigos = new List<Receta_archivos>();
            foreach (Receta receta in recetas)
            {
                Receta_archivos nueva_receta_archivos = new Receta_archivos();
                nueva_receta_archivos.nombre = receta.nombre;
                nueva_receta_archivos.tipo_receta = receta.tipo_receta;
                foreach (Producto ingrediente in receta.ingredientes)
                {
                    int codigo = ingrediente.id;
                    nueva_receta_archivos.codigos.Add(codigo);
                }
                recetas_codigos.Add(nueva_receta_archivos);
            }
            return recetas_codigos;
        }
    }
}
