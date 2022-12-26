using Nest;
using ObjectOrientedPrograms.Inventorymanagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using ObjectOrientedPrograms.Stock1ManagementSystem;
using ObjectOrientedPrograms.StockManagement;
using Stock = ObjectOrientedPrograms.StockManagement.Stock;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventorymanagement\Inventory.json";
        const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryManagementSystem\InventoryDetails.json";
        const string STOCKDETAILS_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\StockManagement\StockDetails.json";
        const string STOCK_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\Stock1ManagementSystem\Stock.json";
        const string COMPANY_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\Stock1ManagementSystem\Company.json";
        private static int NoOfShares;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.Inventory Management \n 2.Inventory Manangement System \n 3.Stock Management  \n 4.Stock Management System");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    case 2:
                        InventoryFactory inventoryFactory = new InventoryFactory();
                        inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                        InventoryDetails details = new InventoryDetails()

                        {
                            Name = "a",
                            Weight = 5,
                            Price = 25
                        };
                        inventoryFactory.AddInventory("WheatList", details);
                        //inventoryFactory.DeleteInventory("WheatList", "a");
                        inventoryFactory.WriteTojson(INVENTORYDETAILS_DATA_FILE_PATH);
                        break;

                    case 3:
                        //Stock stock = new Stock();
                        //stock.ReadJsonFile(STOCKDETAILS_DATA_FILE_PATH);
                        break;

                    case 4:
                        Stock1Management stockManagement = new Stock1Management();
                        stockManagement.ReadJsonFileStock(STOCK_DATA_FILE_PATH);
                        stockManagement.ReadJsonFileCompany(COMPANY_DATA_FILE_PATH);
                        Company company = new Company();
                        Stock stock = new Stock()
                        {
                            Name = "Facebook",
                            NoOfShares = 5,
                            PricePerShare = 250,
                        };
                        stockManagement.SellStockShares(stock);
                        //stockManagement.BuyCompanyShares(company);
                        stockManagement.WriteToJsonStock(STOCK_DATA_FILE_PATH);
                        stockManagement.WriteToJsoncompany(COMPANY_DATA_FILE_PATH);
                        break;



                }

            }
        }
    }
}
