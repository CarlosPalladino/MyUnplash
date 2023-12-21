namespace My_Unsplash.Models
{
    public class Usuarios
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public byte[] ContraseñaHash { get; set; }
        public byte[] ContraseñaSalt { get; set; }

    }
}
