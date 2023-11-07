--26. Stokta bulunmayan ürünlerin ürün listesiyle birlikte tedarikçilerin ismi ve iletişim numarasını (`ProductID`, `ProductName`, `CompanyName`, `Phone`) almak için bir sorgu yazın.
select product_id, product_name, company_name, phone 
from products p
inner join suppliers s 
on p.supplier_id = s.supplier_id
where units_in_stock = 0

--27. 1998 yılı mart ayındaki siparişlerimin adresi, siparişi alan çalışanın adı, çalışanın soyadı
select ship_address, concat(first_name, ' ', last_name) as "Ad Soyad"
from orders o
inner join employees e
on e.employee_id = o.employee_id
where date_part('year', o.order_date) = 1998 
and date_part('month', o.order_date) = 3

--28. 1997 yılı şubat ayında kaç siparişim var?
select count(*)
from orders o
where date_part('year', o.order_date) = 1997 
and date_part('month', o.order_date) = 2

--29. London şehrinden 1998 yılında kaç siparişim var?
select count(*)
from orders o
where date_part('year', o.order_date) = 1998
and ship_city='London'

--30. 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası
select c.contact_name, c.phone
from orders o
inner join customers c
on o.customer_id = c.customer_id
where date_part('year', o.order_date) = 1997
group by c.contact_name, c.phone

--31. Taşıma ücreti 40 üzeri olan siparişlerim
select *
from orders
where freight > 40

--32. Taşıma ücreti 40 ve üzeri olan siparişlerimin şehri, müşterisinin adı
select o.ship_city, c.contact_name
from orders o
inner join customers c
on o.customer_id = c.customer_id
where freight > 40
group by o.ship_city, c.contact_name

--33. 1997 yılında verilen siparişlerin tarihi, şehri, çalışan adı -soyadı ( ad soyad birleşik olacak ve büyük harf),
select order_date, ship_city, concat(upper(first_name), ' ',  upper(last_name))
from orders o
inner join employees e
on o.employee_id = e.employee_id
where date_part('year', o.order_date) = 1997

--34. 1997 yılında sipariş veren müşterilerin contactname i, ve telefon numaraları ( telefon formatı 2223322 gibi olmalı )
select contact_name, regexp_replace(c.Phone, '[^\d]', '', 'g')
from customers c
inner join orders o
on c.customer_id = o.customer_id
where date_part('year', o.order_date) = 1997
group by contact_name, phone

--35. Sipariş tarihi, müşteri contact name, çalışan ad, çalışan soyad
select o.order_date, c.contact_name, concat(e.first_name, ' ', e.last_name) as "Çalışan Ad Soyad"
from orders o
inner join customers c
on c.customer_id = o.customer_id
inner join employees e
on o.employee_id = e.employee_id

--36. Geciken siparişlerim?
select *
from orders
where shipped_date > required_date

--37. Geciken siparişlerimin tarihi, müşterisinin adı
select order_date, c.contact_name
from orders o
inner join customers c
on o.customer_id = c.customer_id
where o.shipped_date > o.required_date

--38. 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi
select p.product_name, c.category_name, od.quantity 
from order_details od
inner join products p 
on od.product_id = p.product_id
inner join categories c 
on p.category_id = c.category_id
where od.order_id = 10248

--39. 10248 nolu siparişin ürünlerinin adı , tedarikçi adı
select p.product_name, s.company_name 
from order_details od
inner join products p 
on od.product_id = p.product_id
inner join suppliers s 
on p.supplier_id = s.supplier_id
where od.order_id = 10248

--40. 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti
select p.product_name, sum(od.quantity)
from orders o 
inner join order_details od 
on o.order_id = od.order_id
inner join products p 
on od.product_id = p.product_id
where o.employee_id = 3 
and date_part('year', o.order_date) = 1997
group by p.product_id

--41. 1997 yılında bir defasinda en çok satış yapan çalışanımın ID, Ad soyad
--tek siparişte en fazla ciroyu elde eden çalışanı ele alırsak..

--test: orders tablosu gruplandıysa select ifadesine
--group by'da olmayan
--diğer kolonlarını yazabiliyor muyuz...??? (postgresql buna izin veriyor galiba...)
select e.employee_id, 
concat(e.first_name, ' ', e.last_name) as "Ad Soyad",
count(*) as "Toplam Sipariş Sayısı"
from employees e
inner join orders o
on o.employee_id = e.employee_id
where e.employee_id = (select o.employee_id
						from orders o
						inner join order_details od
						on o.order_id = od.order_id
					    where date_part('year', o.order_date) = 1997
						group by o.order_id
						order by sum((od.unit_price * od.quantity * (1 - od.discount))) desc
						limit 1)
