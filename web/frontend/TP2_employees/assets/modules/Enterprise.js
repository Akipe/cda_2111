import { Employee } from "./Employee.js";

export class Enterprise
{
    constructor(_salaryCurrency = "€", _mailSuffix = "email.com")
    {
        this.salaryCurrency = _salaryCurrency;
        this.mailSuffix = _mailSuffix;
        this.employees = [];
        this.totalMonthlySalary = parseFloat(0.0);
    }

    addEmployee(_employee){
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

    removeEmployee(_idEmployee)
    {
        if (typeof parseInt(_idEmployee) == "number") {
            let index = this.isEmployeeExist(_idEmployee)

            if (index) {
                this.jsonEmployees.splice(index, 1);
                this.processJsonEmployees();

                return true;
            }
            return false; // No employee find with _idEmployee
        } else {
            throw new Error('The ID of employee has to be a number.');
        }
    }

    /**
     * Check if an employee exist with checking ID,
     * @param {*} _id id of employee to search
     * @returns the index of employee or -1 if not exist
     */
    isEmployeeExist(_id)
    {
        for (let index = 0; index < this.employees.length; index++) {
            if (this.employees[index].id == _id) {
                return index;
            }
        }
        return -1;
    }

    getNumberEmployee()
    {
        return this.employees.length;
    }

    getLastIdEmployee()
    {
        return this.employees[this.employees.length - 1].id;
    }

    setIdNewEmployee(_employee)
    {
        if (_employee instanceof Employee) {
            _employee.id = this.getLastId() + 1;
        } else {
            throw new Error("You have to send an Employee object.");
        }
    }
};
