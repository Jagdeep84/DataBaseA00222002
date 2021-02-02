using System;
using JagdeepDB.Contexts;
using System.Collections;
using System.Collections.Generic;
using JagdeepDB.Models;

namespace JagdeepDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context ctx = new Context())
            {
                Category category = new Category()
            {
                categoryName = "CatagoryA",
                description = "something about A"

            };
               

                Shipper shipper = new Shipper() 
            {
                companyName = "JS.CO.",
                phone = "1435431212"
                };
            Supplier supplier = new Supplier() 
            {
            companyName = "good day",
            contactName = "Davidson",
            contactTitle = "Urgent",
            Address = "U can never found me 13",
            city = "Haven",
            region = "Nobody knows",
            postalCode = "1341324ABC",
            country = "Dont know",
            phone = "1435431212"

            };
            Region region = new Region()
            {
                regionDescription = "jsjsjsj"
            };
            Product[] product = new Product[5];
            for (int i = 1; i <= 5; i++)
            {
                product[i - 1] = new Product()
                {
                    productName = "jadf" + i,
                    quantityPerLabel = 22 + i,
                    unitPrice = 23.3M + i,
                    unitsInStocks = 12 + i,
                    unitsOnOrder = 1 + i,
                    reorderLevel = 2435 + i,
                    dicounted = 121M + i
                };
                    ctx.Products.Add(product[i - 1]);
                }

            OrderDetail orderDetail = new OrderDetail()
            {
                unitPrice = 123.00M,
                quantity = 2,
                discount = 12.3M
            };
            Customer[] customer = new Customer[5];
            
                for (int i = 1; i <= 5; i++)
            {
                customer[i - 1] = new Customer()
                {
                    companyName = "weldfkj" + i,
                    contactTitle = "sadgf" + i,
                    address = "lkfdjg" + i,
                    city = "dfsgdfg" + i,
                    region = "jsadf" + i,
                    postalCode = "2452134" + i,
                    country = "naoaf" + i,
                    phone = "1435431212" + i,
                    fax = 345245 + i
                };
                    ctx.Customers.Add(customer[i - 1]);
                }
            Territory territory = new Territory()
            { 
                territoryDescription = "jajagjag"
            };
            ICollection<Territory> territoryList = new List<Territory>();
            territoryList.Add(territory);

            Employee[] employee = new Employee[5];
            for (int i = 1; i <= 5; i++)
            {
                employee[i - 1] = new Employee()
                {
                  firstName = "JS" + i,
                  lastName = "ss" + i,
                  title = "J" + i,
                  titleOfCourtesy = "just" + i,
                    address = "jadfasdf234" + i,
                    city = "jsss" + i,
                    region = "jaaaa" + i,
                    postalCode = "23423423" + i,
                    coutnry = "dfsjaf" + i,
                    homePhone = "1435431212" + i,
                    photo = "https://media2.s-nbcnews.com/j/streams/2013/March/130326/1C6639340-google-logo.nbcnews-fp-1024-512.jpg" + i,
                    notes = "jjj" +i,
                    reportTo = "anyone" + i,
                    photoPath = "https://media2.s-nbcnews.com/j/streams/2013/March/130326/1C6639340-google-logo.nbcnews-fp-1024-512.jpg" + i,
                    Territories = territoryList 
                };
                    ctx.Employees.Add(employee[i - 1]);
                }

            Order[] order = new Order[5];
            for (int i = 1; i <= 5; i++)
            {
                order[i - 1] = new Order()
                {
                    shipVia = "jjjjj" + i,
                    weight = 1.22f + i,
                    shipName = "Heaven ride" + i,
                    shipAddress = "Nobody Knows" + i,
                    shipCity = "Dumb" + i,
                    shipRegion = "no" + i,
                    shipPostalCode = "1243234" + i,
                    shipCOuntry = "jajaja" + i

                };
                    ctx.Orders.Add(order[i - 1]);

                }

                ctx.Categories.Add(category);
                ctx.Shippers.Add(shipper);
                ctx.Suppliers.Add(supplier);
                ctx.Regions.Add(region);
                ctx.OrderDetails.Add(orderDetail);
                ctx.SaveChanges();
                
            }
          
        }
    }
}
