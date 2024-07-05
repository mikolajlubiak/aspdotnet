using System.ComponentModel.DataAnnotations;

namespace aspdotnet.Models
{
    public class Automobile
    {
        public int Id { get; set; }
        public int Cena { get; set; }
        public string Nazwa { get; set; }

        // Wlasciciel
        public string? Imie_Nazwisko { get; set; }
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Odbior { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Oddanie { get; set; }

        // Methods
        public Automobile()
        {
        }
    }
}
