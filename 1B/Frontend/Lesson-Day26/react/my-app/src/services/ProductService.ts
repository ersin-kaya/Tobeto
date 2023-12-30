import axios from "axios";
import { GetAllProductsModel } from "../models/responses/GetAllProductsModel";
import { ProductModel } from "../models/responses/ProductModel";

// Bu üç nedenden dolayı istekleri servise taşıyoruz
// 1- Birden fazla noktada kullanılabilir
// 2- Sorumluluğun ui dosyası üzerinden kalkması
// 3- Ortak bir noktadan yönetebilmek için


class ProductService {
    getAll() {
        return axios.get<GetAllProductsModel>("https://dummyjson.com/products"); // burada url bir environment dosyasında çekmek daha doğru olur, url hem ortaktır hem de kodun içerisinde magic string yazmamış oluruz

        // buralarda ise ortak noktaları alıyoruz, nedir ortak noktamız? isteğin atılması.. gelen cevapla yapılacak işlemler ortak değildir..
        // burada .then vs. yazmıyoruz çünkü yapılacak işlemler sayfadan sayfaya değişebilir.. gelen cevapla yapılacak işlemler servisin işi değildir..
    }

    getById(id: number) {
        return axios.get<ProductModel>("https://dummyjson.com/products/" + id)
    }
}

export default ProductService;