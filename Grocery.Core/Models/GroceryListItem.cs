namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId {  get; set; } //Todo done: made properties
        public int ProductId { get; set; }  //Todo done: made properties
        public int Amount { get; set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId;      //Todo done, assigned values to properties
            ProductId = productId;
            Amount = amount;
        }

        public Product Product { get; set; } // = new deleted to make sure new product does not get created every time
    }
}