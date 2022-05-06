import { BaseRepository } from "./BaseRepository";
import { Product } from "./Product";
import { userRepository } from "./UserRepository";
import { User } from "./User";

export class ProductRepository extends BaseRepository
{
    constructor()
    {
        super("products")
    }

    public async getAll(): Promise<Array<Product>|null>
    {
        try {
            let arrayProducts: Array<Product> = []
            let arrayRawResult = await this.repository.getAll(
                `SELECT id, name, description, price, seller, buyer FROM ${this.table}`
            )

            if (arrayRawResult === undefined) {
                return null
            }

            arrayRawResult.forEach(async (productRaw) => {
                let product = await this.productFromSql(productRaw)
                arrayProducts.push(product)
            })

            return arrayRawResult
        } catch (error) {
            console.error(`Error to retrieve all products : ${error}`)
            return null
        }
    }

    public async getById(id: number): Promise<Product|null>
    {
        try {
            let productRaw = await this.repository.getOne(
                `SELECT id, name, description, price, seller, buyer FROM ${this.table} WHERE id=?`,
                [String(id)]
            )
    
            if (productRaw === undefined) {
                return null
            }

            return this.productFromSql(productRaw)
        } catch (error) {
            console.error(`Error to retrieve a product with ID ${id} : ${error}`)
            return null
        }
    }

    public async add(product: Product): Promise<void>
    {
        try {
            this.repository.execute(
                `INSERT INTO ${this.table} (name, description, price, seller, buyer) VALUES (?, ?, ?, ?, ?)`,
                [
                    product.name,
                    product.description,
                    String(product.price),
                    String(product.seller),
                    String(product.buyer)
                ]
            )
        } catch (error) {
            console.error(`Error to add a product (id : ${product.id}): ${error}`)
        }
    }

    public async update(id: number, product: Product): Promise<boolean>
    {
        try {
            let currentProduct = await this.getById(id)

            if (!currentProduct) {
                return false
            }

            this.repository.execute(
                `UPDATE ${this.table} SET name=?, description=?, price=?, seller=?, buyer=? WHERE id=?`,
                [
                    product.name,
                    product.description,
                    String(product.price),
                    String(product.seller),
                    String(product.buyer),
                    String(id)
                ]
            )

            return true
        } catch (error) {
            console.error(`Error to update a product (id : ${id}): ${error}`)
            return false
        }
    }

    public async deleteById(id: number): Promise<boolean>
    {
        try {
            let currentProduct = await this.getById(id)

            if (!currentProduct) {
                return false
            }

            this.repository.execute(
                `DELETE FROM ${this.table} WHERE id=?`,
                [String(id)]
            )
            return true
        } catch (error) {
            console.error(`Error to remove product with id ${id}: ${error}`)
            return false
        }
    }

    private async productFromSql(productRaw: any): Promise<Product>
    {
        let seller = await userRepository.getById(productRaw.seller)

        if (seller === null) {
            throw new Error("the product need to have a seller")
        }

        let buyer: User|null

        if (productRaw.buyer == null) {
            buyer = null
        } else {
            buyer = await userRepository.getById(productRaw.buyer)
        }

        return new Product(
            productRaw.name,
            productRaw.description,
            productRaw.price,
            seller,
            productRaw.id,
            buyer,
        )
    }
}

export const productRepository = new ProductRepository()
