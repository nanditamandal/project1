﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Repository;

namespace SmallBusinessManagementSystem.Manager
{
    
    class PurchaseRepotingManager
    {
        PurchaseRepotingRepository _purchaseRepotingRepository= new PurchaseRepotingRepository();
        public List<PurchaseRepotingModel> SearchValue(PurchaseRepotingModel purchaseRepotingModel)
        {
            return _purchaseRepotingRepository.SearchValue(purchaseRepotingModel);

        }
    }
}
