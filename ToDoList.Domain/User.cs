using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain
{
    public class User
    {   public int id { get; set; }
        [Required(ErrorMessage="Digite um nome de usuário válido.",AllowEmptyStrings=false)]
        public string name { get; set; }      
       [Required(ErrorMessage="Digite uma senha de usuário válida.",AllowEmptyStrings=false)]
        public string password { get; set; }
    }
}