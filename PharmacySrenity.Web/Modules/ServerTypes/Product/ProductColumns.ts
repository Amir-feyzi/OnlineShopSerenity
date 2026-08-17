import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Gender } from "../Modules/Product.Product.Gender";
import { ProductRow } from "./ProductRow";

export interface ProductColumns {
    Id: Column<ProductRow>;
    Name: Column<ProductRow>;
    Price: Column<ProductRow>;
    Description: Column<ProductRow>;
    CategoryId: Column<ProductRow>;
    CategoryName: Column<ProductRow>;
    Gender: Column<ProductRow>;
}

export class ProductColumns extends ColumnsBase<ProductRow> {
    static readonly columnsKey = 'Product.Product';
    static readonly Fields = fieldsProxy<ProductColumns>();
}

[Gender]; // referenced types