using Hafta1.Enums;
using Hafta1.Models.Base;

namespace Hafta1.Models
{
    public class ProductModel : ModelBase
    {
        #region CTOR
        public ProductModel()
        {
            Status = StatusEnum.Active;
        }
        #endregion

        #region FIELDS


        public string ProductName { get; set; }

        public double Price { get; set; }

        public string CategoryName { get; set; }
        #endregion
    }
}
