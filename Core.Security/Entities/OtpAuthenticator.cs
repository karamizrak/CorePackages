﻿using MinistryOfHealth.Core.Persistence.Repositories;

namespace MinistryOfHealth.Core.Security.Entities;

public class OtpAuthenticator<TUserId> : Entity<TUserId>
{
    public TUserId UserId { get; set; }
    public byte[] SecretKey { get; set; }
    public bool IsVerified { get; set; }
    public virtual User<TUserId> User { get; set; } = null!;

    public OtpAuthenticator()
    {
        UserId = default!;
        SecretKey = Array.Empty<byte>();
    }

    public OtpAuthenticator(TUserId userId, byte[] secretKey, bool isVerified)
    {
        UserId = userId;
        SecretKey = secretKey;
        IsVerified = isVerified;
    }

    public OtpAuthenticator(TUserId id, TUserId userId, byte[] secretKey, bool isVerified)
        : base(id)
    {
        UserId = userId;
        SecretKey = secretKey;
        IsVerified = isVerified;
    }
}
