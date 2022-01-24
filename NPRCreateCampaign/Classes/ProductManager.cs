using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPRCreateCampaign.Classes
{
    public class ProductManager
    {
        public static Product CreateProduct(dynamic productData)
        {
            Product newProduct = new Product();
            newProduct.product = productData.product;
            newProduct.compName = productData.compName;
            newProduct.productCount = productData.productCount;
            newProduct.price = productData.price;

            return newProduct;
        }
    }
}
