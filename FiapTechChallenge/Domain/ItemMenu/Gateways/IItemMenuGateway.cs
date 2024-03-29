﻿using Domain.ValueObjects;

namespace Domain.Ports;

public interface IItemMenuGateway
{
    public void Create(ItemMenu itemMenu);
    public void Update(ItemMenu itemMenu);
    public void Delete(Guid id);
    public Task<ItemMenu> Get(Guid id);
    public Task<IEnumerable<ItemMenu>> GetByCategory(int categoryId);
}
