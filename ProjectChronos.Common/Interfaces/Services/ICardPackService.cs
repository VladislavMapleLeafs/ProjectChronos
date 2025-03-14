﻿using ProjectChronos.Common.Entities;
using ProjectChronos.Common.Interfaces.Entities;
using ProjectChronos.Common.Models;
using ProjectChronos.Common.Models.Enums;
using ProjectChronos.Common.Models.ExpressApi;

namespace ProjectChronos.Common.Interfaces.Services
{
    public interface ICardPackService
    {
        bool EnsureWelcomePackTemplateExists();

        Task<CreatedPacks> CreatePacksAsync(int cardPackTemplateId);

        Task<CreatedPacks> CreatePacksAsync(CardPackType type);

        Task<CreatedPacks> CreatePacksAsync(ICardPackTemplate packTemplate);

        Task<BaseServiceResult> ClaimPackAsync(IUser user, CardPackType type);

        int GetPacksRemaining(CardPackType type);

        Task<ExpressPackContent> GetPackContentAsync(CardPackType type);

        Task<IEnumerable<ExpressPack>> GetOwnedPacksAsync(IUser user);
    }
}
