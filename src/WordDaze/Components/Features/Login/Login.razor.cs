using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Services;
using WordDaze.Models;


namespace WordDaze.Components.Features
{
    public class LoginModel : ComponentBase
    {
        [Inject] private AppState _appState { get; set; }
        [Inject] private IUriHelper _uriHelper { get; set; }
        
        protected LoginDetails LoginDetails { get; set; } = new LoginDetails();
        protected bool ShowLoginFailed { get; set; }

        protected async Task Login()
        {
            await _appState.Login(LoginDetails);

            if (_appState.IsLoggedIn)
            {
                _uriHelper.NavigateTo("/");
            }
            else
            {
                ShowLoginFailed = true;
            }
        }
    }
}