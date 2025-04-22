using _02_Portafolio.Models;

namespace _02_Portafolio.Servicios
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            //List<Proyecto> listadoProyectos = new List<Proyecto>();

            //listadoProyectos.Add(new Proyecto
            //{
            //    Titulo = "Amazon",
            //    Descripcion = "E-Commerce reaizado en ASP.NET Core",
            //    Link = "https://amazom.com",
            //    ImagenURL = ""
            //});

            //listadoProyectos.Add(new Proyecto
            //{
            //    Titulo = "New York Times",
            //    Descripcion = "Página de noticias en React",
            //    Link = "https://nytimes.com",
            //    ImagenURL = ""
            //});

            List<Proyecto> listadoProyectos = new List<Proyecto> {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce reaizado en ASP.NET Core",
                    Link = "https://amazom.com",
                    ImagenURL = "/imagenes/amazon.png"
                },
                new Proyecto
                {
                    Titulo = "New York Times",
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
                    Descripcion = "Tienda en línea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/imagenes/steam.png"
                }
            };

            return listadoProyectos;
        }
    }
}
