import { Employee } from "./Employee.js";

export class EmployeeApi
{
    constructor(_apiUrl)
    {
        this.apiUrl = _apiUrl;
        this.jsonResponse = {};
        this.jsonEmployees = [];
        this.employees = [];
        this.fetchPromise = false;
        this.totalMonthlySalary = parseFloat(0.0);
        this.salaryCurrency = "€";
        this.mailSuffix = "email.com";
    }

    fetch()
    {
        this.fetchPromise = this.fetchRequest();
    }

    async fetchRequest()
    {
        const response = await fetch(this.apiUrl);
        const json = await response.json();
        this.jsonResponse = json;
        this.jsonEmployees = json.data;
        this.processJsonEmployees();
        return json;
    }

    async fetchDone()
    {
        return this.fetchPromise;
    }

    processJsonEmployees()
    {
        this.employees = [];
        let totalMonthlySalary = parseFloat(0.0);

        this.jsonEmployees.forEach(jsonEmployee => {
            let employee = new Employee(
                jsonEmployee,
                this.salaryCurrency,
                this.mailSuffix
            );
            totalMonthlySalary += parseFloat(employee.monthlySalary);
            this.employees.push(employee);
        });

        this.totalMonthlySalary = parseFloat(totalMonthlySalary).toFixed(2);
    }

    getAllEmployees()
    {
        return this.employees;
    }

    getEmployee(_id)
    {
        let indexEmployee = this.getIndexEmployee(_id);

        if (indexEmployee == -1) {
            throw new Error(`There is not employee with ID ${_id}!`);
        }

        return this.employees[indexEmployee];
    }

    postEmployee(_employee)
    {
        if (_employee instanceof Employee) {
            let employeeJson = {};
            ({
                id: employeeJson.id,
                fullName: employeeJson.employee_name,
                age: employeeJson.employee_age,
                annualSalary: employeeJson.employee_salary,
                profileImage: employeeJson.profile_image
            } = _employee);

            this.jsonEmployees.push(employeeJson);
            this.processJsonEmployees();

            return true;
        } else {
            throw new Error(
                "Error to add an employee: the data has to be an instance of Employee"
            );
        }
    }

    /**
     * TODO
     * @param {*} _id 
     * @returns 
     */
    putEmployee(_id)
    {
        return false;
    }

    deleteEmployee(_id)
    {
        if (typeof parseInt(_id) != "number") {
            throw new Error('The ID of employee has to be a number.');
        }

        let index = this.getIndexEmployee(_id)

        if (index == -1) {
            throw new Error(`There is not employee with ID ${_id}`);
        }
        
        this.jsonEmployees.splice(index, 1);
        this.processJsonEmployees();

        return true;
    }

    /**
     * Check if an employee exist with checking ID,
     * @param {*} _id id of employee to search
     * @returns the index of employee or -1 if not exist
     */
    getIndexEmployee(_id)
    {
        for (let index = 0; index < this.employees.length; index++) {
            if (this.employees[index].id == _id) {
                return index;
            }
        }
        return -1;
    }

    getIdForNewEmployee()
    {
        return this.employees[this.employees.length - 1].id + 1;
    }
}
