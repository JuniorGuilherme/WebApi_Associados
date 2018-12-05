using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain
{
    public class User
    {public int id { get; set; }

        [Required(ErrorMessage="Preenchimento de usu[ario obrigat[orio.",AllowEmptyStrings=false)]
        public string name { get; set; }      
       
        public string password { get; set; }
    }
}