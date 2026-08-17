import { EntityGrid } from '@serenity-is/corelib';
import { ProductColumns, ProductRow, ProductService } from '../../ServerTypes/Product';
import { ProductDialog } from './ProductDialog';

export class ProductGrid extends EntityGrid<ProductRow> {
    static override[Symbol.typeInfo] = this.registerClass("PharmacySrenity.Product.");

    protected override getColumnsKey() { return ProductColumns.columnsKey; }
    protected override getDialogType() { return ProductDialog; }
    protected override getRowDefinition() { return ProductRow; }
    protected override getService() { return ProductService.baseUrl; }

    protected override getColumns() {
        return super.getColumns().filter(x => x.field !== ProductRow.Fields.Id)
    }
    
}