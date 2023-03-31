using System.ComponentModel.DataAnnotations;

namespace top_shop_models
{
    public class Warehouse
    {
        public Guid Id { get; set; }
        [StringLength(100)] public string Name { get; set; }

        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; }
    }
}