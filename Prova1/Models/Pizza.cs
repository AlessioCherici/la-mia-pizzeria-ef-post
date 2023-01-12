

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPizzeriaModel.Models
    {
    [Table("Pizzas")]
    public class Pizza
        {
        
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string Immagine { get; set; }

        public Pizza (string nome, string prezzo, string descrizione, string Immagine)
            {
            this.Nome = nome;
            this.Prezzo = prezzo;
            this.Descrizione = descrizione;
            this.Immagine = Immagine;
            }
        }
    }
