import { fieldsProxy } from "@serenity-is/corelib";
import { Gender } from "../Modules/Product.Product.Gender";

export interface ProductRow {
    Id?: number;
    Name?: string;
    Price?: number;
    Description?: string;
    CategoryId?: string;
    CategoryName?: string;
    Gender?: Gender;
}

export abstract class ProductRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Product.Product';
    static readonly deletePermission = 'Product:Modify';
    static readonly insertPermission = 'Product:Modify';
    static readonly readPermission = 'Product:View';
    static readonly updatePermission = 'Product:Modify';

    static readonly Fields = fieldsProxy<ProductRow>();
}