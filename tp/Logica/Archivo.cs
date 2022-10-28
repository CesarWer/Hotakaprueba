using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Logica
{
    public class Archivo
    {
        #region Serializar
        public void Cargar(List<Producto> carga)
        {
            List<string> direcciones = new List<string>()
            {
                @"C:\Users\USER\Desktop\Jsons\Bebidas.json",
                @"C:\Users\USER\Desktop\Jsons\Cantidad.json",
                @"C:\Users\USER\Desktop\Jsons\Kilo_litro.json"
            };
            List<Producto> cargadivididaB = new List<Producto>();
            List<Producto> cargadivididac = new List<Producto>();
            List<Producto> cargadivididak = new List<Producto>();
            foreach (Producto p in carga)
            {
                if (p is Bebida)
                    cargadivididaB.Add(p);
                else if (p is Cantidad)
                    cargadivididac.Add(p);
                else if (p is Kilo_litro)
                    cargadivididak.Add(p);
            }
            string bebida = JsonConvert.SerializeObject(cargadivididaB, Formatting.Indented);
            File.WriteAllText(direcciones[0], bebida);
            string cantidad = JsonConvert.SerializeObject(cargadivididac, Formatting.Indented);
            File.WriteAllText(direcciones[1], cantidad);
            string kilo_litro = JsonConvert.SerializeObject(cargadivididak, Formatting.Indented);
            File.WriteAllText(direcciones[2], kilo_litro);
        }
        #endregion


        #region Deserializar Despensa
        public List<Producto> Buscar()
        {
            List<Producto> listaProducto = new List<Producto>();
            for (int i = 0; i < 3; i++)
                listaProducto.AddRange(ConseguirLista(i));
            return listaProducto;
        }
        //PARA DESERIALIZAR
        public static dynamic ConseguirLista(int i)
        {
            List<string> direcciones = new List<string>()
            {
                @"C:\Users\USER\Desktop\Jsons\Bebidas.json",
                @"C:\Users\USER\Desktop\Jsons\Cantidad.json",
                @"C:\Users\USER\Desktop\Jsons\Kilo_litro.json"
            };
            StreamReader r = new StreamReader(direcciones[i]);
            string jsonString = r.ReadToEnd();
            switch (i)
            {
                case 0: var lista = JsonConvert.DeserializeObject<List<Bebida>>(jsonString); return lista;
                case 1: var listac = JsonConvert.DeserializeObject<List<Cantidad>>(jsonString); return listac;
                case 2: var listak = JsonConvert.DeserializeObject<List<Kilo_litro>>(jsonString); return listak;
                default: lista = null; return lista;
            }
        }
        #endregion


        public List<Receta_archivos> leer_recetas_archivos()
        {
            List<Receta_archivos> archivos_recetas = new List<Receta_archivos>();
            StreamReader r = new StreamReader(@"Direccion");
            string jsonString = r.ReadToEnd();
            var recetas = JsonConvert.DeserializeObject<List<Receta_archivos>>(jsonString);
            return recetas;
        }

        public void guardar_recetas_archivos()
        {
            List<Receta_archivos> archivos_recetas = new List<Receta_archivos>();
            string R = JsonConvert.SerializeObject(archivos_recetas, Formatting.Indented);
            File.WriteAllText(@"Direccion", R);
        }

        //List<b> LB = LP.where(x is bebidas). select(x as bebidas).tolist
        //a los ingredientes en las recetas son guardados como codigos, y las recetas tambien son codigos
        /*obtener REcetas(parametros) ADmin recetas
         1) leer
         2) filtrar
         3) foreach c recetas para buscar por los filrtos
         */
        // [Json ignore] hace que ignore el json
        // Public list<ing>
    }
}
