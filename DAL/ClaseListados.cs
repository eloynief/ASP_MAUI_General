using Entities;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class ClaseListados
    {


        /// <summary>
        /// Funcion para crear el listado de personas
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> listadoPersonas()
        {
            //se crea la lista de personas
            List<ClsPersona> listado = new List<ClsPersona>();

            // Agregamos personas a la lista
            listado.Add(new ClsPersona(1, "Juan", "Pérez", new DateTime(1985, 5, 12), "Calle Falsa 123", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbS5mqDMLi2AvTNHyYS6qUQoP59Zgo1xZZ3w&s", "555-1234", 1));
            listado.Add(new ClsPersona(2, "Ana", "García", new DateTime(1990, 3, 18), "Av. Siempre Viva 742", "https://econaturagourmet.com/wp-content/uploads/2021/10/jamon-iberico-de-bellota-cebo-de-campo-pata-negra-guijuelo-entero.jpg", "555-5678", 2));
            listado.Add(new ClsPersona(3, "Luis", "Martínez", new DateTime(1982, 11, 23), "Paseo de la Reforma 200", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbS5mqDMLi2AvTNHyYS6qUQoP59Zgo1xZZ3w&s", "555-8765", 3));

            // Agregamos personas a la lista
            listado.Add(new ClsPersona(1, "Juan", "Pérez", new DateTime(1985, 5, 12), "Calle Falsa 123", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbS5mqDMLi2AvTNHyYS6qUQoP59Zgo1xZZ3w&s", "555-1234", 1));
            listado.Add(new ClsPersona(2, "Ana", "García", new DateTime(1990, 3, 18), "Av. Siempre Viva 742", "https://econaturagourmet.com/wp-content/uploads/2021/10/jamon-iberico-de-bellota-cebo-de-campo-pata-negra-guijuelo-entero.jpg", "555-5678", 2));
            listado.Add(new ClsPersona(3, "Luis", "Martínez", new DateTime(1982, 11, 23), "Paseo de la Reforma 200", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbS5mqDMLi2AvTNHyYS6qUQoP59Zgo1xZZ3w&s", "555-8765", 3));

            // Agregamos personas a la lista
            listado.Add(new ClsPersona(1, "Juan", "Pérez", new DateTime(1985, 5, 12), "Calle Falsa 123", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbS5mqDMLi2AvTNHyYS6qUQoP59Zgo1xZZ3w&s", "555-1234", 1));
            listado.Add(new ClsPersona(2, "Ana", "García", new DateTime(1990, 3, 18), "Av. Siempre Viva 742", "https://econaturagourmet.com/wp-content/uploads/2021/10/jamon-iberico-de-bellota-cebo-de-campo-pata-negra-guijuelo-entero.jpg", "555-5678", 2));
            listado.Add(new ClsPersona(3, "Luis", "Martínez", new DateTime(1982, 11, 23), "Paseo de la Reforma 200", "https://upload.wikimedia.org/wikipedia/en/thumb/7/73/Trollface.png/220px-Trollface.pngs", "555-8765", 3));

            //devolvemos el listado
            return listado;
        }

        /// <summary>
        /// Funcion para crear el listado de los departamentos
        /// </summary>
        /// <returns></returns>
        public static List<ClsDepartamento> listadoDepartamentos()
        {
            //se crea una lista de deptartamentos con unos valores por defecto
            List<ClsDepartamento> listado = new List<ClsDepartamento>();

            //se agregan los departamentos
            listado.Add(new ClsDepartamento(1, "NombreA"));
            listado.Add(new ClsDepartamento(2, "NombreB"));
            listado.Add(new ClsDepartamento(3, "NombreC"));

            //se devuelve el listado
            return listado;
        }




        #region funciones de BBDD

        static SqlConnection miConexion = new SqlConnection();
        static SqlCommand miComando = new SqlCommand();
        static SqlDataReader miLector;

        public static List<ClsPersona> ListadoPersonasAZURE()
        {

            //se crea la lista de personas
            List<ClsPersona> listado = new List<ClsPersona>();


            ClsPersona oPersona;




            miConexion.ConnectionString = EnlaceBBDD.enlace("prueba", "fernandoG321");
            try
            {
                miConexion.Open();
                //Creamos el comando (Creamos el comando, le pasamos la sentencia y la conexion, y lo ejecutamos)
                miComando.CommandText = "SELECT * FROM personas";
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();



                oPersona = new ClsPersona();
                oPersona.Id = (int)miLector["IDPersona"];
                oPersona.Nombre = (string)miLector["Nombre"];
                oPersona.Apellido = (string)miLector["apellidos"];

                if (miLector["fechaNac"] != System.DBNull.Value)
                { 
                    oPersona.FechaNac = (DateTime)miLector["fechaNac"];
                }

                oPersona.Direccion = (string)miLector["direccion"];

                oPersona.Telefono = (string)miLector["telefono"];

                listado.Add(oPersona);



                return listado;
            }
            catch (Exception ex)
            {
                return listado;
            }
        }

        #endregion


        public int deletePersonaDAL(int id)

        {

            int numeroFilasAfectadas = 0;


            miConexion.ConnectionString = EnlaceBBDD.enlace("prueba", "fernandoG321");

            try

            {

                miConexion.Open();

                miComando.CommandText = "DELETE FROM Personas WHERE IDPersona=@id";

                miComando.Connection = miConexion;

                numeroFilasAfectadas = miComando.ExecuteNonQuery();

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return numeroFilasAfectadas;

        }







        /// <summary>
        /// funcion para obtener la persona aleatoria de la lista de personas
        /// </summary>
        /// <returns></returns>
        public static ClsPersona ObtenerPersonaAleatoria()
        {
            //se crea la lista llamando al metodo del listadoPersonas
            List<ClsPersona> lista = listadoPersonas();

            //se genera una var tipo random
            Random random = new Random();

            //se genera un numero aleatorio
            int numRandom = random.Next(0, lista.Count);

            //se devuelve el numero aleatorio
            return lista[numRandom];
        }







    }
}
