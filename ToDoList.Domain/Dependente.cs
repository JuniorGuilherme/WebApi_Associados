namespace ToDoList.Domain
{
    public class Dependente
    {
        public int id { get; set; }
        public string name { get; set; }      
       
        public string kinship { get; set; }

        public string birthDate { get; set; }

        public Associated ass { get; set;}
        
    }
}