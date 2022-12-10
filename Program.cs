// Порушено принцип SRP
class Item
{

}
class ItemListClass
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}
class Order
{
    public void PrintOrder(ItemListClass itemList) {/*...*/}
    public void ShowOrder(ItemListClass itemList) {/*...*/}
}
class TotalSum
{
    public void CalculateTotalSum(ItemListClass itemList) {/*...*/}
}
class Actions
{
    public void Load(ItemListClass itemList) {/*...*/}
    public void Save(ItemListClass itemList) {/*...*/}
    public void Update(ItemListClass itemList) {/*...*/}
    public void Delete(ItemListClass itemList) {/*...*/}
}