/*using BanCoTuong.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BanCoTuong.Controllers
{
    public class ChessController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ChessController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            // Đường dẫn đến file ChessJson.txt trong wwwroot
            string jsonPath = Path.Combine(_webHostEnvironment.WebRootPath, "ChessJson.txt");
            string jsonContent = System.IO.File.ReadAllText(jsonPath);
            var chessPieces = JsonSerializer.Deserialize<List<ChessPiece>>(jsonContent);
            return View(chessPieces);
        }
    }
}
*/