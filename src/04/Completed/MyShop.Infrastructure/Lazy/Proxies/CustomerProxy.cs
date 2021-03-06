﻿using MyShop.Domain.Models;
using MyShop.Infrastructure.Services;

namespace MyShop.Infrastructure.Lazy.Proxies
{
    // Lazy Loading: Virtual Proxy
public class CustomerProxy : Customer
{
    public override byte[] ProfilePicture
    {
        get
        {
            if (base.ProfilePicture == null)
            {
                base.ProfilePicture = ProfilePictureService.GetFor(Name);
            }

            return base.ProfilePicture;
        }
    }
}
}
