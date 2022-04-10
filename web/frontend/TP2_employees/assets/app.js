import { EmployeeApi } from "./modules/EmployeeApi.js";
import { EmployeeTableFactory } from "./modules/EmployeeTableFactory.js";

const apiUrl = 'https://arfp.github.io/tp/web/frontend/employees/employees.json';
const employeeTable = document.getElementById("employee_table")

let employeesApi = new EmployeeApi(apiUrl);
let employeeTableFactory = new EmployeeTableFactory(employeeTable, employeesApi);

employeesApi.fetch();

employeesApi.fetchDone().then(() => {
    let anEmployee = employeesApi.getEmployee(1);
    employeesApi.postEmployee(anEmployee.duplicate(employeesApi.getIdForNewEmployee()));
    employeesApi.deleteEmployee(25);
})

employeesApi.fetchDone().then(() => {
    employeeTableFactory.generate();
})
