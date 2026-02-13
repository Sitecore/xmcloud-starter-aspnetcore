using Microsoft.AspNetCore.Localization;

namespace Sitecore.AspNetCore.Starter.Extensions
{
  public class HostnameRequestCultureProvider : RequestCultureProvider
  {
    public override Task<ProviderCultureResult?> DetermineProviderCultureResult(HttpContext httpContext)
    {
      ArgumentNullException.ThrowIfNull(httpContext);

      // Depending on the hostname used, set the culture accordingly so that
      // there is no need to use language prefix or query string parameter to switch language
      var normalizedHost = httpContext.Request.Host.Host.ToLowerInvariant();
      var culture = normalizedHost switch
      {
        "testsite.nl" => "nl-NL",
        "testsite.de" => "de-DE",
        _ => "en", // Default to English if no match found
      };

      return Task.FromResult<ProviderCultureResult?>(new ProviderCultureResult(culture, culture));

    }
  }
}
