using Hafta1.Enums;

namespace Hafta1.Models.Base
{
    public class ModelBase
    {
        #region CTOR
        public ModelBase()
        {
            CreatedDate = DateTime.Now;
            // Id=Guid.NewGuid().ToString("D");

        }
        #endregion

        #region PROPERTIES

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public string? CreatedUser { get; set; }

        public string? UpdatedUser { get; set; }

        public string Description { get; set; }

        public StatusEnum Status { get; set; }

        #endregion

    }
}
