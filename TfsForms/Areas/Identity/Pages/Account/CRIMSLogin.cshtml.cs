using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TfsForms.Data;

namespace TfsForms.Areas.Identity.Pages.Account
{
    public class CRIMSLoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserStore<ApplicationUser> userStore;
        private readonly IDbContextFactory<ApplicationDbContext> factory;
        private readonly IUserEmailStore<ApplicationUser> emailStore;

        public CRIMSLoginModel(SignInManager<ApplicationUser> signInManager,
            ILogger<LoginModel> logger,
            IHttpClientFactory httpClientFactory,
             UserManager<ApplicationUser> userManager,
              IUserStore<ApplicationUser> userStore,
              IDbContextFactory<ApplicationDbContext> factory)
        {
            _signInManager = signInManager;
            _logger = logger;
            this.httpClientFactory = httpClientFactory;
            this.userManager = userManager;
            this.userStore = userStore;
            this.factory = factory;
            this.emailStore = GetEmailStore();
        }


        public SelectList CRIMSOrganizations { get; set; }



        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            //[Required]
            //[EmailAddress]
            //public string Email { get; set; }


            [Required]

            public string UserName { get; set; }

            [Required]

            public string GUID { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public class CRIMSOrganization
        {
            public string name { get; set; }
            public string domain { get; set; }
            public bool batch_enabled { get; set; }
        }
        public class CRIMSOrganizationsResponse
        {
            public int count { get; set; }
            public string next { get; set; }
            public string previous { get; set; }
            public List<CRIMSOrganization> results { get; set; }
        }
        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            try
            {
                using var http = httpClientFactory.CreateClient();
                var response = await http.GetAsync("https://apps.nfiu.gov.ng/crims/api/organisations");

                if (response.IsSuccessStatusCode)
                {
                    var organizationsResponse = await response.Content.ReadFromJsonAsync<CRIMSOrganizationsResponse>();
                    if (organizationsResponse?.results != null && organizationsResponse.results.Any())
                    {
                        CRIMSOrganizations = new SelectList(organizationsResponse.results, "domain", "name");
                    }
                    else
                    {
                        CRIMSOrganizations = new SelectList(Enumerable.Empty<CRIMSOrganization>(), "domain", "name");
                    }
                }
                else
                {
                    _logger.LogWarning("Failed to fetch CRIMS organizations. Status code: {StatusCode}", response.StatusCode);
                    CRIMSOrganizations = new SelectList(Enumerable.Empty<CRIMSOrganization>(), "domain", "name");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching CRIMS organizations");
                CRIMSOrganizations = new SelectList(Enumerable.Empty<CRIMSOrganization>(), "domain", "name");
            }

            ReturnUrl = returnUrl;
        }

        public class LoginObject
        {
            public string username { get; set; }
            public string password { get; set; }
            public string domain { get; set; }
            public string scope { get; set; }

        }

        public class CRIMSUserData
        {
            public string userId { get; set; }
            public string email { get; set; }
            public string userName { get; set; }
            public string domain { get; set; }
        }


        public class CRIMSLoginResponse
        {
            public string _id { get; set; }
            public string role { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public List<string> groups { get; set; }
            public bool active { get; set; }
            public string scope { get; set; }
            public string domain { get; set; }
            public double created { get; set; }
            public double modified { get; set; }
            public string token { get; set; }
            public double tokenExpire { get; set; }
            public string name { get; set; }
            public List<string> permissions { get; set; }
        }


        public class GoAMLLoginResponse
        {
            public GoAMLUserData data { get; set; }
            public string statusCode { get; set; }
            public string statusDescription { get; set; }
        }

        public class GoAMLUserData
        {
            public string userId { get; set; }
            public string email { get; set; }
            public string userName { get; set; }
            public int guid { get; set; }
        }


        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)userStore;
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true

                using var http = httpClientFactory.CreateClient();

                var loginObject = new LoginObject
                {
                    username = Input.UserName,
                    password = Input.Password,
                    domain = Input.GUID,
                    scope = "crims.nfiu.gov.ng"

                };



                var resp = await http.PostAsJsonAsync("https://apps.nfiu.gov.ng/crims/api/login", loginObject);

                if (resp.IsSuccessStatusCode)
                {
                    var loginResponse = await resp.Content.ReadFromJsonAsync<CRIMSLoginResponse>();

                    if (loginResponse != null && loginResponse.active && !string.IsNullOrEmpty(loginResponse.token))
                    {
                        var email = loginResponse.email;

                        var loggedInUser = await userManager.FindByNameAsync(Input.UserName); //try to get the user from the local db
                        if (loggedInUser is null) // if user is not already on the local db, create user
                        {
                            var user = CreateUser();
                            await userStore.SetUserNameAsync(user, Input.UserName, CancellationToken.None);
                            await emailStore.SetEmailAsync(user, email, CancellationToken.None);
                            user.CRIMSReportingEntityId = loginObject.domain;
                            var resultCreated = await userManager.CreateAsync(user, Input.Password);

                            if (!resultCreated.Succeeded) //if user creation succeeds, log user in
                            {
                                //await _signInManager.SignInAsync(user, isPersistent: false);
                                //return LocalRedirect(returnUrl);

                                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                                return Page();
                            }

                            // Add user to RapidAML role
                            var roleResult = await userManager.AddToRoleAsync(user, "CRIMS");
                            if (!roleResult.Succeeded)
                            {
                                _logger.LogWarning("Failed to add user {Email} to RapidAML role", Input.UserName);
                            }

                            loggedInUser = user;
                        }
                        else
                        {
                            loggedInUser = await userManager.FindByNameAsync(Input.UserName);

                        }

                        await _signInManager.SignInAsync(loggedInUser, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");


                //var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                //if (result.Succeeded)
                //{
                //    _logger.LogInformation("User logged in.");
                //    return LocalRedirect(returnUrl);
                //}
                //if (result.RequiresTwoFactor)
                //{
                //    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                //}
                //if (result.IsLockedOut)
                //{
                //    _logger.LogWarning("User account locked out.");
                //    return RedirectToPage("./Lockout");
                //}
                //else
                //{
                //    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                //    return Page();
                //}
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
