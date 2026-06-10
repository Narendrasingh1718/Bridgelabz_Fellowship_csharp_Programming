using BusinessLayer.Interface.NoteServiceInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTO.RequestDto;
using Model.DTO.ResponceDto;
using Model.Entity.Responce;
using Model.Exception;
using System.Security.Claims;

namespace FunDooApplication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService service;
        public NotesController(INoteService service)
        {
            this.service = service;
        }
       
        // CREATE NOTE
        [HttpPost]
        public async Task<ActionResult<ApiResponce<NoteResponceDto>>> CreateNote(CreatedReqDto dto)
        {
            try
            {
                var result = await service.CreateNote(dto);

                return Ok(new ApiResponce<NoteResponceDto>
                {
                    Success = true,
                    Message = "Note created successfully",
                    Data = result
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponce<NoteResponceDto>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }

        // GET ACTIVE NOTES
        [HttpGet("active")]
        public async Task<ActionResult<ApiResponce<List<NoteResponceDto>>>> GetAllActiveNotes()
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.GetAllActiveNotes(userId);

                return Ok(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = true,
                    Message = "Active notes fetched",
                    Data = result
                });
            }
            catch (NoRecordFound ex)
            {
                return NotFound(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }

        // GET ARCHIVED NOTES
        [HttpGet("archive")]
        public async Task<ActionResult<ApiResponce<List<NoteResponceDto>>>> GetArchivedNotes()
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.GetArchivedNotes(userId);

                return Ok(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = true,
                    Message = "Archived notes fetched",
                    Data = result
                });
            }
            catch (NoRecordFound ex)
            {
                return NotFound(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }


        // GET TRASHED NOTES
        [HttpGet("trash")]
        public async Task<ActionResult<ApiResponce<List<NoteResponceDto>>>> GetTrashedNotes()
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.GetTrashedNotes(userId);

                return Ok(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = true,
                    Message = "Trashed notes fetched",
                    Data = result
                });
            }
            catch (NoRecordFound ex)
            {
                return NotFound(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }


        // SEARCH NOTES
        [HttpGet("search")]
        public async Task<ActionResult<ApiResponce<List<NoteResponceDto>>>> SearchNotes( string keyword)
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.SearchNotes(userId, keyword);

                return Ok(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = true,
                    Message = "Search results",
                    Data = result
                });
            }
            catch (NoRecordFound ex)
            {
                return NotFound(new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponce<List<NoteResponceDto>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }


        // UPDATE NOTE
        [HttpPut]
        public async Task<ActionResult<ApiResponce<NoteResponceDto>>> UpdateNote(UpdateReqDto dto)
        {
            try
            {

                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                dto.UserId = userId;

                var result = await service.UpdateNote(dto);

                return Ok(new ApiResponce<NoteResponceDto>
                {
                    Success = true,
                    Message = "Note updated successfully",
                    Data = result
                });
            }
            catch (NoRecordFound ex)
            {
                return NotFound(new ApiResponce<NoteResponceDto>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponce<NoteResponceDto>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }

        // DELETE (SOFT)
        [HttpDelete("{noteId}")]
        public async Task<ActionResult<ApiResponce<string>>> DeleteNote(int noteId)
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.DeleteNote(noteId, userId);

                return Ok(new ApiResponce<string>
                {
                    Success = true,
                    Message = result,
                    Data = null
                });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ApiResponce<string>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }

        // DELETE FOREVER
        [HttpDelete("forever/{noteId}")]
        public async Task<ActionResult<ApiResponce<string>>> DeleteNoteForever(int noteId)
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.DeleteNoteForever(noteId, userId);

                return Ok(new ApiResponce<string>
                {
                    Success = true,
                    Message = result,
                    Data = null
                });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ApiResponce<string>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }

        // TOGGLE PIN
        [HttpPatch("pin/{noteId}")]
        public async Task<ActionResult<ApiResponce<string>>> TogglePin(int noteId)
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.TogglePin(noteId, userId);

                return Ok(new ApiResponce<string>
                {
                    Success = true,
                    Message = result,
                    Data = null
                });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ApiResponce<string>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }

        // TOGGLE ARCHIVE
        [HttpPatch("archive/{noteId}")]
        public async Task<ActionResult<ApiResponce<string>>> ToggleArchive(int noteId)
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.ToggleArchive(noteId, userId);

                return Ok(new ApiResponce<string>
                {
                    Success = true,
                    Message = result,
                    Data = null
                });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ApiResponce<string>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }


        // TOGGLE TRASH
        [HttpPatch("trash/{noteId}")]
        public async Task<ActionResult<ApiResponce<string>>> ToggleTrash(int noteId)
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.ToggleTrash(noteId, userId);

                return Ok(new ApiResponce<string>
                {
                    Success = true,
                    Message = result,
                    Data = null
                });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ApiResponce<string>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }
        //Get by Id
        [HttpGet("{noteId}")]
        public async Task<ActionResult<ApiResponce<NoteResponceDto>>> GetNoteById(int noteId)
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                var result = await service.GetNoteById(noteId, userId);

                if (result == null)
                {
                    return NotFound(new ApiResponce<NoteResponceDto>
                    {
                        Success = false,
                        Message = "Note not found",
                        Data = null
                    });
                }

                return Ok(new ApiResponce<NoteResponceDto>
                {
                    Success = true,
                    Message = "Note fetched successfully",
                    Data = result
                });
            }
            catch (NoRecordFound ex)
            {
                return NotFound(new ApiResponce<NoteResponceDto>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponce<NoteResponceDto>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }
    }
}
