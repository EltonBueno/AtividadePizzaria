using System.ComponentModel.DataAnnotations;

namespace AtividadePizzaria.Models
{
    public class PizzaSabor
    {
        public PizzaSabor(int pizzaId, int saborId)
        {
            PizzaId = pizzaId;
            SaborId = saborId;
        }

        [Key]
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        [Key]
        public int SaborId { get; set; }
        public Sabor Sabor { get; set; }

    }
}
