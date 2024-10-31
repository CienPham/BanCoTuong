using BanCoTuong.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace BanCoTuong.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            try
            {
                string jsonPath = Path.Combine(_webHostEnvironment.WebRootPath, "ChessJson.txt");
                string jsonContent = System.IO.File.ReadAllText(jsonPath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var chessPieces = JsonSerializer.Deserialize<List<ChessPiece>>(jsonContent, options);

                // Kiểm tra dữ liệu
                foreach (var piece in chessPieces)
                {
                    Console.WriteLine($"Id: {piece.Id}, Src: {piece.Src}, Top: {piece.Top}, Left: {piece.Left}");
                }

                return View(chessPieces);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return View(new List<ChessPiece>());
            }
        }
    }
}
