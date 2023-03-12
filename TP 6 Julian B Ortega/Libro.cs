using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_6_Julian_B_Ortega
{
    class Libro
    {
        private string _nombre;
        private string _autor;
        private string _genero;
        private int _paginas;
        private bool _importado;
        private float _precio;

        public Libro(string nombre, string autor, string genero, int paginas, bool importado, float precio)
        {
            _nombre = nombre;
            _autor = autor;
            _genero = genero;
            _paginas = paginas;
            _importado = importado;
            _precio = precio;
        }

        public string GetNombre() => _nombre;
        public string GetAutor() => _autor;
        public string GetGenero() => _genero;
        public int GetPaginas() => _paginas;
        public bool GetImportado() => _importado;
        public float GetPrecio() => _precio;

        public string ObtenerComoString() 
        {
            string resultado = _nombre + " - " + _autor + " - " + _genero + " - " + _paginas;
            if (_importado) resultado += " - Importado"; else resultado += " - Nacional";
            resultado += " - $" + _precio;

            return resultado;
        }
    }
}
