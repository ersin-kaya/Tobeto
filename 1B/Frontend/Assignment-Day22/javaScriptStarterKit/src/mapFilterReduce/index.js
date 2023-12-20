// the map() method
// ----------------

let products = [
    { id: 1, name: "Acer Laptop", unitPrice: 15000 },
    { id: 2, name: "Asus Laptop", unitPrice: 16000 },
    { id: 3, name: "HP Laptop", unitPrice: 17000 },
    { id: 4, name: "Dell Laptop", unitPrice: 18000 },
    { id: 5, name: "Casper Laptop", unitPrice: 19000 },
  ];
  
  // console.log("<ul>");
  // products.map((product) => console.log(`<li>${product.name}</li>`)); // single line
  // console.log("</ul>");
  
  // products.map((product) => {
  //   // multi-line
  //   console.log(product.id);
  //   console.log(product.name);
  // });
  
  // the filter() method
  // -------------------
  // filtreleme sonrası 0 eleman bile olsa sonuç yeni bir array'dir -> []
  // bu şundan dolayı önemli: angular, react, vue içinde state management denilen bir olay var, yani bir data değiştiğinde ekran yeniden şekillenir, ekranı yeniden render ediyoruz, render edilmesi için eğer referans tipse referansın değişmesi gerekiyor. angular'da böyle değil ama ... başka bir yerde lazım oluyor...
  // filter yeni bir array oluşturuyor, yani referans değişiyor ve ekran yeniden render ediliyor, bu yüzden slice() veya splice() değil de (onlar referansı değiştirmiyor) filter() kullanıyoruz
  
  let filteredProducts = products.filter((product) => product.unitPrice >= 17000);
  console.log(filteredProducts);
  
  // the reduce() method
  // -------------------
  // reduce() akümülatör görevi görüyor
  // örneğin (sepetteki) tüm ürünlerin fiyatlarının toplamını göstermek istiyoruz...
  // acc -> accumulator
  
  let cartTotal = products.reduce((acc, product) => acc + product.unitPrice, 0);
  console.log(`Cart total: ${cartTotal}`);
  
  //
  
  let cartTotal2 = products
    .filter((p) => p.unitPrice >= 17000)
    .map((p) => {
      p.unitPrice = p.unitPrice * 1.18;
      return p;
    })
    .reduce((acc, p) => acc + p.unitPrice, 0);
  
  console.log(cartTotal2);
  