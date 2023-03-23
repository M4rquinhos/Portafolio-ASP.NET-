using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "Ecommerce con ASP.NET",
                Link = "https://amazon.com.mx",
                ImagenURL = "/imagenes/amazon.png"
            },
            new Proyecto
            {
                Titulo = "New York times",
                Descripcion = "Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/imagenes/nyt.png"
            },
            new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "/imagenes/reddit.png"
            },
            new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda el linea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "/imagenes/reddit.png"
            }
            };
        }
    }
}
