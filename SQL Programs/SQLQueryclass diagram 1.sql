create table store (store_id int primary key,store_name varchar(20),phone int,email varchar(20),street varchar(20),city varchar(20),state varchar(20),zipcode int)
insert into store values(11,'aadinath',76786543,'adi@gmail.com','bandra','mumbai','MH',776890) 
insert into store values(13,'shrinath',76586543,'shri@gmail.com','shukravari','nagpur','MH',453290)

create table brands (brand_id int primary key,brand_name varchar(20))
insert into brands values(121,'shrishivam')
insert into brands values(122,'ashishnx')


create table categories (category_id int primary key,category_name varchar(20))
insert into categories values(131,'electronics')
insert into categories values(132,'furniture')



create table products (product_id int primary key,product_name varchar(20),brand_id int,category_id int, 
model_year int, list_price int,
constraint P1 foreign key(brand_id) references brands(brand_id),
constraint P2 foreign key(category_id) references categories(category_id))

insert into products values(141,'maggi',121,131,2019,3456)
insert into products values(142,'yipee',122,132,2020,5423)
----------------------------------------------------------------


create table stocks (store_id int,product_id int,quantity int,
constraint s1 foreign key(store_id) references store(store_id),
constraint s2 foreign key(product_id) references products(product_id))

insert into stocks values(11,141,1345)
insert into stocks values(13,142,1234)


create table customer (customer_id int primary key,first_name varchar(20),last_name varchar(20),phone int,email varchar(20),street varchar(20),city varchar(20),state varchar(20),zipcode int)
insert into customer values(1,'adi','nath',9876789,'adi1@gmail.com','shaniwarwada','pune','MH',996890) 
insert into customer values(2,'shree','nath',76686543,'shri1@gmail.com','mangalwari','nagpur','MH',883290)




create table staffs (staff_id int primary key,first_name varchar(20),last_name varchar(20),phone int,
email varchar(20),active varchar(20),store_id int,manager_id int,
constraint s3 foreign key(store_id) references store(store_id))
insert into staffs values(19,'aditya','thakre',0076789,'adi11@gmail.com','yes',11,145) 
insert into staffs values(20,'shreeji','nakade',66686543,'shri11@gmail.com','no',13,146)


---------------------------------------------------------------------------

create table orders (order_id int primary key,customer_id int,order_status varchar(20),order_date varchar(20),
required_date varchar(20),shipped_date varchar(20),store_id int,staff_id int,
constraint o1 foreign key(customer_id) references customer(customer_id),
constraint o2 foreign key(store_id) references store(store_id),
constraint o3 foreign key(staff_id) references staffs(staff_id))

insert into orders values(31,1,'pending','22/4/22','03/05/22','09/07/23',11,19) 
insert into orders values(32,2,'delivered','21/6/22','03/06/23','09/08/22',13,20)





create table order_items (order_id int,item_id int primary key,product_id int,quantity int,list_price int,discount int
constraint O12 foreign key(order_id) references orders(order_id),
constraint O13 foreign key(product_id) references products(product_id))

insert into order_items values(31,198,141,34,34556,10) 
insert into order_items values(32,123,142,76,98789,12)



select * from store
select * from brands
select * from categories
select * from products
select * from stocks
select * from customer
select * from staffs
select * from orders
select * from order_items

