export class EmployeeTableFactory
{
    constructor(tableElement, employeeApi)
    {
        this.table = tableElement;
        this.employeeApi = employeeApi;
        this.virtualTable = document.createDocumentFragment();
        this.numberRow = 0;
    }

    addEmployeeRow(employee)
    {
        let buttons = [];

        buttons.push(this.getActionDuplicateButton(employee.id));
        buttons.push(this.getActionDeleteButton(employee.id));

        this.addRow(
            `employee_${employee.id}`,
            employee.id,
            employee.fullName,
            employee.email,
            `${employee.monthlySalary} ${employee.currencySalary}`,
            employee.birthYear,
            buttons
        );
    }

    addTotalMontlySalaryRow(totalMontlySalary, currencySalary)
    {
        this.addRow(
            `employee_total_monthly_salary`,
            this.numberRow,
            "",
            "",
            `${totalMontlySalary} ${currencySalary}`,
            "",
            ""
        );
    }

    addRow(
        idRow,
        eidCell,
        fullNameCell,
        emailCell,
        monthlySalaryCell,
        yearBirthCell,
        actionsCell
    ) {
        let row = document.createElement("tr");

        row.setAttribute('id', idRow);

        for (let argIndex = 1; argIndex < arguments.length - 1; argIndex++) {
            this.addCell(row, arguments[argIndex]);
        }

        this.addCell(row, "", actionsCell);

        this.virtualTable.appendChild(row);
        this.numberRow++;
    }

    addCell(row, value = "", childNodes = [])
    {
        let cell = document.createElement("td");
        if (value != "") {
            cell.textContent = value;
        }
        if (childNodes.length != 0) {
            childNodes.forEach(node => cell.appendChild(node));
        } 
        row.appendChild(cell);
    }

    getActionDuplicateButton(employeeId)
    {
        return this.getActionButton("Duplicate", "employeeActionDuplicate", employeeId, this.eventActionDuplicate)
    }

    getActionDeleteButton(employeeId)
    {
        return this.getActionButton("Delete", "employeeActionDelete", employeeId, this.eventActionDelete)
    }

    getActionButton(label, className, employeeId, functionOnEvent)
    {
        let button = document.createElement("button");

        button.textContent = label;
        button.classList.add(className);
        button.dataset.employeeId = employeeId;
        button.setAttribute("type", "button");
        button.addEventListener('click', (event) => {
            functionOnEvent(event, this);
        });

        return button;
    }

    generate()
    {
        this.employeeApi.allEmployees.forEach(employee => {
            this.addEmployeeRow(employee);
        });

        this.addTotalMontlySalaryRow(
            this.employeeApi.totalMonthlySalary,
            this.employeeApi.salaryCurrency
        );

        this.table.querySelector("tbody").appendChild(this.virtualTable);
    }

    
    eventActionDuplicate(event, that)
    {
        that.employeeApi.duplicate(event.currentTarget.dataset.employeeId);
        that.eventDeleteTable(event, that);
        that.generate();
    }

    eventActionDelete(event, that)
    {
        that.employeeApi.remove(event.currentTarget.dataset.employeeId);
        that.eventDeleteTable(event, that);
        that.generate();
    }

    eventDeleteTable(event, that)
    {
        event.currentTarget.parentNode.parentNode.parentNode.innerHTML = "";
        that.numberRow = 0;
    }
};