group by e.employee_id

--42. 1997 yılında en çok satış yapan çalışanımın ID, Ad soyad ****
--ürün adedine göre
select e.employee_id, concat(e.first_name, ' ', e.last_name) as "Çalışan Ad Soyad"
from employees e
where e.employee_id = (select o.employee_id
						from orders o
						inner join order_details od on o.order_id = od.order_id
						where date_part('year', o.Order_Date) = 1997
						group by o.employee_id
						order by sum(od.quantity) desc
						limit 1);

--43. En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?
select p.product_name, p.unit_price, c.category_name
from products p
inner join categories c
on p.category_id = c.category_id
order by p.unit_price desc
limit 1
--where p.unit_price = (select max(unit_price) from products)

--44. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre
select concat(e.first_name, ' ', e.last_name) as "Ad Soyad", 
o.order_date, o.order_id
from orders o
inner join employees e
on o.employee_id = e.employee_id
order by o.order_date

--45. SON 5 siparişimin ortalama fiyatı ve orderid nedir?
select avg(od.unit_price * od.quantity * (1 - od.discount)) as Average,
od.order_id
from order_details od
inner join products p
on od.product_id = p.product_id
group by od.order_id
order by od.order_id desc
limit 5

--son 5 siparişin toplam tutarının ortalaması
select avg(total)
from (select sum(od.quantity * od.unit_price * (1 - od.discount)) as total, od.order_id
		from order_details od
		where od.order_id in (select o.order_id
							  from orders o
							  order by o.order_date desc
							  limit 5)
		group by od.order_id)

--46. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?
 select p.product_name, c.category_name, sum(od.quantity) as ToplamSatisMiktari
 from orders o
 inner join order_details od
 on o.order_id = od.order_id
 inner join products p
 on p.product_id = od.product_id
 inner join categories c
 on c.category_id = p.category_id
 where date_part('month', o.order_date) = 1
 group by p.product_id, p.product_name, c.category_name
 order by ToplamSatisMiktari desc

--47. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?
select *
from orders
where order_id in(select o.order_id
					from orders o
					inner join order_details od
					on o.order_id = od.order_id
					group by o.order_id
					having sum(od.quantity) > (select (sum(total_quantity_by_order) / count(*)) as average
												from  (select o.order_id, sum(od.quantity) as total_quantity_by_order
														from orders o
														inner join order_details od
														on o.order_id = od.order_id
														group by o.order_id)))

--48. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı
select p.product_name, c.category_name, s.company_name
from order_details od
inner join products p
on p.product_id = od. product_id
inner join categories c
on c.category_id = p.category_id
inner join suppliers s
on s.supplier_id = p.supplier_id
group by p.product_id, p.product_name, c.category_name, s.company_name
order by sum(od.quantity) desc
limit 1

--49. Kaç ülkeden müşterim var
select count(distinct country)
from customers

--50. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?
select sum((od.unit_price * od.quantity * (1 - od.discount))) as TotalPrice 
from employees as e
inner join orders as o
on o.employee_id = e.employee_id
inner join order_details as od
on od.order_id = o.order_id
where e.employee_id = 3
and o.order_date <= now()
and o.order_date >= (select order_date
					 from orders
					 where date_part('month', order_date) = 1
					 and employee_id = 3
					 order by date_part('year', order_date) desc, date_part('day', order_date) asc
					 limit 1)

 ------------
 select sum(od.quantity * od.unit_price * (1 - od.discount)) as "Total Price"
 from order_details od
 inner join orders o
 on o.order_id = od.order_id
 inner join employees e
 on o.employee_id = e.employee_id
 where e.employee_id = 3
 and o.order_date >= make_date(cast((select date_part('year', order_date)
									 from orders
									 where date_part('month', order_date) = 1
									 and employee_id = 3
									 order by order_date desc
									 limit 1) as integer), --year
					   			1, --month
					   			1) --day
					
 --tarihi koşulunu aşağıdaki şekilde kullanınca hatalı sonuç dönüyor
 --and date_part('day', o.order_date) >= 1
 --and date_part('month', o.order_date) >= 5
 --and date_part('year', o.order_date) >= (select date_part('year', order_date)
										 --from orders
										 --where date_part('month', order_date) = 5
										 --and employee_id = 3
										 --order by order_date asc
										 --limit 1)
										 
										 
 --select o.*
 --from employees e
 --inner join orders o
 --on e.employee_id = o.employee_id
 --where e.employee_id = 3
 --and o.order_date = '1998-04-14'
 --order by o.order_id desc

 select make_date(cast((select date_part('year', order_date)
					 from orders
					 where date_part('month', order_date) = 5
					 and employee_id = 3
					 order by order_date asc
					 limit 1) as integer),
				5,
				1)

