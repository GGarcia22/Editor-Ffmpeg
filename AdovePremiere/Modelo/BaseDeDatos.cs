using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdovePremiere
{
    public class BaseDeDatos
    {
        public List<Usuario> usuariosRegistrados = new List<Usuario>();

      
        public void guardarRegistro(String user, String pass)
        {
            usuariosRegistrados.Add(new Usuario(user, pass));
        }

        public Usuario buscarUsuario(String user, String pass)
        {
            Usuario usuEncontrado = null;
            foreach (var usuario in this.usuariosRegistrados)
            {
                if (usuario.getUsuario().Equals(user) && usuario.getPass().Equals(pass))
                {
                    usuEncontrado = usuario;
                }
            }
            return usuEncontrado;
        }

        public bool api(String username, String password)
        {
            var client = new RestClient("https://localhost:44340");
            var request = new RestRequest("/api/check", Method.POST);
            request.AddJsonBody(new { username = username, password = password });

            var response = client.Execute(request);
            var obj = JObject.Parse(response.Content);

            return (bool)obj["valid"];
        }
    }
}
