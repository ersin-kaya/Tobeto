--join
--hangi ürün hangi kategoride
select p.product_name, c.category_name
from products p
inner join categories c
on p.category_id = c.category_id

--hangi sipariş hangi kargo şirketi ile ne zaman gönderilmiş
select o.order_id, s.company_name, o.order_date
from orders o 
inner join shippers s
on o.ship_via = s.shipper_id

--hangi siparişi, hangi çalışan, hangi müşteri vermiştir?
--orders, employees, customers
select concat(e.first_name, ' ', e.last_name) as "Ad Soyad", o.order_id, c.company_name
from employees e
inner join orders o
on o.employee_id = e.employee_id
inner join customers c
on o.customer_id = c.customer_id

--sipariş alan çalışanlarım listeleniyor
select e.first_name || ' ' || e.last_name as "Ad Soyad", o.order_id, o.order_date   
from employees e
left join orders o
on e.employee_id = o.employee_id

select e.first_name || ' ' || e.last_name as "Ad Soyad", o.order_id, o.order_date   
from orders o
right join employees e
on e.employee_id = o.employee_id

select e.first_name || ' ' || e.last_name as "Ad Soyad", o.order_id, o.order_date   
from employees e
right join orders o
on e.employee_id = o.employee_id

--sorgumuzda tüm müşteriler ve verdikleri siparişlerin tarihleri listelensin
select c.company_name, o.order_date
from customers c
left join orders o
on c.customer_id = o.customer_id
order by order_date desc

--group by
--belirtilen sütun ya da sütunlardaki aynı değere sahip satırları gruplandırır

--sipariş detayları tablosundan product_id alanına göre gruplandıralım ve
--her grubun toplam sipariş miktarını belirterek listeleyelim
select product_id, sum(quantity)
from order_details
group by product_id

--hangi kategoride toplam kaç ürün var?
select c.category_name, count(p.category_id)
from products p
inner join categories c
on p.category_id = c.category_id
group by c.category_name

--hangi ülkeye ne kadarlık satış yapılmıştır?
select * from orders
select * from order_details

select o.ship_country, sum(od.quantity * od.unit_price)
from orders o
inner join order_details od
on o.order_id = od.order_id
group by o.ship_country
order by o.ship_country

--having
--toplam sipariş miktarı 1300 adetten fazla olan ürün kodlarını listeleyelim
select product_id, sum(quantity) as total_quantity
from order_details od
group by product_id
having sum(quantity) > 1300

--stok sayısı 20'den fazla toplam ürün sayısı'da 1'den fazla 
--olan kategoriler
select category_id, units_in_stock, count(*)
from products
where units_in_stock > 20
group by category_id, units_in_stock
having count(*) > 1

--içerisinde en az 10 ürün olan kategorilerin ürün sayısı
select * from orders
select * from order_details
select * from products
select * from categories

select category_name, count(*) as "Kategorideki ürün sayısı"
from products
inner join categories
on categories.category_id = products.category_id
group by category_name
having count(*) >= 10


--1000 adetten fazla satılan ürünler
select od.product_id, sum(quantity)
from order_details od
group by od.product_id
having sum(quantity) > 1000
order by od.product_id


--order by'da kullandığımız kolon ya group by'da bulunacak,
--veya order by'da aggregate functions kullanacağız, diyebilir miyiz?
select product_name, sum(quantity) as "Toplam Sipariş Miktarı" 
from order_details as od
inner join products as p on od.product_id = p.product_id
group by product_name, quantity
having sum(quantity) > 250
order by quantity asc
