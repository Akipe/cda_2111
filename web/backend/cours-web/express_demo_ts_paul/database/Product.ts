import { User } from "./User"

export class Product
{
    public id?: number
    public name: string
    public description: string
    public price: number
    public seller: User
    public buyer: User | null

    constructor(
        name: string,
        description: string,
        price: number,
        seller: User,
        id?: number,
        buyer?: User | null
    ) {
        this.name = name
        this.description = description
        this.price = price
        this.seller = seller
        this.id = id
        this.buyer = buyer || null
    }
}
