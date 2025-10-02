using catalogo.Dtos.Producto;
using catalogo.Interfaces.IRepositories;
using catalogo.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace catalogo.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IProductoService _productoService;
        public ProductosController(IProductoRepository productoRepository, IProductoService productoService)
        {
            _productoRepository = productoRepository;
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productos = await _productoRepository.GetAllAsync();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var producto = await _productoRepository.GetByIdAsync(id);
            if (producto == null) return NotFound();

            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearProductoDto dto)
        {
            var resultado = await _productoService.CreateAsync(dto);
            return Ok(resultado);
        }

        // [HttpPut("{id}")]
        // public async Task<IActionResult> Update(int id, Producto producto)
        // {
        //     return Ok();
        // }
        //
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(int id)
        // {
        //     var producto = await _productoRepository.DeleteAsync(id);
        //     if (producto == false) return NotFound();
        //
        //     return Ok();
        // }

        [HttpGet("listado")]
        public async Task<IActionResult> GetAllListado()
        {
            var productos = await _productoRepository.GetAllListadoAsync();
            return Ok(productos);
        }
    }
}