--51. 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi
select p.product_name, c.category_name, od.quantity 
from order_details od
inner join products p 
on od.product_id = p.product_id
inner join categories c 
on p.category_id = c.category_id
where od.order_id = 10248

--52. 10248 nolu siparişin ürünlerinin adı, tedarikçi adı
select p.product_name, s.company_name 
from order_details od
inner join products p 
on od.product_id = p.product_id
inner join suppliers s 
on p.supplier_id = s.supplier_id
where od.order_id = 10248

--53. 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti
select p.product_name, sum(od.quantity) as quantity
from orders o 
inner join order_details od 
on o.order_id = od.order_id
inner join products p 
on od.product_id = p.product_id
where o.employee_id = 3 
and date_part('year', o.order_date) = 1997
group by p.product_id

--54. 1997 yılında bir defasinda en çok satış yapan çalışanımın ID,Ad soyad
--ürün adedini baz alırsak..
select e.employee_id, concat(first_name, ' ', last_name)
from orders
inner join employees e
on orders.employee_id = e.employee_id
where order_id = (select od.order_id
				 from order_details od
				 inner join orders o
				 on o.order_id = od.order_id
				 where date_part('year', o.order_date) = 1997
				 group by od.order_id
				 order by sum(quantity) desc
				 limit 1)
	 
--55. 1997 yılında en çok satış yapan çalışanımın ID,Ad soyad ****
--satış tutarına göre
select e.employee_id, concat(e.first_name, ' ', e.last_name) as "Çalışan Ad Soyad"
from employees e
where e.employee_id = (select o.employee_id
						from orders o
						inner join order_details od on o.order_id = od.order_id
						where date_part('year', o.Order_Date) = 1997
						group by o.employee_id
						order by sum(od.quantity * od.unit_price * (1 - od.discount)) desc
						limit 1)
						
--56. En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?
select p.product_name, p.unit_price, c.category_name
from products p
inner join categories c
on p.category_id = c.category_id
order by p.unit_price desc
limit 1
--where p.unit_price = (select max(unit_price) from products)

--57. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre
select e.first_name, e.last_name, o.order_date, o.order_id
from orders o
inner join employees e
on o.employee_id = e.employee_id
order by o.order_date

--58. SON 5 siparişimin ortalama fiyatı ve orderid nedir?
select avg(od.unit_price * od.quantity * (1 - od.discount)) as Average,
od.order_id
from order_details od
inner join products p
on od.product_id = p.product_id
group by od.order_id
order by od.order_id desc
limit 5

--son 5 siparişin toplam tutarının ortalaması
select avg(total)
from (select sum(od.quantity * od.unit_price * (1 - od.discount)) as total, od.order_id
		from order_details od
		where od.order_id in (select o.order_id
							  from orders o
							  order by o.order_date desc
							  limit 5)
		group by od.order_id)
		
--59. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?
 select p.product_name, c.category_name, sum(od.quantity) as ToplamSatisMiktari
 from orders o
 inner join order_details od
 on o.order_id = od.order_id
 inner join products p
 on p.product_id = od.product_id
 inner join categories c
 on c.category_id = p.category_id
 where date_part('month', o.order_date) = 1
 group by p.product_id, p.product_name, c.category_name
 order by ToplamSatisMiktari desc
 
--60. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?
select *
from orders
where order_id in(select o.order_id
					from orders o
					inner join order_details od
					on o.order_id = od.order_id
					group by o.order_id
					having sum(od.quantity) > (select (sum(total_quantity_by_order) / count(*)) as average
												from  (select o.order_id, sum(od.quantity) as total_quantity_by_order
														from orders o
														inner join order_details od
														on o.order_id = od.order_id
														group by o.order_id)))

--61. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı
select p.product_name, c.category_name, s.company_name
from order_details od
inner join products p
on p.product_id = od. product_id
inner join categories c
on c.category_id = p.category_id
inner join suppliers s
on s.supplier_id = p.supplier_id
group by od.product_id, p.product_name, c.category_name, s.company_name
order by sum(od.quantity) desc
limit 1

