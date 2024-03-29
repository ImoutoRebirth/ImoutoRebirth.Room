﻿using ImoutoRebirth.Room.DataAccess.Models;
using ImoutoRebirth.Room.DataAccess.Repositories.Queries;

namespace ImoutoRebirth.Room.DataAccess.Repositories.Abstract;

public interface ICollectionFileRepository
{
    Task Add(CollectionFile collectionFile);

    Task<bool> AnyWithPath(Guid collectionId, string path);

    Task<IReadOnlyCollection<CollectionFile>> SearchByQuery(CollectionFilesQuery query);
        
    Task<int> CountByQuery(CollectionFilesQuery query);

    Task Remove(Guid id);

    Task<string?> GetWithMd5(Guid collectionId, string md5);
}