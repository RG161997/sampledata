using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CreatingDatabase context)
        {
            context.Database.EnsureCreated();
            if (context.Categories.Any())
            {
                return;
            }
            var categories = new Categories[]
            {
                new Categories{categoryId=1001,categoryName="Food",description=null,picture=null},
                  new Categories{categoryId=1002,categoryName="Clothes",description=null,picture=null}
            };

            foreach(var item in categories)
            {
                context.Add(item);
            }

            if (context.Customers.Any())
            {
                return;
            }
            var customers = new Customers[]
            {
                new Customers{customerId=2001,companyName="JIO",contactTitle="Reliance",Address="27 krishna nagar",city="Mumbai",
                              postalCode=15012,country="india",phone=708877245,fax=null },
                  new Customers{customerId=2002,companyName="JIO",contactTitle="Reliance",Address="27 krishna nagar",city="Mumbai",
                              postalCode=15012,country="india",phone=708877245,fax=null },
                   new Customers{customerId=2003,companyName="JIO",contactTitle="Reliance",Address="27 krishna nagar",city="Mumbai",
                              postalCode=15012,country="india",phone=708877245,fax=null },
                    new Customers{customerId=2004,companyName="JIO",contactTitle="Reliance",Address="27 krishna nagar",city="Mumbai",
                              postalCode=15012,country="india",phone=708877245,fax=null },
                     new Customers{customerId=2005,companyName="JIO",contactTitle="Reliance",Address="27 krishna nagar",city="Mumbai",
                              postalCode=15012,country="india",phone=708877245,fax=null },
            };

            foreach (var item in customers)
            {
                context.Add(item);
            }

            var employees = new Employees[]
            {
                new Employees{employeeID=3001,lastName="Sharma", firstName ="Himani",title="Mrs",
                    titleOfCOurtesy="Engineer",birthDate="03-12-1993",hireDate="07-01-2017",
                    Address="2 green avenue",city="Delhi",region="Delhi",postalCode= 147001,
                    country ="India",homePhone= 708782492,extension=null,photo=null,notes=null,reportsTo=null,
                photoPath=null},

                new Employees{employeeID=3002,lastName="Sharma", firstName ="Himani",title="Mrs",
                    titleOfCOurtesy="Engineer",birthDate="03-12-1993",hireDate="07-01-2017",
                    Address="2 green avenue",city="Delhi",region="Delhi",postalCode= 147001,
                    country ="India",homePhone= 708782492,extension=null,photo=null,notes=null,reportsTo="3001",
                photoPath=null},

                new Employees{employeeID=3003,lastName="Sharma", firstName ="Himani",title="Mrs",
                    titleOfCOurtesy="Engineer",birthDate="03-12-1993",hireDate="07-01-2017",
                    Address="2 green avenue",city="Delhi",region="Delhi",postalCode= 147001,
                    country ="India",homePhone= 708782492,extension=null,photo=null,notes=null,reportsTo="3002",
                photoPath=null},

                new Employees{employeeID=3004,lastName="Sharma", firstName ="Himani",title="Mrs",
                    titleOfCOurtesy="Engineer",birthDate="03-12-1993",hireDate="07-01-2017",
                    Address="2 green avenue",city="Delhi",region="Delhi",postalCode= 147001,
                    country ="India",homePhone= 708782492,extension=null,photo=null,notes=null,reportsTo="3003",
                photoPath=null},

                new Employees{employeeID=3005,lastName="Sharma", firstName ="Himani",title="Mrs",
                    titleOfCOurtesy="Engineer",birthDate="03-12-1993",hireDate="07-01-2017",
                    Address="2 green avenue",city="Delhi",region="Delhi",postalCode= 147001,
                    country ="India",homePhone= 708782492,extension=null,photo=null,notes=null,reportsTo="3001",
                photoPath=null},

                
            };

            foreach (var item in employees)
            {
                context.Add(item);
            }

            if (context.Shippers.Any())
            {
                return;
            }

            var shippers = new Shippers[]
            {
                new Shippers{shipperId=4001,companyName="Jio",phone=99887766},
                new Shippers{shipperId=4002,companyName="Reliance",phone=99987766}

            };

            foreach (var item in shippers)
            {
                context.Add(item);
            }

            if (context.Suppliers.Any())
            {
                return;
            }

            var suppliers = new Suppliers[]
            {
                new Suppliers{supplierId= 7001,companyName= "Reliance", contactName="Ambani",
                    contactTitle ="Mukesh",
                   Address="Bandra", city="Mumbai",postalCode= 14389,country ="India",phone= 988776655,  homepage = null, fax = null },

                new Suppliers{supplierId= 7002,companyName= "Reliance", contactName="Ambani",
                    contactTitle ="Mukesh",
                   Address="Bandra", city="Mumbai",postalCode= 14389,country ="India",phone= 988776655,  homepage = null, fax = null }
            };

            foreach (var item in suppliers)
            {
                context.Add(item);
            }
            if (context.Regions.Any())
            {
                return;
            }
            var region = new Region[]
            {
                new Region{ regionId=9001,regionDescription="This covers all area in North"},
                new Region{ regionId=9002,regionDescription="This covers all area in South"}
            };

            foreach(var item in region)
            {
                context.Add(item);
            }


            if (context.Territories.Any())
            {
                return;
            }

            var territories = new Territories[]
            {
                new Territories{territoryId=11,territoryDescription="It covers all areas in Punjab"
                ,Region=null},

                  new Territories{territoryId=12,territoryDescription="It covers all areas in Bangalore"
                ,Region=null}

            };
            foreach(var item in territories)
            {
                context.Add(item);
            }

            var product = new Products[]
            {
                new Products{productId=5001,Suppliers=null,Categories=null,productName="Oil",unitPrice=100,
                quantitPerLabel=15,reorderLevel=0,unitsInStock=12,unitsOnOrder=0,discontinued=null},

                 new Products{productId=5002,Suppliers=null,Categories=null,productName="Jeans",unitPrice=1000,
                quantitPerLabel=20,reorderLevel=0,unitsInStock=50,unitsOnOrder=20,discontinued="No"},

                  new Products{productId=5003,Suppliers=null,Categories=null,productName="Maggie",unitPrice=100,
                quantitPerLabel=15,reorderLevel=0,unitsInStock=12,unitsOnOrder=3,discontinued=null},

                   new Products{productId=5004,Suppliers=null,Categories=null,productName="Shirt",unitPrice=1500,
                quantitPerLabel=11,reorderLevel=0,unitsInStock=14,unitsOnOrder=0,discontinued=null},

                    new Products{productId=5005,Suppliers=null,Categories=null,productName="Chips",unitPrice=50,
                quantitPerLabel=15,reorderLevel=0,unitsInStock=12,unitsOnOrder=0,discontinued=null},
            };

            foreach(var item in product)
            {
                context.Add(item);
            }

            var orders = new Orders[]
            {
                new Orders{orderId=6001,Customers=null,Employees=null,orderDate="01-11-2020",
                    requiredDate="05-11-2020",shippedDate="01-11-2020",shipVia="Blue Dart",
                    shipAddress ="Delhi",shipCity="Delhi",shipCountry="India",shipPostalCode=13425,
                shipName=null,shipRegion="North",freigth=null},

                 new Orders{orderId=6002,Customers=null,Employees=null,orderDate="01-11-2020",
                    requiredDate="05-11-2020",shippedDate="01-11-2020",shipVia="Blue Dart",
                    shipAddress ="Delhi",shipCity="Delhi",shipCountry="India",shipPostalCode=13425,
                shipName=null,shipRegion="North",freigth=null},

                  new Orders{orderId=6003,Customers=null,Employees=null,orderDate="01-11-2020",
                    requiredDate="05-11-2020",shippedDate="01-11-2020",shipVia="Blue Dart",
                    shipAddress ="Delhi",shipCity="Delhi",shipCountry="India",shipPostalCode=13425,
                    shipName=null,shipRegion="North",freigth=null},

                  new Orders{orderId=6004,Customers=null,Employees=null,orderDate="01-11-2020",
                    requiredDate="05-11-2020",shippedDate="01-11-2020",shipVia="Blue Dart",
                    shipAddress ="Delhi",shipCity="Delhi",shipCountry="India",shipPostalCode=13425,
                    shipName=null,shipRegion="North",freigth=null},

                  new Orders{orderId=6005,Customers=null,Employees=null,orderDate="01-11-2020",
                    requiredDate="05-11-2020",shippedDate="01-11-2020",shipVia="Blue Dart",
                    shipAddress ="Delhi",shipCity="Delhi",shipCountry="India",shipPostalCode=13425,
                    shipName=null,shipRegion="North",freigth=null}
            };

            foreach(var item in orders)
            {
                context.Add(item);

            }

            var orderDetails = new OrderDetails[]
            {
                new OrderDetails{Orders=null,Products=null,quantity=12,discount=5,unitPrice=10 }
            };

            foreach(var item in orderDetails)
            {
                context.Add(item);
            }

        }

    }
}
