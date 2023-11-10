using OOP2;

//Engin Demiroğ
//Customer customer1 = new Customer();
//customer1.FirstName = "Engin";
//customer1.LastName = "Demiroğ";
//customer1.Id = 1;
//customer1.CitizenshipNumber = "33333333333";
//customer1.CustomerNumber = "54321";
//customer1.CompanyName = "?"; //bu alan bireysel müşteri ile alakalı değil...

//Individual - Corporate //birbirlerine benziyor olsalar bile, birbirlerinin yerine kullanılamazlar çünkü bunlar farklı müşteri tipleri
//customer1.CustomerType = 1; //bu şekilde ele alınabilir ancak zamanla hatalı veri girişinden kaynaklı sorunlar ortaya çıkar o yüzden yanlıştır

//SOLID - L harfi...


//Engin Demiroğ
IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.FirstName = "Engin";
customer1.LastName = "Demiroğ";
customer1.CitizenshipNumber = "12345678910";
//anlamsız hiçbir şey olmadığı için hata yapma olasılığımız minimize oluyor


//Kodlama.io
CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "54321";
customer2.TaxNumber = "1234928734";
customer2.CompanyName = "Kodlama.io";


// new -> reference
//onların referansını tuttuğu için oluşturabiliyoruz
Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();


CustomerManager customerManager = new CustomerManager();
//onların referansını tuttuğu için parametredeki Customer yerine geçebiliyoruz
customerManager.Add(customer1);
customerManager.Add(customer2);

