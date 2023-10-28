using AceiteNegocio.Context;
using AceiteNegocio.Models;
using AceiteNegocio.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace AceiteNegocio.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LancamentosController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public LancamentosController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ObtemLancamentos()
        {
            try
            {
                List<Lancamento> lancamentos = await _context.Lancamentos.ToListAsync();
                List<LancamentoDTO> lancamentosDTOs = _mapper.Map<List<LancamentoDTO>>(lancamentos);
                return Ok(lancamentosDTOs);
            }
            catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> CriaLancamento(LancamentoDTO lancamentoDTO)
        {
            try
            {
                Lancamento lancamento =  _mapper.Map<Lancamento>(lancamentoDTO);

                await _context.Lancamentos.AddAsync(lancamento);
                await _context.SaveChangesAsync();

                return Ok(_mapper.Map<LancamentoDTO>(lancamento));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{idLancamento}")]
        public async Task<IActionResult> DeletaLancamento(int idLancamento)
        {
            try
            {
                Lancamento? lancamento = await _context.Lancamentos.FirstOrDefaultAsync(x=>x.Id == idLancamento);

                if (lancamento == null)
                    return NotFound("Lançamento não encontrado.");

                _context.Lancamentos.Remove(lancamento);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> AtualizaLancamento(LancamentoDTO lancamentoDTO)
        {
            try
            {
                bool lancamentoExiste = _context.Lancamentos.Any(x => x.Id == lancamentoDTO.Id);

                if (!lancamentoExiste)
                    return NotFound("Lançamento não encontrado.");

                Lancamento lancamento = _mapper.Map<Lancamento>(lancamentoDTO);

                _context.Lancamentos.Update(lancamento);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
