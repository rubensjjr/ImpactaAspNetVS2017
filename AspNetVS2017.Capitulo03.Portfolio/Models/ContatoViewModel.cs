using System.ComponentModel.DataAnnotations;

namespace AspNetVS2017.Capitulo03.Portfolio.Models
{
    public class ContatoViewModel
    {   
        [Required] // faz a validação dos campos em java
        public string Nome { get; set; }

        [Required]
        [EmailAddress] // valida o email na tela
        public string Email { get; set; }

        [Required]
        public string Mensagem { get; set;}

    }
}