using System;
using System.Collections.Generic;

namespace Ecommerce
{
    class program
    {
        static void Main(string[] args)
        {
            bool info;
            int choose = 0, loop = 1, next;
            Console.BackgroundColor = ConsoleColor.Yellow; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-------------------      E-Raquun      -------------------");
            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("\t\t      ...Sign Up... \n\t ----------------------------------------");
            Console.Write("\t\t        Id : "); string isim = Console.ReadLine();
            Console.Write("\t\t  Password : "); string sifre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\t  Account Created Successfully...\n"); System.Threading.Thread.Sleep(400);
            Console.WriteLine("\t\t ...Sign In...\n\t----------------------------------\n");
            do
            {
                Console.Write("\t           Id : ");
                string id = Console.ReadLine();
                Console.Write("\t     Password : ");
                string pass = Console.ReadLine();

                {
                    if (id == isim && pass == sifre)
                    {
                        info = true;
                        Console.Clear();
                        Console.Write("\t     Welcome " + id + " , ");
                    }
                    else
                    {
                        info = false;
                        Console.Clear();
                        Console.WriteLine("Invalid Id or Password !!!\a");
                    }
                }
            } while (!info == true);

            List<Product> products = new List<Product>();
            products.Add(new Product(100, "Shirt", "In Stock", 220, "clothing"));
            products.Add(new Product(101, "Phone", "In Stock", 11000, "elektronic"));
            products.Add(new Product(102, "Pen", "Out of Stock", 39.90, "stationary"));
            products.Add(new Product(103, "Laptop", "In Stock", 15000, "elektronic"));
            products.Add(new Product(104, "Ruler", "In Stock", 15.90, "stationary"));

            do
            {
                do
                {
                    Console.WriteLine("Select a menu : \n");
                    Console.WriteLine("\t\t(1) View Product\n\t\t--------------------\n\t\t(2) Add a Product\n\t\t--------------------\n\t\t(3) Remove a Product\n\t\t--------------------\n\t\t(4) Sign Out\n ");

                    Console.Write("\t\t  Selection => ");
                    try
                    {
                        choose = Convert.ToInt32(Console.ReadLine());
                    }
                    catch { Console.WriteLine(""); };
                    switch (choose)
                    {
                        case 1:
                            int index = 0;
                            Console.Clear();

                            Console.WriteLine("Sequence\tProduct Id\tProduct\t\tPrice\t\tStock\t\tCategory");
                            Console.WriteLine("--------\t----------\t-------\t\t-----\t\t-----------\t--------");
                            foreach (var product in products)
                            {

                                Console.WriteLine(index + "\t\t{0}\t\t{1}\t\t{3}\t\t{2}\t{4}", product.Id, product.Name, product.Stock, product.Price, product.Categ);
                                index++;
                            }
                            Console.WriteLine("\nPress (1) to return to the main menu, Press (2) to exit the application...");
                            loop = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            break;

                        case 2:
                            {
                                int productId = 104, insertNo = 4, index1 = 0;

                                do
                                {
                                    productId++; insertNo++;
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Add product information.\n\nRespectively; (Product Name), (Price) and (Category):\n");
                                        products.Insert(insertNo, new Product() { Id = productId, Name = Console.ReadLine(), Stock = "In Stock", Price = double.Parse(Console.ReadLine()), Categ = Console.ReadLine() });
                                        Console.Write("The product has been added successfully .\n");
                                        System.Threading.Thread.Sleep(1200);

                                    }

                                    catch (Exception ex)
                                    {
                                        insertNo--;
                                        productId--;
                                        Console.WriteLine("!!! The product price entered in the wrong type, please try again !!!");
                                        System.Threading.Thread.Sleep(1500);

                                    }
                                    finally
                                    {
                                        Console.Clear();
                                    }

                                    Console.Write("Press (1) to add a new product, Press (2) to view Products:  ");
                                    next = Convert.ToInt32(Console.ReadLine());

                                } while (next == 1);
                                Console.WriteLine("\nSequence\tProduct Id\tProduct\t\tPrice\t\tStock\t\tCategory");
                                Console.WriteLine("--------\t----------\t-------\t\t-----\t\t-----------\t--------");


                                foreach (var product in products)
                                {
                                    Console.WriteLine(index1 + "\t\t{0}\t\t{1}\t\t{3}\t\t{2}\t{4}", product.Id, product.Name, product.Stock, product.Price, product.Categ);
                                    index1++;
                                }
                                Console.WriteLine("\nPress (1) to return to the main menu, Press (2) to exit the application...");
                                loop = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                break;
                            }

                        case 3:
                            {
                                do
                                {
                                    int index2 = 0, index3 = 0;
                                    Console.Clear();
                                    Console.WriteLine("Sequence\tProduct Id\tProduct\t\tPrice\t\tStock\t\tCategory");
                                    Console.WriteLine("--------\t----------\t-------\t\t-----\t\t-----------\t--------");
                                    foreach (var product in products)
                                    {
                                        Console.WriteLine(index2 + "\t\t{0}\t\t{1}\t\t{3}\t\t{2}\t{4}", product.Id, product.Name, product.Stock, product.Price, product.Categ);
                                        index2++;
                                    }
                                    Console.WriteLine("\nEnter the product sequence number you want to remove:");
                                    int remove = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Products edited:\n");
                                    products.RemoveAt(remove);
                                    Console.WriteLine("Sequence\tProduct Id\tProduct\t\tPrice\t\tStock\t\tCategory");
                                    Console.WriteLine("--------\t----------\t-------\t\t-----\t\t-----------\t--------");
                                    foreach (var product in products)
                                    {
                                        Console.WriteLine(index3 + "\t\t{0}\t\t{1}\t\t{3}\t\t{2}\t{4}", product.Id, product.Name, product.Stock, product.Price, product.Categ);
                                        index3++;
                                    }
                                    Console.WriteLine("\nPress (1) to remove another product, Press (2) return to the Main menu:  ");
                                    next = int.Parse(Console.ReadLine());
                                } while (next == 1);
                                if (next == 2)
                                    Console.WriteLine("Redirecting to main menu..");
                                else
                                    loop = 2;
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("...Signed out successfully...\a");
                                loop = 2;
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("!!!  Incorrect menu selection, try again    !!!\n \a ");
                                break;
                            }
                    }
                } while (choose >= 5);
            } while (loop == 1);
            Console.WriteLine(" ...Application Terminated...");
        }
    }

    public class Product
    {
        public Product() { }

        public Product(int id, string name, string stock, double price, string categ)
        {
            this.Id = id;
            this.Name = name;
            this.Stock = stock;
            this.Price = price;
            this.Categ = categ;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public double Price { get; set; }
        public string Categ { get; set; }
    }
}
