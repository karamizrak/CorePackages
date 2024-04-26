using MinistryOfHealth.Core.Security.Entities;

namespace MinistryOfHealth.Core.Security.JWT;

public interface ITokenHelper<TUserId, TOperationClaimId, TRefreshTokenId>
{
    public AccessToken CreateToken(User<TUserId> user, IList<OperationClaim<TOperationClaimId>> operationClaims);

    public RefreshToken<TRefreshTokenId, TUserId> CreateRefreshToken(User<TUserId> user, string ipAddress);
}
