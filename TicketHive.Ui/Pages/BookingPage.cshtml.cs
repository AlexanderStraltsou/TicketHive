using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using TicketHive.Server.Data;
using TicketHive.Server.Models;

namespace TicketHive.Ui.Pages.Display
{
    public class BookingPageModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        [BindProperty]
        public int EventId { get; set; }
        public string SearchInput { get; set; }

        public BookingPageModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<EventModel> Events { get; set; }

        public void OnGet(string searchInput)
        {
            SearchInput = searchInput;

            Events = _dbContext.Events.ToList();
        }

        public IActionResult OnPost()
        {
            // L�gg till eventet med det bindade EventId:t i ShoppingCart-cookien

            // H�mta ShoppingCart-cookien

            string shoppingCartJson = HttpContext.Session.GetString("ShoppingCart");

            // G�r om cookie-str�ngen till ett Cart-objekt

            CartModel cart = new();
            cart.CartItems = new();
            if(!string.IsNullOrEmpty(shoppingCartJson))
            {
                cart = JsonSerializer.Deserialize<CartModel>(shoppingCartJson);   
            }

            // H�mta info om det klickade eventet fr�n databasen

            EventModel clickedEvent = _dbContext.Events.FirstOrDefault(e => e.Id == EventId);

            // Skapa cookie-data fr�n infon fr�n det h�mtade eventet

            if(cart!.CartItems.Any(c => c.EventId == EventId))
            {
                CartItemModel cartItem = cart.CartItems.First(c => c.EventId == EventId);

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


