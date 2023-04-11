using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TicketHive.Ui.Pages
{
    [BindProperties]
    public class RegisterpageModel : PageModel
    {

        private readonly SignInManager<IdentityUser> signInManager;

        [Required(ErrorMessage = "Username is requierd")]
        [MinLength(5, ErrorMessage = "Username must be at least 5 characters")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is requierd")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string? Password { get; set; }

        public RegisterpageModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            // Om alla props �r bindade som de ska...
            if (ModelState.IsValid)
            {
                // Skapa en ny IdentityUser med anv�ndarnamnet som �r inskrivet
                IdentityUser newUser = new()
                {
                    UserName = Username
                };

                // testa att registerera anv�ndaren med l�senordet den skrev in
                var registerResult = await signInManager.UserManager.CreateAsync(newUser, Password!);

                //Om registreningsf�rs�ket lyckades...
                if (registerResult.Succeeded)
                {
                    return Redirect("/Index");
                }

            }

            return Page();
        }
    }
}