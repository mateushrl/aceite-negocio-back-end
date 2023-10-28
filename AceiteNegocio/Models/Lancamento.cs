using static AceiteNegocio.Enum.Enum;

namespace AceiteNegocio.Models
{
    public class Lancamento
    {
        //- As propriedades de cada lançamento são: Id, descrição, data, valor, avulso, status.

        public  int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public EStatus Status { get; set; }
        public bool Avulso { get; set; }
    }
}
