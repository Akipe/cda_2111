export class User
{
    private _id: number|null
    private _name: string
    private _password: string
    private _quote: string

    constructor(
        name: string,
        password: string,
        quote: string,
        id?: number
    ) {
        this._name = name
        this._password = password
        this._quote = quote
        this._id = id || null
    }

    public set id(id: number|null)
    {
        this._id = id
    }

    public get id(): number|null
    {
        return this._id
    }

    public set password(password: string)
    {
        this.password = password
    }

    public get password(): string
    {
        return this._password
    }

    public set name(name: string)
    {
        this._name = name
    }

    public get name(): string
    {
        return this._name
    }

    public set quote(quote: string)
    {
        this._quote = quote
    }

    public get quote(): string
    {
        return this._quote
    }
}
