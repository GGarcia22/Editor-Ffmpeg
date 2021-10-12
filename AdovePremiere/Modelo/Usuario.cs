using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdovePremiere
{
   public class Usuario
    {
        private String nombreUsuario;
        private String contraseña;

        public Usuario(string nombreUsuario, string contraseña)
        {
            //setUser(nombreUsuario);
            //setPass(contraseña);
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }

        public void setUser(String user)
        {
            if (string.IsNullOrEmpty(user))
            {
                throw new Exception("El usuario es nulo o esta vacio");
            }
        }

        public void setPass(String pass)
        {
            if (string.IsNullOrEmpty(pass))
            {
                throw new Exception("La contraseña es nula o esta vacia");
            }
        }

        public String getUsuario()
        {
            return this.nombreUsuario;
        }

        public String getPass()
        {
            return this.contraseña;
        }
    }
}
