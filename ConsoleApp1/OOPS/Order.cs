using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Order
    {
        int order1;
        string orderdate;
        Customer cust;

        public Order()
        {

        }
        public Order(int order1, string orderdate, Customer cust)
        {
            this.order1 = order1;
            this.orderdate = orderdate;
            this.cust = cust;


        }
        public int Order1
        {
            set { order1 = value; }
            get { return order1; }
        }
        public string Orderdate
        {
            set { orderdate = value; }
            get { return orderdate; }
        }
        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }

    }
    class Customer
    {
        int custid;
        string custname;
        Address address;
        public Customer()
        {

        }
        public Customer(int custid, string custname, Address address)
        {
            this.custid = custid;
            this.custname = custname;
            this.address = address;
        }
        public int Custid
        {
            set { custid = value; }
            get { return custid; }
        }
        public string Custname
        {
            set { custname = value; }
            get { return custname; }
        }
        public Address Address1
        {
            set { address = value; }
            get { return address; }
        }
    }
    class Address
    {
        String addr1, city;
        int pincode;
        public Address()
        {

        }
        public Address(string addr1, int pincode)
        {
            this.addr1 = addr1;
            this.pincode = pincode;
        }
        public string Addr1
        {
            set { addr1 = value; }
            get { return addr1; }
        }

        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }

    } 
            class Item
            {
                int itemid;
                string itemname;
                int price;
                public Item()
                {

                }
                public Item(int itemid,string itemname,int price)
                {
                    this.itemid = itemid;
                    this.itemname = itemname;
                    this.price = price;
                }
                public int Itemid
                {
                    set { itemid = value; }
                    get { return itemid; }
                }
                public string Itemname
                {
                    set { itemname = value; }
                    get { return itemname; }
                }
                public int Price
                {
                    set { price = value; }
                    get { return price; }
                }

            
            static void Main(string[] args)
            {
                    Order o = new Order(1, "02/09/2022", (new Customer(21, "Rohini", (new Address("Nashik", 422009)))));
                    Console.WriteLine(o.Order1);
                    Console.WriteLine(o.Cust.Custname);
                    Console.WriteLine(o.Cust.Address1.City);
            }
        
        
        }


            
    
}
