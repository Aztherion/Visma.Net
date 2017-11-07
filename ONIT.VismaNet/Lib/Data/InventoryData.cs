﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ONIT.VismaNetApi.Models;

namespace ONIT.VismaNetApi.Lib.Data
{
    public class InventoryData : BaseCrudDataClass<Inventory>
    {
        public InventoryData(VismaNetAuthorization auth) : base(auth)
        {
            ApiControllerUri = VismaNetControllers.Inventory;
        }

        public async Task<List<InventorySummary>> InventorySummary(string entityNumber)
        {
            return await VismaNetApiHelper.FetchInventorySummaryForItem(entityNumber, Authorization);
        }
    }
}