import { EntityGrid } from '@serenity-is/corelib';
import { CategoryColumns, CategoryRow, CategoryService } from '../../ServerTypes/Category';
import { CategoryDialog } from './CategoryDialog';

export class CategoryGrid extends EntityGrid<CategoryRow> {
    static override [Symbol.typeInfo] = this.registerClass("PharmacySrenity.Category.");

    protected override getColumnsKey() { return CategoryColumns.columnsKey; }
    protected override getDialogType() { return CategoryDialog; }
    protected override getRowDefinition() { return CategoryRow; }
    protected override getService() { return CategoryService.baseUrl; }
    
    protected override getColumns() {
        return super.getColumns().filter(x => x.field !== CategoryRow.Fields.Id)
    }
}