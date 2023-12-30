import { ProductModel } from "./ProductModel";

export interface GetAllProductsModel {
    total: number;
    skip: number;
    limit: number; // bu alanı yazmasak bile response.data'da gelecektir sadece modellememiş olacağız
    products: ProductModel[];
}