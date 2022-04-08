import { EmployeeApi } from "./modules/EmployeeApi.js";
import { EmployeeTableFactory } from "./modules/EmployeeTableFactory.js";

const apiUrl = 'https://arfp.github.io/tp/web/frontend/employees/employees.json';
const employeeTable = document.getElementById("employee_table")

let employeesApi = new EmployeeApi(apiUrl);
let employeeTableFactory = new EmployeeTableFactory(employeeTable, employeesApi);

employeesApi.apiRequest();

employeesApi.fetchDone().then(() => {
    employeesApi.duplicate(1);
    employeesApi.remove(25);
})

employeesApi.fetchDone().then(() => {
    employeeTableFactory.generate();
})

/*
constructor(_employe){
    ({
        id: this.id,
        employee_name: this.fullName,
        ... this.renaming_employee
    } = _employe
    );
}

renaming_employee[];
renaming_employee{
    age: 42,
};

function test(arg1, arg2, ...arg3) {

}


const o = {
    size: 42,
    isReal: true
};
let p = {
    size: toto,
    isReal: tata
} = o;

console.log(p.toto); // 42
console.log(p.tata); // true
*/
