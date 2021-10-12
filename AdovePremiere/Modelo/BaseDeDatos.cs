using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdovePremiere
{
    public class BaseDeDatos
    {
        private Dictionary<String, Usuario> bbdd;

        public BaseDeDatos()
        {
            this.bbdd = new Dictionary<string, Usuario>();
            cargarRegistros();
        }

        public void guardarRegistro(String user, String pass)
        {
            this.bbdd.Add(user, new Usuario(user, pass));
        }

        public Usuario buscarUsuario(String user, String pass)
        {
            Usuario usuEncontrado = null;
            foreach (var usuario in this.bbdd)
            {
                if (usuario.Value.getUsuario().Equals(user) && usuario.Value.getPass().Equals(pass))
                {
                    usuEncontrado = usuario.Value;
                }
            }
            return usuEncontrado;
        }

        public void cargarRegistros()
        {
            guardarRegistro("german", "12345");
        }
    }
}
