import { User } from "./User"

export class Product
{
    private _id?: number
    private _name: string
    private _description: string
    private _price: number
    private _seller: User
    private _buyer: User | null

    constructor(
        name: string,
        description: string,
        price: number,
        seller: User,
        id?: number,
        buyer?: User | null
    ) {
        this._name = name
        this._description = description
        this._price = price
        this._seller = seller
        this._id = id
        this._buyer = buyer || null
    }

    public set id(id: number)
    {
        if (id == -1) {
            this._id = undefined
        } else {
            this._id = id
        }
    }

    public get id(): number
    {
        if (this._id === undefined) return -1
        
        return this._id
    }

    public set name(name: string)
    {
        this._name = name
    }

    public get name(): string
    {
        return this._name
    }

    public set description(description: string)
    {
        this._description = description
    }

    public get description(): string
    {
        return this._description
    }

    public set price(price: number)
    {
        this._price = price
    }

    public get price(): number
    {
        return this._price
    }

    public set seller(seller: User)
    {
        this._seller = seller
    }

    public get seller(): User
    {
        return this._seller
    }
    
    public set buyer(buyer: User | null)
    {
        this._buyer
    }
    
    public get buyer(): User|null
    {
        return this._buyer
    }
}
