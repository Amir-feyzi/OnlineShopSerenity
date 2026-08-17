import { fieldsProxy } from "@serenity-is/corelib";

export interface ProvinceRow {
    Id?: number;
    Name?: string;
}

export abstract class ProvinceRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Province.Province';
    static readonly deletePermission = 'Province:Modify';
    static readonly insertPermission = 'Province:Modify';
    static readonly readPermission = 'Province:View';
    static readonly updatePermission = 'Province:Modify';

    static readonly Fields = fieldsProxy<ProvinceRow>();
}