--62. Kaç ülkeden müşterim var
select count(distinct country)
from customers

--63. Hangi ülkeden kaç müşterimiz var
select country, count(*)
from customers
group by country

--64. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?
 select sum(od.quantity * od.unit_price * (1 - od.discount)) as "Total Price"
 from order_details od
 inner join orders o
 on o.order_id = od.order_id
 inner join employees e
 on o.employee_id = e.employee_id
 where e.employee_id = 3
 and date_part('month', o.Order_Date) >= 1
 and date_part('year', o.Order_Date) >= (select date_part('year', order_date)
										 from orders
										 where date_part('month', order_date) = 1
										 order by order_date desc
										 limit 1)

--65. 10 numaralı ID ye sahip ürünümden son 3 ayda ne kadarlık ciro sağladım?
select sum(unit_price * quantity * (1 - discount))
from order_details
where product_id = 10
group by product_id

--66. Hangi çalışan şimdiye kadar toplam kaç sipariş almış..?
select employee_id, count(*)
from orders
group by employee_id

--67. 91 müşterim var. Sadece 89’u sipariş vermiş. Sipariş vermeyen 2 kişiyi bulun
select c.*, o.*
from customers c
left join orders o
on c.customer_id = o.customer_id
where order_id is null
order by c.customer_id

select c.*
from orders o
right join customers c
on c.customer_id = o.customer_id
where o.order_id is null
order by c.customer_id

--68. Brazil’de bulunan müşterilerin Şirket Adı, TemsilciAdi, Adres, Şehir, Ülke bilgileri
select company_name, contact_name, address, city, country
from customers
where country = 'Brazil'

--69. Brezilya’da olmayan müşteriler
select * 
from customers 
where country != 'Brazil'

--70. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler
select *
from customers
where country in ('Spain', 'France', 'Germany')

--71. Faks numarasını bilmediğim müşteriler
select *
from customers
where fax is null

--72. Londra’da ya da Paris’de bulunan müşterilerim
select *
from customers
where city in ('London', 'Paris')

--73. Hem Mexico D.F’da ikamet eden HEM DE ContactTitle bilgisi ‘owner’ olan müşteriler
select *
from customers
where city = 'México D.F.'
and contact_title='Owner'

--74. C ile başlayan ürünlerimin isimleri ve fiyatları
select product_name, unit_price 
from products
where product_name like 'C%' --case sensitive

--75. Adı (FirstName) ‘A’ harfiyle başlayan çalışanların (Employees); Ad, Soyad ve Doğum Tarihleri
select first_name, last_name, birth_date
from employees
where first_name like 'A%'

--76. İsminde ‘RESTAURANT’ geçen müşterilerimin şirket adları
select company_name
from customers
where upper(company_name) like '%RESTAURANT%'
--where company_name like '%RESTAURANT%'

--77. 50$ ile 100$ arasında bulunan tüm ürünlerin adları ve fiyatları
select product_name, unit_price
from products
where unit_price between 50 and 100

--78. 1 temmuz 1996 ile 31 Aralık 1996 tarihleri arasındaki siparişlerin (Orders), SiparişID (OrderID) ve SiparişTarihi (OrderDate) bilgileri
select order_id, order_date
from orders
where order_date between '1996-7-1' and '1996-12-31'
order by order_date

--79. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler
select *
from customers
where country in ('Spain', 'France', 'Germany')

select *
from customers
where country = 'Germany' 
or country = 'Spain' 
or country = 'France'

--80. Faks numarasını bilmediğim müşteriler
select *
from customers
where fax is null

--81. Müşterilerimi ülkeye göre sıralıyorum:
select *
from customers
order by country

--82. Ürünlerimi en pahalıdan en ucuza doğru sıralama, sonuç olarak ürün adı ve fiyatını istiyoruz
select product_name, unit_price 
from products
order by unit_price desc

--83. Ürünlerimi en pahalıdan en ucuza doğru sıralasın, ama stoklarını küçükten-büyüğe doğru göstersin sonuç olarak ürün adı ve fiyatını istiyoruz
select product_name, unit_price, units_in_stock
from products
order by unit_price desc, units_in_stock asc

--84. 1 Numaralı kategoride kaç ürün vardır..?
select count(*)
from products
where category_id = 1

--85. Kaç farklı ülkeye ihracat yapıyorum..?
select count(distinct ship_country)
from orders
