namespace Clases
{
    public class A
    {

        string NombreInstancia;
        public A()
        {
            this.NombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre)
        {
            this.NombreInstancia = nombre;
        }


        public void MostrarNombre()
        {
            System.Console.WriteLine(this.NombreInstancia);
        }

        public void M1()
        {
            System.Console.WriteLine("M1 invocado!");
        }

        public void M2()
        {
            System.Console.WriteLine("M2 invocado!");
        }

        public void M3()
        {
            System.Console.WriteLine("M3 invocado!");
        }

    }
}
