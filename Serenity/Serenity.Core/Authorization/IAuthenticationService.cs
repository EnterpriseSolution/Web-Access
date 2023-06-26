
namespace Serenity.Abstractions
{
    /// <summary>
    /// Authentication service abstraction
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Returns true if username/password pair is correct
        /// </summary>
        IUserDefinition Validate(ref string username, string password, string companyCode);
    }
}