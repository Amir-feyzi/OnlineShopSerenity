import { EntityDialog } from '@serenity-is/corelib';
import { ProvinceForm, ProvinceRow, ProvinceService } from '../../ServerTypes/Province';

export class ProvinceDialog extends EntityDialog<ProvinceRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("PharmacySrenity.Province.");

    protected override getFormKey() { return ProvinceForm.formKey; }
    protected override getRowDefinition() { return ProvinceRow; }
    protected override getService() { return ProvinceService.baseUrl; }

    protected form = new ProvinceForm(this.idPrefix);
}