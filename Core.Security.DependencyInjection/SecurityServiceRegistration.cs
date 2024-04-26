using Microsoft.Extensions.DependencyInjection;
using MinistryOfHealth.Core.Security.EmailAuthenticator;
using MinistryOfHealth.Core.Security.JWT;
using MinistryOfHealth.Core.Security.OtpAuthenticator;
using MinistryOfHealth.Core.Security.OtpAuthenticator.OtpNet;

namespace MinistryOfHealth.Core.Security.DependencyInjection;

public static class SecurityServiceRegistration
{
    public static IServiceCollection AddSecurityServices<TUserId, TOperationClaimId, TRefreshTokenId>(
        this IServiceCollection services,
        TokenOptions tokenOptions
    )
    {
        services.AddScoped<
            ITokenHelper<TUserId, TOperationClaimId, TRefreshTokenId>,
            JwtHelper<TUserId, TOperationClaimId, TRefreshTokenId>
        >(_ => new JwtHelper<TUserId, TOperationClaimId, TRefreshTokenId>(tokenOptions));
        services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
        services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();

        return services;
    }
}
