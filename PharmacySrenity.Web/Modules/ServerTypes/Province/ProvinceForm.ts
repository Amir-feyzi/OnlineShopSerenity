import { initFormType, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface ProvinceForm {
    Name: StringEditor;
}

export class ProvinceForm extends PrefixedContext {
    static readonly formKey = 'Province.Province';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProvinceForm.init) {
            ProvinceForm.init = true;

            var w0 = StringEditor;

            initFormType(ProvinceForm, [
                'Name', w0
            ]);
        }
    }
}