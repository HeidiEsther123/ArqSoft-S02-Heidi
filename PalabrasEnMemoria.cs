using System;
using System.Collections.Generic;

namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly List<string> _palabras;

        public PalabrasEnMemoria(string categoria)
        {
            _palabras = categoria.ToLower() switch
            {
                "arquitectura" => new List<string>
                {
                    "arquitectura", "componente", "descomposición",
                    "dependencia", "acoplamiento"
                },
                "poo" => new List<string>
                {
                    "polimorfismo", "encapsulamiento", "herencia",
                    "abstracción", "clase"
                },
                ".net" => new List<string>
                {
                    "ensamblado", "namespace", "interfaz",
                    "delegado", "middleware"
                },
                _ => new List<string> { "default" }
            };
        }

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            return _palabras[random.Next(_palabras.Count)];
        }
    }
}


