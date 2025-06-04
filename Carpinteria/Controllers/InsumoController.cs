using Carpinteria.DTO_s;
using Carpinteria.DTO_s.Accesorio;
using Carpinteria.DTO_s.Vidrio;
using Carpinteria.Excepciones;
using Carpinteria.ImplementacionCU;
using Carpinteria.InterfacesCU;
using Carpinteria.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace Carpinteria.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    ///COMENTARIO CHOTO
    public class InsumoController : ControllerBase
    {
        public IAltaInsumo AltaInsumo { get; set; }
        public IBajaInsumo BajaInsumo { get; set; }

        public IModificarInsumo ModificarInsumo { get; set; }


        public InsumoController(IAltaInsumo altaInsumo, IBajaInsumo bajaInsumo, IModificarInsumo modificarInsumo)
        {
            AltaInsumo = altaInsumo;
            BajaInsumo = bajaInsumo;
            ModificarInsumo = modificarInsumo;
        }



        //---------------------------------ALTA----------------------------------------

        /// <summary>
        /// Los valores de serie perfil son  Serie_20 = 0,Serie_30 = 1,Serie_15 = 2,Linea_Probba = 3,Linea_Summa = 4,Linea_Gala = 5,
        /// Linea_Gala_CR = 6, Monoblock = 7,TUBO = 8, ANGULOS = 9,U= 10, Mampara =11, Claraboya =12
        /// </summary>
        /// <returns>POST de Perfil en Stock e Insumos</returns>

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("perfil")]
        public IActionResult PostPerfil([FromBody] PerfilCreateDTO perfilDto)
        {
            try
            {
                if (perfilDto == null)
                {
                    return BadRequest("Los datos recibidos son incorrectos");

                }
                AltaInsumo.AltaPerfil(perfilDto);

                return Ok();
                //return CreatedAtRoute("ObtenerDisciplinaPorId", new { Id = disDTO.Id }, disDTO);

            }
            catch (InsumoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Datos incorrectos");
            }
        }
       
        /// <summary>
        /// Los valores de tipoVidrio son Transparente = 0,Fantasia = 1, Laminado = 2,Miniboreal = 3, Templado = 4,Opacid = 5,Espejado = 6, Espejo = 7
        /// </summary>
        /// <returns>POST de vidrio en Stock e Insumos</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("vidrio")]
        public IActionResult PostVidrio([FromBody] VidrioCreateDTO vidrioDTO)
        {
            try
            {
                if (vidrioDTO == null)
                {
                    return BadRequest("Los datos recibidos son incorrectos");

                }
                AltaInsumo.AltaVidrio(vidrioDTO);

                return Ok();
                //return CreatedAtRoute("ObtenerDisciplinaPorId", new { Id = disDTO.Id }, disDTO);

            }
            catch (InsumoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Datos incorrectos");
            }
        }
       
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("accesorio")]
        public IActionResult PostAccesorio([FromBody] AccesorioCreateDTO accesorioDto)
        {
            try
            {
                if (accesorioDto == null)
                {
                    return BadRequest("Los datos recibidos son incorrectos");

                }
                AltaInsumo.AltaAccesorio(accesorioDto);

                return Ok();
                //return CreatedAtRoute("ObtenerDisciplinaPorId", new { Id = disDTO.Id }, disDTO);

            }
            catch (InsumoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Datos incorrectos");
            }
        }


        //---------------------------------BAJA----------------------------------------

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("perfil")]
        public IActionResult EliminarPerfil([FromBody] DeletePerfilDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                BajaInsumo.BajaPerfil(dto);
                return Ok(new { mensaje = $"Perfil eliminado correctamente. InsumoId: {dto.InsumoId}" });
            }
            catch (InsumoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno al eliminar el perfil.");
            }
        }
        [HttpDelete("vidrio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteVidrio([FromBody] DeleteVidrioDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                BajaInsumo.BajaVidrio(dto);

                return Ok(new { mensaje = "Vidrio eliminado correctamente." });
            }
            catch (InsumoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error al eliminar el vidrio.");
            }
        }
        [HttpDelete("accesorio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteAccesorio([FromBody] DeleteAccesorioDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                BajaInsumo.BajaAccesorio(dto);

                return Ok(new { mensaje = "Accesorio eliminado correctamente." });
            }
            catch (InsumoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error al eliminar el accesorio.");
            }
        }



        //----------------------------------MODIFICACIÓN--------------------------------


        [HttpPut("perfil")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ModificarPerfil([FromBody] ModificarPerfilDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                ModificarInsumo.ModificarPerfil(dto);
                return Ok(new { mensaje = "Perfil y stock modificados correctamente." });
            }
            catch (InsumoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (StockException ex)
            {
                return BadRequest($"Error al modificar el stock: {ex.Message}");
            }
            catch
            {
                return StatusCode(500, "Error interno al modificar el perfil.");
            }
        }
    }
}
