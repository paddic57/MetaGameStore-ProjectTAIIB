using IBusinessLayer;
using IRepositories;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLProductGame : IProductGame
    {
        private readonly IUnitOfWork unitOfWork;
        public BLProductGame(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public ProductGame getByProductId(int productId)
        {
            if (productId < 0)
                throw new ArgumentException("Invalid product id");
            return unitOfWork.productGame.getByProductId(productId);
        }
    }
}
