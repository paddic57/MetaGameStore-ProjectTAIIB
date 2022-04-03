using IBusinessLayer;
using Models.Models;
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
        private readonly UnitOfWork unitOfWork;
        public BLProductGame(UnitOfWork unitOfWork)
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
