using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    //===========================================
    //Порушено принцип Single Responsibility Principle
    //Клас Order виконує занадто багато різних функцій, 
    //таких як робота з елементами замовлення, розрахунок суми,
    //виведення на екран, збереження/видалення/завантаженн/оновлення.
    //Щоб виправти, треба розділити на декілька різних класів
    //===========================================
    class Item
    {

    }
    class Order
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

        public void CalculateTotalSum() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class OrderPrinter
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }

    class OrderManager
    {
        public void GetItems(Order order) {/*...*/}
        public void GetItemCount(Order order) {/*...*/}
    }

    class OrderFileManager
    {
        public void Load(Order order) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }


    class Program
    {
        static void Main()
        {
        }
    }
}
