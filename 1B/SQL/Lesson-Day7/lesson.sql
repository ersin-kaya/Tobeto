--Exists - not exists
select company_name
from suppliers
where exists (select product_name
			  from products
			  where products.supplier_id = suppliers.supplier_id
			  and unit_price < 20)
			  
--iki tarih arasında sipariş almış çalışanları listeleyelim
select e.employee_id, e.first_name, e.last_name
from employees e
where exists (select *
			  from orders o
			  where e.employee_id = o.employee_id
			  and o.order_date between '3/5/1998' and '4/5/1998')
	

--All
--tüm alt sorgu değerleri koşulumuzu sağlıyorsa => true --and operatörüne benzetebiliriz
select product_name
from products
where product_id = all(select distinct product_id
						from order_details
						where quantity = 10)
			
			
--Any
--alt sorgu değerlerinden herhangi biri koşulu sağlıyorsa => true --or operatörüne benzer
select product_name
from products
where product_id = any(select distinct product_id
						from order_details
						where quantity > 99)
			  
			  