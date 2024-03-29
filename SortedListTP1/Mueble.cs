namespace SortedListTP1
{
    public class Mueble
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Mueble(int id, string name)
        {
           this. Id = id;
            this.Name = name;
        }
        public Mueble (string Name) 
        { 
            this.Name = Name;
        }
    }
    
}
