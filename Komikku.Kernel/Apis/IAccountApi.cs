using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 账号
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IAccountApi
{
    /// <summary>
    /// Create a account
    /// </summary>
    /// <param name="create">CreateAccount</param>
    /// <returns></returns>
    [Post("/account/create")]
    Task<UserResponse?> CreateAccountAsync([Body] AccountCreate create);

    /// <summary>
    /// Activate a account
    /// </summary>
    /// <param name="code">Account activate code</param>
    /// <returns></returns>
    [Post("/account/activate/{code}")]
    Task<AccountActivateResponse> ActivateAccountAsync(string code);

    /// <summary>
    /// Resend activation code
    /// </summary>
    /// <param name="resend">SendAccountActivationCode</param>
    /// <returns></returns>
    [Post("/account/activate/resend")]
    Task<AccountActivateResponse> ResendActivationCodeAsync([Body] SendAccountActivationCode resend);

    /// <summary>
    /// Recover given account
    /// You can only request Account Recovery once per Hour for the same Email Address  
    /// </summary>
    /// <returns></returns>
    [Post("/account/recover")]
    Task<AccountActivateResponse> RecoverAccountAsync();

    /// <summary>
    /// Complete account recover
    /// </summary>
    /// <param name="code">Account activate code</param>
    /// <param name="complete"></param>
    /// <returns></returns>
    [Post("/account/recover/{code}")]
    Task<AccountActivateResponse> CompleteAccountRecoverAsync(string code, [Body] RecoverCompleteBody complete);
}