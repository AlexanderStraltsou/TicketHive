using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using TicketHive.Server.Data;
using TicketHive.Server.Models;


namespace TicketHive.Ui.Pages
{
    public class EventPageModel : PageModel
    {
        private readonly AppDbContext _context;

        public EventModel Event { get; set; }

        public EventPageModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            Event = _context.Events.Find(id);

            if (Event == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int id) 
        {

            // L�gg till eventet med det bindade EventId:t i ShoppingCart-cookien

            // H�mta ShoppingCart-cookien

            string shoppingCartJson = HttpContext.Session.GetString("ShoppingCart");

            // G�r om cookie-str�ngen till ett Cart-objekt

            CartModel cart = new();
            cart.CartItems = new();
            if (!string.IsNullOrEmpty(shoppingCartJson))
            {
                cart = JsonSerializer.Deserialize<CartModel>(shoppingCartJson);
            }

            // H�mta info om det klickade eventet fr�n databasen

            EventModel clickedEvent = _context.Events.FirstOrDefault(e => e.Id == id);

            // Skapa cookie-data fr�n infon fr�n det h�mtade eventet

            if (cart!.CartItems.Any(c => c.EventId == id))
            {
                CartItemModel cartItem = cart.CartItems.First(c => c.EventId == id);

                cartItem.Quantity++;
            }
            else
            {
                cart.CartItems.Add(new CartItemModel()
                {
                    EventId = clickedEvent.Id,
                    EventName = clickedEvent.Name,
                    Price = clickedEvent.TicketPrice,
                    EventType = clickedEvent.EventType,
                    Quantity = 1
                });
            }

            shoppingCartJson = JsonSerializer.Serialize(cart);

            HttpContext.Session.SetString("ShoppingCart", shoppingCartJson);

            return RedirectToPage("/member/basket");
        }
    }
}

