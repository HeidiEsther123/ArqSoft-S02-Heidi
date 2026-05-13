using System;
using System.Collections.Generic;
using System.Linq;

namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly List<string> _palabras;
        public static readonly Dictionary<string, List<string>> CategoriasMap =
            new(StringComparer.OrdinalIgnoreCase)
            {
                ["arquitectura"] = new List<string>
                {
                    "arquitectura", "componente", "descomposición",
                    "dependencia", "acoplamiento"
                },
                ["poo"] = new List<string>
                {
                    "polimorfismo", "encapsulamiento", "herencia",
                    "abstracción", "clase"
                },
                [".net"] = new List<string>
                {
                    "ensamblado", "namespace", "interfaz",
                    "delegado", "middleware"
                },
                ["default"] = new List<string> { "default" }
            };

        public PalabrasEnMemoria()
        {
            _palabras = new List<string>(CategoriasMap["default"]);
        }

        public PalabrasEnMemoria(string categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria) || !CategoriasMap.ContainsKey(categoria))
                _palabras = new List<string>(CategoriasMap["default"]);
            else
                _palabras = new List<string>(CategoriasMap[categoria]);
        }

        public IEnumerable<string> ObtenerCategorias()
        {
            return CategoriasMap.Keys.Where(k => !string.Equals(k, "default", StringComparison.OrdinalIgnoreCase));
        }

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            return _palabras[random.Next(_palabras.Count)];
        }
    }
}