using KickOff.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KickOff.Models
{
    public static class CustomerViewModelMapper
    {
        public static CustomerModelView ToViewModel(this Customer entity)
        {
            return entity == null ? null : new CustomerModelView
            {
                Id = entity.Id,
                CustomerName = entity.CustomerName,
                CustomerCategory = entity.CustomerCategory,
                Status = entity.CustStatus,
                CustomerCreationDate = entity.CustomerCreationDate,
                CustomerModificationDate = entity.CustomerModificationDate
            };
        }

        public static Customer ToEntity(this CustomerModelView viewModel)
        {
            return viewModel == null ? null : new Customer
            {
                CustomerName = viewModel.CustomerName,
                CustomerCategory = viewModel.CustomerCategory,
                CustStatus = viewModel.Status,
                CustomerCreationDate = viewModel.CustomerCreationDate,
                CustomerModificationDate = viewModel.CustomerModificationDate
            };
        }
    }
}