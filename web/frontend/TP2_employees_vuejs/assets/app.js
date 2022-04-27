import { createApp } from 'vue';

const app = createApp({
    data() { // Retourne toutes les variables pour les scripts
        return {
            message: "List of employees",
            employeesData: null
        }
    },
    computed: {
        countEmployee() {
            return this.employeesData.length
        },
        sumAllMonthlySalaries() {
            let sum = 0;
            for (employee of this.employeesData) {
                sum += employee.employee_salary
            }
            return sum
        }
    },
    methods: { // Fonction de notre application
        async fetchEmployeesData() {
            this.employeesData = null
            const response = await fetch('https://arfp.github.io/tp/web/frontend/employees/employees.json')
            const jsonEmployee = await response.json()
            this.employeesData = jsonEmployee.data
            console.log("Fetch executed")
        },
        getEmployeeEmail(name) {
            return name.split(' ')[1] + "@email.com"
        },
        deleteEmployee(employee) {
            return this.employeesData = this.employeesData.filter((savedEmployee) => savedEmployee != employee)
        },
        duplicate(employee) {
            let newId = this.employeesData[this.employeesData.length - 1].id + 1
            let newEmployee = Object.assign({}, employee)
            newEmployee.id = newId
            this.employeesData.push(newEmployee)
        }
    },
    mounted() { // Quand application chargé, lancer automatiquement des actions
        this.fetchEmployeesData()
    }
}).mount('#app') // Où greffer notre application vuejs
