﻿using ELIXIRETD.DATA.DATA_ACCESS_LAYER.DTOs.INVENTORY_DTO.MRP;
using ELIXIRETD.DATA.DATA_ACCESS_LAYER.HELPERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIRETD.DATA.CORE.INTERFACES.INVENTORY_INTERFACE
{
    public interface IMRPInventory
    {
        Task<IReadOnlyList<DtoGetAllAvailableInRawmaterialInventory>> GetAllAvailableInRawmaterialInventory();
        //Task<IReadOnlyList<DtoMRP>> MRPInventory();
        //Task<PagedList<DtoMRP>> GetallItemForInventoryPagination(UserParams userParams);
        Task<PagedList<DtoMRP>> GetallItemForInventoryPaginationOrig(UserParams userParams, string search);

        Task<IReadOnlyList<DtoYmirSOHList>> YmirSOHList(string itemCode);

        Task<PagedList<DtoMRP>> GetMRP(UserParams userParams, string search);
        //Task<PagedList<DtoMRP>> GetMRPOrig(UserParams userParams, string search);



    }
}
