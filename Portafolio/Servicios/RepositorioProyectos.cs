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
                    Titulo="Amazon",
                    Descripcion="E-Comerce realizado en ASP.NET Core",
                    link="https://amazon.com",
                    ImagenURL="/imagenes/amazon.png"

                },
                 new Proyecto
                {
                    Titulo="New York Times",
                    Descripcion="Página de noticias en React",
                    link="https://nytimes.com",
                    ImagenURL="/imagenes/nyt.png"

                },
                 new Proyecto
                {
                    Titulo="Reddit",
                    Descripcion="Red social para compartir en comunidades",
                    link="https://reddit.com",
                    ImagenURL="/imagenes/reddit.png"

                },
                 new Proyecto
                {
                    Titulo="Stam",
                    Descripcion="Tienda en Línea para comprar videojuegos",
                    link="https://store.steampowered.com",
                    ImagenURL="/imagenes/steam.png"

                }
            };
        }


    }
}
