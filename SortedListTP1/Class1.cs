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
    }
}
