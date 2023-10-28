using static AceiteNegocio.Enum.Enum;

namespace AceiteNegocio.Models.DTO
{
    public class LancamentoDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public EStatus Status { get; set; }
        public bool Avulso { get; set; }
    }
}
