export interface Pagination {
    totalItems: number;
    totalPages: number;
    itemsPerPage: number;
    currentPage: number;
}

export class PaginatedResult<T> {
    result: T; // users objects
    pagination: Pagination; // pagination params
}
