import { commonRepository, CommonRepository } from "./CommonRepository";

export abstract class BaseRepository {
    protected table: string
    protected repository: CommonRepository

    constructor(
        _table: string,
        _commonRepository: CommonRepository = commonRepository
    )
    {
        this.table = _table
        this.repository = _commonRepository
    }
}
