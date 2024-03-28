namespace SortedListTP1
{
    public class Concesionaria
    {
        public SortedList<int, string> Vehiculos {  get; set; }


        //Inicializamos vehículo
        public Concesionaria() 
        {
            Vehiculos = new SortedList<int, string>();



        }
        public int Id{ get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
    }
}
