using System;
namespace BancoResguard.DTO
{
    public class Persona
    {
        //ATRIBUTOS

        private String run;
        private String nombre;
        private String Apellido;
        private String password;
        private int telefono;

        //METODOS

        public string Run { get => run; set => run = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Password { get => password; set => password = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
