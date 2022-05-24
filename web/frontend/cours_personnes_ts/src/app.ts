import { defineComponent } from 'vue'
import { DbEmployees } from "./class/DbEmployees"
import type { Employee } from "./class/Employee"

export default defineComponent({
    data() {
            return {
                title: "Liste des employées",
                employees: [] as Array<Employee>
            }
        },
    methods: {
        getEmployees() {
            this.employees = DbEmployees.getEmployees()
        },
    },
    computed: {
        updateEmployees() {
            this.employees = DbEmployees.getEmployees()
        },
    },
    async mounted() {
        await DbEmployees.init()
        this.getEmployees()
    }
})
