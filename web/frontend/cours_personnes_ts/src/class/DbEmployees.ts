import { Employee } from "./Employee"
import type { EmployeeJson } from "./EmployeeJson"

export class DbEmployees
{
    static readonly API_URL = "https://arfp.github.io/tp/web/frontend/employees/employees.json"
    
    private employees: Array<Employee> = [] as Array<Employee>
    private hasInit: boolean = false
    
    private async getEmployeesJson(): Promise<Array<EmployeeJson>>
    {
        try {
            let response = await fetch(DbEmployees.API_URL)
            let json = await response.json()
            return json.data
        } catch(error) {
            console.error(error)
            throw new Error()
        }
    }

    public async init(): Promise<void>
    {
        let employees: Array<Employee> = []
        let json = await this.getEmployeesJson()

        for(let employeeJson of json) {
            employees.push(new Employee(employeeJson))
        }
        DbEmployees.employees = employees
    }

    public getEmployees(): Array<Employee>
    {
        return DbEmployees.employees
    }

    public async removeEmployee(employeeRemoved: Employee)
    {
        
    }
}
