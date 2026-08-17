import { initFormType, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface CategoryForm {
    Name: StringEditor;
}

export class CategoryForm extends PrefixedContext {
    static readonly formKey = 'Category.Category';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoryForm.init) {
            CategoryForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoryForm, [
                'Name', w0
            ]);
        }
    }
}