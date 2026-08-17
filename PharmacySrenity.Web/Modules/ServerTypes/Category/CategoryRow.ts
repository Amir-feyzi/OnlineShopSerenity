import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface CategoryRow {
    Id?: string;
    Name?: string;
}

export abstract class CategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Category.Category';
    static readonly lookupKey = 'Category.Category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CategoryRow>('Category.Category') }
    static async getLookupAsync() { return getLookupAsync<CategoryRow>('Category.Category') }

    static readonly deletePermission = 'Category:Modify';
    static readonly insertPermission = 'Category:Modify';
    static readonly readPermission = 'Category:View';
    static readonly updatePermission = 'Category:Modify';

    static readonly Fields = fieldsProxy<CategoryRow>();
}