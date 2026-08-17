import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProvinceRow } from "./ProvinceRow";

export interface ProvinceColumns {
    Id: Column<ProvinceRow>;
    Name: Column<ProvinceRow>;
}

export class ProvinceColumns extends ColumnsBase<ProvinceRow> {
    static readonly columnsKey = 'Province.Province';
    static readonly Fields = fieldsProxy<ProvinceColumns>();
}