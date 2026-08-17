import { EntityGrid, getColumns } from '@serenity-is/corelib';
import { ProvinceColumns, ProvinceRow, ProvinceService } from '../../ServerTypes/Province';
import { ProvinceDialog } from './ProvinceDialog';

export class ProvinceGrid extends EntityGrid<ProvinceRow> {
    static override [Symbol.typeInfo] = this.registerClass("PharmacySrenity.Province.");

    protected override getColumnsKey() { return ProvinceColumns.columnsKey; }
    protected override getDialogType() { return ProvinceDialog; }
    protected override getRowDefinition() { return ProvinceRow; }
    protected override getService() { return ProvinceService.baseUrl; }
    protected override getColumns() { return super.getColumns().filter(x => x.field !== ProvinceRow.Fields.Id) }
}