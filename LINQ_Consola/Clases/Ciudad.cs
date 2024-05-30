namespace Clases
{
    public class Ciudad {

        public string nombre;
        public int codPostal;

        public Ciudad() {
        }

        public Ciudad(string nombre, int codPostal) {
            this.nombre = nombre.ToLower();
            this.codPostal = codPostal;
        }

    }
}
