namespace ToDoList.API.DTOs
{
    public class AssociatedDTO
    {
        public int id { get; set; }

        public string name { get; set; }      
       
        public string adress { get; set; }
        public string city { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string email { get; set; }
        public string maritalStatus { get; set; }
        public string birthDate { get; set; }
    }
}