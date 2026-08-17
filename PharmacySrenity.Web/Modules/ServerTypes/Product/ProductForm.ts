import { DecimalEditor, EnumEditor, initFormType, LookupEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";
import { Gender } from "../Modules/Product.Product.Gender";

export interface ProductForm {
    Name: StringEditor;
    Price: DecimalEditor;
    Description: StringEditor;
    CategoryId: LookupEditor;
    Gender: EnumEditor;
}

export class ProductForm extends PrefixedContext {
    static readonly formKey = 'Product.Product';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductForm.init) {
            ProductForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = LookupEditor;
            var w3 = EnumEditor;

            initFormType(ProductForm, [
                'Name', w0,
                'Price', w1,
                'Description', w0,
                'CategoryId', w2,
                'Gender', w3
            ]);
        }
    }
}

[Gender]; // referenced types