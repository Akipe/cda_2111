export class User
{
    public id: number|null
    public name: string
    public password: string
    public quote: string

    constructor(
        name: string,
        password: string,
        quote: string,
        id?: number
    ) {
        this.name = name
        this.password = password
        this.quote = quote
        this.id = id || null
    }
}
