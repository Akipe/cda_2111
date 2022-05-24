import type { EmployeeJson } from "./EmployeeJson"

export class Employee
{
    id: number
    name: string
    salary: number
    age: number
    profile_image: string
    email: string = ""
    monthlySalary: number = 0
    birthYear: number = 0

    constructor(employeeJson: EmployeeJson)
    {
        this.id = employeeJson.id
        this.name = employeeJson.employee_name
        this.salary = employeeJson.employee_salary
        this.age = employeeJson.employee_age
        this.profile_image = employeeJson.profile_image

        this.setEmail()
        this.setMonthlySalary()
        this.setBirthYear()
    }

    private setEmail(): void
    {
        let firstLetter = this.name.charAt(0)
        let lastName = this.getLastName()

        this.email = (`${firstLetter}.${lastName}@email.com`).toLocaleLowerCase()
    }

    private getLastName(): string
    {
        return this.name.split(' ')[1] ?? "John"
    }

    private setMonthlySalary(): void
    {
        let howManyToRound = 100
        this.monthlySalary = Math.round(this.salary / 12 * howManyToRound) / howManyToRound
    }

    private setBirthYear(): void
    {
        let currentYear = new Date().getFullYear()

        this.birthYear = currentYear - this.age
    }
}