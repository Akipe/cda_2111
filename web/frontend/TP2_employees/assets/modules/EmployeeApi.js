import { Employee } from "./Employee.js";

export class EmployeeApi
{
    constructor(apiUrl)
    {
        this.apiUrl = apiUrl;
        this.allEmployees = [];
        this.fetchPromise = false;
        this.totalMonthlySalary = parseFloat(0.0);
        this.salaryCurrency = "€";
    }

    apiRequest()
    {
        this.fetchPromise = this.apiFetch();
    }

    async apiFetch()
    {
        const response = await fetch(this.apiUrl);
        const json = await response.json();
        this.processData(json.data);
        return json;
    }

    async fetchDone()
    {
        return this.fetchPromise;
    }

    processData(jsonEmployees)
    {
        let totalMonthlySalary = parseFloat(0.0);
        jsonEmployees.forEach(jsonEmployee => {
            let employee = new Employee(
                jsonEmployee.id,
                jsonEmployee.employee_name,
                jsonEmployee.employee_age,
                jsonEmployee.employee_salary,
                this.salaryCurrency,
                jsonEmployee.profile_image
            );
            totalMonthlySalary += parseFloat(employee.monthlySalary);
            this.allEmployees.push(employee);
        });

        this.totalMonthlySalary = parseFloat(totalMonthlySalary).toFixed(2);
    }

    duplicate(idEmployee)
    {
        this.allEmployees.forEach(employee => {
            if (employee.id == idEmployee) {
                this.add(
                    (this.getLastId() + 1),
                    employee.fullName,
                    employee.age,
                    employee.annualSalary,
                    employee.currencySalary,
                    employee.profileImage
                );
                return true;
            }
        });

        return false;
    }

    add(
        id,
        fullName,
        age,
        annualSalary,
        currencySalary = this.salaryCurrency,
        profileImage
    )
    {
        this.allEmployees.push(new Employee(
            id,
            fullName,
            age,
            annualSalary,
            currencySalary,
            profileImage
        ));

        this.calculateTotalMonthlySalary();
    }

    remove(idEmployee)
    {
        for (let employeeIndex = 0; employeeIndex <= this.allEmployees.length; employeeIndex++) {
            if (this.allEmployees[employeeIndex].id == idEmployee) {
                this.allEmployees.splice(employeeIndex, 1);

                this.calculateTotalMonthlySalary();
                return true;
            }
        }

        return false;
    }

    calculateTotalMonthlySalary()
    {
        this.totalMonthlySalary = parseFloat(0.0);
        this.allEmployees.forEach(
            employee => this.totalMonthlySalary += parseFloat(employee.monthlySalary)
        );

        this.totalMonthlySalary = parseFloat(this.totalMonthlySalary).toFixed(2);
    }

    getLastId()
    {
        return this.allEmployees[this.allEmployees.length - 1].id;
    }
};
