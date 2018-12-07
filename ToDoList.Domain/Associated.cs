using System.Collections.Generic;

namespace ToDoList.Domain
{
    public class Associated
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

        public List<Dependente> dep {get; set;}
    }
}