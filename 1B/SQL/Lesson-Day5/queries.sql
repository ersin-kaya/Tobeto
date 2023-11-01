--SQL => Structred Query Language

SELECT * from products

select * from products
where unit_price > 20 or units_in_stock>15


--IN()
--içerisine aldığı parametre olarak verilen n kadar veri
--ile ilgili alanların uyuşmasını bekler
select * from products
where LOWER(product_name) IN ('chai', 'chang', 'ikura')

select * from products
where category_id in(1,2)

--LIKE
--pattern => kalıba benzer ifadeleri getirir
--% => ilgili metnin sağına veya soluna eklendiğinde metinden önce veya sonrasında gelecek
--metni önemsemediğimi söylüyorum
-- _ => karakter atlamasını gösterir
select * from products
where product_name LIKE '%te%'

select * from products
where lower(product_name) like 'te%'

select * from products
where lower(product_name) like '__r%'



--Built-in Functions
--Summary => toplama
select sum(unit_price) from products

--Average => ortalama
select avg(unit_price) from products

--Maximum => 
select max(unit_price) from products

--Minimum =>
select min(unit_price) from products

-- Distinct => tekrar eden verileri filtreler
--kaç farklı şehirden çalışan var?
--select * from employees
select distinct city from employees

--Date
--bugünün tarihi
--interval
select current_Date as "bugünün tarihi"
--ay
select date_part('month',current_date)
--datediff(interval,date1,date2)
select first_name, datediff(year,birth_date,'1.11.2023') from employees


--son 10 gün içerisindeki siparişleri
select * from orders where
date_part('year',current_date) = date_part('year', order_date) and
date_part('month',current_date) = date_part('month', order_date) and
date_part('day', current_date) - date_part('day',order_date) < 10
--(kayıt tarihlerinde güncelleme yapmak gerekli)


--sub-query -> iç içe sorgular
--ortalamanın altında bir fiyata sahip olan ürünleri listemek istiyoruz
select avg(unit_price) from products
select product_name,unit_price from products

select product_name, unit_price from products
where unit_price < (select avg(unit_price) from products)

--en pahalı ürünün bilgilerini alalım
select max(unit_price) from products
select * from products where unit_price = 263.5

select * 
from products 
where unit_price = (select max(unit_price) from products)


--order by =>
--default => asc
--desc
--select product_name,unite_price



